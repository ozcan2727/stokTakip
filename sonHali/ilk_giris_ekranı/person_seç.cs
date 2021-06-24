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
    public partial class person_seç : Form
    {
        public person_seç()
        {
            InitializeComponent();
        }
        public static int say;
        private void person_seç_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM personel_list";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;
            
            SqlDataReader dr;
            baglan.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["kullanıcı_adi"].ToString().TrimEnd());
                say += 1;

            }
            comboBox1.AutoCompleteCustomSource.Add(comboBox1.Items.ToString());

            baglan.Close();
        }
        public static string per_adi;
        public static int al;
        private void button1_Click(object sender, EventArgs e)
        {
            al = comboBox1.SelectedIndex;
            per_adi = comboBox1.Text.TrimEnd() ;
            grafik_1 vw = new grafik_1();
            vw.Show();

            this.Hide();

        }
    }
}
