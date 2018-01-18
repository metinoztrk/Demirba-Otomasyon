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

namespace SinamaProje
{
    public partial class DemirbasSayisiArama : Form
    {
        public DemirbasSayisiArama()
        {
            InitializeComponent();
        }

        private void btn_demirbas_ara_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Server=LAPTOP-H9FLMHQ1\\SQLEXPRESS;Database=Sinama_Proje;Uid=YazilimSinama;Password=111;";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Demirbaslar";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            demirbas_listele.DataSource = dt;
            baglanti.Close();
        }

        private void DemirbasSayisiArama_Load(object sender, EventArgs e)
        {

        }
    }
}
