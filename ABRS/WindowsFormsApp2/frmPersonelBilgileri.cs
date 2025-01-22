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
    public partial class frmPersonelBilgileri : Form
    {
        private List<Personel> PersonelOku(string dosyaYolu)
        {
            var personelListesi = new List<Personel>();
            var lines = File.ReadAllLines(dosyaYolu);

            foreach (var line in lines)
            {
                var values = line.Split(',');
                var personelID = int.Parse(values[0]);
                var personel = new Personel(personelID, values[1], values[2], values[3], values[4],
                    values[5], int.Parse(values[6]));
                personelListesi.Add(personel);
            }

            return personelListesi;
        }

        public frmPersonelBilgileri()
        {
            InitializeComponent();
            var personelListesi = PersonelOku("personeller.txt");
            comboBox1.Items.Add("PersonelID");
            comboBox1.Items.Add("Ad");
            comboBox1.Items.Add("Soyad");
            comboBox1.Items.Add("Pozisyon");
            comboBox1.Items.Add("Tümü");

            lstPersonelBilgileri.View = View.Details;

        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            lstPersonelBilgileri.Items.Clear();
            txtArananPersonel.Clear();
        }

        private void btnPersonelEkleSil_Click(object sender, EventArgs e)
        {
            frmPersonleEkleSil frmPersonleEkleSil = new frmPersonleEkleSil();
            frmPersonleEkleSil.ShowDialog();
        }

        private void btnPersonelAra_Click(object sender, EventArgs e)
        {
            lstPersonelBilgileri.Items.Clear(); // Önceki arama sonuçlarını temizle

            var personelListesi = PersonelOku("personeller.txt");
            var searchText = txtArananPersonel.Text.ToLower(); // Arama metnini küçük harfe çevirerek tutmak isteyebilirsiniz
            var selectedItem = comboBox1.SelectedItem?.ToString(); // Seçilen öğeyi alırken null kontrolü yapın

            // Her bir personeli kontrol et ve filtrele
            foreach (var personel in personelListesi)
            {
                // Seçilen öğeye göre filtreleme yapın
                if (selectedItem == "PersonelID" && personel.PersonelID.ToString() == searchText)
                {
                    lstPersonelBilgileri.Items.Add(new ListViewItem(new string[] { personel.PersonelID.ToString(),
                        personel.Ad, personel.Soyad, personel.Email, personel.Telefon, personel.Pozisyon, personel.Maas.ToString() }));
                }
                else if (selectedItem == "Ad" && personel.Ad.ToLower() == searchText)
                {
                    lstPersonelBilgileri.Items.Add(new ListViewItem(new string[] { personel.PersonelID.ToString(),
                        personel.Ad, personel.Soyad, personel.Email, personel.Telefon, personel.Pozisyon, personel.Maas.ToString() }));
                }
                else if (selectedItem == "Soyad" && personel.Soyad.ToLower() == searchText)
                {
                    lstPersonelBilgileri.Items.Add(new ListViewItem(new string[] { personel.PersonelID.ToString(),
                        personel.Ad, personel.Soyad, personel.Email, personel.Telefon, personel.Pozisyon, personel.Maas.ToString() }));
                }
                else if (selectedItem == "Email" && personel.Email.ToLower() == searchText)
                {
                    lstPersonelBilgileri.Items.Add(new ListViewItem(new string[] { personel.PersonelID.ToString(),
                        personel.Ad, personel.Soyad, personel.Email, personel.Telefon, personel.Pozisyon, personel.Maas.ToString() }));
                }
                else if (selectedItem == "Telefon" && personel.Telefon.ToLower() == searchText)
                {
                    lstPersonelBilgileri.Items.Add(new ListViewItem(new string[] { personel.PersonelID.ToString(),
                        personel.Ad, personel.Soyad, personel.Email, personel.Telefon, personel.Pozisyon, personel.Maas.ToString() }));
                }
                else if (selectedItem == "Pozisyon" && personel.Pozisyon.ToLower() == searchText)
                {
                    lstPersonelBilgileri.Items.Add(new ListViewItem(new string[] { personel.PersonelID.ToString(),
                        personel.Ad, personel.Soyad, personel.Email, personel.Telefon, personel.Pozisyon, personel.Maas.ToString() }));
                }
                else if (selectedItem == "Maas" && personel.Maas.ToString() == searchText)
                {
                    lstPersonelBilgileri.Items.Add(new ListViewItem(new string[] { personel.PersonelID.ToString(),
                        personel.Ad, personel.Soyad, personel.Email, personel.Telefon, personel.Pozisyon, personel.Maas.ToString() }));
                }
                else if (selectedItem == "Tümü") // Eğer "Tümü" seçiliyse personelleri PersonelID'ye göre sırala ve listeye ekle
                {
                    var siraliPersoneller = personelListesi.OrderBy(p => p.PersonelID);
                    foreach (var siraliPersonel in siraliPersoneller)
                    {
                        lstPersonelBilgileri.Items.Add(new ListViewItem(new string[] { siraliPersonel.PersonelID.ToString(),
                            siraliPersonel.Ad, siraliPersonel.Soyad, siraliPersonel.Email, siraliPersonel.Telefon, siraliPersonel.Pozisyon,
                            siraliPersonel.Maas.ToString() }));
                    }
                    break; // Tüm personelleri sıraladıktan sonra döngüden çık
                }
            }
        }
    }
}
