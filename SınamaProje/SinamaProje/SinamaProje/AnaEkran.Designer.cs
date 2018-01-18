namespace SinamaProje
{
    partial class AnaEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aramalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelDemirbasAramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demirbaşSayısıAramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokDemirbaşKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaDemirbaşİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaAtamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaDemirbaşListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odayaPersonelAtamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aramalarToolStripMenuItem,
            this.stokDemirbaşKaydıToolStripMenuItem,
            this.odaTanımlamaToolStripMenuItem,
            this.odaDemirbaşİşlemleriToolStripMenuItem,
            this.odayaPersonelAtamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1055, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aramalarToolStripMenuItem
            // 
            this.aramalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelDemirbasAramaToolStripMenuItem,
            this.demirbaşSayısıAramaToolStripMenuItem});
            this.aramalarToolStripMenuItem.Name = "aramalarToolStripMenuItem";
            this.aramalarToolStripMenuItem.Size = new System.Drawing.Size(102, 26);
            this.aramalarToolStripMenuItem.Text = "Aramalar";
            // 
            // personelDemirbasAramaToolStripMenuItem
            // 
            this.personelDemirbasAramaToolStripMenuItem.Name = "personelDemirbasAramaToolStripMenuItem";
            this.personelDemirbasAramaToolStripMenuItem.Size = new System.Drawing.Size(429, 30);
            this.personelDemirbasAramaToolStripMenuItem.Text = "Personel Üzerindeki Demirbaşı Arama";
            this.personelDemirbasAramaToolStripMenuItem.Click += new System.EventHandler(this.PersonelÜzerindekiDemirbaşıAramaToolStripMenuItem_Click);
            // 
            // demirbaşSayısıAramaToolStripMenuItem
            // 
            this.demirbaşSayısıAramaToolStripMenuItem.Name = "demirbaşSayısıAramaToolStripMenuItem";
            this.demirbaşSayısıAramaToolStripMenuItem.Size = new System.Drawing.Size(429, 30);
            this.demirbaşSayısıAramaToolStripMenuItem.Text = "Demirbaş Sayısı Arama";
            this.demirbaşSayısıAramaToolStripMenuItem.Click += new System.EventHandler(this.demirbaşSayısıAramaToolStripMenuItem_Click);
            // 
            // stokDemirbaşKaydıToolStripMenuItem
            // 
            this.stokDemirbaşKaydıToolStripMenuItem.Name = "stokDemirbaşKaydıToolStripMenuItem";
            this.stokDemirbaşKaydıToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.stokDemirbaşKaydıToolStripMenuItem.Text = "Stok Demirbaş Kaydı";
            this.stokDemirbaşKaydıToolStripMenuItem.Click += new System.EventHandler(this.stokDemirbaşKaydıToolStripMenuItem_Click);
            // 
            // odaTanımlamaToolStripMenuItem
            // 
            this.odaTanımlamaToolStripMenuItem.Name = "odaTanımlamaToolStripMenuItem";
            this.odaTanımlamaToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.odaTanımlamaToolStripMenuItem.Text = "Oda Tanımlama";
            this.odaTanımlamaToolStripMenuItem.Click += new System.EventHandler(this.odaTanımlamaToolStripMenuItem_Click);
            // 
            // odaDemirbaşİşlemleriToolStripMenuItem
            // 
            this.odaDemirbaşİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaAtamaToolStripMenuItem,
            this.odaDemirbaşListeleToolStripMenuItem});
            this.odaDemirbaşİşlemleriToolStripMenuItem.Name = "odaDemirbaşİşlemleriToolStripMenuItem";
            this.odaDemirbaşİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.odaDemirbaşİşlemleriToolStripMenuItem.Text = "Oda Demirbaş İşlemleri";
            // 
            // odaAtamaToolStripMenuItem
            // 
            this.odaAtamaToolStripMenuItem.Name = "odaAtamaToolStripMenuItem";
            this.odaAtamaToolStripMenuItem.Size = new System.Drawing.Size(284, 30);
            this.odaAtamaToolStripMenuItem.Text = "Oda Demirbaş Atama";
            this.odaAtamaToolStripMenuItem.Click += new System.EventHandler(this.odaAtamaToolStripMenuItem_Click);
            // 
            // odaDemirbaşListeleToolStripMenuItem
            // 
            this.odaDemirbaşListeleToolStripMenuItem.Name = "odaDemirbaşListeleToolStripMenuItem";
            this.odaDemirbaşListeleToolStripMenuItem.Size = new System.Drawing.Size(284, 30);
            this.odaDemirbaşListeleToolStripMenuItem.Text = "Oda Demirbaş Listele";
            this.odaDemirbaşListeleToolStripMenuItem.Click += new System.EventHandler(this.odaDemirbaşListeleToolStripMenuItem_Click);
            // 
            // odayaPersonelAtamaToolStripMenuItem
            // 
            this.odayaPersonelAtamaToolStripMenuItem.Name = "odayaPersonelAtamaToolStripMenuItem";
            this.odayaPersonelAtamaToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.odayaPersonelAtamaToolStripMenuItem.Text = "Odaya Personel Atama";
            this.odayaPersonelAtamaToolStripMenuItem.Click += new System.EventHandler(this.odayaPersonelAtamaToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 565);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnaEkran";
            this.Text = "AnaEkran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aramalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelDemirbasAramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demirbaşSayısıAramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokDemirbaşKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaTanımlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaDemirbaşİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaAtamaToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem odaDemirbaşListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odayaPersonelAtamaToolStripMenuItem;
    }
}

