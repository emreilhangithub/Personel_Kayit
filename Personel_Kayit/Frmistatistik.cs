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
using System.Windows.Forms.DataVisualization.Charting;
using Personel_Kayit.DataAccess;

namespace Personel_Kayit
{
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = null;
        Connection connection = new Connection();
        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti = connection.GetConnection();
                //Toplam Personel sayısı          
                SqlCommand komut1 = new SqlCommand("select count(*) from Tbl_Personel", baglanti);
                SqlDataReader dr1 = komut1.ExecuteReader();
                //SqlDataReader veri okuyudur
                //ExecuteReader select için sorguyu calıstırır

                while (dr1.Read())
                {
                    //d1 komutu okuma işlemi yaptıgı müddetce
                    LblToplamPersonel.Text = dr1[0].ToString();
                    //d1 den gelen 0 indexdeki degeri yazdır
                }
                dr1.Close();

                //Evli Personel sayısı
                SqlCommand komut2 = new SqlCommand("select count(*) from Tbl_Personel where PerDurum = 1", baglanti);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    LblEvliPersonel.Text = dr2[0].ToString();
                }
                dr2.Close();

                //Bekar Personel sayısı
                SqlCommand komut3 = new SqlCommand("select count(*) from Tbl_Personel where PerDurum = 0", baglanti);
                SqlDataReader dr3 = komut3.ExecuteReader();
                while (dr3.Read())
                {
                    LblBekarPersonel.Text = dr3[0].ToString();
                }
                dr3.Close();

                //Şehir sayısı
                SqlCommand komut4 = new SqlCommand("select count(distinct(PerSehir)) from Tbl_Personel", baglanti);
                SqlDataReader dr4 = komut4.ExecuteReader();
                while (dr4.Read())
                {
                    LblSehirSayisi.Text = dr4[0].ToString();
                }
                dr4.Close();

                //Toplam Maaş
                SqlCommand komut5 = new SqlCommand("select sum(PerMaas) from Tbl_Personel", baglanti);
                SqlDataReader dr5 = komut5.ExecuteReader();
                while (dr5.Read())
                {
                    LblToplamMaas.Text = dr5[0].ToString();
                }
                dr5.Close();

                //Ortlama Maaş
                SqlCommand komut6 = new SqlCommand("select avg(PerMaas) from Tbl_Personel", baglanti);
                SqlDataReader dr6 = komut6.ExecuteReader();
                while (dr6.Read())
                {
                    LblOrtalamaMaas.Text = dr6[0].ToString();
                }
                dr6.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close(); // Bağlantıyı kapat
            }        
        }

        private void LblEvliPersonel_Click(object sender, EventArgs e)
        {

        }
    }
}
