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
    public partial class AnaForm : Form
    {
        KafeVeri db = new KafeVeri();
        public AnaForm()
        {
            OrnekUrunlerEkle();
            InitializeComponent();
            masalarImageList.Images.Add("bos", Resource.bos);
            masalarImageList.Images.Add("dolu", Resource.dolu);

            MasalariOlustur();
        }

        private void OrnekUrunlerEkle()
        {
            db.Urunler.Add(new Urun() { UrunAd = "Çay", BirimFiyat = 4.00m });
            db.Urunler.Add(new Urun() { UrunAd = "Simit", BirimFiyat = 5.00m });
        }

        private void MasalariOlustur()
        {
            ListViewItem lvi;
            for (int i = 1; i < db.MasaAdet; i++)
            {
                lvi = new ListViewItem();
                lvi.Text = "Masa " + i;
                lvi.ImageKey = "bos";
                lvi.Tag = i;
                lvwMasalar.Items.Add(lvi);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiUrunler)
            {
                new UrunlerForm().ShowDialog();
            }
            else if (e.ClickedItem == tsmiGecmisSiparisler)
            {
                new GecmisSiparislerForm().ShowDialog();
            }
        }


        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvi = lvwMasalar.SelectedItems[0];
            int masaNo = (int)lvi.Tag;
            lvi.ImageKey = "dolu";
            //eğer bu masada önceden bi rsipariş yoksa oluştur
            Siparis siparis = SiparisBul(masaNo);
            if (siparis==null)
            {
                siparis = new Siparis() { MasaNo = masaNo };
                db.AktifSiparisler.Add(siparis);
            }
            //todo: bu siparişi başka form da aç
            SiparisForm siparisForm = new SiparisForm(db,siparis);
            siparisForm.ShowDialog();
            
        }
        private Siparis SiparisBul(int masaNo)
        {
           // return db.AktifSiparisler.FirstOrDefault(s => s.MasaNo == masaNo);
            foreach (Siparis siparis in db.AktifSiparisler)
            {
                if(siparis.MasaNo == masaNo)
                {
                    return siparis;
                }
            }
            return null;
        }
    }
}
