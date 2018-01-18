using SinamaProje;
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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        Giris frm9;

        private void PersonelÜzerindekiDemirbaşıAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelÜzerindekiDemirbaşıArama frm2 = new PersonelÜzerindekiDemirbaşıArama();
            frm2.Show();
            frm2.MdiParent = this;
        }

        private void demirbaşSayısıAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemirbasSayisiArama frm3 = new DemirbasSayisiArama();
            frm3.Show();
            frm3.MdiParent = this;
        }

        private void stokDemirbaşKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemirbasKaydi frm4 = new DemirbasKaydi();
            frm4.Show();
            frm4.MdiParent = this;
        }

        private void odaTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdaTanimlama frm5 = new OdaTanimlama();
            frm5.Show();
            frm5.MdiParent = this;
        }
        private void odaAtamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdaAtama frm7 = new OdaAtama();
            frm7.Show();
            frm7.MdiParent = this;
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            frm9 = new Giris();
            frm9.Show();
            frm9.MdiParent = this;

            timer.Interval = 500;
            timer.Enabled = true;
            timer.Start();
            menuStrip1.Hide();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (frm9.yetki == 1)
            {
                frm9.Hide();
                menuStrip1.Show();
                timer.Stop();
            }
            else if(frm9.yetki == 0)
            {
                frm9.Hide();
                menuStrip1.Show();
                stokDemirbaşKaydıToolStripMenuItem.Enabled = false;
                stokDemirbaşKaydıToolStripMenuItem.ForeColor = Color.Gray;
                odaTanımlamaToolStripMenuItem.Enabled = false;
                odaTanımlamaToolStripMenuItem.ForeColor = Color.Gray;
                timer.Stop();

            }
           
        }

        private void odaDemirbaşListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdaDemirbasListesi frm8 = new OdaDemirbasListesi();
            frm8.Show();
            frm8.MdiParent = this;
        }

        private void odayaPersonelAtamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdaPersonelAtama frm9 = new OdaPersonelAtama();
            frm9.Show();
            frm9.MdiParent = this;
        }

        
    }
}
