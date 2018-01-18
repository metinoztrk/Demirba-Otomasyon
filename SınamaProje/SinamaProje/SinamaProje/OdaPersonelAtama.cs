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
    public partial class OdaPersonelAtama : Form
    {
        public OdaPersonelAtama()
        {
            InitializeComponent();
        }
        static string conString = "Server=LAPTOP-H9FLMHQ1\\SQLEXPRESS;Database=Sinama_Proje;Uid=YazilimSinama;Password=111;";
        SqlConnection baglanti = new SqlConnection(conString);
        private void OdaPersonelAtama_Load(object sender, EventArgs e)
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

                cmb_odalar.Items.Add(Convert.ToString(dr2["OdaAdi"]));
            }
            dr2.Close();
            SqlCommand komut4 = new SqlCommand();
            komut4.CommandText = "Select PersonelAdi From Personeller";
            komut4.Connection = baglanti;
            komut4.CommandType = CommandType.Text;
            dr2 = komut4.ExecuteReader();
            while (dr2.Read())
            {

                cmb_personel.Items.Add(Convert.ToString(dr2["PersonelAdi"]));
            }
            dr2.Close();
            baglanti.Close();
        }

        private void btn_ata_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(OdayaPersonelAtama(cmb_personel.SelectedItem.ToString(), cmb_odalar.SelectedItem.ToString(), cmb_personel.SelectedIndex, cmb_odalar.SelectedIndex));
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
           
           
        }
        public string OdayaPersonelAtama(string PersonelAdi,string OdaAdi,int PersonelIndex, int OdaIndex)
        {
         
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "UPDATE OdaDemirbasAtamalari SET PersonelID='" + (PersonelIndex + 1) + "'" + " WHERE OdaID='" + (OdaIndex + 1) + "'";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@Personel", Convert.ToInt32(PersonelIndex + 1));
                komut.ExecuteNonQuery();
                string kayit2 = "UPDATE Odalar SET PersonelID='" + (PersonelIndex + 1) + "'" + "WHERE OdaID='" + (OdaIndex + 1) + "'";
                SqlCommand komut2 = new SqlCommand(kayit2, baglanti);
                komut2.Parameters.AddWithValue("@Personel", Convert.ToInt32(PersonelIndex + 1));
                komut2.ExecuteNonQuery();
                baglanti.Close();
                return "İşlem Başarılı.";
            
        }
    }
}
