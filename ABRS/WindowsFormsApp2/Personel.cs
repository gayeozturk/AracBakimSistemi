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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Personel
    {
        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Pozisyon { get; set; }
        public int Maas { get; set; }

        public Personel(int ID, string ad, string soyad, string email, string telefon, string pozisyon, int maas)
        {
            PersonelID = ID;
            Ad = ad;
            Soyad = soyad;
            Email = email;
            Telefon = telefon;
            Pozisyon = pozisyon;
            Maas = maas;
        }

        public string ToCsvString()
        {
            return $"{PersonelID},{Ad},{Soyad},{Email},{Telefon},{Pozisyon},{Maas}";
        }
    }
}