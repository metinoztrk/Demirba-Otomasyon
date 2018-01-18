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
    public partial class OdaTanimlama : Form
    {
        public OdaTanimlama()
        {
            InitializeComponent();
        }
        static string conString = "Server=LAPTOP-H9FLMHQ1\\SQLEXPRESS;Database=Sinama_Proje;Uid=YazilimSinama;Password=111;";
        SqlConnection baglanti = new SqlConnection(conString);
        
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            
            try
            {
                string odaadi = txt_oda_adi.Text; ;
                int odasorumlusu = cmb_oda_sorumlusu.SelectedIndex; ;
                int departman = cmb_departman.SelectedIndex;
                int fakulte = cmb_fakulte.SelectedIndex;
                if(odasorumlusu == -1 || departman == -1 || fakulte==-1)
                {
                    MessageBox.Show("Lütfen doğru şekilde doldurunuz.");
                }
                else
                {
                    MessageBox.Show(OdaKayit(odaadi, odasorumlusu, fakulte));
                }
                
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        public string OdaKayit(string odaadi, int odasorumlusu, int fakulte)
        {
            try
            {
                string oda_adi = null;
                int id_arttirici = 0;
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlCommand komut2 = new SqlCommand();
                komut2.CommandText = "Select COUNT(*) As OdaID From  Odalar";
                komut2.Connection = baglanti;
                komut2.CommandType = CommandType.Text;
                SqlDataReader dr = komut2.ExecuteReader();
                while (dr.Read())
                {
                    id_arttirici = Convert.ToInt32(dr["OdaID"]);
                }
                dr.Close();
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlCommand komut3 = new SqlCommand();
                komut3.CommandText = "Select OdaAdi From Odalar Where FakulteID=" + "'" + fakulte+1 + "' and OdaAdi="+"'"+odaadi+"'";
                komut3.Connection = baglanti;
                komut3.CommandType = CommandType.Text;
                SqlDataReader dr2 = komut3.ExecuteReader();
                while (dr2.Read())
                {
                    oda_adi = Convert.ToString(dr2["OdaAdi"]);
                }
                dr2.Close();
                if (oda_adi == null)
                {
                    // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                    string kayit = "insert into Odalar(OdaID,OdaAdi,FakulteID,PersonelID) values(@OdaID,@OdaAdi,@FakulteID,@PerID)";
                    // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                    komut.Parameters.AddWithValue("@OdaID", id_arttirici + 1);
                    id_arttirici++;
                    komut.Parameters.AddWithValue("@OdaAdi", odaadi);
                    komut.Parameters.AddWithValue("@PerID", odasorumlusu + 1);
                    komut.Parameters.AddWithValue("@FakulteID", fakulte + 1);
                    //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                    komut.ExecuteNonQuery();
                    //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                    baglanti.Close();
                    return "Başarıyla oda tanımlandı.";
                }
                else
                {
                    return "Fakültede zaten böyle bir oda bulunmaktadır";
                }

            }
            catch (Exception hata)
            {
                return "İşlem Sırasında Hata Oluştu." + hata.Message;
            }

        }


        private void OdaTanimlama_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            SqlCommand komut3 = new SqlCommand();
            komut3.CommandText = "Select PersonelAdi From Personeller";
            komut3.Connection = baglanti;
            komut3.CommandType = CommandType.Text;
            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                cmb_oda_sorumlusu.Items.Add(Convert.ToString(dr2["PersonelAdi"]));
            }
            dr2.Close();
            komut3.CommandText = "Select FakulteAdi From Fakulteler";
            komut3.Connection = baglanti;
            komut3.CommandType = CommandType.Text;
            dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                cmb_fakulte.Items.Add(Convert.ToString(dr2["FakulteAdi"]));
            }
            dr2.Close();
            baglanti.Close();
        }

        private void cmb_fakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_departman.Items.Clear();
            int secim = cmb_fakulte.SelectedIndex;
            secim++;
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            SqlCommand komut3 = new SqlCommand();
            komut3.CommandText = "Select D.DepartmanAdi From Fakulteler F INNER JOIN Departmanlar D ON F.FakulteID=D.FakulteID Where F.FakulteID=" + secim;
            komut3.Connection = baglanti;
            komut3.CommandType = CommandType.Text;
            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                cmb_departman.Items.Add(Convert.ToString(dr2["DepartmanAdi"]));
            }
            dr2.Close();
        }
    }
}
