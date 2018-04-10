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
    public partial class FrmOnTap : MetroFramework.Forms.MetroForm
    {
        List<FrmPhieuTraLoi> listptl = new List<FrmPhieuTraLoi>();

        public FrmOnTap()
        {
            InitializeComponent();
        }

        private int CauDangLam = 0;
        public int CauDaLam { get; set; }
        private void Anserkey(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1: { listptl[CauDangLam].daocheck(listptl[CauDangLam].getcb1()); break; }
                case Keys.NumPad2: { listptl[CauDangLam].daocheck(listptl[CauDangLam].getcb2()); break; }
                case Keys.NumPad3: { if (listptl[CauDangLam].getsda() >= 3) listptl[CauDangLam].daocheck(listptl[CauDangLam].getcb3()); break; }
                case Keys.NumPad4: { if (listptl[CauDangLam].getsda() >= 4) listptl[CauDangLam].daocheck(listptl[CauDangLam].getcb4()); break; }
            }
        }
        private void keyup11(object sender, KeyEventArgs e)
        {
            //btn_xemdapan.Text = "Xem đáp án";
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        if (CauDangLam > 0)
                        {
                            listptl[CauDangLam].setBackColor();
                            CauDangLam--;
                            listptl[CauDangLam].setBackColorCDL();
                            loadcauhoi(this.CauDangLam);
                            lbCauHoi.Text = "Câu hỏi: " + (CauDangLam + 1);
                        }
                        break;
                    }
                case Keys.Down:
                    {

                        if (CauDangLam < 29)
                        {
                            listptl[CauDangLam].setBackColor();
                            CauDangLam++;
                            listptl[CauDangLam].setBackColorCDL();
                            loadcauhoi(this.CauDangLam);
                            lbCauHoi.Text = "Câu hỏi: " + (CauDangLam + 1);
                        }
                        break;
                    }
            }

        }
        private DataTable ontap;
        private void loadcauhoi(int i)
        {
            if (i <= 29)
            {
                DataRow row = ontap.Rows[i];
                String myValue = row["MaCH"].ToString();
                myValue = myValue.Trim();
                string filepath = @"C:\Users\USER\Documents\Visual Studio 2015\Projects\SatHachBangLaiXe\SatHachBangLaiXe\Images\" + myValue + ".JPG";

                pictureBox1.Image = Image.FromFile(filepath.ToString());
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void setdethi()
        {
            OnTap ontap = new OnTap();
            this.ontap = ontap.getOnTap();
        }

        public string QuestionID;

        private void Gbox_MouseClick(object sender, MouseEventArgs e)
        {
            var ctrl = sender as Control;
            int questionID = (int)(sender as Control).Tag;
            loadcauhoi(this.CauDangLam);
        }
        private void QuestionGroupBox_Click(object sender, EventArgs e)
        {
            var questionID = ((FrmOnTap)sender).QuestionID;
            loadcauhoi(this.CauDangLam);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
        private void FrmOnTap_Load(object sender, EventArgs e)
        {
            droptable();
            this.CauDaLam = 0;
            if (ontap == null) setdethi();
            Screen scr = Screen.PrimaryScreen; //đi lấy màn hình chính
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;
            int i = 0;
            foreach (DataRow row in this.ontap.Rows)
            {
                String myValue = row["SoDA"].ToString();
                String msch = row["MaCH"].ToString();
                ptl = new FrmPhieuTraLoi();
                pn_DeThi.Controls.Add(ptl.gbx("cau" + (i + 1).ToString(), int.Parse(myValue), (i + 1).ToString(), msch));
                listptl.Add(ptl);
                i++;
            }
            loadcauhoi(this.CauDangLam);
            listptl[CauDangLam].setBackColorCDL();

            txt = lbSatHachBangLai.Text;
            len = txt.Length;
            lbSatHachBangLai.Text = "";
            timer1.Start();
            this.timer2.Start();
        }

        private void thubai()
        {
            SqlConnection connDB = new SqlConnection(Program.connStr);
            connDB.Open();
            String sqlcmd = "";
            int k = 1;
            for (int i = 0; i < 30; i++)
            {
                string MsCauHoi = listptl[i].getMsCH();
                string DapAnofTS = listptl[i].getDapAnTS();
                sqlcmd = "insert into DAPAN values (" + k + ",'" + MsCauHoi + "','" + DapAnofTS + "');";
                k++;
                SqlCommand sqlCmd = new SqlCommand(sqlcmd, connDB);
                try { sqlCmd.ExecuteNonQuery(); }
                catch { }
            }
            connDB.Close();
        }
        private void droptable()
        {
            SqlConnection connDB = new SqlConnection(Program.connStr);
            connDB.Open();
            String sqlcmd = "";
            sqlcmd = " delete from DAPAN ";
            SqlCommand sqlCmd = new SqlCommand(sqlcmd, connDB);
            try { sqlCmd.ExecuteNonQuery(); }
            catch { }
            connDB.Close();
        }
        private void btnThoat1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        int counter = 0;
        int len = 0;
        string txt;

        private void btnChamDiem1_Click(object sender, EventArgs e)
        {
            thubai();
            MetroFramework.MetroMessageBox.Show(this, "Đã thu bài", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (FrmXemDapAn frm = new FrmXemDapAn())
            {
                frm.ShowDialog();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                counter = 0;
                lbSatHachBangLai.Text = "";
            }
            else
            {
                lbSatHachBangLai.Text = txt.Substring(0, counter);
                if (lbSatHachBangLai.ForeColor == Color.OrangeRed)
                {
                    lbSatHachBangLai.ForeColor = Color.Black;
                    lbSatHachBangLai.ForeColor = Color.White;
                    lbSatHachBangLai.ForeColor = Color.Blue;
                    lbSatHachBangLai.ForeColor = Color.Orange;
                    lbSatHachBangLai.ForeColor = Color.Brown;
                    lbSatHachBangLai.ForeColor = Color.Green;
                    lbSatHachBangLai.ForeColor = Color.Honeydew;


                }
                else { lbSatHachBangLai.ForeColor = Color.OrangeRed; }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.metroProgressBar1.Increment(1);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
