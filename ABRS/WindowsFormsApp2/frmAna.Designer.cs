namespace WindowsFormsApp2
{
    partial class frmAna
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
            this.btnMusteriBilgileri = new System.Windows.Forms.Button();
            this.btnPersonelBilgisi = new System.Windows.Forms.Button();
            this.frmRandevuPlanlama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusteriBilgileri
            // 
            this.btnMusteriBilgileri.Location = new System.Drawing.Point(277, 163);
            this.btnMusteriBilgileri.Name = "btnMusteriBilgileri";
            this.btnMusteriBilgileri.Size = new System.Drawing.Size(158, 72);
            this.btnMusteriBilgileri.TabIndex = 0;
            this.btnMusteriBilgileri.Text = "Müşteri Bilgileri";
            this.btnMusteriBilgileri.UseVisualStyleBackColor = true;
            this.btnMusteriBilgileri.Click += new System.EventHandler(this.btnMusteriBilgileri_Click);
            // 
            // btnPersonelBilgisi
            // 
            this.btnPersonelBilgisi.Location = new System.Drawing.Point(277, 278);
            this.btnPersonelBilgisi.Name = "btnPersonelBilgisi";
            this.btnPersonelBilgisi.Size = new System.Drawing.Size(158, 72);
            this.btnPersonelBilgisi.TabIndex = 1;
            this.btnPersonelBilgisi.Text = "Personel Bilgileri";
            this.btnPersonelBilgisi.UseVisualStyleBackColor = true;
            this.btnPersonelBilgisi.Click += new System.EventHandler(this.btnPersonelBilgisi_Click);
            // 
            // frmRandevuPlanlama
            // 
            this.frmRandevuPlanlama.Location = new System.Drawing.Point(277, 60);
            this.frmRandevuPlanlama.Name = "frmRandevuPlanlama";
            this.frmRandevuPlanlama.Size = new System.Drawing.Size(158, 72);
            this.frmRandevuPlanlama.TabIndex = 3;
            this.frmRandevuPlanlama.Text = "Randevu Planlama";
            this.frmRandevuPlanlama.UseVisualStyleBackColor = true;
            this.frmRandevuPlanlama.Click += new System.EventHandler(this.frmRandevuPlanlama_Click);
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmRandevuPlanlama);
            this.Controls.Add(this.btnPersonelBilgisi);
            this.Controls.Add(this.btnMusteriBilgileri);
            this.Name = "frmAna";
            this.Text = "frmAna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriBilgileri;
        private System.Windows.Forms.Button btnPersonelBilgisi;
        private System.Windows.Forms.Button frmRandevuPlanlama;
    }
}