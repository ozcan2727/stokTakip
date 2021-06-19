using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;


namespace ilk_giris_ekranı
{
    
    public partial class anaform : Form
    {
        SoundPlayer player = new SoundPlayer();//SoundPlayer nesnesi oluşturulur.

        
        
        
        public anaform()
        {
            InitializeComponent();
        }

        private void anaform_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath.ToString() + "\\deep-alarm.wav"; // Ses dosyası Bin\\Debug içindeki yeri. Dosyayı Debug içinden aldım.

            player.SoundLocation = path;
            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            baglan.Open();
            SqlCommand komut = new SqlCommand();

            komut.Connection = baglan;
            komut.CommandText = "Select * from hatırlatıcı where tarih = '" + dateTimePicker1.Value.ToShortDateString() + "' ";
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if(dr["alarm"].ToString().TrimEnd() == "cal")
                {
                    groupBox1.Visible = true;
                   
                    player.Play(); 
                    label1_alarmnot.Visible = true;
                   label1_alarmnot.Text = dr["not_1"].ToString().TrimEnd();
                }
                label1_alarmnot.Visible = true;
                label1_alarmnot.Text = dr["not_1"].ToString().TrimEnd();
            }
               

            
            this.cariTableAdapter.Fill(this.carilerDataSet20.cari);
            caridüzenlesil sl = new caridüzenlesil();
            caridüzesilson dl = new caridüzesilson();
            From1 al = new From1();
            if(From1.kullanıcı_adı == "admin")//Admin
            {
                dl.button5.Visible = true;
                sl.button2.Visible = true;

                personelEkleToolStripMenuItem.Visible = true;
                işlemlerToolStripMenuItem.Visible = true;


            }
            
            
        }

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_stokyönetim_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
          
        }

        private void asdasdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
  

        }
        stokyükleilk stkyklmılk;

        private void asdasdToolStripMenuItem_Click(object sender, EventArgs e)
        {




        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button4_satıs_Click(object sender, EventArgs e)
        {
          
        }

        private void ToolStripMenuItem_2_Click(object sender, EventArgs e)
        {

      
        }

        private void yeniStokKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
                stkyklmılk = new stokyükleilk();
     
                stkyklmılk.Show();
  
        }

        private void yeniCariKartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cariac carigir = new cariac();
            carigir.Show();
        }

        private void cariKartAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cariara gr = new cariara();
            gr.Show();
        }

        private void cARİKARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caridüzenlesil gr = new caridüzenlesil();
            gr.Show();
        }

        private void stokKartıAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokara gr = new stokara();
            gr.Show();
        }

        private void cariKartSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caridüzenlesil gr = new caridüzenlesil();
            gr.Show();
            
        }

        private void anaform_Leave(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void stokKartıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokgör gr = new stokgör();
            gr.Show();
        }

        private void pERAKENDESATIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satis prksatis = new satis();
            prksatis.Show();
        }

        private void perakendeSatışKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            per_satis_kaydi gstr = new per_satis_kaydi();
            
            gstr.Show();
        }

        private void cariSatışKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cari_satis_kaydi crgster = new cari_satis_kaydi();
            crgster.Show();
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

               
        }

        private void personelEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            personel_ekle ekle = new personel_ekle();
            ekle.Show();
        }

        private void personelDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            person_seç ac = new person_seç();
            ac.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void satışFaturaDökümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faturalar ac = new faturalar();
            ac.Show();
        }



        private void hesaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesaplar hs = new hesaplar();
            hs.Show();
        }

        private void hatırlatıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HATIRLATICI ht = new HATIRLATICI();
            ht.Show();
        }

        private void button3_alarmertele_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            timer1.Start();
            timer1.Interval = 60000;
            groupBox1.Visible = false;
            sayac = 0;
            player.Stop();
        }

        private void button2_alarmkapat_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            groupBox1.Visible = false;
            player.Stop();
        }
        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            
            if (sayac == 15)
            {
                groupBox1.Visible = true;
                label1_alarmnot.Visible = true;
                groupBox1.Show();
                player.Play(); //Ses dosyasını çal.
            }
        }
    }

}
