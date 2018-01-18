namespace SinamaProje
{
    partial class PersonelÜzerindekiDemirbaşıArama
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
            this.lbl_personel_adi = new System.Windows.Forms.Label();
            this.personel_uzerindeki_demirbasi_listele = new System.Windows.Forms.DataGridView();
            this.btn_personel_ara = new System.Windows.Forms.Button();
            this.cmb_adi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.personel_uzerindeki_demirbasi_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_personel_adi
            // 
            this.lbl_personel_adi.AutoSize = true;
            this.lbl_personel_adi.Location = new System.Drawing.Point(46, 33);
            this.lbl_personel_adi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_personel_adi.Name = "lbl_personel_adi";
            this.lbl_personel_adi.Size = new System.Drawing.Size(66, 13);
            this.lbl_personel_adi.TabIndex = 0;
            this.lbl_personel_adi.Text = "Personel Adı";
            // 
            // personel_uzerindeki_demirbasi_listele
            // 
            this.personel_uzerindeki_demirbasi_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personel_uzerindeki_demirbasi_listele.Location = new System.Drawing.Point(21, 112);
            this.personel_uzerindeki_demirbasi_listele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.personel_uzerindeki_demirbasi_listele.Name = "personel_uzerindeki_demirbasi_listele";
            this.personel_uzerindeki_demirbasi_listele.RowTemplate.Height = 28;
            this.personel_uzerindeki_demirbasi_listele.Size = new System.Drawing.Size(474, 214);
            this.personel_uzerindeki_demirbasi_listele.TabIndex = 3;
            // 
            // btn_personel_ara
            // 
            this.btn_personel_ara.Location = new System.Drawing.Point(49, 59);
            this.btn_personel_ara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_personel_ara.Name = "btn_personel_ara";
            this.btn_personel_ara.Size = new System.Drawing.Size(176, 24);
            this.btn_personel_ara.TabIndex = 6;
            this.btn_personel_ara.Text = "Personel Arama";
            this.btn_personel_ara.UseVisualStyleBackColor = true;
            this.btn_personel_ara.Click += new System.EventHandler(this.btn_personel_ara_Click);
            // 
            // cmb_adi
            // 
            this.cmb_adi.FormattingEnabled = true;
            this.cmb_adi.Location = new System.Drawing.Point(116, 30);
            this.cmb_adi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_adi.Name = "cmb_adi";
            this.cmb_adi.Size = new System.Drawing.Size(109, 21);
            this.cmb_adi.TabIndex = 7;
            // 
            // PersonelÜzerindekiDemirbaşıArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 370);
            this.Controls.Add(this.cmb_adi);
            this.Controls.Add(this.btn_personel_ara);
            this.Controls.Add(this.personel_uzerindeki_demirbasi_listele);
            this.Controls.Add(this.lbl_personel_adi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PersonelÜzerindekiDemirbaşıArama";
            this.Text = "Personel Üzerindeki Demirbaş Arama";
            this.Load += new System.EventHandler(this.PersonelÜzerindekiDemirbaşıArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personel_uzerindeki_demirbasi_listele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_personel_adi;
        private System.Windows.Forms.DataGridView personel_uzerindeki_demirbasi_listele;
        private System.Windows.Forms.Button btn_personel_ara;
        private System.Windows.Forms.ComboBox cmb_adi;
    }
}