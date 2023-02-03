using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Takdir_Tesekkür_Hesapla
{
    public partial class Yks : Form
    {
        public Yks()
        {
            InitializeComponent();
        }

        SecenekSeviye ansayfa = new SecenekSeviye();
        private void btnHome_Click(object sender, EventArgs e)
        {
            ansayfa.Show();
            this.Close();
        }

        AnadoluLisesi geri = new AnadoluLisesi();
        private void btnGeri_Click(object sender, EventArgs e)
        {
            geri.Show();
            this.Close();
        }

        DialogResult cikis = new DialogResult();
        private void btnCik_Click(object sender, EventArgs e)
        {
            cikis = MessageBox.Show("Çıkış işlemini onaylıyor musunuz ?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cikis == DialogResult.Yes) Application.Exit();
            else MessageBox.Show("Çıkış işlemi iptal edildi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        int gun, saat, dakika, saniye;
        int gun2, saat2, dakika2, saniye2;
        private void Yks_Load(object sender, EventArgs e)
        {
            lblTarih.Text = "TYT : ";
            lblTarih2.Text = "AYT :";
            maskedTextBox1.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString(); 
            timer1.Interval = 1000;
            timer1.Enabled = true;
            TimeSpan arası = DateTime.Parse(mskdTYT.Text) - DateTime.Parse(maskedTextBox1.Text);
            TimeSpan zaman = DateTime.Parse(mskdAYT.Text) - DateTime.Parse(maskedTextBox1.Text);
            //AYT için kalan süre 
            gun = Math.Abs(arası.Days); saat = Math.Abs(arası.Hours); dakika = Math.Abs(arası.Minutes); saniye = Math.Abs(arası.Seconds);
            gun2 = Math.Abs(zaman.Days); saat2 = Math.Abs(zaman.Hours); dakika2 = Math.Abs(zaman.Minutes); saniye = Math.Abs(zaman.Seconds);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //TYT
                saniye--;
                if (saniye <= 0)
                {
                    saniye = 59;
                    dakika--;
                }
                else if (dakika <= 0)
                {
                    dakika = 59;
                    saat--;
                }
                else if (saat <= 0)
                {
                    saat = 23;
                    gun--;
                }
                lblGun.Text = gun.ToString();
                if (saniye < 10) lblSaniye.Text = "0" + saniye;
                else lblSaniye.Text = saniye.ToString();

                if (dakika < 10) lblDakika.Text = "0" + dakika;
                else lblDakika.Text = dakika.ToString();

                if (saat < 10) lblSaat.Text = "0" + saat;
                else lblSaat.Text = saat.ToString();
            }
            catch
            {
                MessageBox.Show("Hata var !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                //AYT
                saniye2--;
                if (saniye2 <= 0)
                {
                    saniye2 = 59;
                    dakika2--;
                }
                else if (dakika2 <= 0)
                {
                    dakika2 = 59;
                    saat2--;
                }
                else if (saat2 <= 0)
                {
                    saat2 = 23;
                    gun2--;
                }
                lblGun2.Text = gun2.ToString();
                if (saniye2 < 10) lblSaniye2.Text = "0" + saniye2;
                else lblSaniye2.Text = saniye2.ToString();

                if (dakika2 < 10) lblDakika2.Text = "0" + dakika2;
                else lblDakika2.Text = dakika2.ToString();

                if (saat2 < 10) lblSaat2.Text = "0" + saat2;
                else lblSaat2.Text = saat2.ToString();
            }
            catch
            {
                MessageBox.Show("Hata var !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        double tmlMatNet, turknet, sosnet, fennet;
        double tmlmatd, tmlmaty, fend, feny, turkced, turkcey, sosyald, sosyaly;
        double ort1, ort2, ort3, ort4;
        double puanTYT;

        private void btnTYTKaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                turkced = Convert.ToDouble(nmrcTurkceDogru.Value);
                turkcey = Convert.ToDouble(nmrcTurkceYanlis.Value);

                sosyald = Convert.ToDouble(nmrcSosyalDogru.Value);
                sosyaly = Convert.ToDouble(nmrcSosyalYanlis.Value);

                tmlmatd = Convert.ToDouble(nmrcTmlMatDogru.Value);
                tmlmaty = Convert.ToDouble(nmrcTmlMatDogru.Value);

                fend = Convert.ToDouble(nmrcFenDogru.Value);
                feny = Convert.ToDouble(nmrcFenYanlis.Value);
            }
            catch
            {
            }

            turknet = turkced - (turkcey * 1 / 4);
            txtTurkceNet.Text = turknet.ToString();

            sosnet = sosyald - (sosyaly * 1 / 4);
            txtSosyalNet.Text = sosnet.ToString();

            tmlMatNet = tmlmatd - (tmlmaty * 1 / 4);
            txtTmlMatNet.Text = tmlMatNet.ToString();

            fennet = fend - (feny * 1 / 4);
            txtFenNet.Text = fennet.ToString();

            ort1 = turknet * 3.1512;
            ort2 = sosnet * 3.5767;
            ort3 = tmlMatNet * 3.4579;
            ort4 = fennet * 3.31815;

            puanTYT = 100 + ort1 + ort2 + ort3 + ort4;
            MessageBox.Show("TYT : " + (32.318 + puanTYT));
        }

        private void nmrcTurkceDogru_ValueChanged_1(object sender, EventArgs e)
        {
            txtTurkceNet.Text = (nmrcTurkceDogru.Value - (nmrcTurkceYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcTurkceYanlis_ValueChanged_1(object sender, EventArgs e)
        {
            txtTurkceNet.Text = (nmrcTurkceDogru.Value - (nmrcTurkceYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcTmlMatDogru_ValueChanged_1(object sender, EventArgs e)
        {
            txtTmlMatNet.Text = (nmrcTmlMatDogru.Value - (nmrcTmlMatYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcTmlMatYanlis_ValueChanged_1(object sender, EventArgs e)
        {
            txtTmlMatNet.Text = (nmrcTmlMatDogru.Value - (nmrcTmlMatYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcSosyalDogru_ValueChanged_1(object sender, EventArgs e)
        {
            txtSosyalNet.Text = (nmrcSosyalDogru.Value - (nmrcSosyalYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcSosyalYanlis_ValueChanged_1(object sender, EventArgs e)
        {
            txtSosyalNet.Text = (nmrcSosyalDogru.Value - (nmrcSosyalYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcFenDogru_ValueChanged_1(object sender, EventArgs e)
        {
            txtFenNet.Text = (nmrcFenDogru.Value - (nmrcFenYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcFenYanlis_ValueChanged_1(object sender, EventArgs e)
        {
            txtFenNet.Text = (nmrcFenDogru.Value - (nmrcFenYanlis.Value * 1 / 4)).ToString();
        }

        private void bntTytTemizle_Click(object sender, EventArgs e)
        {
            nmrcTurkceDogru.Value = 0;
            nmrcTurkceYanlis.Value = 0;
            txtTurkceNet.Clear();
            nmrcTmlMatDogru.Value = 0;
            nmrcTmlMatYanlis.Value = 0;
            txtTmlMatNet.Clear();
            nmrcSosyalDogru.Value = 0;
            nmrcSosyalYanlis.Value = 0;
            txtSosyalNet.Clear();
            nmrcFenDogru.Value = 0;
            nmrcFenYanlis.Value = 0;
            txtFenNet.Clear();
            puanTYT = 0;
        }

        private void nmrcMatDogru_ValueChanged(object sender, EventArgs e)
        {
            txtMatNet.Text = (nmrcMatDogru.Value - (nmrcMatYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcMatYanlis_ValueChanged(object sender, EventArgs e)
        {
            txtMatNet.Text = (nmrcMatDogru.Value - (nmrcMatYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcFizDogru_ValueChanged(object sender, EventArgs e)
        {
            txtFizNet.Text = (nmrcFizDogru.Value - (nmrcFizYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcFizYanlis_ValueChanged(object sender, EventArgs e)
        {
            txtFizNet.Text = (nmrcFizDogru.Value - (nmrcFizYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcKimDogru_ValueChanged(object sender, EventArgs e)
        {
            txtKimNet.Text = (nmrcKimDogru.Value - (nmrcKimYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcKimYanlis_ValueChanged(object sender, EventArgs e)
        {
            txtKimNet.Text = (nmrcKimDogru.Value - (nmrcKimYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcBioDogru_ValueChanged(object sender, EventArgs e)
        {
            txtBioNet.Text = (nmrcBioDogru.Value - (nmrcBioYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcBioYanlis_ValueChanged(object sender, EventArgs e)
        {
            txtBioNet.Text = (nmrcBioDogru.Value - (nmrcBioYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcFelDogru_ValueChanged(object sender, EventArgs e)
        {
            txtFelNet.Text = (nmrcFelDogru.Value - (nmrcFelYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcFelYanlis_ValueChanged(object sender, EventArgs e)
        {
            txtFelNet.Text = (nmrcFelDogru.Value - (nmrcFelYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcEdeDogru_ValueChanged(object sender, EventArgs e)
        {
            txtEdeNet.Text = (nmrcEdeDogru.Value - (nmrcEdeYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcEdeYanlis_ValueChanged(object sender, EventArgs e)
        {
            txtEdeNet.Text = (nmrcEdeDogru.Value - (nmrcEdeYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcTar1Dogru_ValueChanged(object sender, EventArgs e)
        {
            txtTar1Net.Text = (nmrcTar1Dogru.Value - (nmrcTar1Yanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcTar1Yanlis_ValueChanged(object sender, EventArgs e)
        {
            txtTar1Net.Text = (nmrcTar1Dogru.Value - (nmrcTar1Yanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcCog1Dogru_ValueChanged(object sender, EventArgs e)
        {
            txtCog1Net.Text = (nmrcCog1Dogru.Value - (nmrcCog1Yanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcCog1Yanlis_ValueChanged(object sender, EventArgs e)
        {
            txtCog1Net.Text = (nmrcCog1Dogru.Value - (nmrcCog1Yanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcTar2Dogru_ValueChanged(object sender, EventArgs e)
        {
            txtTar2Net.Text = (nmrcTar2Dogru.Value - (nmrcTar2Yanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcTar2Yanlis_ValueChanged(object sender, EventArgs e)
        {
            txtTar2Net.Text = (nmrcTar2Dogru.Value - (nmrcTar2Yanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcCog2Dogru_ValueChanged(object sender, EventArgs e)
        {
            txtCog2Net.Text = (nmrcCog2Dogru.Value - (nmrcCog2Yanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcCog2Yanlis_ValueChanged(object sender, EventArgs e)
        {
            txtCog2Net.Text = (nmrcCog2Dogru.Value - (nmrcCog2Yanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcDinDogru_ValueChanged(object sender, EventArgs e)
        {
            txtDinNet.Text = (nmrcDinDogru.Value - (nmrcDinYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcDinYanlis_ValueChanged(object sender, EventArgs e)
        {
            txtDinNet.Text = (nmrcDinDogru.Value - (nmrcDinYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcDilDogru_ValueChanged(object sender, EventArgs e)
        {
            txtDilNet.Text = (nmrcDilDogru.Value - (nmrcDilYanlis.Value * 1 / 4)).ToString();
        }

        private void nmrcDilYanlis_ValueChanged(object sender, EventArgs e)
        {
            txtDilNet.Text = (nmrcDilDogru.Value - (nmrcDilYanlis.Value * 1 / 4)).ToString();
        }

        private void bntAytTemizle_Click(object sender, EventArgs e)
        {
            nmrcMatDogru.Value = 0;
            nmrcMatYanlis.Value = 0;
            nmrcFizDogru.Value = 0;
            nmrcFizYanlis.Value = 0;
            nmrcKimDogru.Value = 0;
            nmrcKimYanlis.Value = 0;
            nmrcBioDogru.Value = 0;
            nmrcBioYanlis.Value = 0;
            nmrcFelDogru.Value = 0;
            nmrcFelYanlis.Value = 0;
            nmrcEdeDogru.Value = 0;
            nmrcEdeYanlis.Value = 0;
            nmrcTar1Dogru.Value = 0;
            nmrcTar1Yanlis.Value = 0;
            nmrcCog1Dogru.Value = 0;
            nmrcCog1Yanlis.Value = 0;
            nmrcTar2Dogru.Value = 0;
            nmrcTar2Yanlis.Value = 0;
            nmrcCog2Dogru.Value = 0;
            nmrcCog2Yanlis.Value = 0;
            nmrcDinDogru.Value = 0;
            nmrcDinYanlis.Value = 0;
            nmrcDilDogru.Value = 0;
            nmrcDilYanlis.Value = 0;
            txtMatNet.Clear();
            txtFizNet.Clear();
            txtKimNet.Clear();
            txtBioNet.Clear();
            txtFelNet.Clear();
            txtEdeNet.Clear();
            txtTar1Net.Clear();
            txtCog1Net.Clear();
            txtTar2Net.Clear();
            txtCog2Net.Clear();
            txtDinNet.Clear();
            txtDilNet.Clear();
        }

        double MatNet, edeNet, tar1Net, tar2Net, cog1Net, cog2Net, fizNet, kimNet, bioNet, felNet, dilNet, dinNet;
        double matD, matY, edeD, edeY, tar1D, tar1Y, tar2D, tar2Y, cog1D, cog1Y, cog2D, cog2Y, fizD, fizY, kimD, kimY, bioD, bioY, felD, felY, dilD, dilY, dinD, dinY;
        double ortMat, ortEde, ortTar1, ortTar2, ortCog1, ortCog2, ortFiz, ortKim, ortBio, ortFel, ortDil, ortDin;
        double puanAYT;
        private void btnAytKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                matD = Convert.ToDouble(nmrcMatDogru.Value);
                matY = Convert.ToDouble(nmrcMatYanlis.Value);

                edeD = Convert.ToDouble(nmrcEdeDogru.Value);
                edeY = Convert.ToDouble(nmrcEdeYanlis.Value);

                tar1D = Convert.ToDouble(nmrcTar1Dogru.Value);
                tar1Y = Convert.ToDouble(nmrcTar1Yanlis.Value);

                tar2D = Convert.ToDouble(nmrcTar2Dogru.Value);
                tar2Y = Convert.ToDouble(nmrcTar2Yanlis.Value);

                cog1D = Convert.ToDouble(nmrcCog1Dogru.Value);
                cog1Y = Convert.ToDouble(nmrcCog1Yanlis.Value);

                cog2D = Convert.ToDouble(nmrcCog2Dogru.Value);
                cog2Y = Convert.ToDouble(nmrcCog2Yanlis.Value);

                fizD = Convert.ToDouble(nmrcFizDogru.Value);
                fizY = Convert.ToDouble(nmrcFizYanlis.Value);

                kimD = Convert.ToDouble(nmrcKimDogru.Value);
                kimY = Convert.ToDouble(nmrcKimYanlis.Value);

                bioD = Convert.ToDouble(nmrcBioDogru.Value);
                bioY = Convert.ToDouble(nmrcBioYanlis.Value);

                felD = Convert.ToDouble(nmrcFelDogru.Value);
                felY = Convert.ToDouble(nmrcFelYanlis.Value);

                dilD = Convert.ToDouble(nmrcDilDogru.Value);
                dilY = Convert.ToDouble(nmrcDilYanlis.Value);

                dinD = Convert.ToDouble(nmrcDinDogru.Value);
                dinY = Convert.ToDouble(nmrcDinYanlis.Value);
            }
            catch
            {
            }

            MatNet = matD - (matY * 1 / 4);
            txtMatNet.Text = MatNet.ToString();

            fizNet = fizD - (fizY * 1 / 4);
            txtFizNet.Text = fizNet.ToString();

            kimNet = kimD - (kimY * 1 / 4);
            txtKimNet.Text = kimNet.ToString();

            bioNet = bioD - (bioY * 1 / 4);
            txtBioNet.Text = bioNet.ToString();

            edeNet = edeD - (edeY * 1 / 4);
            txtEdeNet.Text = edeNet.ToString();

            felNet = felD - (felY * 1 / 4);
            txtFelNet.Text = felNet.ToString();

            tar1Net = tar1D - (tar1Y * 1 / 4);
            txtTar1Net.Text = tar1Net.ToString();

            tar2Net = tar2D - (tar2Y * 1 / 4);
            txtTar2Net.Text = tar2Net.ToString();

            cog1Net = cog1D - (cog1Y * 1 / 4);
            txtCog1Net.Text = cog1Net.ToString();

            cog2Net = cog2D - (cog2Y * 1 / 4);
            txtCog2Net.Text = cog2Net.ToString();

            dinNet = dinD - (dinY * 1 / 4);
            txtDinNet.Text = dinNet.ToString();

            dilNet = dilD - (dilY * 1 / 4);
            txtDilNet.Text = dilNet.ToString();

            ortMat = MatNet ;
            ortEde = edeNet ;
            ortFiz = fizNet;
            ortKim = kimNet;
            ortBio = bioNet;
            ortFel = felNet;
            ortDin = dinNet;
            ortDil = dilNet;
            ortTar1 = tar1Net;
            ortTar2 = tar2Net;
            ortCog1 = cog1Net;
            ortCog2 = cog2Net;

            puanAYT = 100 + ortMat + ortEde + ortFiz + ortBio + ortFel + ortDin + ortDil + ortTar1 + ortTar2 + ortCog1 + ortCog2 + ortKim;
            MessageBox.Show("AYT : " + (32.318 + puanAYT));
        }
    }
}
