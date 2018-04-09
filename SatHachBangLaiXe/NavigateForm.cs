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
            using (FrmThiSinh frm = new FrmThiSinh())//Open main form and hide login form
            {
                frm.ShowDialog();
            }
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            using (LogInThiSinh frm = new LogInThiSinh())//Open main form and hide login form
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
    }
}
