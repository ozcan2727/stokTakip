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
using System.Collections;


namespace ilk_giris_ekranı
{
    public partial class grafik_1 : Form
    {
        public grafik_1()
        {
            InitializeComponent();
        }
        public static string kulad;
        private void grafik_1_Load(object sender, EventArgs e)
        {
            kulad = person_seç.per_adi;
          
            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            baglan.Open();
            SqlCommand komut = new SqlCommand();

            komut.Connection = baglan;
            komut.CommandText = "Select * from personel_list where kullanıcı_adi  like '%" + person_seç.per_adi + "%'";
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            string kull_adi = "";
            if (dr.Read())
            {
                textBox1.Text = dr["ad_1"].ToString().TrimEnd();
                textBox2.Text = dr["soyad_1"].ToString().TrimEnd();
                textBox3.Text = dr["tc_no"].ToString().TrimEnd();
                richTextBox1.Text = dr["adres"].ToString().TrimEnd();
                textBox4.Text = dr["sifre_1"].ToString().TrimEnd();
                dateTimePicker1_.Text = dr["tarih"].ToString().TrimEnd();
                textBox8.Text = dr["kullanıcı_adi"].ToString().TrimEnd();
                kull_adi = dr["kullanıcı_adi"].ToString().TrimEnd();
                if (dr["per_resmi"] != null)
                {
                    pictureBox1.ImageLocation = dr["per_resmi"].ToString();
                }
                else
                {
                    pictureBox1.Image = null;
                }



            }
            baglan.Close();
            DataTable tbl = new DataTable();
            string vara, cumle;
            vara = textBox1.Text;
            cumle = "Select * from per_satis_kaydi where personel_adi  like '%" + kull_adi + "%'";

            baglan.Open();
            SqlDataAdapter adptr = new SqlDataAdapter(cumle, baglan);
            adptr.Fill(tbl);


            dataGridView1_per_detay.DataSource = tbl;
            DataTable tbl1 = new DataTable();
            string vara1, cumle1;
            vara1 = textBox1.Text;
            cumle1 = "Select * from cari_satis_kaydi where personel_adi  like '%" + kull_adi + "%'";

            SqlDataAdapter adptr1 = new SqlDataAdapter(cumle1, baglan);
            adptr1.Fill(tbl1);


            dataGridView2_per_detay.DataSource = tbl1;


            decimal toplam = 0;
            for (int i = 0; i < dataGridView1_per_detay.Rows.Count; i++)
            {

                toplam += Convert.ToDecimal(dataGridView1_per_detay.Rows[i].Cells[0].Value.ToString().TrimEnd());


            }
            decimal top = 0;
            for (int j = 0; j < dataGridView2_per_detay.Rows.Count; j++)
            {

                top += Convert.ToDecimal(dataGridView2_per_detay.Rows[j].Cells[0].Value.ToString().TrimEnd());


            }
            baglan.Close();
            textBox6.Text = (toplam + top).ToString();
       
           
 
            






        }



        ArrayList ismler = new ArrayList();
        ArrayList toplamlar = new ArrayList();
        private void button1_Click_1(object sender, EventArgs e)
        {
            button2.Visible = true;
            decimal toplamson = 0;
            SqlConnection baglan1 = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");
            SqlCommand komut1 = new SqlCommand();
            komut1.CommandText = "SELECT * FROM personel_list";
            komut1.Connection = baglan1;
            komut1.CommandType = CommandType.Text;

            SqlDataReader dr1;
            baglan1.Open();
            dr1 = komut1.ExecuteReader();
         
            while (dr1.Read())
            {

                ismler.Add(dr1["kullanıcı_adi"].ToString());
        


            }
            baglan1.Close();
            foreach(string t in ismler)
            {
                baglan1.Open();
                DataTable tbl2 = new DataTable();
                string cumle2;

                cumle2 = "Select * from per_satis_kaydi where personel_adi  like '%" + t + "%'";

                SqlDataAdapter adptr2 = new SqlDataAdapter(cumle2, baglan1);
                adptr2.Fill(tbl2);


                dataGridView1_per_detay.DataSource = tbl2;
                DataTable tbl3 = new DataTable();
                string cumle3;

                cumle3 = "Select * from cari_satis_kaydi where personel_adi  like '%" +t + "%'";

                SqlDataAdapter adptr3 = new SqlDataAdapter(cumle3, baglan1);
                adptr3.Fill(tbl3);


                dataGridView2_per_detay.DataSource = tbl3;



                for (int i = 0; i < dataGridView1_per_detay.Rows.Count; i++)
                {

                    toplamson += Convert.ToDecimal(dataGridView1_per_detay.Rows[i].Cells[0].Value.ToString().TrimEnd());



                }

                for (int j = 0; j < dataGridView2_per_detay.Rows.Count; j++)
                {

                    toplamson += Convert.ToDecimal(dataGridView2_per_detay.Rows[j].Cells[0].Value.ToString().TrimEnd());


                }

                
                
                toplamlar.Add(toplamson);
                toplamson = 0;


                //Point leri temizleme.
 
                baglan1.Close();

            }
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            //Grafiğe değer ekleme
            foreach (decimal deger in toplamlar)
            {
                chart1.Series["PERSONEL"].Points.Add(Convert.ToDouble(deger));
                
            }


            //x ekseninde öğrenci isimlerini belirleme
            int say = 0;
            foreach (string ad in ismler)
            {
                
                chart1.Series["PERSONEL"].Points[say].LegendText = ad.ToUpper();
                
                say += 1;


            }

            //sağ taraftaki isimlerin değişimi legendtext
            chart1.Series["PERSONEL"].Points[person_seç.al].LegendText ="İNCELENEN("+person_seç.per_adi.ToUpper()+")";



            button1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            iade nw = new iade();
            nw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            SqlCommand ekle = new SqlCommand();
            baglan.Open();



            ekle.Connection = baglan;
            ekle.CommandText = "UPDATE  personel_list set  ad_1 = '" + textBox1.Text.ToString().TrimEnd() + "' , soyad_1 = '" + textBox2.Text.ToString().TrimEnd() + "',tc_no = '" + textBox3.Text.ToString().TrimEnd() + "', adres = '" + richTextBox1.Text.ToString().TrimEnd() + "',tarih= '" + dateTimePicker1_.Value.ToString().TrimEnd() + "',kullanıcı_adi= '" + textBox8.Text.ToString().TrimEnd() + "',sifre_1= '" + textBox4.Text.ToString().TrimEnd() +  "' ";
            ekle.ExecuteNonQuery();
            MessageBox.Show("KAYIT BAŞARIYLA GÜNCELLENDİ");
            baglan.Close();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sil = new DialogResult();
            sil = MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ ?", "Uyarı", MessageBoxButtons.YesNo);
            if(sil == DialogResult.Yes)
            {
                SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");
                baglan.Open();
                string sql = "DELETE FROM personel_list WHERE kullanıcı_adi=@kullanıcı_adi  ";
                SqlCommand komut = new SqlCommand(sql, baglan);

                komut.Parameters.AddWithValue("@kullanıcı_adi", textBox8.Text.ToString().TrimEnd());
               
                komut.ExecuteNonQuery();
                baglan.Close();
                
                MessageBox.Show("KAYIT SİLİNDİ");
                this.Close();
            }
        }
    }
}



