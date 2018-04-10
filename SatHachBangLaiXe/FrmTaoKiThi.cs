using BLL;
using DTO;
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
    public partial class FrmTaoKiThi : MetroFramework.Forms.MetroForm
    {
        EntityState objState = EntityState.Unchanged;

        public FrmTaoKiThi()
        {
            InitializeComponent();
        }

        private void FrmTaoKiThi_Load(object sender, EventArgs e)
        {
            try
            {
                bindingSource1.DataSource = KyThiService.GetAll();
                //pContainer.Enabled = False
                DTO.TTKyThi obj = bindingSource1.Current as DTO.TTKyThi;

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnThemKiThi_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            bindingSource1.Add(new DTO.TTKyThi());
            bindingSource1.MoveLast();
            txtKyThi.Focus();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            bindingSource1.ResetBindings(false);
            this.FrmTaoKiThi_Load(sender, e);
        }

        private void btnLuuKiThi_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource1.EndEdit();
                TTKyThi obj = bindingSource1.Current as TTKyThi;
                if (obj != null)
                {
                    obj = KyThiService.Save(obj, objState);
                    //metroGrid1.Refresh();
                    objState = EntityState.Unchanged;
                    MetroFramework.MetroMessageBox.Show(this, "Đã Cập Nhật Thành Công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaKiThi_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            txtKyThi.Focus();
        }

        private void btnXoaKiThi_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MetroFramework.MetroMessageBox.Show(this, "Bạn có chắc muốn xóa không?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DTO.TTKyThi obj = bindingSource1.Current as DTO.TTKyThi;
                    if (obj != null)
                    {
                        bool result = KyThiService.Delete(obj.KyThi);
                        if (result)
                        {
                            bindingSource1.RemoveCurrent();
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


    }
}
