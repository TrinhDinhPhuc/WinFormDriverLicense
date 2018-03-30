namespace SatHachBangLaiXe
{
    partial class FrmXemDapAn
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sATHACHBANGLAI1DataSet = new SatHachBangLaiXe.SATHACHBANGLAI1DataSet();
            this.xemDapAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xem_Dap_AnTableAdapter = new SatHachBangLaiXe.SATHACHBANGLAI1DataSetTableAdapters.Xem_Dap_AnTableAdapter();
            this.maCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sATHACHBANGLAI1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xemDapAnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCHDataGridViewTextBoxColumn,
            this.dapAnDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.xemDapAnBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // sATHACHBANGLAI1DataSet
            // 
            this.sATHACHBANGLAI1DataSet.DataSetName = "SATHACHBANGLAI1DataSet";
            this.sATHACHBANGLAI1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xemDapAnBindingSource
            // 
            this.xemDapAnBindingSource.DataMember = "Xem_Dap_An";
            this.xemDapAnBindingSource.DataSource = this.sATHACHBANGLAI1DataSet;
            // 
            // xem_Dap_AnTableAdapter
            // 
            this.xem_Dap_AnTableAdapter.ClearBeforeFill = true;
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
            // FrmXemDapAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 365);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmXemDapAn";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.FrmXemDapAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sATHACHBANGLAI1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xemDapAnBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SATHACHBANGLAI1DataSet sATHACHBANGLAI1DataSet;
        private System.Windows.Forms.BindingSource xemDapAnBindingSource;
        private SATHACHBANGLAI1DataSetTableAdapters.Xem_Dap_AnTableAdapter xem_Dap_AnTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapAnDataGridViewTextBoxColumn;
    }
}