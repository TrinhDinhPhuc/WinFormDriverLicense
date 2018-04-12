using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatHachBangLaiXe
{
    public partial class FrmMainMenu : MetroFramework.Forms.MetroForm
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            using (Login frm = new Login())
            {
                frm.ShowDialog();
            }
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Vui lòng mở file Word để xem hướng dẫn! \n Xin cảm ơn", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
            System.Diagnostics.Process.Start(@"C:\Users\USER\Documents\Visual Studio 2015\Projects\SatHachBangLaiXe\SatHachBangLaiXe\Files\QuyDinhVeDaoTaoSatHachCapGPLXCoGioiDuongBo.pdf");

        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            using (LogInThiSinh frm = new LogInThiSinh())
            {
                frm.ShowDialog();
            }
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "PHẦN MỀM LÀ BẢN QUYỀN CỦA NHÓM 5! \n Xin cảm ơn", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Đang Cập Nhật! \n Xin cảm ơn", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Vui lòng ghé thăm facebook.com/KPP! \n Xin cảm ơn", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Vui lòng ghé thăm twitter.com/KPP! \n Xin cảm ơn", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Vui lòng ghé thăm youtube.com/KPP! \n Xin cảm ơn", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Vui lòng ghé thăm google.com/KPP! \n Xin cảm ơn", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
