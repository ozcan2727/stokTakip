using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ilk_giris_ekranı
{
    public partial class satissecme : Form
    {

        public satissecme()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            baglan.Open();


            DataTable tbl = new DataTable();
            string vara, cumle;
            vara = textBox1_satissecme.Text.Trim();
            cumle = "Select * from stok_list where stok_adi + stok_kodu   like '%" + textBox1_satissecme.Text.TrimEnd() + "%'";

            SqlDataAdapter adptr = new SqlDataAdapter(cumle, baglan);
            adptr.Fill(tbl);
            baglan.Close();

            dataGridView1.DataSource = tbl;
        }



        private void satissecme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'carilerDataSet19.stok_list' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stok_listTableAdapter.Fill(this.carilerDataSet19.stok_list);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }

     
    
}
