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

    public partial class personel_ekle : Form
    {


        public personel_ekle()
        {
            InitializeComponent();
        }

        private void personel_ekle_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox5.Text == textBox6.Text)
            {
                SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

                SqlCommand ekle = new SqlCommand();
                baglan.Open();

                ekle.Connection = baglan;
                ekle.CommandText = "INSERT INTO personel_list(ad_1,soyad_1,tc_no,adres,tarih,kullanıcı_adi,sifre_1,per_resmi) VALUES ('" + textBox1.Text.ToString().TrimEnd() + "','" + textBox2.Text.ToString().TrimEnd() + "','" + textBox3.Text.ToString().TrimEnd() + "','" + richTextBox1.Text.ToString().TrimEnd() + "','" + dateTimePicker1_personel.Value.ToString() + "','" + textBox4.Text.ToString().TrimEnd() + "','" + textBox5.Text.ToString().TrimEnd() + "','" + pictureBox1.ImageLocation + "')";
                ekle.ExecuteNonQuery();

                baglan.Close();
                richTextBox1.Clear(); textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); textBox6.Clear();
                label10.Visible = true;
                MessageBox.Show(pictureBox1.ImageLocation.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("ŞİFRELER UYUŞMUYOR !");
            }
 
        }


        private void textBox6_Leave(object sender, EventArgs e)
        {
            if(textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("ŞİFRELER UYUŞMUYOR !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
