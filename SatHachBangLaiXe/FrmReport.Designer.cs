namespace SatHachBangLaiXe
{
    partial class FrmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXuatReport = new MetroFramework.Controls.MetroButton();
            this.txtMaThiSinh = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton22 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnXuatReport
            // 
            this.btnXuatReport.Location = new System.Drawing.Point(96, 155);
            this.btnXuatReport.Name = "btnXuatReport";
            this.btnXuatReport.Size = new System.Drawing.Size(190, 55);
            this.btnXuatReport.TabIndex = 0;
            this.btnXuatReport.Text = "Xuất Report Theo Mã Thí Sinh";
            this.btnXuatReport.UseSelectable = true;
            this.btnXuatReport.Click += new System.EventHandler(this.btnXuatReport_Click);
            // 
            // txtMaThiSinh
            // 
            this.txtMaThiSinh.Lines = new string[0];
            this.txtMaThiSinh.Location = new System.Drawing.Point(89, 92);
            this.txtMaThiSinh.MaxLength = 32767;
            this.txtMaThiSinh.Name = "txtMaThiSinh";
            this.txtMaThiSinh.PasswordChar = '\0';
            this.txtMaThiSinh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaThiSinh.SelectedText = "";
            this.txtMaThiSinh.Size = new System.Drawing.Size(232, 23);
            this.txtMaThiSinh.TabIndex = 1;
            this.txtMaThiSinh.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Mã Thí Sinh";
            // 
            // metroButton22
            // 
            this.metroButton22.Location = new System.Drawing.Point(482, 155);
            this.metroButton22.Name = "metroButton22";
            this.metroButton22.Size = new System.Drawing.Size(166, 55);
            this.metroButton22.TabIndex = 0;
            this.metroButton22.Text = "Xuất Report Theo Kỳ Thi";
            this.metroButton22.UseSelectable = true;
            this.metroButton22.Click += new System.EventHandler(this.metroButton22_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(469, 92);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(203, 23);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(406, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Kỳ Thi";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(626, 5);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(80, 30);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Thoát";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 233);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroButton22);
            this.Controls.Add(this.txtMaThiSinh);
            this.Controls.Add(this.btnXuatReport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnXuatReport;
        private MetroFramework.Controls.MetroTextBox txtMaThiSinh;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton22;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}