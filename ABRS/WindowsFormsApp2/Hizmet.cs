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
    public class Hizmet
    {
        public int HizmetID { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public decimal Ucret { get; set; }

        public Hizmet(int ID,string ad, decimal ucret, string aciklama)
        {
            HizmetID = ID;
            Ad = ad;
            Ucret = ucret;
            Aciklama = aciklama;
        }
        public string ToCsvString()
        {
            return $"{HizmetID},{Ad},{Aciklama},{Ucret}";
        }
    }
}
