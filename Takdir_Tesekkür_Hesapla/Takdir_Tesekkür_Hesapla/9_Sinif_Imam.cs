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
    public partial class _9_Sinif_Imam : Form
    {
        public _9_Sinif_Imam()
        {
            InitializeComponent();
        }

        double bdnsaat = 2, cogst = 2, tarihst = 2, fizst = 2, kimyast = 2, biyost = 2, matst = 6, edebiyatst = 5, ybnciBirst = 5, arapcast = 4, dinibilst = 1, kuranst = 5, saglikst = 1, s1saat, s2saat, s3saat;
        double beden, cografya, tarih, fizik, kimya, biyoloji, matematik, edebiyat, yabanciBir, arapca, saglik, dinibilgi, kuran, secmeli1, secmeli2, secmeli3;
        double ort1, ort2, ort3, ort4, ort5, ort6, ort7, ort8, ort9, ort10, ort11, ort12, ort13, ort14, ort15, ort16;
        double saat, puan, gnltoplam;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (txtBeden.Text == "" || txtCografya.Text == "" || txtTarih.Text == "" || txtFizik.Text == "" || txtKimya.Text == "" || txtBiyoloji.Text == "" || txtMatematik.Text == "" || txtEdebiyat.Text == "" || txtYabanciBir.Text == "" || txtArapca.Text == "" || txtSaglik.Text == "" || txtSecmeli1.Text == "" | txtSecmeli2.Text == "" || txtSecmeli3.Text == "")
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
                    edebiyat = Convert.ToDouble(txtEdebiyat.Text);
                    yabanciBir = Convert.ToDouble(txtYabanciBir.Text);
                    arapca = Convert.ToDouble(txtArapca.Text);
                    dinibilgi = Convert.ToDouble(txtDiniBilgi.Text);
                    kuran = Convert.ToDouble(txtKuran.Text);
                    saglik = Convert.ToDouble(txtSaglik.Text);
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
                ort8 = dinibilgi * dinibilst;
                ort9 = edebiyat * edebiyatst;
                ort10 = yabanciBir * ybnciBirst;
                ort11 = arapca * arapcast;
                ort12 = saglik * saglikst;
                ort13 = kuran * kuranst;
                ort14 = secmeli1 * s1saat;
                ort15 = secmeli2 * s2saat;
                ort16 = secmeli3 * s3saat;

                puan = ort1 + ort2 + ort3 + ort4 + ort5 + ort6 + ort7 + ort8 + ort9 + ort10 + ort11 + ort12 + ort13 + ort14 + ort15 + ort16;
                saat = bdnsaat + cogst + tarihst + fizst + kimyast + biyost + matst + dinibilst + edebiyatst + ybnciBirst + arapcast + kuranst + saglikst + s1saat + s2saat + s3saat;
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
                    if (beden < 50 || cografya < 50 || tarih < 50 || fizik < 50 || kimya < 50 || biyoloji < 50 || matematik < 50 || edebiyat < 50 || yabanciBir < 50 || arapca < 50 || kuran < 50 || dinibilgi < 50 || saglik < 50 || secmeli1 < 50 || secmeli2 < 50 || secmeli3 < 50)
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
                    if (beden < 50 || cografya < 50 || tarih < 50 || fizik < 50 || kimya < 50 || biyoloji < 50 || matematik < 50 || edebiyat < 50 || yabanciBir < 50 || arapca < 50 || kuran < 50 || dinibilgi < 50 || saglik < 50 || secmeli1 < 50 || secmeli2 < 50 || secmeli3 < 50)
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
            txtEdebiyat.Clear();
            txtYabanciBir.Clear();
            txtArapca.Clear();
            txtKuran.Clear();
            txtDiniBilgi.Clear();
            txtSaglik.Clear();
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

        DialogResult cik = new DialogResult();
        private void btnCik_Click(object sender, EventArgs e)
        {
            cik = MessageBox.Show("Çıkış işlemini onaylıyor musunuz ?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cik == DialogResult.Yes) Application.Exit();
            else MessageBox.Show("Çıkış işlemi iptal edildi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ImamHatipLisesi geri = new ImamHatipLisesi();
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

        private void cmbSecmeli1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox();
        }

        private void cmbSecmeli2_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox();
        }

        private void cmbSecmeli3_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox();
        }

        private void combobox() 
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
            if (secmelist > 6)
            {
                MessageBox.Show("Seçmeli ders saati toplamda 6 ders saati olmalıdır !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
