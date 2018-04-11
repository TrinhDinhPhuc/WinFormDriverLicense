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
            SqlConnection con = new SqlConnection(Program.connStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Reports where MaHV = '" + txtMaThiSinh.Text+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            //XtraReport1 report = new XtraReport1();
            //report.DataSource = dt;
            //report.ShowPreviewDialog();
        }
    }
}
