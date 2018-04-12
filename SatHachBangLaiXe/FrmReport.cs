using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatHachBangLaiXe
{
    public partial class FrmReport : MetroFramework.Forms.MetroForm
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {

        }

        private void btnXuatReport_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMaThiSinh.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Không được để trống!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SqlConnection con = new SqlConnection(Program.connStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Reports2 ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                XtraReport222 report = new XtraReport222();
                report.DataSource = dt;
                report.ShowPreviewDialog();
            }

        
    }

        private void metroButton22_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(metroButton22.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Không được để trống!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SqlConnection con = new SqlConnection(Program.connStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Reports3 ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                XtraReport333 report = new XtraReport333();
                report.DataSource = dt;
                report.ShowPreviewDialog();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
