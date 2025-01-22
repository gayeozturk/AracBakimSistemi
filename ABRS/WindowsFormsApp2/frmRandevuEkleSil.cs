/****************************************************************************
** DÜZCE ÜNİVERSİTESİ
** Lisansüstü Eğitim Enstitüsü
** Bilgisayar Mühendisliği Anabilim Dalı Yüksek Lisans Programı
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2023-2024 BAHAR DÖNEMİ
**
**
** ÖĞRENCİ ADI............: Gaye ÖZTÜRK
** ÖĞRENCİ NUMARASI.......: 23455007014
** DERSİN ALINDIĞI GRUP...:
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class frmRandevuEkleSil : Form
    {
        public frmRandevuEkleSil()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string musteriID = txtMüsID.Text;
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            string motor = txtMotor.Text;
            string personel = txtPer.Text;
            string hizmetID = txtHizID.Text;
            DateTime tarih = dateTimePicker1.Value;

            try
            {
                // Müşteri bilgilerini al
                List<string> musteriBilgileri = new List<string>();
                using (StreamReader sr = new StreamReader("musteriler.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == musteriID)
                        {
                            musteriBilgileri.Add(line);
                        }
                    }
                }

                if (musteriBilgileri.Count == 0)
                {
                    MessageBox.Show("Müşteri bulunamadı!");
                    return;
                }

                // Hizmet bilgilerini al
                List<string> hizmetBilgileri = new List<string>();
                using (StreamReader sr = new StreamReader("hizmetler.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == hizmetID)
                        {
                            hizmetBilgileri.Add(line);
                        }
                    }
                }

                if (hizmetBilgileri.Count == 0)
                {
                    MessageBox.Show("Hizmet bulunamadı!");
                    return;
                }

                // Randevu bilgilerini oluştur ve dosyaya ekle
                using (StreamWriter sw = File.AppendText("randevular.txt"))
                {
                    foreach (string musteriBilgisi in musteriBilgileri)
                    {
                        foreach (string hizmetBilgisi in hizmetBilgileri)
                        {
                            string randevuBilgisi = string.Join(",", musteriBilgisi, marka,
                                model, motor, personel, hizmetBilgisi, tarih.ToString("yyyy-MM-dd"));
                            sw.WriteLine(randevuBilgisi);
                        }
                    }
                }

                MessageBox.Show("Randevular kaydedildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşterileri okurken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnEkleCikis_Click(object sender, EventArgs e)
        {
            txtMüsID.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtMotor.Clear();
            txtPer.Clear();
            txtHizID.Clear();
            dateTimePicker1.Value = DateTime.Now; // Şu anki tarihe geri dönüş
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string musteriID = txtSilMusID.Text;
            string hizmetID = txtSilHizID.Text;

            try
            {
                // Geçici dosya oluştur
                string tempFile = Path.GetTempFileName();

                // Okuma ve yazma işlemleri için StreamReader ve StreamWriter kullanarak geçici dosyaya kopyala
                using (StreamReader sr = new StreamReader("randevular.txt"))
                using (StreamWriter sw = new StreamWriter(tempFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        // Satırı yazmamak için koşullar belirle
                        if (parts[0] == musteriID && parts[8] == hizmetID)
                            continue;

                        sw.WriteLine(line); // Satırı kopyala
                    }
                }

                // Geçici dosyayı asıl dosyanın yerine geçir
                File.Delete("randevular.txt");
                File.Move(tempFile, "randevular.txt");

                MessageBox.Show("Randevu başarıyla silindi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu silinirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnSilCikis_Click(object sender, EventArgs e)
        {
            txtSilMusID.Clear();
            txtSilHizID.Clear();
        }
    }
}
