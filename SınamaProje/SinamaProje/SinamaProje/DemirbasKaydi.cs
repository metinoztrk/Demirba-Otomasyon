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
    public partial class DemirbasKaydi : Form
    {
        public DemirbasKaydi()
        {
            InitializeComponent();
        }
        static string conString = "Server=LAPTOP-H9FLMHQ1\\SQLEXPRESS;Database=Sinama_Proje;Uid=YazilimSinama;Password=111;";
        SqlConnection baglanti = new SqlConnection(conString);
        
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                string demirbas = null;
                string demirbasadi;
                int demirbasfiyati;
                DateTime tarih;
                int demirbasturu;
                int adet;
                demirbasadi = (txt_demirbas_adi.Text);

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlCommand komut3 = new SqlCommand();
                komut3.CommandText = "Select DemirbasAdi From Demirbaslar Where DemirbasAdi=" + "'" + demirbasadi + "'";
                komut3.Connection = baglanti;
                komut3.CommandType = CommandType.Text;
                SqlDataReader dr2 = komut3.ExecuteReader();
                while (dr2.Read())
                {
                    demirbas = Convert.ToString(dr2["DemirbasAdi"]);       
                }
                dr2.Close();
                if (demirbas == null)
                {
                    demirbasfiyati = Convert.ToInt32(txt_demirbas_fiyati.Text);
                    tarih = Convert.ToDateTime(date_demrbas_alim.Text);
                    demirbasturu = Convert.ToInt32(cmb_demirbas_turu.SelectedIndex + 1);
                    adet = Convert.ToInt32(txt_demirbas_adet.Text);
                    MessageBox.Show(DemirBasKayit(demirbasadi, demirbasfiyati, tarih, demirbasturu, adet));
                }
                else
                {
                    MessageBox.Show("Aynı isimde demirbaş vardır.");
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }

        }

        private void DemirbasKaydi_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            SqlCommand komut3 = new SqlCommand();
            komut3.CommandText = "Select DemirbasTuruAdi From DemirbasTurleri";
            komut3.Connection = baglanti;
            komut3.CommandType = CommandType.Text;
            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                
                cmb_demirbas_turu.Items.Add(Convert.ToString(dr2["DemirbasTuruAdi"]));
            }
            dr2.Close();

        }

        public String DemirBasKayit(string demirbasadi, int demirbasfiyati, DateTime tarih, int demirbasturu, int adet)
        {
            try
            {
                int id_arttirici = 0;
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlCommand komut2 = new SqlCommand();
                komut2.CommandText = "Select COUNT(*) As DemirbasID From  Demirbaslar";
                komut2.Connection = baglanti;
                komut2.CommandType = CommandType.Text;
                SqlDataReader dr = komut2.ExecuteReader();
                while (dr.Read())
                {
                    id_arttirici = Convert.ToInt32(dr["DemirbasID"]);
                }
                dr.Close();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into Demirbaslar(DemirbasID,DemirbasAdi,Fiyat,AlimTarihi,DemirbasTuruID,AlinanAdet) values (@DmrID,@DmrAdi,@fiyat,@tarih,@DmrTrID,@adet)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@DmrID", id_arttirici + 1);
                id_arttirici++;
                komut.Parameters.AddWithValue("@DmrAdi", demirbasadi);
                komut.Parameters.AddWithValue("@fiyat", demirbasfiyati);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@DmrTrID", demirbasturu);
                komut.Parameters.AddWithValue("@adet", adet);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                return "Basarıyla kaydedildi";
            }
            catch (Exception hata)
            {
                return "İşlem Sırasında Hata Oluştu." + hata.Message;
            }
            
        }
    }
}
