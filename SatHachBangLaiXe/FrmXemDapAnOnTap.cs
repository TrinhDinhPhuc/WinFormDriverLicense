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
    public partial class FrmXemDapAnOnTap : MetroFramework.Forms.MetroForm
    {
        public FrmXemDapAnOnTap()
        {
            InitializeComponent();
        }

        private void FrmXemDapAnOnTap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sATHACHLAIXEDataSet2.Xem_Dap_An_Sai1' table. You can move, or remove it, as needed.
            this.xem_Dap_An_Sai1TableAdapter.Fill(this.sATHACHLAIXEDataSet2.Xem_Dap_An_Sai1);
            // TODO: This line of code loads data into the 'sATHACHLAIXEDataSet1.Xem_Dap_An_Dung1' table. You can move, or remove it, as needed.
            this.xem_Dap_An_Dung1TableAdapter.Fill(this.sATHACHLAIXEDataSet1.Xem_Dap_An_Dung1);
            int count1 = metroGrid1.Rows.Count - 1;
            int count2 = metroGrid2.Rows.Count - 1;

            lbCauDung.Text = "" + count1;
            lbCauSai.Text = "" + count2;
        }

        private void btnThoatThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
