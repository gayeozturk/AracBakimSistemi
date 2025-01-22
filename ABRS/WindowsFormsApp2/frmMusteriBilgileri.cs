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
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class frmMusteriBilgileri : Form
    {

        // MusterileriOku metodu buraya yazılır
        private List<Musteri> Musterilerioku(string dosyaYolu)
        {
            var musteriListesi = new List<Musteri>();
            var lines = File.ReadAllLines(dosyaYolu);
            foreach (var line in lines)
            {
                var values = line.Split(',');
                int musteriID;
                if (int.TryParse(values[0], out musteriID))
                {
                    var musteri = new Musteri(musteriID, values[1], values[2], values[3]);
                    musteriListesi.Add(musteri);
                }
                else
                {
                    Console.WriteLine("Geçersiz müşteri ID: " + values[0]);
                    // Hatalı müşteri ID'yi işlemek için gerekli adımları ekleyebilirsiniz.
                }
            }

            return musteriListesi;
        }

        public frmMusteriBilgileri()
        {
            InitializeComponent();

            var musteriListesi = Musterilerioku("musteriler.txt");
            comboBox1.Items.Add("MusteriID");
            comboBox1.Items.Add("Ad");
            comboBox1.Items.Add("Soyad");
            comboBox1.Items.Add("Tümü");

            lstMusteriler.View = View.Details;
        }

        private void btnMusteriAra_Click(object sender, EventArgs e)
        {
            lstMusteriler.Items.Clear(); // Her arama öncesinde listeyi temizle

            var musteriListesi = Musterilerioku("musteriler.txt");

            var searchText = textBox1.Text.ToLower(); // Arama metnini küçük harfe çevirerek tutmak isteyebilirsiniz
            var selectedItem = comboBox1.SelectedItem?.ToString(); // Seçilen öğeyi alırken null kontrolü yapın

            // Her bir müşteriyi kontrol et ve filtrele
            foreach (var musteri in musteriListesi)
            {
                if (selectedItem == "MusteriID" && musteri.MusteriID.ToString() == searchText)
                {
                    lstMusteriler.Items.Add(new ListViewItem(new string[] { musteri.MusteriID.ToString(), musteri.Ad,
                        musteri.Soyad, musteri.Telefon }));
                }
                else if (selectedItem == "Ad" && musteri.Ad.ToLower() == searchText)
                {
                    lstMusteriler.Items.Add(new ListViewItem(new string[] { musteri.MusteriID.ToString(), musteri.Ad,
                        musteri.Soyad, musteri.Telefon }));
                }
                else if (selectedItem == "Soyad" && musteri.Soyad.ToLower() == searchText)
                {
                    lstMusteriler.Items.Add(new ListViewItem(new string[] { musteri.MusteriID.ToString(), musteri.Ad,
                        musteri.Soyad, musteri.Telefon }));
                }
                else if (selectedItem == "Telefon" && musteri.Telefon.ToLower() == searchText)
                {
                    lstMusteriler.Items.Add(new ListViewItem(new string[] { musteri.MusteriID.ToString(), musteri.Ad,
                        musteri.Soyad, musteri.Telefon }));
                }
                else if (selectedItem == "Tümü") // Eğer "Tümü" seçiliyse müşterileri MusteriID'ye göre sırala ve listeye ekle
                {
                    var siraliMusteriler = musteriListesi.OrderBy(m => m.MusteriID);
                    foreach (var siraliMusteri in siraliMusteriler)
                    {
                        lstMusteriler.Items.Add(new ListViewItem(new string[] { siraliMusteri.MusteriID.ToString(),
                            siraliMusteri.Ad, siraliMusteri.Soyad, siraliMusteri.Telefon }));
                    }
                    break; // Tüm müşterileri sıraladıktan sonra döngüden çık
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstMusteriler.Items.Clear();
            textBox1.Clear();
        }

        private void btnMusteriEkleSil_Click(object sender, EventArgs e)
        {
            frmMusteriEkleSil frmMusteriEkleSil = new frmMusteriEkleSil();
            frmMusteriEkleSil.ShowDialog();
        }



    }
}






