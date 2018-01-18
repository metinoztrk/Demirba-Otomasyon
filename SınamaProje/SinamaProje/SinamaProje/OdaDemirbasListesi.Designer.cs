namespace SinamaProje
{
    partial class OdaDemirbasListesi
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
            this.lbl_oda_adi = new System.Windows.Forms.Label();
            this.btn_listele = new System.Windows.Forms.Button();
            this.cmb_oda_adi = new System.Windows.Forms.ComboBox();
            this.dataliste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataliste)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_oda_adi
            // 
            this.lbl_oda_adi.AutoSize = true;
            this.lbl_oda_adi.Location = new System.Drawing.Point(33, 47);
            this.lbl_oda_adi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_oda_adi.Name = "lbl_oda_adi";
            this.lbl_oda_adi.Size = new System.Drawing.Size(45, 13);
            this.lbl_oda_adi.TabIndex = 0;
            this.lbl_oda_adi.Text = "Oda Adı";
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(36, 74);
            this.btn_listele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(136, 26);
            this.btn_listele.TabIndex = 1;
            this.btn_listele.Text = "Oda Demirbaş Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // cmb_oda_adi
            // 
            this.cmb_oda_adi.FormattingEnabled = true;
            this.cmb_oda_adi.Location = new System.Drawing.Point(90, 45);
            this.cmb_oda_adi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_oda_adi.Name = "cmb_oda_adi";
            this.cmb_oda_adi.Size = new System.Drawing.Size(82, 21);
            this.cmb_oda_adi.TabIndex = 2;
            // 
            // dataliste
            // 
            this.dataliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataliste.Location = new System.Drawing.Point(36, 114);
            this.dataliste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataliste.Name = "dataliste";
            this.dataliste.RowTemplate.Height = 28;
            this.dataliste.Size = new System.Drawing.Size(475, 228);
            this.dataliste.TabIndex = 3;
            // 
            // OdaDemirbasListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 353);
            this.Controls.Add(this.dataliste);
            this.Controls.Add(this.cmb_oda_adi);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.lbl_oda_adi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OdaDemirbasListesi";
            this.Text = "Oda Demirbaş Listele";
            this.Load += new System.EventHandler(this.OdaDemirbasListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataliste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_oda_adi;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.ComboBox cmb_oda_adi;
        private System.Windows.Forms.DataGridView dataliste;
    }
}