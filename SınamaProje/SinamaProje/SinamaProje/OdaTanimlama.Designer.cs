namespace SinamaProje
{
    partial class OdaTanimlama
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
            this.cmb_oda_sorumlusu = new System.Windows.Forms.ComboBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.txt_oda_adi = new System.Windows.Forms.TextBox();
            this.lbl_oda_adi = new System.Windows.Forms.Label();
            this.lbl_oda_sorumlusu = new System.Windows.Forms.Label();
            this.lbl_departman_adi = new System.Windows.Forms.Label();
            this.cmb_departman = new System.Windows.Forms.ComboBox();
            this.cmb_fakulte = new System.Windows.Forms.ComboBox();
            this.lbl_fakulte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_oda_sorumlusu
            // 
            this.cmb_oda_sorumlusu.FormattingEnabled = true;
            this.cmb_oda_sorumlusu.Location = new System.Drawing.Point(168, 70);
            this.cmb_oda_sorumlusu.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_oda_sorumlusu.Name = "cmb_oda_sorumlusu";
            this.cmb_oda_sorumlusu.Size = new System.Drawing.Size(111, 21);
            this.cmb_oda_sorumlusu.TabIndex = 0;
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(71, 170);
            this.btn_kayit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(208, 30);
            this.btn_kayit.TabIndex = 1;
            this.btn_kayit.Text = "Kayıt";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // txt_oda_adi
            // 
            this.txt_oda_adi.Location = new System.Drawing.Point(168, 41);
            this.txt_oda_adi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_oda_adi.Name = "txt_oda_adi";
            this.txt_oda_adi.Size = new System.Drawing.Size(111, 20);
            this.txt_oda_adi.TabIndex = 2;
            // 
            // lbl_oda_adi
            // 
            this.lbl_oda_adi.AutoSize = true;
            this.lbl_oda_adi.Location = new System.Drawing.Point(102, 46);
            this.lbl_oda_adi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_oda_adi.Name = "lbl_oda_adi";
            this.lbl_oda_adi.Size = new System.Drawing.Size(45, 13);
            this.lbl_oda_adi.TabIndex = 3;
            this.lbl_oda_adi.Text = "Oda Adı";
            // 
            // lbl_oda_sorumlusu
            // 
            this.lbl_oda_sorumlusu.AutoSize = true;
            this.lbl_oda_sorumlusu.Location = new System.Drawing.Point(68, 73);
            this.lbl_oda_sorumlusu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_oda_sorumlusu.Name = "lbl_oda_sorumlusu";
            this.lbl_oda_sorumlusu.Size = new System.Drawing.Size(79, 13);
            this.lbl_oda_sorumlusu.TabIndex = 4;
            this.lbl_oda_sorumlusu.Text = "Oda Sorumlusu";
            // 
            // lbl_departman_adi
            // 
            this.lbl_departman_adi.AutoSize = true;
            this.lbl_departman_adi.Location = new System.Drawing.Point(88, 135);
            this.lbl_departman_adi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_departman_adi.Name = "lbl_departman_adi";
            this.lbl_departman_adi.Size = new System.Drawing.Size(59, 13);
            this.lbl_departman_adi.TabIndex = 5;
            this.lbl_departman_adi.Text = "Departman";
            // 
            // cmb_departman
            // 
            this.cmb_departman.FormattingEnabled = true;
            this.cmb_departman.Location = new System.Drawing.Point(168, 132);
            this.cmb_departman.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_departman.Name = "cmb_departman";
            this.cmb_departman.Size = new System.Drawing.Size(111, 21);
            this.cmb_departman.TabIndex = 6;
            // 
            // cmb_fakulte
            // 
            this.cmb_fakulte.FormattingEnabled = true;
            this.cmb_fakulte.Location = new System.Drawing.Point(168, 100);
            this.cmb_fakulte.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_fakulte.Name = "cmb_fakulte";
            this.cmb_fakulte.Size = new System.Drawing.Size(111, 21);
            this.cmb_fakulte.TabIndex = 8;
            this.cmb_fakulte.SelectedIndexChanged += new System.EventHandler(this.cmb_fakulte_SelectedIndexChanged);
            // 
            // lbl_fakulte
            // 
            this.lbl_fakulte.AutoSize = true;
            this.lbl_fakulte.Location = new System.Drawing.Point(105, 103);
            this.lbl_fakulte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fakulte.Name = "lbl_fakulte";
            this.lbl_fakulte.Size = new System.Drawing.Size(42, 13);
            this.lbl_fakulte.TabIndex = 7;
            this.lbl_fakulte.Text = "Fakülte";
            // 
            // OdaTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 287);
            this.Controls.Add(this.cmb_fakulte);
            this.Controls.Add(this.lbl_fakulte);
            this.Controls.Add(this.cmb_departman);
            this.Controls.Add(this.lbl_departman_adi);
            this.Controls.Add(this.lbl_oda_sorumlusu);
            this.Controls.Add(this.lbl_oda_adi);
            this.Controls.Add(this.txt_oda_adi);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.cmb_oda_sorumlusu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OdaTanimlama";
            this.Text = "Oda Tanimlama";
            this.Load += new System.EventHandler(this.OdaTanimlama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_oda_sorumlusu;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.TextBox txt_oda_adi;
        private System.Windows.Forms.Label lbl_oda_adi;
        private System.Windows.Forms.Label lbl_oda_sorumlusu;
        private System.Windows.Forms.Label lbl_departman_adi;
        private System.Windows.Forms.ComboBox cmb_departman;
        private System.Windows.Forms.ComboBox cmb_fakulte;
        private System.Windows.Forms.Label lbl_fakulte;
    }
}