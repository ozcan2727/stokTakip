using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Web;

namespace ilk_giris_ekranı
{
    public partial class faturalar : Form
    {
        public faturalar()
        {
            InitializeComponent();
        }
        
        private void stsfatura_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'carilerDataSet59.faturalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.faturalarTableAdapter.Fill(this.carilerDataSet59.faturalar);
            DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
            {
                buttons.HeaderText = "Fatura";
                buttons.Text = "Görüntüle";
                buttons.UseColumnTextForButtonValue = true;
                buttons.AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.AllCells;
                buttons.FlatStyle = FlatStyle.Standard;
                buttons.CellTemplate.Style.BackColor = Color.Honeydew;
                buttons.DisplayIndex = 0;
            }
            buttons.DisplayIndex = 5;
            dataGridView1.Columns.Add(buttons);
            this.dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Ariel", 10);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                System.Diagnostics.Process.Start(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
