namespace WindowsFormsApp2
{
    partial class frmMusteriBilgileri
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
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMusteriAra = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstMusteriler = new System.Windows.Forms.ListView();
            this.MusteriID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMusteriEkleSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Location = new System.Drawing.Point(61, 54);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(117, 16);
            this.lblMusteriID.TabIndex = 5;
            this.lblMusteriID.Text = "Şuna Göre Filtrele:";
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(24, 84);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(163, 16);
            this.lblMusteriAd.TabIndex = 6;
            this.lblMusteriAd.Text = "Aramak İstediğiniz Kelime:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 46);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 81);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 12;
            // 
            // btnMusteriAra
            // 
            this.btnMusteriAra.Location = new System.Drawing.Point(181, 119);
            this.btnMusteriAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMusteriAra.Name = "btnMusteriAra";
            this.btnMusteriAra.Size = new System.Drawing.Size(81, 35);
            this.btnMusteriAra.TabIndex = 13;
            this.btnMusteriAra.Text = "Ara";
            this.btnMusteriAra.UseVisualStyleBackColor = true;
            this.btnMusteriAra.Click += new System.EventHandler(this.btnMusteriAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(282, 119);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(78, 35);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstMusteriler
            // 
            this.lstMusteriler.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MusteriID,
            this.Ad,
            this.Soyad,
            this.TelNo});
            this.lstMusteriler.HideSelection = false;
            this.lstMusteriler.Location = new System.Drawing.Point(6, 158);
            this.lstMusteriler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMusteriler.Name = "lstMusteriler";
            this.lstMusteriler.Size = new System.Drawing.Size(398, 288);
            this.lstMusteriler.TabIndex = 15;
            this.lstMusteriler.UseCompatibleStateImageBehavior = false;
            this.lstMusteriler.View = System.Windows.Forms.View.Details;
            // 
            // MusteriID
            // 
            this.MusteriID.Text = "MusteriID";
            this.MusteriID.Width = 71;
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            this.Ad.Width = 65;
            // 
            // Soyad
            // 
            this.Soyad.Text = "Soyad";
            this.Soyad.Width = 74;
            // 
            // TelNo
            // 
            this.TelNo.Text = "TelNo";
            this.TelNo.Width = 80;
            // 
            // btnMusteriEkleSil
            // 
            this.btnMusteriEkleSil.Location = new System.Drawing.Point(436, 409);
            this.btnMusteriEkleSil.Name = "btnMusteriEkleSil";
            this.btnMusteriEkleSil.Size = new System.Drawing.Size(179, 37);
            this.btnMusteriEkleSil.TabIndex = 16;
            this.btnMusteriEkleSil.Text = "Müşteri Ekle / Sil";
            this.btnMusteriEkleSil.UseVisualStyleBackColor = true;
            this.btnMusteriEkleSil.Click += new System.EventHandler(this.btnMusteriEkleSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.lstMusteriler);
            this.groupBox1.Controls.Add(this.btnMusteriEkleSil);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.lblMusteriAd);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblMusteriID);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnMusteriAra);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(57, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 466);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // frmMusteriBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 635);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMusteriBilgileri";
            this.Text = "frmMusteriEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMusteriAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListView lstMusteriler;
        private System.Windows.Forms.ColumnHeader MusteriID;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader TelNo;
        private System.Windows.Forms.Button btnMusteriEkleSil;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}