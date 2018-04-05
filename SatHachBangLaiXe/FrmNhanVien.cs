using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;

namespace SatHachBangLaiXe
{
    public partial class FrmNhanVien : MetroFramework.Forms.MetroForm
    {
        EntityState objState = EntityState.Unchanged;
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString)) 
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    nhanVienBindingSource.DataSource = db.Query<DTO.NhanVien>("select * from TTNhanVien", commandType: CommandType.Text);
                    //pContainer.Enabled = False
                    DTO.NhanVien obj = nhanVienBindingSource.Current as DTO.NhanVien;
                    if (obj == null)
                    {
                        if (!string.IsNullOrEmpty(obj.AnhNV))
                            pic.Image = Image.FromFile(obj.AnhNV);
                    }
                    else
                    {
                        pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        pic.Image = Image.FromFile(obj.AnhNV);
                    }
                }
                   
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
            {
                string selectedPath;
                var t = new Thread((ThreadStart)(() => {
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
                    fbd.ShowNewFolderButton = true;
                    if (fbd.ShowDialog() == DialogResult.Cancel)
                        return;

                    selectedPath = fbd.SelectedPath;
                }));

                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                t.Join();
                if (ofd.ShowDialog() != DialogResult.OK)
                {
                    //Read image from file, then load to picture box
                    pic.Image = Image.FromFile(ofd.FileName);
                    DTO.NhanVien obj = nhanVienBindingSource.Current as DTO.NhanVien;
                    if (obj != null)
                        obj.AnhNV = ofd.FileName;
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pic.Image = null;
            nhanVienBindingSource.Add(new DTO.NhanVien());
            nhanVienBindingSource.MoveLast();
            txtTaikhoan.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            txtTaikhoan.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            nhanVienBindingSource.ResetBindings(false);
            //ClearInput();
            this.FrmNhanVien_Load(sender, e);
        }

        private void metroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DTO.NhanVien obj = nhanVienBindingSource.Current as DTO.NhanVien;
                pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pic.Image = Image.FromFile(obj.AnhNV);
                if (obj == null)
                {
                    if (!string.IsNullOrEmpty(obj.AnhNV))
                        pic.Image = Image.FromFile(obj.AnhNV);
                }
            } catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MetroFramework.MetroMessageBox.Show(this, "Bạn có chắc muốn xóa không?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes) { 
            try
            {
                    DTO.NhanVien obj = nhanVienBindingSource.Current as DTO.NhanVien;
                    if(obj!=null)
                    {
                        using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                        {
                            if (db.State == ConnectionState.Closed)
                                db.Open();
                            int result = db.Execute("delete from TTNhanVien where TaiKhoan=@TaiKhoan", new { TaiKhoan = obj.TaiKhoan }, commandType : CommandType.Text);
                            if(result!=0)
                            {
                                nhanVienBindingSource.RemoveCurrent();
                                //pContainer.Enabled = False
                                pic.Image = null;
                                objState = EntityState.Unchanged;
                            }
                        }
                    }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                nhanVienBindingSource.EndEdit();
                DTO.NhanVien obj = nhanVienBindingSource.Current as DTO.NhanVien;
                if (obj != null)
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        if (objState == EntityState.Added)
                        {
                            DynamicParameters p = new DynamicParameters();
                            p.Add("@TaiKhoan", dbType: DbType.String, direction: ParameterDirection.Output);
                            p.AddDynamicParams(new { MatKhau = obj.MatKhau, HoNV = obj.HoNV, TenNV = obj.TenNV, DiaChi = obj.DiaChi, SDT = obj.SDT, TruyCapCuoi = obj.TruyCapCuoi, AnhNV = obj.AnhNV });
                            db.Execute("sp_NhanVien_Insert", p, commandType: CommandType.StoredProcedure);
                            obj.TaiKhoan = p.Get<string>("@TaiKhoan");
                        }
                        else if(objState == EntityState.Changed)
                        {
                            db.Execute("sp_NhanVien_Update", new { TaiKhoan = obj.TaiKhoan, MatKhau = obj.MatKhau, HoNV = obj.HoNV, TenNV = obj.TenNV, DiaChi = obj.DiaChi, SDT = obj.SDT, TruyCapCuoi = obj.TruyCapCuoi, AnhNV = obj.AnhNV },commandType: CommandType.StoredProcedure);
                            metroGrid.Refresh();
                            objState = EntityState.Unchanged;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
