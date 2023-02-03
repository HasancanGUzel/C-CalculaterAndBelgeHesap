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
    public partial class Lgs : Form
    {
        public Lgs()
        {
            InitializeComponent();
        }

        public static string bolum;

        SecenekSeviye ana = new SecenekSeviye();
        private void btnHome_Click(object sender, EventArgs e)
        {
            ana.Show();
            this.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (bolum=="orta")
            {
                OrtaOkulHesap geri1 = new OrtaOkulHesap();
                geri1.Show();
            }
            else if (bolum=="imam")
            {
                ImamHatipOrtaOkul geri2 = new ImamHatipOrtaOkul();
                geri2.Show();
            }
            this.Close();
        }

        DialogResult cik = new DialogResult();
        private void btnCik_Click(object sender, EventArgs e)
        {
            cik = MessageBox.Show("Çıkış işlemini onaylıyor musunuz ?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cik == DialogResult.Yes) Application.Exit();
            else MessageBox.Show("Çıkış işlemi iptal edildi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        int gun, saat, dakika, saniye;
        private void Lgs_Load(object sender, EventArgs e)
        {
            lblTarih.Text = "LGS ' ye Kalan Süre : ";
            maskedTextBox1.Text = DateTime.Now.ToShortDateString();
            maskedTextBox3.Text = DateTime.Now.ToShortTimeString();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            TimeSpan arası = DateTime.Parse(maskedTextBox2.Text) - DateTime.Parse(maskedTextBox1.Text);
            TimeSpan zaman = DateTime.Parse(maskedTextBox4.Text) - DateTime.Parse(maskedTextBox3.Text);
            gun = Math.Abs(arası.Days); saat = Math.Abs(zaman.Hours); dakika = Math.Abs(zaman.Minutes); saniye = Math.Abs(zaman.Seconds);
        }

        double matnet, turknet, sosnet, dinnet, fennet, ingnet;
        double matd, maty, inkilapd, inkilapy, dind, diny, fend, feny, ingd, ingy, turkced, turkcey;
        double ort1, ort2, ort3, ort4, ort5, ort6;
        double puan;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                turkced = Convert.ToDouble(nmrcTurkceDogru.Value);
                turkcey = Convert.ToDouble(nmrcTurkceYanlis.Value);

                inkilapd = Convert.ToDouble(nmrcTcDogru.Value);
                inkilapy = Convert.ToDouble(nmrcTcYanlis.Value);

                dind = Convert.ToDouble(nmrcDinDogru.Value);
                diny = Convert.ToDouble(nmrcDinYanlis.Value);

                ingd = Convert.ToDouble(nmrcIngDogru.Value);
                ingy = Convert.ToDouble(nmrcIngYanlis.Value);

                matd = Convert.ToDouble(nmrcMatDogru.Value);
                maty = Convert.ToDouble(nmrcMatYanlis.Value);

                fend = Convert.ToDouble(nmrcFenDogru.Value);
                feny = Convert.ToDouble(nmrcFenYanlis.Value);
            }
            catch
            {
            }

            turknet = turkced - (turkcey * 1 / 3);
            txtTurkNet.Text = turknet.ToString();

            sosnet = inkilapd - (inkilapy * 1 / 3);
            txtTcNet.Text = sosnet.ToString();

            dinnet = dind - (diny * 1 / 3);
            txtDinNet.Text = dinnet.ToString();

            ingnet = ingd - (ingy * 1 / 3);
            txtIngNet.Text = ingnet.ToString();

            matnet = matd - (maty * 1 / 3);
            txtMatNet.Text = matnet.ToString();

            fennet = fend - (feny * 1 / 3);
            txtFenNet.Text = fennet.ToString();

            ort1 = matnet * 7.407407;
            ort2 = fennet * 7.407407;
            ort3 = turknet * 7.407407;
            ort4 = ingnet * 1.851851;
            ort5 = dinnet * 1.851851;
            ort6 = sosnet * 1.851851;
            puan = (ort1 + ort2 + ort3 + ort4 + ort5 + ort6) + 0.01;
            txtLgsPuani.Text = puan.ToString();
            txtToplamDogru.Text = (turkced + inkilapd + dind + ingd + matd + fend).ToString();
            txtToplamYanlis.Text = (turkcey + inkilapy + diny + ingy + maty + feny).ToString();
            txtToplamNet.Text = (turknet + sosnet + dinnet + ingnet + matnet + fennet).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
               
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
                else  lblDakika.Text = dakika.ToString();

                if (saat < 10) lblSaat.Text = "0" + saat;
                else lblSaat.Text = saat.ToString();
            }
            catch
            {
                MessageBox.Show("Hata var");
            }
        }

        private void nmrcTurkceDogru_ValueChanged(object sender, EventArgs e)
        {

            txtTurkNet.Text = (nmrcTurkceDogru.Value - (nmrcTurkceYanlis.Value * 1 / 3)).ToString(); 
        }

        private void nmrcTurkceYanlis_ValueChanged(object sender, EventArgs e)
        {
            txtTurkNet.Text = (nmrcTurkceDogru.Value - (nmrcTurkceYanlis.Value * 1 / 3)).ToString(); 
        }

        private void nmrcTcDogru_ValueChanged(object sender, EventArgs e)
        {
            txtTcNet.Text = (nmrcTcDogru.Value - (nmrcTcYanlis.Value * 1 / 3)).ToString();
        }

        private void nmrcTcYanlis_ValueChanged(object sender, EventArgs e)
        {
            txtTcNet.Text = (nmrcTcDogru.Value - (nmrcTcYanlis.Value * 1 / 3)).ToString();
        }

        private void nmrcDinDogru_ValueChanged(object sender, EventArgs e)
        {
            txtDinNet.Text = (nmrcDinDogru.Value - (nmrcDinYanlis.Value * 1 / 3)).ToString();
        }

        private void nmrcDinYanlis_ValueChanged(object sender, EventArgs e)
        {
            txtDinNet.Text = (nmrcDinDogru.Value - (nmrcDinYanlis.Value * 1 / 3)).ToString();
        }

        private void nmrcIngDogru_ValueChanged(object sender, EventArgs e)
        {
            txtIngNet.Text = (nmrcIngDogru.Value - (nmrcIngYanlis.Value * 1 / 3)).ToString();
        }

        private void nmrcIngYanlis_ValueChanged(object sender, EventArgs e)
        {
            txtIngNet.Text = (nmrcIngDogru.Value - (nmrcIngYanlis.Value * 1 / 3)).ToString();
        }

        private void nmrcMatDogru_ValueChanged(object sender, EventArgs e)
        {
            txtMatNet.Text = (nmrcMatDogru.Value - (nmrcMatYanlis.Value * 1 / 3)).ToString();
        }

        private void nmrcMatYanlis_ValueChanged(object sender, EventArgs e)
        {
            txtMatNet.Text = (nmrcMatDogru.Value - (nmrcMatYanlis.Value * 1 / 3)).ToString();
        }

        private void nmrcFenDogru_ValueChanged(object sender, EventArgs e)
        {
            txtFenNet.Text = (nmrcFenDogru.Value - (nmrcFenYanlis.Value * 1 / 3)).ToString();
        }

        private void nmrcFenYanlis_ValueChanged(object sender, EventArgs e)
        {
            txtFenNet.Text = (nmrcFenDogru.Value - (nmrcFenYanlis.Value * 1 / 3)).ToString();
        }
    }
}
