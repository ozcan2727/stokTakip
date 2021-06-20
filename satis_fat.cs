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
using System.IO;



namespace ilk_giris_ekranı
{
    public partial class satis_fat : Form
    {
        

        public satis_fat()
        {
            InitializeComponent();
        }

        private void satis_fat_Load(object sender, EventArgs e)
        {
            
            comboBox1.Text = satis.firadı;
            textBox4.Text = satis.belgenotu;
            
            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");



            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM cari";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglan.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["firma_adi"].ToString().TrimEnd());
                comboBox3.Items.Add(dr["vergi_no"].ToString().TrimEnd());
            }

            comboBox1.AutoCompleteCustomSource.Add(comboBox1.Items.ToString());

            baglan.Close();
            From1 st = new From1();
            textBox5.Text = st.dateTimePicker1_tarih.Value.ToString();


        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = comboBox1.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            try
            {      
                baglan.Open();

                string kom = "INSERT INTO faturalar(firma_adi,vergi_no,fat_basligi,ödendi_durumu,fat_tarih,fatura) VALUES ('" + comboBox1.Text.ToString().TrimEnd().ToLower() + "','" + comboBox3.Text.ToString().TrimEnd() + "','" + textBox4.Text.ToString().TrimEnd() + "','" + comboBox2.Text.ToString().TrimEnd() + "','" + textBox5.Text.ToString().TrimEnd() + "','" + satis.yol.ToString() + "')";
                SqlCommand ekle = new SqlCommand(kom,baglan);
                ekle.Connection = baglan;
         
       
                ekle.ExecuteNonQuery();
            MessageBox.Show("FATURA KAYDEDİLDİ");
            baglan.Close();
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
           System.Diagnostics.Process.Start(satis.yol);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (System.IO.File.Exists(@satis.yol))
            {
                MessageBox.Show("FATURA BAŞARIYLA SİLİNDİ");
                System.IO.File.Delete(@satis.yol);
            }
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(satis.yol);
        }
    }
}
