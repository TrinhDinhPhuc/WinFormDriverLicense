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
using DTO;
using BLL;
using Net.Code.ADONet;

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
                    nhanVienBindingSource.DataSource = NhanVienService.GetAll();
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
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
            {
               
                if (ofd.ShowDialog() != DialogResult.OK)
                {
                    
                    //Read image from file, then load to picture box
                    pic.Image = Image.FromFile(ofd.FileName);
                    DTO.NhanVien obj = nhanVienBindingSource.Current as DTO.NhanVien;
                    //if (obj != null)
                    //    obj.AnhNV = ofd.FileName;
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

 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            nhanVienBindingSource.ResetBindings(false);
            this.FrmNhanVien_Load(sender,e);
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
                //MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MetroFramework.MetroMessageBox.Show(this, "Bạn có chắc muốn xóa không?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            { 
            try
            {
                    DTO.NhanVien obj = nhanVienBindingSource.Current as DTO.NhanVien;
                    if(obj!=null)
                    {
                        bool result = NhanVienService.Delete(obj.TaiKhoan);
                            if(result)
                            {
                                nhanVienBindingSource.RemoveCurrent();
                                //pContainer.Enabled = False
                                pic.Image = null;
                                objState = EntityState.Unchanged;
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
                //nhanVienBindingSource.EndEdit();
                ////Get current object
                //NhanVien obj = nhanVienBindingSource.Current as NhanVien;
                //if (obj != null)
                //{
                //    using (var db = Db.FromConfig("cn"))
                //    {
                //        if (objState == EntityState.Added)
                //        {
                //            //Execute sql insert query
                //            obj.TaiKhoan = db.Sql("insert into TTNhanVien(TaiKhoan,MatKhau,HoNV,TenNV,DiaChi,SDT) values(@TaiKhoan, @MatKhau, @HoNV, @TenNV, @DiaChi, @SDT)").WithParameters(new { TaiKhoan = obj.TaiKhoan, MatKhau = obj.MatKhau, HoNV = obj.HoNV, TenNV = obj.TenNV, DiaChi = obj.DiaChi, SDT = obj.SDT }).AsScalar<string>();
                //            MetroFramework.MetroMessageBox.Show(this, "Đã Thêm Thành Công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //        }
                //        else if (objState == EntityState.Changed)
                //        {
                //            //Execute stored procedure update
                //            db.StoredProcedure("sp_NhanVien_Update").WithParameters(new { TaiKhoan = obj.TaiKhoan, MatKhau = obj.MatKhau, HoNV = obj.HoNV, TenNV = obj.TenNV, DiaChi = obj.DiaChi, SDT = obj.SDT }).AsNonQuery();
                //            MetroFramework.MetroMessageBox.Show(this, "Đã Cập Nhật Thành Công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //        }
                //        metroGrid.Refresh();
                //        //pContainer.Enabled = false;
                //        objState = EntityState.Unchanged;
                //    }
                //}
                nhanVienBindingSource.EndEdit();
                NhanVien obj = nhanVienBindingSource.Current as NhanVien;
                if (obj != null)
                {
                    obj = NhanVienService.Save(obj, objState);
                    metroGrid.Refresh();
                    objState = EntityState.Unchanged;
                    MetroFramework.MetroMessageBox.Show(this, "Đã Cập Nhật Thành Công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            txtTaikhoan.Focus();
        }
    }
}
