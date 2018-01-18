namespace SinamaProje
{
    partial class OdaPersonelAtama
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
            this.lbl_personel = new System.Windows.Forms.Label();
            this.lbl_oda = new System.Windows.Forms.Label();
            this.cmb_personel = new System.Windows.Forms.ComboBox();
            this.cmb_odalar = new System.Windows.Forms.ComboBox();
            this.btn_ata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_personel
            // 
            this.lbl_personel.AutoSize = true;
            this.lbl_personel.Location = new System.Drawing.Point(69, 69);
            this.lbl_personel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_personel.Name = "lbl_personel";
            this.lbl_personel.Size = new System.Drawing.Size(59, 13);
            this.lbl_personel.TabIndex = 0;
            this.lbl_personel.Text = "Personeller";
            // 
            // lbl_oda
            // 
            this.lbl_oda.AutoSize = true;
            this.lbl_oda.Location = new System.Drawing.Point(90, 100);
            this.lbl_oda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_oda.Name = "lbl_oda";
            this.lbl_oda.Size = new System.Drawing.Size(38, 13);
            this.lbl_oda.TabIndex = 1;
            this.lbl_oda.Text = "Odalar";
            // 
            // cmb_personel
            // 
            this.cmb_personel.FormattingEnabled = true;
            this.cmb_personel.Location = new System.Drawing.Point(155, 66);
            this.cmb_personel.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_personel.Name = "cmb_personel";
            this.cmb_personel.Size = new System.Drawing.Size(82, 21);
            this.cmb_personel.TabIndex = 2;
            // 
            // cmb_odalar
            // 
            this.cmb_odalar.FormattingEnabled = true;
            this.cmb_odalar.Location = new System.Drawing.Point(155, 97);
            this.cmb_odalar.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_odalar.Name = "cmb_odalar";
            this.cmb_odalar.Size = new System.Drawing.Size(82, 21);
            this.cmb_odalar.TabIndex = 3;
            // 
            // btn_ata
            // 
            this.btn_ata.Location = new System.Drawing.Point(72, 132);
            this.btn_ata.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ata.Name = "btn_ata";
            this.btn_ata.Size = new System.Drawing.Size(165, 27);
            this.btn_ata.TabIndex = 4;
            this.btn_ata.Text = "Personel Ata";
            this.btn_ata.UseVisualStyleBackColor = true;
            this.btn_ata.Click += new System.EventHandler(this.btn_ata_Click);
            // 
            // OdaPersonelAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 225);
            this.Controls.Add(this.btn_ata);
            this.Controls.Add(this.cmb_odalar);
            this.Controls.Add(this.cmb_personel);
            this.Controls.Add(this.lbl_oda);
            this.Controls.Add(this.lbl_personel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OdaPersonelAtama";
            this.Text = "Oda Personel Atama";
            this.Load += new System.EventHandler(this.OdaPersonelAtama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_personel;
        private System.Windows.Forms.Label lbl_oda;
        private System.Windows.Forms.ComboBox cmb_personel;
        private System.Windows.Forms.ComboBox cmb_odalar;
        private System.Windows.Forms.Button btn_ata;
    }
}