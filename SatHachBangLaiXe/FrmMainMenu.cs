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
    public partial class FrmMainMenu : MetroFramework.Forms.MetroForm
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            using (NavigateForm frm = new NavigateForm())//Open main form and hide login form
            {
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            using (NavigateFormQuanLy frm = new NavigateFormQuanLy())//Open main form and hide login form
            {
                this.Hide();
                frm.ShowDialog();
            }
        }
    }
}
