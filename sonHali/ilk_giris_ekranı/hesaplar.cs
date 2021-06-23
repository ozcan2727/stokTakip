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
    public partial class hesaplar : Form
    {
        public hesaplar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            SqlCommand ekle = new SqlCommand();
            baglan.Open();

            ekle.Connection = baglan;
            ekle.CommandText = "INSERT INTO hesaplar(hesap_türü,aciklama,tutar,adisoyadi,tc,tarih,telno) VALUES ('" + comboBox1.Text.ToString().TrimEnd() + "','" + textBox1.Text.ToString().TrimEnd() + "','" + textBox2.Text.ToString().TrimEnd() + "','" + textBox3.Text.ToString().TrimEnd() + "','"  + textBox4.Text.ToString().TrimEnd() + "','" +dateTimePicker1.Value.ToString()  + "','" +textBox5.Text.ToString().TrimEnd() + "')";
            ekle.ExecuteNonQuery();

            baglan.Close();
            comboBox1.Text = ""; textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();

            MessageBox.Show("Hesap Kaydedildi");
            this.Close();
        }
        decimal toplam = 0;
        private void hesaplar_Load(object sender, EventArgs e)
        {
            
            // TODO: Bu kod satırı 'carilerDataSet67.hesaplar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesaplarTableAdapter1.Fill(this.carilerDataSet67.hesaplar);
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(comboBox1.Text.TrimEnd() == "TAHSİLAT")
                {
                    toplam += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                }
                else
                    toplam -= Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

            }
            textBox6.Text = toplam.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult sil = new DialogResult();
            sil = MessageBox.Show("HESAP SİLİNSİN Mİ ?","UYARI ",MessageBoxButtons.YesNo);
            if(sil == DialogResult.Yes)
            {
                SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");
                baglan.Open();
                string sql = "DELETE FROM hesaplar WHERE id=@id  ";
                SqlCommand komut = new SqlCommand(sql, baglan);

                komut.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString().TrimEnd()));

                komut.ExecuteNonQuery();
                baglan.Close();

                MessageBox.Show("HESAP SİLİNDİ");
                this.hesaplarTableAdapter1.Fill(this.carilerDataSet67.hesaplar);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (comboBox1.Text == "TAHSİLAT")
                    {
                        toplam += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                    }
                    else
                        toplam -= Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                }
                textBox6.Text = toplam.ToString();
            }
            
        }
    }
}
