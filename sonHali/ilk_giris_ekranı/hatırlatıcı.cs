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
    public partial class HATIRLATICI : Form
    {

        public HATIRLATICI()
        {
            InitializeComponent();
        }

        private void hatırlatıcı_Load(object sender, EventArgs e)
        {
            
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        string cal = "cal";
        string calma = "calma";

        private void button_alarm_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

                SqlCommand ekle = new SqlCommand();
                baglan.Open();

                ekle.Connection = baglan;
                ekle.CommandText = "INSERT INTO hatırlatıcı(tarih,not_1,alarm) VALUES ('" + monthCalendar1.SelectionRange.Start.ToShortDateString() + "','" + richTextBox1.Text.ToString().TrimEnd() + "','" + calma + "')";
                ekle.ExecuteNonQuery();

                baglan.Close();
                MessageBox.Show("ALARM KURULDU");
            }
            else
            {
                SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

                SqlCommand ekle = new SqlCommand();
                baglan.Open();

                ekle.Connection = baglan;
                ekle.CommandText = "INSERT INTO hatırlatıcı(tarih,not_1,alarm) VALUES ('" + monthCalendar1.SelectionRange.Start.ToShortDateString() + "','" + richTextBox1.Text.ToString().TrimEnd() + "','" + cal + "')";
                ekle.ExecuteNonQuery();

                baglan.Close();
                MessageBox.Show("ALARM KURULDU");
            }
        }
    }
}
