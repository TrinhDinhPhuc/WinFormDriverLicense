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
    public partial class FrmThongTinHV : MetroFramework.Forms.MetroForm
    {
        public FrmThongTinHV()
        {
            InitializeComponent();
        }

        private void FrmThongTinHV_Load(object sender, EventArgs e)
        {
           txtMaHocVien.Text= Properties.Settings.Default.KMaHV ;
           txtTenHocVien.Text= Properties.Settings.Default.KTenHV ;
           txtHoHocVien.Text= Properties.Settings.Default.KHoHV ;
           txtSoCMNDD.Text= Properties.Settings.Default.KSoCMND ;
           txtKyThiHV.Text =  Properties.Settings.Default.KKyThi ;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
