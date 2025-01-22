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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class frmRandevuPlanlama : Form
    {
        private List<Musteri> musteriler;
        public frmRandevuPlanlama()
        {
            InitializeComponent();
            musteriler = new List<Musteri>();

            // Metin dosyasından müşteri bilgilerini oku
            OkuMusterileri("musteriler.txt");

            // ComboBox'a seçenekleri ekle
            cmbMusteriEkle.Items.AddRange(new string[] { "Müşteri ID", "Müşteri Ad",
                "Müşteri Soyad","Müşteri Telefon" });
        }
        private void OkuMusterileri(string dosyaAdi)
        {
            try
            {
                using (StreamReader sr = new StreamReader(dosyaAdi))
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        string[] parcalar = satir.Split(',');
                        int musteriID = int.Parse(parcalar[0]);
                        string ad = parcalar[1];
                        string soyad = parcalar[2];
                        string telefon = parcalar[3];
                        musteriler.Add(new Musteri(musteriID, ad, soyad, telefon));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri bilgileri okunurken bir hata oluştu: " + ex.Message);
            }
        }


        private void btnRandevuAra_Click(object sender, EventArgs e)
        {
            string secilen = cmbMusteriEkle.SelectedItem?.ToString();
            string kelime = txtAranacakRan.Text.ToLower();

            lstRanMusteri.Items.Clear();

            switch (secilen)
            {
                case "Müşteri ID":
                    if (int.TryParse(kelime, out int musteriID))
                    {
                        Musteri arananMusteri = musteriler.FirstOrDefault(m => m.MusteriID == musteriID);
                        if (arananMusteri != null)
                        {
                            ListViewItem item = new ListViewItem(new string[] { arananMusteri.MusteriID.ToString(),
                                arananMusteri.Ad, arananMusteri.Soyad, arananMusteri.Telefon.ToString() });
                            lstRanMusteri.Items.Add(item);
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen müşteri ID'si ile eşleşen müşteri bulunamadı.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir müşteri ID'si girin.");
                    }
                    break;
                case "Müşteri Ad":
                    foreach (Musteri musteri in musteriler)
                    {
                        if (musteri.Ad.ToLower().Contains(kelime))
                        {
                            ListViewItem item = new ListViewItem(new string[] { musteri.MusteriID.ToString(),
                                musteri.Ad, musteri.Soyad, musteri.Telefon.ToString() });
                            lstRanMusteri.Items.Add(item);
                        }
                    }
                    break;
                case "Müşteri Soyad":
                    foreach (Musteri musteri in musteriler)
                    {
                        if (musteri.Soyad.ToLower().Contains(kelime))
                        {
                            ListViewItem item = new ListViewItem(new string[] { musteri.MusteriID.ToString(), 
                                musteri.Ad, musteri.Soyad, musteri.Telefon.ToString() });
                            lstRanMusteri.Items.Add(item);
                        }
                    }
                    break;
                default:
                    MessageBox.Show("Lütfen bir arama kriteri seçin.");
                    break;
            }
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            cmbMusteriEkle.SelectedIndex = -1;
            txtAranacakRan.Clear();
            lstRanMusteri.Items.Clear();
        }
        private const string DosyaAdi = "randevular.txt";
        private const int MusteriIdSutunu = 0;
        private const int AdSutunu = 1;
        private const int SoyadSutunu = 2;
        private const int TelefonSutunu = 3;
        private const int MarkaSutunu = 4;
        private const int ModelSutunu = 5;
        private const int MotorSutunu = 6;
        private const int PersonelSutunu = 7;



        private string[] DosyadanMusteriBilgileriOku(string musteriId)
        {
            try
            {
                using (StreamReader sr = new StreamReader(DosyaAdi))
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        string[] sutunlar = satir.Split(',');
                        if (sutunlar[MusteriIdSutunu] == musteriId)
                        {
                            return sutunlar; // Eşleşen satırı bulduk, dön
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Metin dosyası okunurken bir hata oluştu: " + ex.Message);
            }
            return null; // Eşleşen satır bulunamadı, null dön
        }
     
        private void btnRanSec_Click_1(object sender, EventArgs e)
        {
            // Eğer ListView'da en az bir satır seçiliyse devam et
            if (lstRanMusteri.SelectedItems.Count > 0)
            {
                // ListView'da seçili olan ilk satırı al
                ListViewItem selectedRow = lstRanMusteri.SelectedItems[0];

                // Satırın değerlerine erişim örneği
                string musteriID = selectedRow.SubItems[0].Text;

                // Eşleştirilecek metin dosyasının adı ve yolu
                string dosyaAdi = "randevular.txt";

                // Dosyadan müşteri bilgilerini oku
                string[] musteriBilgileri = DosyadanMusteriBilgileriOku(musteriID);

                if (musteriBilgileri == null)
                {
                    MessageBox.Show("Belirtilen müşteri ID'si ile eşleşen müşteri bulunamadı.");
                    return; // Eşleşen müşteri bulunamazsa işleme devam etme
                }

                // Eşleşen müşteri bilgilerini TextBox'lara yaz
                txtRanMusteriID.Text = musteriBilgileri[MusteriIdSutunu];
                txtRanAd.Text = musteriBilgileri[AdSutunu];
                txtRanSoyad.Text = musteriBilgileri[SoyadSutunu];
                txtRanTel.Text = musteriBilgileri[TelefonSutunu];
                txtRanMarka.Text = musteriBilgileri[MarkaSutunu];
                txtRanModel.Text = musteriBilgileri[ModelSutunu];
                txtRanMotor.Text = musteriBilgileri[MotorSutunu];
                txtRanPer.Text = musteriBilgileri[PersonelSutunu];

                // ListView2'yi temizle
                lstRandevular.Items.Clear();

                // Geri kalan sütunları al ve ListView'daki sütunlara böl
                string geriKalanSutunlar = string.Join(",", musteriBilgileri,
                    PersonelSutunu + 1, musteriBilgileri.Length - PersonelSutunu - 1);
                string[] kalanParcalar = geriKalanSutunlar.Split(',');

                // Her bir parçayı ListView'daki sütunlara yerleştir
                ListViewItem yeniSatir = new ListViewItem();
                yeniSatir.Text = kalanParcalar[0]; // İlk sütun
                for (int i = 1; i < kalanParcalar.Length; i++)
                {
                    yeniSatir.SubItems.Add(kalanParcalar[i]);
                }

                // ListView2'ye ekle
                lstRandevular.Items.Add(yeniSatir);

                MessageBox.Show("Seçilen satır metin dosyasıyla eşleştirildi.");
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
                
            }
        }

        private void btnRanDuzenle_Click(object sender, EventArgs e)
        {
            frmRandevuEkleSil frmRandevuEkleSil = new frmRandevuEkleSil();
            frmRandevuEkleSil.ShowDialog();
        }
    }
}








