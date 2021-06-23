namespace ilk_giris_ekranı
{
    partial class faturalar
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
            this.firmaadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatbasligiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ödendidurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fattarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.faturalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carilerDataSet59 = new ilk_giris_ekranı.carilerDataSet59();
            this.faturalarTableAdapter = new ilk_giris_ekranı.carilerDataSet59TableAdapters.faturalarTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet59)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmaadiDataGridViewTextBoxColumn,
            this.fatbasligiDataGridViewTextBoxColumn,
            this.ödendidurumuDataGridViewTextBoxColumn,
            this.fattarihDataGridViewTextBoxColumn,
            this.faturaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.faturalarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1392, 567);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // firmaadiDataGridViewTextBoxColumn
            // 
            this.firmaadiDataGridViewTextBoxColumn.DataPropertyName = "firma_adi";
            this.firmaadiDataGridViewTextBoxColumn.HeaderText = "FİRMA ADI";
            this.firmaadiDataGridViewTextBoxColumn.Name = "firmaadiDataGridViewTextBoxColumn";
            this.firmaadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.firmaadiDataGridViewTextBoxColumn.Width = 286;
            // 
            // fatbasligiDataGridViewTextBoxColumn
            // 
            this.fatbasligiDataGridViewTextBoxColumn.DataPropertyName = "fat_basligi";
            this.fatbasligiDataGridViewTextBoxColumn.HeaderText = "FATURA BAŞLIĞI";
            this.fatbasligiDataGridViewTextBoxColumn.Name = "fatbasligiDataGridViewTextBoxColumn";
            this.fatbasligiDataGridViewTextBoxColumn.ReadOnly = true;
            this.fatbasligiDataGridViewTextBoxColumn.Width = 300;
            // 
            // ödendidurumuDataGridViewTextBoxColumn
            // 
            this.ödendidurumuDataGridViewTextBoxColumn.DataPropertyName = "ödendi_durumu";
            this.ödendidurumuDataGridViewTextBoxColumn.HeaderText = "DURUM";
            this.ödendidurumuDataGridViewTextBoxColumn.Name = "ödendidurumuDataGridViewTextBoxColumn";
            this.ödendidurumuDataGridViewTextBoxColumn.ReadOnly = true;
            this.ödendidurumuDataGridViewTextBoxColumn.Width = 180;
            // 
            // fattarihDataGridViewTextBoxColumn
            // 
            this.fattarihDataGridViewTextBoxColumn.DataPropertyName = "fat_tarih";
            this.fattarihDataGridViewTextBoxColumn.HeaderText = "TARİH";
            this.fattarihDataGridViewTextBoxColumn.Name = "fattarihDataGridViewTextBoxColumn";
            this.fattarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.fattarihDataGridViewTextBoxColumn.Width = 156;
            // 
            // faturaDataGridViewTextBoxColumn
            // 
            this.faturaDataGridViewTextBoxColumn.DataPropertyName = "fatura";
            this.faturaDataGridViewTextBoxColumn.HeaderText = "FATURA";
            this.faturaDataGridViewTextBoxColumn.Name = "faturaDataGridViewTextBoxColumn";
            this.faturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.faturaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.faturaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.faturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // faturalarBindingSource
            // 
            this.faturalarBindingSource.DataMember = "faturalar";
            this.faturalarBindingSource.DataSource = this.carilerDataSet59;
            // 
            // carilerDataSet59
            // 
            this.carilerDataSet59.DataSetName = "carilerDataSet59";
            this.carilerDataSet59.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // faturalarTableAdapter
            // 
            this.faturalarTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1290, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "KAPAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // faturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1416, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1434, 689);
            this.Name = "faturalar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.stsfatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet59)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private carilerDataSet59 carilerDataSet59;
        private System.Windows.Forms.BindingSource faturalarBindingSource;
        private carilerDataSet59TableAdapters.faturalarTableAdapter faturalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatbasligiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ödendidurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fattarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn faturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}