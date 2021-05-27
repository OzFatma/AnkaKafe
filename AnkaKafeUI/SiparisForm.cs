using AnkaKafe.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnkaKafeUI
{
    public partial class SiparisForm : Form
    {
        private readonly KafeVeri _db;
        private readonly Siparis _siparis;
        public SiparisForm(KafeVeri kafeVeri, Siparis siparis)
        {
            InitializeComponent();
            _db = kafeVeri;
            _siparis = siparis;
            MasaNoGuncelle();
            FiyatGuncelle();
            UrunleriGoster();
            DetaylariListele();
        }

        private void UrunleriGoster()
        {
            cboUrun.DataSource = _db.Urunler;
        }

        private void FiyatGuncelle()
        {
            lblOdemeTutar.Text = _siparis.ToplamTutarTL;
        }

        private void MasaNoGuncelle()
        {
            Text = $"Masa {_siparis.MasaNo} Sipariş Bilgileri";
            lblMasaNo.Text = _siparis.MasaNo.ToString("00");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun urun = (Urun)cboUrun.SelectedItem;
            SiparisDetay siparisDetay = new SiparisDetay()
            {
                UrunAd = urun.UrunAd,
                BirimFiyat = urun.BirimFiyat,
                Adet = (int)nudAdet.Value
            };
            _siparis.SiparisDetaylar.Add(siparisDetay);
            DetaylariListele();
            FiyatGuncelle();
        }

        private void DetaylariListele()
        {
            dgvSiparisDetaylar.DataSource = null;
            dgvSiparisDetaylar.DataSource = _siparis.SiparisDetaylar;
        }
    }
}
