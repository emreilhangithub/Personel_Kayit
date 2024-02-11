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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = null;
        Connection connection = new Connection();

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti = connection.GetConnection();
                SqlCommand komut = new SqlCommand("Select * from Tbl_Yonetici where KullaniciAd = @p1 and Sifre = @p2", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    FrmAnaForm frm = new FrmAnaForm();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
                }
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
