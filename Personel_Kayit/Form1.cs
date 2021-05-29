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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E9UTSVL;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //baglanti ac
            SqlCommand komut = new SqlCommand(
                "insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values(@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            //sql komut nesnesi ürettik  //@p1 parametre belirttik

            komut.Parameters.AddWithValue("@p1",TxtAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",CmbSehir.Text);
            komut.Parameters.AddWithValue("@p4",MskMaas.Text);
            komut.Parameters.AddWithValue("@p5",TxtMeslek.Text);
            komut.Parameters.AddWithValue("@p6",label1.Text);
            //komut nesnesinden gelen parametrelerin değer olarak ekle virgülen once parametre ad vir sonra nerden alacagını

            komut.ExecuteNonQuery(); //sorguyu calıştır

            baglanti.Close(); //baglanti kapat
            MessageBox.Show("Personel Başarıyla Eklendi");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "False";
        }
    }
}
