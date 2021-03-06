﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatHachBangLaiXe
{
    public partial class NavigateFormQuanLy : MetroFramework.Forms.MetroForm
    {
        public NavigateFormQuanLy()
        {
            InitializeComponent();
        }

        private void NavigateFormQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            using (Login frm = new Login())
            {
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void metroTile15_Click(object sender, EventArgs e)
        {
            using (FrmNhanVien frm = new FrmNhanVien())
            {
                frm.ShowDialog();
            }
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            using (FrmThiSinh frm = new FrmThiSinh())
            {
                frm.ShowDialog();
            }
        }

        private void metroTile43_Click(object sender, EventArgs e)
        {
                using (FrmTaoKiThi frm = new FrmTaoKiThi())
                {
                    frm.ShowDialog();
                }

        }

        private void metroTile34_Click(object sender, EventArgs e)
        {
            using (FrmReport frm = new FrmReport())
            {
                frm.ShowDialog();
            }
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {

        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "PHẦN MỀM LÀ BẢN QUYỀN CỦA NHÓM 5! \n Xin cảm ơn", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
        }
    }
}
