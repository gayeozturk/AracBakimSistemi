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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void btnMusteriBilgileri_Click(object sender, EventArgs e)
        {
            frmMusteriBilgileri frmMusteriBilgileri = new frmMusteriBilgileri();
            frmMusteriBilgileri.ShowDialog();
        }

        private void btnPersonelBilgisi_Click(object sender, EventArgs e)
        {
            frmPersonelBilgileri frmPersonelBilgileri = new frmPersonelBilgileri();
            frmPersonelBilgileri.ShowDialog();
        }


        private void frmRandevuPlanlama_Click(object sender, EventArgs e)
        {
            frmRandevuPlanlama frmRandevuPlanlama = new frmRandevuPlanlama();
            frmRandevuPlanlama.ShowDialog();
        }
    }
}




