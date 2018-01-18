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
    public partial class OdaAtama : Form
    {
        public OdaAtama()
        {
            InitializeComponent();
        }
        static string conString = "Server=LAPTOP-H9FLMHQ1\\SQLEXPRESS;Database=Sinama_Proje;Uid=YazilimSinama;Password=111;";
        SqlConnection baglanti = new SqlConnection(conString);
        private void btn_oda_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(OdaDemirbasAtama(cmb_oda_adi.SelectedItem.ToString(), cmb_demirbas_adi.SelectedItem.ToString(), txt_demirbas_adeti.Text, cmb_oda_adi.SelectedIndex, cmb_demirbas_adi.SelectedIndex));
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        
        }
        public string OdaDemirbasAtama(string OdaAdi,string DemirBasAdi, string DemirBasAdet,int OdaIndex,int DemirBasIndex)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlCommand komut0 = new SqlCommand();
                komut0.CommandText = "Select AlinanAdet From Demirbaslar Where DemirbasAdi = '" + DemirBasAdi + "'";
                komut0.Connection = baglanti;
                komut0.CommandType = CommandType.Text;
                int stoktaki_adet = Convert.ToInt32(komut0.ExecuteScalar());
                int eklenecek_adet = Convert.ToInt32(txt_demirbas_adeti.Text);

                if (stoktaki_adet < eklenecek_adet)
                {
                   return "Stokta bulunandan daha fazla demirbaş eklemeye çalıştınız! " + DemirBasAdi + " stok = " + stoktaki_adet;
                }
                else
                {

                    int id_arttirici = 0;


                    SqlCommand komut2 = new SqlCommand();
                    komut2.CommandText = "Select COUNT(*) As OdaDemirbasAtamaID From  OdaDemirbasAtamalari";
                    komut2.Connection = baglanti;
                    komut2.CommandType = CommandType.Text;
                    SqlDataReader dr = komut2.ExecuteReader();
                    while (dr.Read())
                    {
                        id_arttirici = Convert.ToInt32(dr["OdaDemirbasAtamaID"]);
                    }
                    dr.Close();

                    string kayit = "insert into OdaDemirbasAtamalari(OdaDemirbasAtamaID,OdaID,DemirbasID,AtananAdet) values (@OdaDmrID,@OdaID,@DmrbID,@Adet)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@OdaDmrID", id_arttirici + 1);
                    komut.Parameters.AddWithValue("@OdaID", Convert.ToInt32(OdaIndex + 1));
                    komut.Parameters.AddWithValue("@DmrbID", Convert.ToInt32(DemirBasIndex + 1));
                    komut.Parameters.AddWithValue("@Adet", Convert.ToInt32(DemirBasAdet));
                    komut.ExecuteNonQuery();

                    kayit = "UPDATE Demirbaslar SET AlinanAdet='" + (stoktaki_adet - eklenecek_adet) + "'" + " WHERE DemirbasAdi='" + DemirBasAdi + "'";
                    SqlCommand komut3 = new SqlCommand(kayit, baglanti);
                    komut3.Parameters.AddWithValue("@Adet", (stoktaki_adet - eklenecek_adet));
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    return "Demirbaşlar Odaya Eklendi.";
                }
            }
            catch (Exception hata)
            {
                return "İşlem Sırasında Hata Oluştu." + hata.Message;
            }
        }

        private void OdaAtama_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            SqlCommand komut3 = new SqlCommand();
            komut3.CommandText = "Select OdaAdi From Odalar";
            komut3.Connection = baglanti;
            komut3.CommandType = CommandType.Text;
            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                cmb_oda_adi.Items.Add(Convert.ToString(dr2["OdaAdi"]));
            }
            dr2.Close();
            SqlCommand komut4 = new SqlCommand();
            komut4.CommandText = "Select DemirbasAdi From Demirbaslar";
            komut4.Connection = baglanti;
            komut4.CommandType = CommandType.Text;
            SqlDataReader dr3 = komut4.ExecuteReader();
            while (dr3.Read())
            {
                cmb_demirbas_adi.Items.Add(Convert.ToString(dr3["DemirbasAdi"]));
            }
            dr3.Close();
            baglanti.Close();
        }
    }
}
