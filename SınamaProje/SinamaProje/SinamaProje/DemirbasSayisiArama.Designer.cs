namespace SinamaProje
{
    partial class DemirbasSayisiArama
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
            this.btn_demirbas_ara = new System.Windows.Forms.Button();
            this.demirbas_listele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.demirbas_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_demirbas_ara
            // 
            this.btn_demirbas_ara.Location = new System.Drawing.Point(165, 346);
            this.btn_demirbas_ara.Margin = new System.Windows.Forms.Padding(2);
            this.btn_demirbas_ara.Name = "btn_demirbas_ara";
            this.btn_demirbas_ara.Size = new System.Drawing.Size(222, 37);
            this.btn_demirbas_ara.TabIndex = 4;
            this.btn_demirbas_ara.Text = "ARA";
            this.btn_demirbas_ara.UseVisualStyleBackColor = true;
            this.btn_demirbas_ara.Click += new System.EventHandler(this.btn_demirbas_ara_Click);
            // 
            // demirbas_listele
            // 
            this.demirbas_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.demirbas_listele.Location = new System.Drawing.Point(29, 24);
            this.demirbas_listele.Margin = new System.Windows.Forms.Padding(2);
            this.demirbas_listele.Name = "demirbas_listele";
            this.demirbas_listele.RowTemplate.Height = 28;
            this.demirbas_listele.Size = new System.Drawing.Size(506, 304);
            this.demirbas_listele.TabIndex = 11;
            // 
            // DemirbasSayisiArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 412);
            this.Controls.Add(this.demirbas_listele);
            this.Controls.Add(this.btn_demirbas_ara);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DemirbasSayisiArama";
            this.Text = "Demirbaş Arama";
            this.Load += new System.EventHandler(this.DemirbasSayisiArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.demirbas_listele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_demirbas_ara;
        private System.Windows.Forms.DataGridView demirbas_listele;
    }
}