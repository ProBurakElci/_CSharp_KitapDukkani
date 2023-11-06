using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_KitapDukkani
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        ArrayList yazarlarList = new ArrayList();
        ArrayList kitaplarList = new ArrayList();
        ArrayList musterilerList = new ArrayList();

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            Yazar yazar = new Yazar();

            yazar.YazarAdi = txtYazarAdi.Text;

            yazar.DogumTarihi = dtDogumTarihi.Value; // datetime pcker ın Value özelliği, seçilen tarihi DateTime tipinden verir.
 if (rdbVar.Checked)
            {
                yazar.NobelOduluVarMi = true;
            }
            else if (rdbYok.Checked)
            {
                yazar.NobelOduluVarMi = false;
            }
            yazarlarList.Add(yazar);
            cmbYazari.Items.Add(yazar);
            cmbYazari.DisplayMember = "YazarAdi";

        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.KitapAdi = txtKitapAdi.Text;
            kitap.KitapTuru = cmbTuru.Text;
            kitap.SayfaSayisi = int.Parse(txtSayfaSayisi.Text);
            kitap.Fiyat = double.Parse(txtFiyat.Text);
            kitap.KitabinYazari = (Yazar)cmbYazari.SelectedItem;
            kitaplarList.Add(kitap);
            cmbAldigiKitap.Items.Add(kitap);
            cmbAldigiKitap.DisplayMember = "KitapAdi";
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriAdi = txtMusteriAdi.Text;
            musteri.Meslegi = cmbMeslegi.Text;
            musteri.MusteriKitap = (Kitap)cmbAldigiKitap.SelectedItem;
            musterilerList.Add(musteri);
            lsbMusteriler.Items.Add(musteri);
            lsbMusteriler.DisplayMember = "MusteriAdi";
        }
        private void lsbMusteriler_DoubleClick(object sender, EventArgs e)
        {
            // çift tıklauyınca diğer lsb da aldığı kitabın adını ve yazarını göstersin.
            string secilenMusteriIsmi = (lsbMusteriler.SelectedItem as Musteri).MusteriAdi;
            foreach (object item in musterilerList)
            {
                if (secilenMusteriIsmi == ((Musteri)item).MusteriAdi)
                {
                    lsbKitapAdiYazarAdi.Items.Add(((Musteri)item).MusteriKitap.KitapAdi + "--" +
                   ((Musteri)item).MusteriKitap.KitabinYazari.YazarAdi);
                }
            }
        }

        private void lsbMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
