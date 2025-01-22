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
    public class Randevu
    {
        public int RandevuID { get; set; }
        public Musteri Musteri { get; set; }
        public Hizmet Hizmet { get; set; }
        public DateTime Tarih { get; set; }
        public Personel Personel { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Motor { get; set; }

        public Randevu(int ID,Musteri musteri, Hizmet hizmet, DateTime tarih, Personel personel,string marka,string model, string motor)
        {
            RandevuID = ID;
            Musteri = musteri;
            Hizmet = hizmet;
            Tarih = tarih;
            Personel = personel;
            Marka = marka;
            Model = model;
            Motor = motor;

        }
    }
}
