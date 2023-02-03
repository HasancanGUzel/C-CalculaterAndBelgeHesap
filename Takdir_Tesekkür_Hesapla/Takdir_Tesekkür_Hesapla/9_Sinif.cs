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
    public partial class _9_Sinif : Form
    {
        public _9_Sinif()
        {
            InitializeComponent();
        }

        DialogResult cikis = new DialogResult();
        private void btnCik_Click(object sender, EventArgs e)
        {
            cikis = MessageBox.Show("Çıkış işlemini onaylıyor musunuz ?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cikis == DialogResult.Yes) Application.Exit();
            else MessageBox.Show("Çıkış işlemi iptal edildi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        AnadoluLisesi geri = new AnadoluLisesi();
        private void btnGeri_Click(object sender, EventArgs e)
        {
            geri.Show();
            this.Close();
        }

        SecenekSeviye anasayfa = new SecenekSeviye();
        private void btnHome_Click(object sender, EventArgs e)
        {
            anasayfa.Show();
            this.Close();
        }

        double bdnsaat = 1, cogst = 2, tarihst = 2, fizst = 2, kimyast = 2, biyost = 2, matst = 6, dinsst = 2, edebiyatst = 5, ybnciBirst = 4, ybnciIkist = 2, saglikst = 1, muzikst = 2, s1saat, s2saat, s3saat;
        double beden, cografya, tarih, fizik, kimya, biyoloji, matematik, din, edebiyat, yabanciBir, yabanciIki, saglik, muzik, secmeli1, secmeli2, secmeli3;
        double ort1, ort2, ort3, ort4, ort5, ort6, ort7, ort8, ort9, ort10, ort11, ort12, ort13, ort14, ort15, ort16;
        double saat, puan, gnltoplam;

        private void cmbSaatler()
        {
            if (cmbSecmeli1.SelectedItem == "1.Seçmeli Ders (Haftada 1 Saat)") s1saat = 1;
            else if (cmbSecmeli1.SelectedItem == "1.Seçmeli Ders (Haftada 2 Saat)") s1saat = 2;
            else if (cmbSecmeli1.SelectedItem == "1.Seçmeli Ders (Haftada 3 Saat)") s1saat = 3;
            else if (cmbSecmeli1.SelectedItem == "1.Seçmeli Ders (Haftada 4 Saat)") s1saat = 4;

            if (cmbSecmeli2.SelectedItem == "2.Seçmeli Ders (Haftada 1 Saat)") s2saat = 1;
            else if (cmbSecmeli2.SelectedItem == "2.Seçmeli Ders (Haftada 2 Saat)") s2saat = 2;
            else if (cmbSecmeli2.SelectedItem == "2.Seçmeli Ders (Haftada 3 Saat)") s2saat = 3;
            else if (cmbSecmeli2.SelectedItem == "2.Seçmeli Ders (Haftada 4 Saat)") s2saat = 4;

            if (cmbSecmeli3.SelectedItem == "3.Seçmeli Ders (Haftada 1 Saat)") s3saat = 1;
            else if (cmbSecmeli3.SelectedItem == "3.Seçmeli Ders (Haftada 2 Saat)") s3saat = 2;
            else if (cmbSecmeli3.SelectedItem == "3.Seçmeli Ders (Haftada 3 Saat)") s3saat = 3;
            else if (cmbSecmeli3.SelectedItem == "3.Seçmeli Ders (Haftada 4 Saat)") s3saat = 4;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (txtBeden.Text == "" || txtCografya.Text == "" || txtTarih.Text == "" || txtFizik.Text == "" || txtKimya.Text == "" || txtBiyoloji.Text == "" || txtMatematik.Text == "" || txtDin.Text == "" || txtEdebiyat.Text == "" || txtYabanciBir.Text == "" || txtYabanciIki.Text == "" || txtSaglik.Text == "" || txtSecmeli1.Text == "" | txtSecmeli2.Text == "" || txtSecmeli3.Text == "")
            {

            }
            else
            {
                try
                {
                    beden = Convert.ToDouble(txtBeden.Text);
                    cografya = Convert.ToDouble(txtCografya.Text);
                    tarih = Convert.ToDouble(txtTarih.Text);
                    fizik = Convert.ToDouble(txtFizik.Text);
                    kimya = Convert.ToDouble(txtKimya.Text);
                    biyoloji = Convert.ToDouble(txtBiyoloji.Text);
                    matematik = Convert.ToDouble(txtMatematik.Text);
                    din = Convert.ToDouble(txtDin.Text);
                    edebiyat = Convert.ToDouble(txtEdebiyat.Text);
                    yabanciBir = Convert.ToDouble(txtYabanciBir.Text);
                    yabanciIki = Convert.ToDouble(txtYabanciIki.Text);
                    saglik = Convert.ToDouble(txtSaglik.Text);
                    muzik = Convert.ToDouble(txtMuzik.Text);
                    secmeli1 = Convert.ToDouble(txtSecmeli1.Text);
                    secmeli2 = Convert.ToDouble(txtSecmeli2.Text);
                    secmeli3 = Convert.ToDouble(txtSecmeli3.Text);
                }
                catch 
                {
                }

                //ağırlıklı not ortalamaları için//
                ort1 = beden * bdnsaat;
                ort2 = cografya * cogst;
                ort3 = tarih * tarihst;
                ort4 = fizik * fizst;
                ort5 = kimya * kimyast;
                ort6 = biyoloji * biyost;
                ort7 = matematik * matst;
                ort8 = din * dinsst;
                ort9 = edebiyat * edebiyatst;
                ort10 = yabanciBir * ybnciBirst;
                ort11 = yabanciIki * ybnciIkist;
                ort12 = saglik * saglikst;
                ort13 = muzik * muzikst;
                ort14 = secmeli1 * s1saat;
                ort15 = secmeli2 * s2saat;
                ort16 = secmeli3 * s3saat;

                puan = ort1 + ort2 + ort3 + ort4 + ort5 + ort6 + ort7 + ort8 + ort9 + ort10 + ort11 + ort12 + ort13 + ort14 + ort15 + ort16;
                saat = bdnsaat + cogst + tarihst + fizst + kimyast + biyost + matst + dinsst + edebiyatst + ybnciBirst + ybnciIkist + saglikst + muzikst + s1saat + s2saat + s3saat;
                gnltoplam = puan / saat;
                txtGnlTplm.Text = gnltoplam.ToString();
                lblDersSaati.Text = "Haftalık toplam ders saati : " + saat;

                if (gnltoplam < 70)
                {
                    lblGereken.Text = "Teşekkür İçin Gereken Puan= " + (70 - gnltoplam);
                    pctBelge.Visible = false;
                    lblGereken.Visible = true;
                    lblBelgesiz.Visible = true;
                    lblBelgesiz.Text = "                   ÜZGÜNÜZ \nHİÇ BİR BELGE ALAMIYORSUNUZ.";
                }
                else if (gnltoplam >= 70 && gnltoplam < 85)
                {
                    pctBelge.Image = Properties.Resources.teşekkür;
                    lblGereken.Text = "Takdir İçin Gereken Puan= " + (85 - gnltoplam);
                    lblGereken.Visible = true;
                    pctBelge.Visible = true;
                    lblBelgesiz.Visible = false;
                    if (beden < 50 || cografya < 50 || tarih < 50 || fizik < 50 || kimya < 50 || biyoloji < 50 || matematik < 50 || din < 50 || edebiyat < 50 || yabanciBir < 50 || yabanciIki < 50 || saglik < 50 || muzik < 50 || secmeli1 < 50 || secmeli2 < 50 || secmeli3 < 50)
                    {
                        lblBelgesiz.Visible = true;
                        pctBelge.Visible = false;
                        lblBelgesiz.Text = "                   ÜZGÜNÜZ \nHİÇ BİR BELGE ALAMIYORSUNUZ.\nÇÜNKÜ 50 ' nin ALTINDA NOT VAR.";
                    }
                }
                else if (gnltoplam >= 85)
                {
                    pctBelge.Image = Properties.Resources.takdir;
                    lblGereken.Visible = false;
                    pctBelge.Visible = true;
                    lblBelgesiz.Visible = false;
                    if (beden < 50 || cografya < 50 || tarih < 50 || fizik < 50 || kimya < 50 || biyoloji < 50 || matematik < 50 || din < 50 || edebiyat < 50 || yabanciBir < 50 || yabanciIki < 50 || saglik < 50 || muzik < 50 || secmeli1 < 50 || secmeli2 < 50 || secmeli3 < 50)
                    {
                        lblBelgesiz.Visible = true;
                        pctBelge.Visible = false;
                        lblBelgesiz.Text = "                   ÜZGÜNÜZ \nHİÇ BİR BELGE ALAMIYORSUNUZ.\nÇÜNKÜ 50 ' nin ALTINDA NOT VAR.";
                    }
                }
                this.Width = 1019;
                this.CenterToScreen();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            gnltoplam = 0;
            txtGnlTplm.Text = "";
            this.Width = 446;
            this.CenterToScreen();
            txtGnlTplm.Clear();
            txtBeden.Clear();
            txtCografya.Clear();
            txtTarih.Clear();
            txtFizik.Clear();
            txtKimya.Clear();
            txtBiyoloji.Clear();
            txtMatematik.Clear();
            txtDin.Clear();
            txtEdebiyat.Clear();
            txtYabanciBir.Clear();
            txtYabanciIki.Clear();
            txtSaglik.Clear();
            txtMuzik.Clear();
            txtSecmeli1.Clear();
            txtSecmeli2.Clear();
            txtSecmeli3.Clear();
            lblGereken.Visible = true;
            cmbSecmeli1.SelectedItem = null;
            cmbSecmeli2.SelectedItem = null;
            cmbSecmeli3.SelectedItem = null;
            cmbSecmeli1.Text = "        -----Seçiniz-----";
            cmbSecmeli2.Text = "        -----Seçiniz-----";
            cmbSecmeli3.Text = "        -----Seçiniz-----";
            lblBelgesiz.Visible = false;
        }

        private void cmbSecmeli1_SelectedIndexChanged(object sender, EventArgs e)
        {
            enabledcmb();
        }

        private void cmbSecmeli2_SelectedIndexChanged(object sender, EventArgs e)
        {
            enabledcmb();
        }

        private void cmbSecmeli3_SelectedIndexChanged(object sender, EventArgs e)
        {
            enabledcmb();
        }

        private void enabledcmb()
        {
            if (cmbSecmeli1.SelectedItem == "1.Seçmeli Ders (Haftada 1 Saat)") s1saat = 1;
            else if (cmbSecmeli1.SelectedItem == "1.Seçmeli Ders (Haftada 2 Saat)") s1saat = 2;
            else if (cmbSecmeli1.SelectedItem == "1.Seçmeli Ders (Haftada 3 Saat)") s1saat = 3;
            else if (cmbSecmeli1.SelectedItem == "1.Seçmeli Ders (Haftada 4 Saat)") s1saat = 4;

            if (cmbSecmeli2.SelectedItem == "2.Seçmeli Ders (Haftada 1 Saat)") s2saat = 1;
            else if (cmbSecmeli2.SelectedItem == "2.Seçmeli Ders (Haftada 2 Saat)") s2saat = 2;
            else if (cmbSecmeli2.SelectedItem == "2.Seçmeli Ders (Haftada 3 Saat)") s2saat = 3;
            else if (cmbSecmeli2.SelectedItem == "2.Seçmeli Ders (Haftada 4 Saat)") s2saat = 4;

            if (cmbSecmeli3.SelectedItem == "3.Seçmeli Ders (Haftada 1 Saat)") s3saat = 1;
            else if (cmbSecmeli3.SelectedItem == "3.Seçmeli Ders (Haftada 2 Saat)") s3saat = 2;
            else if (cmbSecmeli3.SelectedItem == "3.Seçmeli Ders (Haftada 3 Saat)") s3saat = 3;
            else if (cmbSecmeli3.SelectedItem == "3.Seçmeli Ders (Haftada 4 Saat)") s3saat = 4;

            double secmelist = s1saat + s2saat + s3saat;
            if (secmelist > 5)
            {
                MessageBox.Show("Seçmeli ders saati toplamda 5 ders saati olmalıdır !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmbSecmeli1.Enabled = true;
                cmbSecmeli2.Enabled = true;
                cmbSecmeli3.Enabled = true;
            }
        }
    }
}
