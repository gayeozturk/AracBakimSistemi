namespace WindowsFormsApp2
{
    partial class frmPersonleEkleSil
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
            this.grpbx1 = new System.Windows.Forms.GroupBox();
            this.btnPersonelKaydet = new System.Windows.Forms.Button();
            this.BtnPerIptal = new System.Windows.Forms.Button();
            this.txtPerTelefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPerSoyad = new System.Windows.Forms.TextBox();
            this.txtPerAd = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtPerEmail = new System.Windows.Forms.TextBox();
            this.txtPerPozis = new System.Windows.Forms.TextBox();
            this.txtPerMaas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.txtPersonelIDSil = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpbx1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbx1
            // 
            this.grpbx1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grpbx1.Controls.Add(this.label7);
            this.grpbx1.Controls.Add(this.label6);
            this.grpbx1.Controls.Add(this.label5);
            this.grpbx1.Controls.Add(this.txtPerMaas);
            this.grpbx1.Controls.Add(this.txtPerPozis);
            this.grpbx1.Controls.Add(this.txtPerEmail);
            this.grpbx1.Controls.Add(this.btnPersonelKaydet);
            this.grpbx1.Controls.Add(this.BtnPerIptal);
            this.grpbx1.Controls.Add(this.txtPerTelefon);
            this.grpbx1.Controls.Add(this.label1);
            this.grpbx1.Controls.Add(this.label2);
            this.grpbx1.Controls.Add(this.label3);
            this.grpbx1.Controls.Add(this.label4);
            this.grpbx1.Controls.Add(this.txtPerSoyad);
            this.grpbx1.Controls.Add(this.txtPerAd);
            this.grpbx1.Controls.Add(this.txtPersonelID);
            this.grpbx1.Location = new System.Drawing.Point(12, 27);
            this.grpbx1.Name = "grpbx1";
            this.grpbx1.Size = new System.Drawing.Size(378, 342);
            this.grpbx1.TabIndex = 14;
            this.grpbx1.TabStop = false;
            this.grpbx1.Text = "Personel Ekle";
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.Location = new System.Drawing.Point(99, 259);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(92, 38);
            this.btnPersonelKaydet.TabIndex = 4;
            this.btnPersonelKaydet.Text = "Kaydet";
            this.btnPersonelKaydet.UseVisualStyleBackColor = true;
            this.btnPersonelKaydet.Click += new System.EventHandler(this.btnPersonelKaydet_Click_1);
            // 
            // BtnPerIptal
            // 
            this.BtnPerIptal.Location = new System.Drawing.Point(224, 259);
            this.BtnPerIptal.Name = "BtnPerIptal";
            this.BtnPerIptal.Size = new System.Drawing.Size(91, 38);
            this.BtnPerIptal.TabIndex = 5;
            this.BtnPerIptal.Text = "Çıkış";
            this.BtnPerIptal.UseVisualStyleBackColor = true;
            // 
            // txtPerTelefon
            // 
            this.txtPerTelefon.Location = new System.Drawing.Point(184, 147);
            this.txtPerTelefon.Name = "txtPerTelefon";
            this.txtPerTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtPerTelefon.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Personel ID\'si Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Personel Adını Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Personel Soyadını Giriniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Personel Telefonunu Giriniz:";
            // 
            // txtPerSoyad
            // 
            this.txtPerSoyad.Location = new System.Drawing.Point(184, 91);
            this.txtPerSoyad.Name = "txtPerSoyad";
            this.txtPerSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtPerSoyad.TabIndex = 2;
            // 
            // txtPerAd
            // 
            this.txtPerAd.Location = new System.Drawing.Point(184, 63);
            this.txtPerAd.Name = "txtPerAd";
            this.txtPerAd.Size = new System.Drawing.Size(100, 22);
            this.txtPerAd.TabIndex = 1;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(184, 33);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(100, 22);
            this.txtPersonelID.TabIndex = 0;
            // 
            // txtPerEmail
            // 
            this.txtPerEmail.Location = new System.Drawing.Point(184, 119);
            this.txtPerEmail.Name = "txtPerEmail";
            this.txtPerEmail.Size = new System.Drawing.Size(100, 22);
            this.txtPerEmail.TabIndex = 12;
            // 
            // txtPerPozis
            // 
            this.txtPerPozis.Location = new System.Drawing.Point(184, 175);
            this.txtPerPozis.Name = "txtPerPozis";
            this.txtPerPozis.Size = new System.Drawing.Size(100, 22);
            this.txtPerPozis.TabIndex = 13;
            // 
            // txtPerMaas
            // 
            this.txtPerMaas.Location = new System.Drawing.Point(184, 203);
            this.txtPerMaas.Name = "txtPerMaas";
            this.txtPerMaas.Size = new System.Drawing.Size(100, 22);
            this.txtPerMaas.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Personel EMail Giriniz:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Personel Pozisyon Giriniz:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Personel Maaş Giriniz:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.btnPersonelSil);
            this.groupBox2.Controls.Add(this.txtPersonelIDSil);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(414, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 342);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Sil";
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Location = new System.Drawing.Point(153, 230);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(74, 34);
            this.btnPersonelSil.TabIndex = 7;
            this.btnPersonelSil.Text = "Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click_1);
            // 
            // txtPersonelIDSil
            // 
            this.txtPersonelIDSil.Location = new System.Drawing.Point(142, 192);
            this.txtPersonelIDSil.Name = "txtPersonelIDSil";
            this.txtPersonelIDSil.Size = new System.Drawing.Size(100, 22);
            this.txtPersonelIDSil.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Silmek İstediğiniz Personel ID\'yi Giriniz:";
            // 
            // frmPersonleEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpbx1);
            this.Name = "frmPersonleEkleSil";
            this.Text = "PersonleEkleSil";
            this.grpbx1.ResumeLayout(false);
            this.grpbx1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx1;
        private System.Windows.Forms.Button btnPersonelKaydet;
        private System.Windows.Forms.Button BtnPerIptal;
        private System.Windows.Forms.TextBox txtPerTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPerSoyad;
        private System.Windows.Forms.TextBox txtPerAd;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtPerMaas;
        private System.Windows.Forms.TextBox txtPerPozis;
        private System.Windows.Forms.TextBox txtPerEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.TextBox txtPersonelIDSil;
        private System.Windows.Forms.Label label8;
    }
}