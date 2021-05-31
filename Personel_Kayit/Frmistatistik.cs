using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  //sql kütüphanesini cagırmamız lazım

namespace Personel_Kayit
{
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E9UTSVL;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void Frmistatistik_Load(object sender, EventArgs e)
        {

            //Toplam Personel sayısı
            baglanti.Open();
          
            SqlCommand komut1 = new SqlCommand("select count(*) from Tbl_Personel",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            //SqlDataReader veri okuyudur
            //ExecuteReader select için sorguyu calıstırır

            while(dr1.Read())
            {
                //d1 komutu okuma işlemi yaptıgı müddetce
                LblToplamPersonel.Text = dr1[0].ToString(); 
                //d1 den gelen 0 indexdeki degeri yazdır
            }

            baglanti.Close();

            //Evli Personel sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from Tbl_Personel where PerDurum = 1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {                
                LblEvliPersonel.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //Bekar Personel sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from Tbl_Personel where PerDurum = 0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblBekarPersonel.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //Şehir sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(PerSehir)) from Tbl_Personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblSehirSayisi.Text = dr4[0].ToString();
            }
            baglanti.Close();

        }
    }
}
