namespace SatHachBangLaiXe
{
    partial class FrmTaoKiThi
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThemKiThi = new MetroFramework.Controls.MetroButton();
            this.btnSuaKiThi = new MetroFramework.Controls.MetroButton();
            this.btnXoaKiThi = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtKyThi = new MetroFramework.Controls.MetroTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtNgayBatDau = new MetroFramework.Controls.MetroTextBox();
            this.btnLuuKiThi = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtTaiKhoan = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.kyThiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDauDKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemKiThi
            // 
            this.btnThemKiThi.Location = new System.Drawing.Point(452, 221);
            this.btnThemKiThi.Name = "btnThemKiThi";
            this.btnThemKiThi.Size = new System.Drawing.Size(90, 32);
            this.btnThemKiThi.TabIndex = 5;
            this.btnThemKiThi.Text = "Thêm Kì Thi";
            this.btnThemKiThi.UseSelectable = true;
            this.btnThemKiThi.Click += new System.EventHandler(this.btnThemKiThi_Click);
            // 
            // btnSuaKiThi
            // 
            this.btnSuaKiThi.Location = new System.Drawing.Point(592, 221);
            this.btnSuaKiThi.Name = "btnSuaKiThi";
            this.btnSuaKiThi.Size = new System.Drawing.Size(90, 32);
            this.btnSuaKiThi.TabIndex = 6;
            this.btnSuaKiThi.Text = "Sửa Kì Thi";
            this.btnSuaKiThi.UseSelectable = true;
            this.btnSuaKiThi.Click += new System.EventHandler(this.btnSuaKiThi_Click);
            // 
            // btnXoaKiThi
            // 
            this.btnXoaKiThi.Location = new System.Drawing.Point(718, 221);
            this.btnXoaKiThi.Name = "btnXoaKiThi";
            this.btnXoaKiThi.Size = new System.Drawing.Size(90, 32);
            this.btnXoaKiThi.TabIndex = 7;
            this.btnXoaKiThi.Text = "Xóa Kì Thi";
            this.btnXoaKiThi.UseSelectable = true;
            this.btnXoaKiThi.Click += new System.EventHandler(this.btnXoaKiThi_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(482, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Kỳ Thi:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(440, 121);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(138, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Ngày Bắt Đầu Kỳ Thi:";
            // 
            // txtKyThi
            // 
            this.txtKyThi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "KyThi", true));
            this.txtKyThi.Lines = new string[0];
            this.txtKyThi.Location = new System.Drawing.Point(605, 88);
            this.txtKyThi.MaxLength = 32767;
            this.txtKyThi.Name = "txtKyThi";
            this.txtKyThi.PasswordChar = '\0';
            this.txtKyThi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKyThi.SelectedText = "";
            this.txtKyThi.Size = new System.Drawing.Size(203, 23);
            this.txtKyThi.TabIndex = 1;
            this.txtKyThi.UseSelectable = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = false;
            this.bindingSource1.DataSource = typeof(DTO.TTKyThi);
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "NgayBatDauDK", true));
            this.txtNgayBatDau.Lines = new string[0];
            this.txtNgayBatDau.Location = new System.Drawing.Point(605, 121);
            this.txtNgayBatDau.MaxLength = 32767;
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.PasswordChar = '\0';
            this.txtNgayBatDau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNgayBatDau.SelectedText = "";
            this.txtNgayBatDau.Size = new System.Drawing.Size(203, 23);
            this.txtNgayBatDau.TabIndex = 2;
            this.txtNgayBatDau.UseSelectable = true;
            // 
            // btnLuuKiThi
            // 
            this.btnLuuKiThi.Location = new System.Drawing.Point(592, 273);
            this.btnLuuKiThi.Name = "btnLuuKiThi";
            this.btnLuuKiThi.Size = new System.Drawing.Size(102, 41);
            this.btnLuuKiThi.TabIndex = 8;
            this.btnLuuKiThi.Text = "Lưu!";
            this.btnLuuKiThi.UseSelectable = true;
            this.btnLuuKiThi.Click += new System.EventHandler(this.btnLuuKiThi_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(482, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Tài Khoản";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "TaiKhoan", true));
            this.txtTaiKhoan.Lines = new string[0];
            this.txtTaiKhoan.Location = new System.Drawing.Point(605, 154);
            this.txtTaiKhoan.MaxLength = 32767;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.PasswordChar = '\0';
            this.txtTaiKhoan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTaiKhoan.SelectedText = "";
            this.txtTaiKhoan.Size = new System.Drawing.Size(203, 23);
            this.txtTaiKhoan.TabIndex = 3;
            this.txtTaiKhoan.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(729, 42);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(79, 23);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Refresh";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kyThiDataGridViewTextBoxColumn,
            this.ngayBatDauDKDataGridViewTextBoxColumn,
            this.taiKhoanDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.bindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 63);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(411, 251);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGrid1.TabIndex = 4;
            // 
            // kyThiDataGridViewTextBoxColumn
            // 
            this.kyThiDataGridViewTextBoxColumn.DataPropertyName = "KyThi";
            this.kyThiDataGridViewTextBoxColumn.HeaderText = "Kỳ Thi";
            this.kyThiDataGridViewTextBoxColumn.Name = "kyThiDataGridViewTextBoxColumn";
            // 
            // ngayBatDauDKDataGridViewTextBoxColumn
            // 
            this.ngayBatDauDKDataGridViewTextBoxColumn.DataPropertyName = "NgayBatDauDK";
            this.ngayBatDauDKDataGridViewTextBoxColumn.HeaderText = "Ngày Bắt Đầu Đăng Kí";
            this.ngayBatDauDKDataGridViewTextBoxColumn.Name = "ngayBatDauDKDataGridViewTextBoxColumn";
            // 
            // taiKhoanDataGridViewTextBoxColumn
            // 
            this.taiKhoanDataGridViewTextBoxColumn.DataPropertyName = "TaiKhoan";
            this.taiKhoanDataGridViewTextBoxColumn.HeaderText = "Tài Khoản";
            this.taiKhoanDataGridViewTextBoxColumn.Name = "taiKhoanDataGridViewTextBoxColumn";
            // 
            // FrmTaoKiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 327);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.txtNgayBatDau);
            this.Controls.Add(this.txtKyThi);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnXoaKiThi);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnSuaKiThi);
            this.Controls.Add(this.btnLuuKiThi);
            this.Controls.Add(this.btnThemKiThi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTaoKiThi";
            this.Text = "Tạo Kì Thi";
            this.Load += new System.EventHandler(this.FrmTaoKiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnThemKiThi;
        private MetroFramework.Controls.MetroButton btnSuaKiThi;
        private MetroFramework.Controls.MetroButton btnXoaKiThi;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtKyThi;
        private MetroFramework.Controls.MetroButton btnLuuKiThi;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtTaiKhoan;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox txtNgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyThiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDauDKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoanDataGridViewTextBoxColumn;
    }
}