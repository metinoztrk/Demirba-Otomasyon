namespace SinamaProje
{
    partial class OdaAtama
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
            this.lbl_demirbas_adi = new System.Windows.Forms.Label();
            this.lbl_demirbas_adeti = new System.Windows.Forms.Label();
            this.btn_oda_kayit = new System.Windows.Forms.Button();
            this.txt_demirbas_adeti = new System.Windows.Forms.TextBox();
            this.lbl_oda_adi = new System.Windows.Forms.Label();
            this.cmb_oda_adi = new System.Windows.Forms.ComboBox();
            this.cmb_demirbas_adi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_demirbas_adi
            // 
            this.lbl_demirbas_adi.AutoSize = true;
            this.lbl_demirbas_adi.Location = new System.Drawing.Point(67, 72);
            this.lbl_demirbas_adi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_demirbas_adi.Name = "lbl_demirbas_adi";
            this.lbl_demirbas_adi.Size = new System.Drawing.Size(69, 13);
            this.lbl_demirbas_adi.TabIndex = 0;
            this.lbl_demirbas_adi.Text = "Demirbaş Adı";
            // 
            // lbl_demirbas_adeti
            // 
            this.lbl_demirbas_adeti.AutoSize = true;
            this.lbl_demirbas_adeti.Location = new System.Drawing.Point(67, 104);
            this.lbl_demirbas_adeti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_demirbas_adeti.Name = "lbl_demirbas_adeti";
            this.lbl_demirbas_adeti.Size = new System.Drawing.Size(78, 13);
            this.lbl_demirbas_adeti.TabIndex = 1;
            this.lbl_demirbas_adeti.Text = "Demirbaş Adeti";
            // 
            // btn_oda_kayit
            // 
            this.btn_oda_kayit.Location = new System.Drawing.Point(70, 136);
            this.btn_oda_kayit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_oda_kayit.Name = "btn_oda_kayit";
            this.btn_oda_kayit.Size = new System.Drawing.Size(177, 31);
            this.btn_oda_kayit.TabIndex = 2;
            this.btn_oda_kayit.Text = "Kayıt";
            this.btn_oda_kayit.UseVisualStyleBackColor = true;
            this.btn_oda_kayit.Click += new System.EventHandler(this.btn_oda_kayit_Click);
            // 
            // txt_demirbas_adeti
            // 
            this.txt_demirbas_adeti.Location = new System.Drawing.Point(159, 102);
            this.txt_demirbas_adeti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_demirbas_adeti.Name = "txt_demirbas_adeti";
            this.txt_demirbas_adeti.Size = new System.Drawing.Size(88, 20);
            this.txt_demirbas_adeti.TabIndex = 4;
            // 
            // lbl_oda_adi
            // 
            this.lbl_oda_adi.AutoSize = true;
            this.lbl_oda_adi.Location = new System.Drawing.Point(67, 46);
            this.lbl_oda_adi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_oda_adi.Name = "lbl_oda_adi";
            this.lbl_oda_adi.Size = new System.Drawing.Size(45, 13);
            this.lbl_oda_adi.TabIndex = 6;
            this.lbl_oda_adi.Text = "Oda Adı";
            // 
            // cmb_oda_adi
            // 
            this.cmb_oda_adi.FormattingEnabled = true;
            this.cmb_oda_adi.Location = new System.Drawing.Point(159, 44);
            this.cmb_oda_adi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_oda_adi.Name = "cmb_oda_adi";
            this.cmb_oda_adi.Size = new System.Drawing.Size(88, 21);
            this.cmb_oda_adi.TabIndex = 7;
            // 
            // cmb_demirbas_adi
            // 
            this.cmb_demirbas_adi.FormattingEnabled = true;
            this.cmb_demirbas_adi.Location = new System.Drawing.Point(159, 70);
            this.cmb_demirbas_adi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_demirbas_adi.Name = "cmb_demirbas_adi";
            this.cmb_demirbas_adi.Size = new System.Drawing.Size(88, 21);
            this.cmb_demirbas_adi.TabIndex = 8;
            // 
            // OdaAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 295);
            this.Controls.Add(this.cmb_demirbas_adi);
            this.Controls.Add(this.cmb_oda_adi);
            this.Controls.Add(this.lbl_oda_adi);
            this.Controls.Add(this.txt_demirbas_adeti);
            this.Controls.Add(this.btn_oda_kayit);
            this.Controls.Add(this.lbl_demirbas_adeti);
            this.Controls.Add(this.lbl_demirbas_adi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OdaAtama";
            this.Text = "Oda Demirbaş Atama";
            this.Load += new System.EventHandler(this.OdaAtama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_demirbas_adi;
        private System.Windows.Forms.Label lbl_demirbas_adeti;
        private System.Windows.Forms.Button btn_oda_kayit;
        private System.Windows.Forms.TextBox txt_demirbas_adeti;
        private System.Windows.Forms.Label lbl_oda_adi;
        private System.Windows.Forms.ComboBox cmb_oda_adi;
        private System.Windows.Forms.ComboBox cmb_demirbas_adi;
    }
}