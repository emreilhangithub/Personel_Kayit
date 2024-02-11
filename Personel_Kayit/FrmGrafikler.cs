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
using Personel_Kayit.DataAccess;

namespace Personel_Kayit
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = null;
        Connection connection = new Connection();

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti = connection.GetConnection();
                //Personel Şehirleri
                SqlCommand komutg1 = new SqlCommand("select PerSehir,Count(*) from Tbl_Personel GROUP BY PerSehir", baglanti);
                SqlDataReader dr1 = komutg1.ExecuteReader();
                while (dr1.Read())
                {
                    chartSehirler.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
                }
                dr1.Close();

                //personel maaş ve meslek
                SqlCommand komutg2 = new SqlCommand("select PerMeslek,AVG(PerMaas) from Tbl_Personel GROUP BY PerMeslek", baglanti);
                SqlDataReader dr2 = komutg2.ExecuteReader();
                while (dr2.Read())
                {
                    chartMeslekMaas.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
                }
                dr2.Close();
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
    }
}
