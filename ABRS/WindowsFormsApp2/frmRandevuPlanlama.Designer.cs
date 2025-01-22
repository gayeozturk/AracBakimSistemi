namespace WindowsFormsApp2
{
    partial class frmRandevuPlanlama
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
            this.cmbMusteriEkle = new System.Windows.Forms.ComboBox();
            this.btnRandevuAra = new System.Windows.Forms.Button();
            this.txtAranacakRan = new System.Windows.Forms.TextBox();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.txtRanAd = new System.Windows.Forms.TextBox();
            this.txtRanSoyad = new System.Windows.Forms.TextBox();
            this.txtRanMusteriID = new System.Windows.Forms.TextBox();
            this.txtRanTel = new System.Windows.Forms.TextBox();
            this.txtRanMarka = new System.Windows.Forms.TextBox();
            this.txtRanModel = new System.Windows.Forms.TextBox();
            this.txtRanMotor = new System.Windows.Forms.TextBox();
            this.lstRandevular = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRanSec = new System.Windows.Forms.Button();
            this.lstRanMusteri = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtRanPer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRanDuzenle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMusteriEkle
            // 
            this.cmbMusteriEkle.FormattingEnabled = true;
            this.cmbMusteriEkle.Location = new System.Drawing.Point(203, 46);
            this.cmbMusteriEkle.Name = "cmbMusteriEkle";
            this.cmbMusteriEkle.Size = new System.Drawing.Size(125, 24);
            this.cmbMusteriEkle.TabIndex = 0;
            // 
            // btnRandevuAra
            // 
            this.btnRandevuAra.Location = new System.Drawing.Point(79, 149);
            this.btnRandevuAra.Name = "btnRandevuAra";
            this.btnRandevuAra.Size = new System.Drawing.Size(111, 31);
            this.btnRandevuAra.TabIndex = 5;
            this.btnRandevuAra.Text = "Ara";
            this.btnRandevuAra.UseVisualStyleBackColor = true;
            this.btnRandevuAra.Click += new System.EventHandler(this.btnRandevuAra_Click);
            // 
            // txtAranacakRan
            // 
            this.txtAranacakRan.Location = new System.Drawing.Point(203, 86);
            this.txtAranacakRan.Name = "txtAranacakRan";
            this.txtAranacakRan.Size = new System.Drawing.Size(125, 22);
            this.txtAranacakRan.TabIndex = 4;
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Location = new System.Drawing.Point(203, 149);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(104, 31);
            this.btnCıkıs.TabIndex = 6;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // txtRanAd
            // 
            this.txtRanAd.Location = new System.Drawing.Point(201, 257);
            this.txtRanAd.Name = "txtRanAd";
            this.txtRanAd.Size = new System.Drawing.Size(165, 22);
            this.txtRanAd.TabIndex = 8;
            // 
            // txtRanSoyad
            // 
            this.txtRanSoyad.Location = new System.Drawing.Point(201, 285);
            this.txtRanSoyad.Name = "txtRanSoyad";
            this.txtRanSoyad.Size = new System.Drawing.Size(165, 22);
            this.txtRanSoyad.TabIndex = 9;
            // 
            // txtRanMusteriID
            // 
            this.txtRanMusteriID.Location = new System.Drawing.Point(201, 229);
            this.txtRanMusteriID.Name = "txtRanMusteriID";
            this.txtRanMusteriID.Size = new System.Drawing.Size(165, 22);
            this.txtRanMusteriID.TabIndex = 10;
            // 
            // txtRanTel
            // 
            this.txtRanTel.Location = new System.Drawing.Point(201, 313);
            this.txtRanTel.Name = "txtRanTel";
            this.txtRanTel.Size = new System.Drawing.Size(165, 22);
            this.txtRanTel.TabIndex = 11;
            // 
            // txtRanMarka
            // 
            this.txtRanMarka.Location = new System.Drawing.Point(201, 341);
            this.txtRanMarka.Name = "txtRanMarka";
            this.txtRanMarka.Size = new System.Drawing.Size(165, 22);
            this.txtRanMarka.TabIndex = 12;
            // 
            // txtRanModel
            // 
            this.txtRanModel.Location = new System.Drawing.Point(201, 369);
            this.txtRanModel.Name = "txtRanModel";
            this.txtRanModel.Size = new System.Drawing.Size(165, 22);
            this.txtRanModel.TabIndex = 13;
            // 
            // txtRanMotor
            // 
            this.txtRanMotor.Location = new System.Drawing.Point(201, 397);
            this.txtRanMotor.Name = "txtRanMotor";
            this.txtRanMotor.Size = new System.Drawing.Size(165, 22);
            this.txtRanMotor.TabIndex = 14;
            // 
            // lstRandevular
            // 
            this.lstRandevular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader9,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstRandevular.HideSelection = false;
            this.lstRandevular.Location = new System.Drawing.Point(12, 480);
            this.lstRandevular.Name = "lstRandevular";
            this.lstRandevular.Size = new System.Drawing.Size(764, 157);
            this.lstRandevular.TabIndex = 15;
            this.lstRandevular.UseCompatibleStateImageBehavior = false;
            this.lstRandevular.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hizmet ID";
            this.columnHeader5.Width = 74;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Hizmet Adı";
            this.columnHeader9.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Açıklama";
            this.columnHeader6.Width = 580;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fiyat";
            this.columnHeader7.Width = 101;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tarih";
            this.columnHeader8.Width = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Müşteri ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Müşteri Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Müşteri Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Müşteri Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Araç Marka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Araç Model:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Araç Motor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Şuna Göre Filtrele";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Aranacak Kelime:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.btnRanSec);
            this.groupBox1.Controls.Add(this.lstRanMusteri);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnCıkıs);
            this.groupBox1.Controls.Add(this.btnRandevuAra);
            this.groupBox1.Controls.Add(this.cmbMusteriEkle);
            this.groupBox1.Controls.Add(this.txtAranacakRan);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 209);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevular";
            // 
            // btnRanSec
            // 
            this.btnRanSec.Location = new System.Drawing.Point(794, 149);
            this.btnRanSec.Name = "btnRanSec";
            this.btnRanSec.Size = new System.Drawing.Size(78, 31);
            this.btnRanSec.TabIndex = 26;
            this.btnRanSec.Text = "Seç";
            this.btnRanSec.UseVisualStyleBackColor = true;
            this.btnRanSec.Click += new System.EventHandler(this.btnRanSec_Click_1);
            // 
            // lstRanMusteri
            // 
            this.lstRanMusteri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstRanMusteri.FullRowSelect = true;
            this.lstRanMusteri.HideSelection = false;
            this.lstRanMusteri.Location = new System.Drawing.Point(404, 21);
            this.lstRanMusteri.MultiSelect = false;
            this.lstRanMusteri.Name = "lstRanMusteri";
            this.lstRanMusteri.Size = new System.Drawing.Size(374, 159);
            this.lstRanMusteri.TabIndex = 25;
            this.lstRanMusteri.UseCompatibleStateImageBehavior = false;
            this.lstRanMusteri.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Müşteri Ad";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Müşteri Soyad";
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Müşteri Telefon";
            this.columnHeader4.Width = 109;
            // 
            // txtRanPer
            // 
            this.txtRanPer.Location = new System.Drawing.Point(201, 425);
            this.txtRanPer.Name = "txtRanPer";
            this.txtRanPer.Size = new System.Drawing.Size(165, 22);
            this.txtRanPer.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(103, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Personel:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnRanDuzenle);
            this.groupBox2.Location = new System.Drawing.Point(501, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 100);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RandevuEkle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Randevu Düzenlemek İçin Tıklayın";
            // 
            // btnRanDuzenle
            // 
            this.btnRanDuzenle.Location = new System.Drawing.Point(125, 58);
            this.btnRanDuzenle.Name = "btnRanDuzenle";
            this.btnRanDuzenle.Size = new System.Drawing.Size(177, 30);
            this.btnRanDuzenle.TabIndex = 0;
            this.btnRanDuzenle.Text = "Randevu Düzenle";
            this.btnRanDuzenle.UseVisualStyleBackColor = true;
            this.btnRanDuzenle.Click += new System.EventHandler(this.btnRanDuzenle_Click);
            // 
            // frmRandevuPlanlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 670);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRanPer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRandevular);
            this.Controls.Add(this.txtRanMotor);
            this.Controls.Add(this.txtRanModel);
            this.Controls.Add(this.txtRanMarka);
            this.Controls.Add(this.txtRanTel);
            this.Controls.Add(this.txtRanMusteriID);
            this.Controls.Add(this.txtRanSoyad);
            this.Controls.Add(this.txtRanAd);
            this.Name = "frmRandevuPlanlama";
            this.Text = "frmRandevuEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMusteriEkle;
        private System.Windows.Forms.Button btnRandevuAra;
        private System.Windows.Forms.TextBox txtAranacakRan;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.TextBox txtRanAd;
        private System.Windows.Forms.TextBox txtRanSoyad;
        private System.Windows.Forms.TextBox txtRanMusteriID;
        private System.Windows.Forms.TextBox txtRanTel;
        private System.Windows.Forms.TextBox txtRanMarka;
        private System.Windows.Forms.TextBox txtRanModel;
        private System.Windows.Forms.TextBox txtRanMotor;
        private System.Windows.Forms.ListView lstRandevular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstRanMusteri;
        private System.Windows.Forms.Button btnRanSec;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox txtRanPer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRanDuzenle;
    }
}