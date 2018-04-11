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
            this.SuspendLayout();
            // 
            // btnXuatReport
            // 
            this.btnXuatReport.Location = new System.Drawing.Point(178, 155);
            this.btnXuatReport.Name = "btnXuatReport";
            this.btnXuatReport.Size = new System.Drawing.Size(74, 38);
            this.btnXuatReport.TabIndex = 0;
            this.btnXuatReport.Text = "Xuất Report";
            this.btnXuatReport.UseSelectable = true;
            this.btnXuatReport.Click += new System.EventHandler(this.btnXuatReport_Click);
            // 
            // txtMaThiSinh
            // 
            this.txtMaThiSinh.Lines = new string[0];
            this.txtMaThiSinh.Location = new System.Drawing.Point(148, 92);
            this.txtMaThiSinh.MaxLength = 32767;
            this.txtMaThiSinh.Name = "txtMaThiSinh";
            this.txtMaThiSinh.PasswordChar = '\0';
            this.txtMaThiSinh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaThiSinh.SelectedText = "";
            this.txtMaThiSinh.Size = new System.Drawing.Size(163, 23);
            this.txtMaThiSinh.TabIndex = 1;
            this.txtMaThiSinh.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(50, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Mã Thí Sinh";
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 235);
            this.Controls.Add(this.metroLabel1);
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
    }
}