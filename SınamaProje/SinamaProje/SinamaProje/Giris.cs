using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinamaProje
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        static string conString = "Server=LAPTOP-H9FLMHQ1\\SQLEXPRESS;Database=Sinama_Proje;Uid=YazilimSinama;Password=111;";
        SqlConnection baglanti = new SqlConnection(conString);
        public int yetki = 100;

        private void btnGiris_Click(object sender, EventArgs e)
        {

            string kullaniciadi = Convert.ToString(txtKullaniciAdi.Text);
            string sifre = Convert.ToString(txtSifre.Text);
           MessageBox.Show(GirisYap(kullaniciadi, sifre));
            
        }
        public string GirisYap(string kullaniciadi, string sifre)
        {
            Boolean kullanici = false;
            Boolean sifrekontrol = true;

              if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select KullaniciAdi From dbo.Kullanicilar";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (kullaniciadi == Convert.ToString(dr["KullaniciAdi"]))
                {
                    kullanici = true;
                }
            }
            dr.Close();
            if (kullanici)
            {
                SqlCommand komut2 = new SqlCommand();
                komut2.CommandText = "Select Sifre From  dbo.Kullanicilar";
                komut2.Connection = baglanti;
                komut2.CommandType = CommandType.Text;
                dr = komut2.ExecuteReader();
                while (dr.Read())
                {
                    if (sifre == Convert.ToString(dr["Sifre"]))
                    {
                        sifrekontrol = false;
                        
                        dr.Close();
                        SqlCommand komut3 = new SqlCommand();
                        komut3.CommandText = "Select YetkiliID From  dbo.Kullanicilar Where KullaniciAdi='" + kullaniciadi + "'";
                        komut3.Connection = baglanti;
                        komut3.CommandType = CommandType.Text;
                        dr = komut3.ExecuteReader();
                        while (dr.Read())
                        {
                            yetki = Convert.ToInt16(dr["YetkiliID"]);
                        }
                    
                    dr.Close();
                    baglanti.Close();
                    return "Giriş Başarılı.";
                    }
                }
                if (sifrekontrol)
                {
                    dr.Close();
                    baglanti.Close();
                    return "Şifrenizi yanlış girdiniz.";
                }

            }
            else
            {
                dr.Close();
                baglanti.Close();
                return "Böyle bir kullanıcı bulunmamaktadır.";
            }
            return "Böyle bir kullanıcı bulunmamaktadır.";
        }
        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
