using DevExpress.Utils.OAuth.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatHachBangLaiXe
{
    public partial class NavigateForm : MetroFramework.Forms.MetroForm
    {
        public NavigateForm()
        {
            InitializeComponent();
        }

        private void NavigateForm_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMetroInfoAccount_Click(object sender, EventArgs e)
        {
            using (FrmThongTinHV frm = new FrmThongTinHV())//Open main form and hide login form
            {
                frm.ShowDialog();
            }
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            using (FrmThi frm = new FrmThi())//Open main form and hide login form
            {
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            using (FrmXemDapAn frm= new FrmXemDapAn())
            {
                frm.ShowDialog();
            }
        }

        private void metroTile15_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            using (FrmThiSinh frm = new FrmThiSinh())
            {
                frm.ShowDialog();
            }

        }

        private void metroTile13_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile8_Click(object sender, EventArgs e)
        {

        }

        private void metroTile10_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click_1(object sender, EventArgs e)
        {
            using (FrmOnTap frm = new FrmOnTap())
            {
                frm.ShowDialog();
            }

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Bạn có thể dùng mẫu phúc khảo của chúng tôi, điền đầy đủ thông tin và gửi cho cán bộ coi thi! \n Xin cảm ơn", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
            System.Diagnostics.Process.Start(@"C:\Users\USER\Documents\Visual Studio 2015\Projects\SatHachBangLaiXe\SatHachBangLaiXe\Files\don-xin-cham-phuc-khao-bai-thi1.doc");

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\USER\Documents\Visual Studio 2015\Projects\SatHachBangLaiXe\SatHachBangLaiXe\Files\QuyDinhVeDaoTaoSatHachCapGPLXCoGioiDuongBo.pdf");

        }

        private void metroTile14_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
