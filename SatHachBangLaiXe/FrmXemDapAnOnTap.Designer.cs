namespace SatHachBangLaiXe
{
    partial class FrmXemDapAnOnTap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbCauSai = new MetroFramework.Controls.MetroLabel();
            this.lbCauDung = new MetroFramework.Controls.MetroLabel();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.btnThoatThongKe = new MetroFramework.Controls.MetroButton();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.sTTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCHDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapAnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xemDapAnSai1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sATHACHLAIXEDataSet2 = new SatHachBangLaiXe.SATHACHLAIXEDataSet2();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xemDapAnDung1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sATHACHLAIXEDataSet1 = new SatHachBangLaiXe.SATHACHLAIXEDataSet1();
            this.xem_Dap_An_Dung1TableAdapter = new SatHachBangLaiXe.SATHACHLAIXEDataSet1TableAdapters.Xem_Dap_An_Dung1TableAdapter();
            this.xem_Dap_An_Sai1TableAdapter = new SatHachBangLaiXe.SATHACHLAIXEDataSet2TableAdapters.Xem_Dap_An_Sai1TableAdapter();
            this.lbDiem = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xemDapAnSai1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sATHACHLAIXEDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xemDapAnDung1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sATHACHLAIXEDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCauSai
            // 
            this.lbCauSai.AutoSize = true;
            this.lbCauSai.Location = new System.Drawing.Point(151, 91);
            this.lbCauSai.Name = "lbCauSai";
            this.lbCauSai.Size = new System.Drawing.Size(45, 19);
            this.lbCauSai.TabIndex = 10;
            this.lbCauSai.Text = "mmm";
            // 
            // lbCauDung
            // 
            this.lbCauDung.AutoSize = true;
            this.lbCauDung.Location = new System.Drawing.Point(548, 85);
            this.lbCauDung.Name = "lbCauDung";
            this.lbCauDung.Size = new System.Drawing.Size(45, 19);
            this.lbCauDung.TabIndex = 11;
            this.lbCauDung.Text = "mmm";
            // 
            // metroLink2
            // 
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink2.ForeColor = System.Drawing.Color.Teal;
            this.metroLink2.Location = new System.Drawing.Point(430, 85);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(122, 23);
            this.metroLink2.TabIndex = 8;
            this.metroLink2.Text = "Câu Làm Sai";
            this.metroLink2.UseCustomForeColor = true;
            this.metroLink2.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.ForeColor = System.Drawing.Color.Teal;
            this.metroLink1.Location = new System.Drawing.Point(35, 91);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(122, 23);
            this.metroLink1.TabIndex = 9;
            this.metroLink1.Text = "Câu Làm Đúng";
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            // 
            // btnThoatThongKe
            // 
            this.btnThoatThongKe.Location = new System.Drawing.Point(733, 23);
            this.btnThoatThongKe.Name = "btnThoatThongKe";
            this.btnThoatThongKe.Size = new System.Drawing.Size(80, 33);
            this.btnThoatThongKe.TabIndex = 7;
            this.btnThoatThongKe.Text = "Thoát";
            this.btnThoatThongKe.UseSelectable = true;
            this.btnThoatThongKe.Click += new System.EventHandler(this.btnThoatThongKe_Click);
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.AutoGenerateColumns = false;
            this.metroGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn1,
            this.maCHDataGridViewTextBoxColumn1,
            this.dapAnDataGridViewTextBoxColumn1});
            this.metroGrid2.DataSource = this.xemDapAnSai1BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(430, 120);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(362, 350);
            this.metroGrid2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroGrid2.TabIndex = 5;
            this.metroGrid2.UseCustomBackColor = true;
            this.metroGrid2.UseCustomForeColor = true;
            // 
            // sTTDataGridViewTextBoxColumn1
            // 
            this.sTTDataGridViewTextBoxColumn1.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn1.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn1.Name = "sTTDataGridViewTextBoxColumn1";
            // 
            // maCHDataGridViewTextBoxColumn1
            // 
            this.maCHDataGridViewTextBoxColumn1.DataPropertyName = "MaCH";
            this.maCHDataGridViewTextBoxColumn1.HeaderText = "MaCH";
            this.maCHDataGridViewTextBoxColumn1.Name = "maCHDataGridViewTextBoxColumn1";
            // 
            // dapAnDataGridViewTextBoxColumn1
            // 
            this.dapAnDataGridViewTextBoxColumn1.DataPropertyName = "DapAn";
            this.dapAnDataGridViewTextBoxColumn1.HeaderText = "DapAn";
            this.dapAnDataGridViewTextBoxColumn1.Name = "dapAnDataGridViewTextBoxColumn1";
            // 
            // xemDapAnSai1BindingSource
            // 
            this.xemDapAnSai1BindingSource.DataMember = "Xem_Dap_An_Sai1";
            this.xemDapAnSai1BindingSource.DataSource = this.sATHACHLAIXEDataSet2;
            // 
            // sATHACHLAIXEDataSet2
            // 
            this.sATHACHLAIXEDataSet2.DataSetName = "SATHACHLAIXEDataSet2";
            this.sATHACHLAIXEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.maCHDataGridViewTextBoxColumn,
            this.dapAnDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.xemDapAnDung1BindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(25, 120);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(390, 350);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroGrid1.TabIndex = 6;
            this.metroGrid1.UseCustomBackColor = true;
            this.metroGrid1.UseCustomForeColor = true;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            // 
            // maCHDataGridViewTextBoxColumn
            // 
            this.maCHDataGridViewTextBoxColumn.DataPropertyName = "MaCH";
            this.maCHDataGridViewTextBoxColumn.HeaderText = "MaCH";
            this.maCHDataGridViewTextBoxColumn.Name = "maCHDataGridViewTextBoxColumn";
            // 
            // dapAnDataGridViewTextBoxColumn
            // 
            this.dapAnDataGridViewTextBoxColumn.DataPropertyName = "DapAn";
            this.dapAnDataGridViewTextBoxColumn.HeaderText = "DapAn";
            this.dapAnDataGridViewTextBoxColumn.Name = "dapAnDataGridViewTextBoxColumn";
            // 
            // xemDapAnDung1BindingSource
            // 
            this.xemDapAnDung1BindingSource.DataMember = "Xem_Dap_An_Dung1";
            this.xemDapAnDung1BindingSource.DataSource = this.sATHACHLAIXEDataSet1;
            // 
            // sATHACHLAIXEDataSet1
            // 
            this.sATHACHLAIXEDataSet1.DataSetName = "SATHACHLAIXEDataSet1";
            this.sATHACHLAIXEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xem_Dap_An_Dung1TableAdapter
            // 
            this.xem_Dap_An_Dung1TableAdapter.ClearBeforeFill = true;
            // 
            // xem_Dap_An_Sai1TableAdapter
            // 
            this.xem_Dap_An_Sai1TableAdapter.ClearBeforeFill = true;
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbDiem.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbDiem.ForeColor = System.Drawing.Color.Red;
            this.lbDiem.Location = new System.Drawing.Point(311, 45);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(118, 25);
            this.lbDiem.TabIndex = 12;
            this.lbDiem.Text = "metroLabel1";
            this.lbDiem.UseCustomForeColor = true;
            // 
            // FrmXemDapAnOnTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 503);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.lbCauSai);
            this.Controls.Add(this.lbCauDung);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.btnThoatThongKe);
            this.Controls.Add(this.metroGrid2);
            this.Controls.Add(this.metroGrid1);
            this.Name = "FrmXemDapAnOnTap";
            this.Text = "ĐÁP ÁN";
            this.Load += new System.EventHandler(this.FrmXemDapAnOnTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xemDapAnSai1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sATHACHLAIXEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xemDapAnDung1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sATHACHLAIXEDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbCauSai;
        private MetroFramework.Controls.MetroLabel lbCauDung;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroButton btnThoatThongKe;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private SATHACHLAIXEDataSet1 sATHACHLAIXEDataSet1;
        private System.Windows.Forms.BindingSource xemDapAnDung1BindingSource;
        private SATHACHLAIXEDataSet1TableAdapters.Xem_Dap_An_Dung1TableAdapter xem_Dap_An_Dung1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapAnDataGridViewTextBoxColumn;
        private SATHACHLAIXEDataSet2 sATHACHLAIXEDataSet2;
        private System.Windows.Forms.BindingSource xemDapAnSai1BindingSource;
        private SATHACHLAIXEDataSet2TableAdapters.Xem_Dap_An_Sai1TableAdapter xem_Dap_An_Sai1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCHDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapAnDataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroLabel lbDiem;
    }
}