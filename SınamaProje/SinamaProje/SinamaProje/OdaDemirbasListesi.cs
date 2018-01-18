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
    public partial class OdaDemirbasListesi : Form
    {
        public OdaDemirbasListesi()
        {
            InitializeComponent();
        }
        static string conString = "Server=LAPTOP-H9FLMHQ1\\SQLEXPRESS;Database=Sinama_Proje;Uid=YazilimSinama;Password=111;";
        SqlConnection baglanti = new SqlConnection(conString);
        private void btn_listele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@oda_id",cmb_oda_adi.SelectedIndex + 1);
            komut.CommandText = "Select D.DemirbasID,DemirbasAdi,AtananAdet From Demirbaslar D Inner Join OdaDemirbasAtamalari O On D.DemirbasID=O.DemirbasID Where OdaID=@oda_id";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataliste.DataSource = dt;
            baglanti.Close();
        }
        private void OdaDemirbasListesi_Load(object sender, EventArgs e)
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
        }
    }
}
