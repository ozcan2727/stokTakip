namespace ilk_giris_ekranı
{
    partial class satissecme
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
            this.stokadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokadediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokfiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokneviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoklistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carilerDataSet19 = new ilk_giris_ekranı.carilerDataSet19();
            this.textBox1_satissecme = new System.Windows.Forms.TextBox();
            this.stok_listTableAdapter = new ilk_giris_ekranı.carilerDataSet19TableAdapters.stok_listTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet19)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokadiDataGridViewTextBoxColumn,
            this.stokkoduDataGridViewTextBoxColumn,
            this.stokadediDataGridViewTextBoxColumn,
            this.stokfiyatiDataGridViewTextBoxColumn,
            this.stokneviDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stoklistBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 612);
            this.dataGridView1.TabIndex = 5;
            // 
            // stokadiDataGridViewTextBoxColumn
            // 
            this.stokadiDataGridViewTextBoxColumn.DataPropertyName = "stok_adi";
            this.stokadiDataGridViewTextBoxColumn.HeaderText = "stok_adi";
            this.stokadiDataGridViewTextBoxColumn.Name = "stokadiDataGridViewTextBoxColumn";
            this.stokadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokkoduDataGridViewTextBoxColumn
            // 
            this.stokkoduDataGridViewTextBoxColumn.DataPropertyName = "stok_kodu";
            this.stokkoduDataGridViewTextBoxColumn.HeaderText = "stok_kodu";
            this.stokkoduDataGridViewTextBoxColumn.Name = "stokkoduDataGridViewTextBoxColumn";
            this.stokkoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokadediDataGridViewTextBoxColumn
            // 
            this.stokadediDataGridViewTextBoxColumn.DataPropertyName = "stok_adedi";
            this.stokadediDataGridViewTextBoxColumn.HeaderText = "stok_adedi";
            this.stokadediDataGridViewTextBoxColumn.Name = "stokadediDataGridViewTextBoxColumn";
            this.stokadediDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokfiyatiDataGridViewTextBoxColumn
            // 
            this.stokfiyatiDataGridViewTextBoxColumn.DataPropertyName = "stok_fiyati";
            this.stokfiyatiDataGridViewTextBoxColumn.HeaderText = "stok_fiyati";
            this.stokfiyatiDataGridViewTextBoxColumn.Name = "stokfiyatiDataGridViewTextBoxColumn";
            this.stokfiyatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokneviDataGridViewTextBoxColumn
            // 
            this.stokneviDataGridViewTextBoxColumn.DataPropertyName = "stok_nevi";
            this.stokneviDataGridViewTextBoxColumn.HeaderText = "stok_nevi";
            this.stokneviDataGridViewTextBoxColumn.Name = "stokneviDataGridViewTextBoxColumn";
            this.stokneviDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stoklistBindingSource
            // 
            this.stoklistBindingSource.DataMember = "stok_list";
            this.stoklistBindingSource.DataSource = this.carilerDataSet19;
            // 
            // carilerDataSet19
            // 
            this.carilerDataSet19.DataSetName = "carilerDataSet19";
            this.carilerDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1_satissecme
            // 
            this.textBox1_satissecme.Location = new System.Drawing.Point(799, 644);
            this.textBox1_satissecme.Name = "textBox1_satissecme";
            this.textBox1_satissecme.Size = new System.Drawing.Size(125, 22);
            this.textBox1_satissecme.TabIndex = 0;
            this.textBox1_satissecme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // stok_listTableAdapter
            // 
            this.stok_listTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // satissecme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 687);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1_satissecme);
            this.Controls.Add(this.dataGridView1);
            this.Name = "satissecme";
            this.Text = "satissecme";
            this.Load += new System.EventHandler(this.satissecme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1_satissecme;
        private carilerDataSet19 carilerDataSet19;
        private System.Windows.Forms.BindingSource stoklistBindingSource;
        private carilerDataSet19TableAdapters.stok_listTableAdapter stok_listTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokadediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokfiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokneviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}