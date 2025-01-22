namespace WindowsFormsApp2
{
    partial class frmPersonelBilgileri
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
            this.txtArananPersonel = new System.Windows.Forms.TextBox();
            this.btnPersonelAra = new System.Windows.Forms.Button();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.lstPersonelBilgileri = new System.Windows.Forms.ListView();
            this.PersonelID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPersonelEkleSil = new System.Windows.Forms.Button();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArananPersonel
            // 
            this.txtArananPersonel.Location = new System.Drawing.Point(216, 78);
            this.txtArananPersonel.Name = "txtArananPersonel";
            this.txtArananPersonel.Size = new System.Drawing.Size(121, 22);
            this.txtArananPersonel.TabIndex = 7;
            // 
            // btnPersonelAra
            // 
            this.btnPersonelAra.Location = new System.Drawing.Point(168, 126);
            this.btnPersonelAra.Name = "btnPersonelAra";
            this.btnPersonelAra.Size = new System.Drawing.Size(75, 33);
            this.btnPersonelAra.TabIndex = 5;
            this.btnPersonelAra.Text = "Ara";
            this.btnPersonelAra.UseVisualStyleBackColor = true;
            this.btnPersonelAra.Click += new System.EventHandler(this.btnPersonelAra_Click);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Location = new System.Drawing.Point(265, 126);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(81, 33);
            this.btnPersonelSil.TabIndex = 8;
            this.btnPersonelSil.Text = "Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // lstPersonelBilgileri
            // 
            this.lstPersonelBilgileri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PersonelID,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstPersonelBilgileri.HideSelection = false;
            this.lstPersonelBilgileri.Location = new System.Drawing.Point(6, 165);
            this.lstPersonelBilgileri.Name = "lstPersonelBilgileri";
            this.lstPersonelBilgileri.Size = new System.Drawing.Size(467, 271);
            this.lstPersonelBilgileri.TabIndex = 9;
            this.lstPersonelBilgileri.UseCompatibleStateImageBehavior = false;
            this.lstPersonelBilgileri.View = System.Windows.Forms.View.Details;
            // 
            // PersonelID
            // 
            this.PersonelID.Text = "PersonelID";
            this.PersonelID.Width = 44;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "EMail";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pozisyon";
            this.columnHeader5.Width = 71;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Maaş";
            // 
            // btnPersonelEkleSil
            // 
            this.btnPersonelEkleSil.Location = new System.Drawing.Point(479, 401);
            this.btnPersonelEkleSil.Name = "btnPersonelEkleSil";
            this.btnPersonelEkleSil.Size = new System.Drawing.Size(146, 35);
            this.btnPersonelEkleSil.TabIndex = 10;
            this.btnPersonelEkleSil.Text = "Personel Ekle / Sil";
            this.btnPersonelEkleSil.UseVisualStyleBackColor = true;
            this.btnPersonelEkleSil.Click += new System.EventHandler(this.btnPersonelEkleSil_Click);
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Location = new System.Drawing.Point(67, 51);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(117, 16);
            this.lblMusteriID.TabIndex = 13;
            this.lblMusteriID.Text = "Şuna Göre Filtrele:";
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(21, 81);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(163, 16);
            this.lblMusteriAd.TabIndex = 14;
            this.lblMusteriAd.Text = "Aramak İstediğiniz Kelime:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lstPersonelBilgileri);
            this.groupBox1.Controls.Add(this.lblMusteriAd);
            this.groupBox1.Controls.Add(this.btnPersonelEkleSil);
            this.groupBox1.Controls.Add(this.lblMusteriID);
            this.groupBox1.Controls.Add(this.btnPersonelAra);
            this.groupBox1.Controls.Add(this.btnPersonelSil);
            this.groupBox1.Controls.Add(this.txtArananPersonel);
            this.groupBox1.Location = new System.Drawing.Point(77, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 454);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // frmPersonelBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 657);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPersonelBilgileri";
            this.Text = "frmPersonelEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtArananPersonel;
        private System.Windows.Forms.Button btnPersonelAra;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.ListView lstPersonelBilgileri;
        private System.Windows.Forms.Button btnPersonelEkleSil;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader PersonelID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}