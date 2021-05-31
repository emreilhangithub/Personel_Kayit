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

namespace Personel_Kayit
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E9UTSVL;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //Personel Şehirleri
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("select PerSehir,Count(*) from Tbl_Personel GROUP BY PerSehir", baglanti);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0],dr1[1]);
            }
            baglanti.Close();
        }
    }
}
