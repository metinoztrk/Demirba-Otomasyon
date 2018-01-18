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
    public partial class PersonelÜzerindekiDemirbaşıArama : Form
    {
        public PersonelÜzerindekiDemirbaşıArama()
        {
            InitializeComponent();
        }
        static string conString = "Server=LAPTOP-H9FLMHQ1\\SQLEXPRESS;Database=Sinama_Proje;Uid=YazilimSinama;Password=111;";
        SqlConnection baglanti = new SqlConnection(conString);
        private void btn_personel_ara_Click(object sender, EventArgs e)
        {
           
            
            SqlCommand komut3 = new SqlCommand();
            komut3.CommandText = "Select d.DemirbasAdi,da.AtananAdet,o.OdaAdi,f.FakulteAdi From Demirbaslar d INNER JOIN OdaDemirbasAtamalari da On d.DemirbasID=da.DemirbasID INNER JOIN Odalar o ON o.OdaID=da.OdaID INNER JOIN Fakulteler f ON o.FakulteID=f.FakulteID Where o.PersonelID=" + (cmb_adi.SelectedIndex + 1);
            komut3.Connection = baglanti;  
            komut3.CommandType = CommandType.Text;           
            SqlDataAdapter da = new SqlDataAdapter(komut3);
            DataTable dt = new DataTable();
            da.Fill(dt);
            personel_uzerindeki_demirbasi_listele.DataSource = dt;
     
            baglanti.Close();
            
        }

        private void PersonelÜzerindekiDemirbaşıArama_Load(object sender, EventArgs e)
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
                cmb_adi.Items.Add(Convert.ToString(dr2["PersonelAdi"]));
            }
            dr2.Close();
            baglanti.Close();
        }
    }
}
