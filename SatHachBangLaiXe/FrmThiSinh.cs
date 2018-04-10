using BLL;
using DTO;
using Net.Code.ADONet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatHachBangLaiXe
{
    public partial class FrmThiSinh : MetroFramework.Forms.MetroForm
    {
        EntityState objState = EntityState.Unchanged;

        public FrmThiSinh()
        {
            InitializeComponent();
        }

        private void FrmThiSinh_Load(object sender, EventArgs e)
        {
            try
            {
                bindingSource1.DataSource = HocVienService.GetAll();
                //pContainer.Enabled = False
                DTO.HocVien obj = bindingSource1.Current as DTO.HocVien;
                if (obj == null)
                {
                    if (!string.IsNullOrEmpty(obj.AnhThiSinh))
                        pic.Image = Image.FromFile(obj.AnhThiSinh);
                }
                else
                {
                    pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    pic.Image = Image.FromFile(obj.AnhThiSinh);
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pic.Image = null;
            bindingSource1.Add(new DTO.HocVien());
            bindingSource1.MoveLast();
            txtMaHV.Focus();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DTO.HocVien obj = bindingSource1.Current as DTO.HocVien;
                pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pic.Image = Image.FromFile(obj.AnhThiSinh);
                if (obj == null)
                {
                    if (!string.IsNullOrEmpty(obj.AnhThiSinh))
                        pic.Image = Image.FromFile(obj.AnhThiSinh);
                }
            }
            catch (Exception ex)
            {
                //MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bindingSource1.ResetBindings(false);
            this.FrmThiSinh_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            txtMaHV.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MetroFramework.MetroMessageBox.Show(this, "Bạn có chắc muốn xóa không?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DTO.HocVien obj = bindingSource1.Current as DTO.HocVien;
                    if (obj != null)
                    {
                        bool result = HocVienService.Delete(obj.MaHV);
                        if (result)
                        {
                            bindingSource1.RemoveCurrent();
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
            bindingSource1.EndEdit();
            HocVien obj = bindingSource1.Current as HocVien;
            if(obj!=null)
            {
                obj = HocVienService.Save(obj, objState);
                metroGrid1.Refresh();
                objState = EntityState.Unchanged;
                MetroFramework.MetroMessageBox.Show(this, "Đã Cập Nhật Thành Công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
    }
}
