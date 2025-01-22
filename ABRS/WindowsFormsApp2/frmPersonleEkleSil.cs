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
    public partial class frmPersonleEkleSil : Form
    {
        private int nextPersonelID = 1; // Otomatik olarak atanacak PersonelID değeri
        public frmPersonleEkleSil()
        {
            InitializeComponent();
            txtPersonelID.Text = nextPersonelID.ToString();
            
        }
        
        private bool PersonelVarMi(string dosyaYolu, string personelID)
        {
            // Dosyadaki her satırı oku ve PersonelID'leri kontrol et
            foreach (string line in File.ReadAllLines(dosyaYolu))
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[0] == personelID)
                {
                    return true; // Aynı PersonelID bulundu
                }
            }
            return false; // Aynı PersonelID bulunamadı
        }
        

        private void btnPersonelKaydet_Click_1(object sender, EventArgs e)
        {
            string personelID = txtPersonelID.Text;
            string ad = txtPerAd.Text;
            string soyad = txtPerSoyad.Text;
            string email = txtPerEmail.Text;
            string telefon = txtPerTelefon.Text;
            string pozisyon = txtPerPozis.Text;
            string maas = txtPerMaas.Text;

            // Gerekli alanların dolu olup olmadığını kontrol et
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefon)
                || string.IsNullOrEmpty(pozisyon) || string.IsNullOrEmpty(maas))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            string dosyaYolu = "personeller.txt";

            // Aynı PersonelID'nin var olup olmadığını kontrol et
            if (PersonelVarMi(dosyaYolu, personelID))
            {
                MessageBox.Show("Bu PersonelID zaten kullanılıyor. Lütfen farklı bir PersonelID seçin.");
                return;
            }

            // Yeni personeli dosyaya ekle
            using (StreamWriter writer = new StreamWriter(dosyaYolu, true))
            {
                writer.WriteLine($"{personelID},{ad},{soyad},{email},{telefon},{pozisyon},{maas}");
            }

            // Otomatik olarak bir sonraki PersonelID değerini ayarla
            nextPersonelID++;
            txtPersonelID.Text = nextPersonelID.ToString();

            MessageBox.Show("Yeni personel başarıyla eklendi.");
            this.Close();
        }

        private void btnPersonelSil_Click_1(object sender, EventArgs e)
        {
            string personelID = txtPersonelIDSil.Text;

            // Girilen ID'nin boş olup olmadığını kontrol et
            if (string.IsNullOrEmpty(personelID))
            {
                MessageBox.Show("Lütfen bir personel ID'si girin.");
                return;
            }

            string dosyaYolu = "personeller.txt";
            string[] lines = File.ReadAllLines(dosyaYolu);
            List<string> yeniPersonelListesi = new List<string>();

            // Dosyadaki her bir satırı kontrol et
            foreach (string line in lines)
            {
                // Satırdaki personel ID'si girilen ID'ye eşit değilse, bu satırı yeni listeye ekle
                if (!line.StartsWith(personelID + ","))
                {
                    yeniPersonelListesi.Add(line);
                }
            }

            // Dosyaya yeni personel listesini yaz
            File.WriteAllLines(dosyaYolu, yeniPersonelListesi);

            // Kullanıcıya işlem başarıyla tamamlandı mesajını göster
            MessageBox.Show("Personel başarıyla silindi.");
        }
    }
}
