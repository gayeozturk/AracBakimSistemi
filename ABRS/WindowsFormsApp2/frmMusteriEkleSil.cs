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

namespace WindowsFormsApp2
{
    public partial class frmMusteriEkleSil : Form
    {
        private int nextMusteriID = 1; // Otomatik olarak atanacak MusteriID değeri
        public frmMusteriEkleSil()
        {
            InitializeComponent();
            txtMusteriID.Text = nextMusteriID.ToString();
        }

        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            string musteriID = txtMusteriID.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = txtTelefon.Text;

            // MusteriID, ad, soyad ve telefonun boş olup olmadığını kontrol et
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(telefon))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }
            string dosyaYolu = "musteriler.txt";
            if (KullaniciVarMi(dosyaYolu, musteriID))
            {
                MessageBox.Show("Bu MusteriID zaten kullanılıyor. Lütfen farklı bir MusteriID seçin.");
                return;
            }
            using (StreamWriter writer = new StreamWriter(dosyaYolu, true))
            {
                writer.WriteLine($"{musteriID},{ad},{soyad},{telefon}");
            }

            // Otomatik olarak bir sonraki MusteriID değerini ayarla
            nextMusteriID++;
            txtMusteriID.Text = nextMusteriID.ToString();

            MessageBox.Show("Yeni müşteri başarıyla eklendi.");
            this.Close();
        }
        private bool KullaniciVarMi(string dosyaYolu, string musteriID)
        {
            // Dosyadaki her satırı oku ve MusteriID'leri kontrol et
            foreach (string line in File.ReadAllLines(dosyaYolu))
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[0] == musteriID)
                {
                    return true; // Aynı MusteriID bulundu
                }
            }
            return false; // Aynı MusteriID bulunamadı
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            string musteriID = txtMusteriIDSil.Text;

            // Girilen ID'nin boş olup olmadığını kontrol et
            if (string.IsNullOrEmpty(musteriID))
            {
                MessageBox.Show("Lütfen bir müşteri ID'si girin.");
                return;
            }
            string dosyaYolu = "musteriler.txt";
            string[] lines = File.ReadAllLines(dosyaYolu);
            List<string> yeniMusteriListesi = new List<string>();

            // Dosyadaki her bir satırı kontrol et
            foreach (string line in lines)
            {
                // Satırdaki müşteri ID'si girilen ID'ye eşit değilse, bu satırı yeni listeye ekle
                if (!line.StartsWith(musteriID + ","))
                {
                    yeniMusteriListesi.Add(line);
                }
            }

            // Dosyaya yeni müşteri listesini yaz
            File.WriteAllLines(dosyaYolu, yeniMusteriListesi);

            // Kullanıcıya işlem başarıyla tamamlandı mesajını göster
            MessageBox.Show("Müşteri başarıyla silindi.");
        }
    }
}

