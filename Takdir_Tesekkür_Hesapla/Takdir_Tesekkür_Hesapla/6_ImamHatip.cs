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
    public partial class _6_ImamHatip : Form
    {
        public _6_ImamHatip()
        {
            InitializeComponent();
        }

        ImamHatipOrtaOkul geri = new ImamHatipOrtaOkul();
        SecenekSeviye ana = new SecenekSeviye();
        private void btnHome_Click(object sender, EventArgs e)
        {
            ana.Show();
            this.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            geri.Show();
            this.Close();
        }

        DialogResult cik = new DialogResult();
        private void btnCik_Click(object sender, EventArgs e)
        {
            cik = MessageBox.Show("Çıkış işlemini onaylıyor musunuz ?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cik == DialogResult.Yes) Application.Exit();
            else MessageBox.Show("Çıkış işlemi iptal edildi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        double bdnsaat = 1, blsmsaat = 2, dinsaat = 2, fensaat = 4, rsmsaat = 1, matsaat = 5, muzsaat = 1, sossaat = 3, turksaat = 6, ingsaat = 3, arpcasaat = 2, kuransaat = 2, siyersaat = 2, diniBilsaat = 1, s1saat;
        double beden, bilisim, din, fen, resim, matematik, muzik, sosyal, turkce, ingilizce, arapca, siyer, kuran, dinibilgiler, secmeli1;
        double ort1, ort2, ort3, ort4, ort5, ort6, ort7, ort8, ort9, ort10, ort11, ort12, ort13, ort14, ort15;
        double saat, puan, gnltoplam;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (txtTemelDini.Text==""|| txtKuran.Text == "" || txtResim.Text == "" || txtSecmeli1.Text == "" || txtArapca.Text == "" || txtSiyer.Text == "" || txtSosyal.Text == "" || txtTurkce.Text == "" || txtBeden.Text == "" || txtBilisim.Text == "" || txtDin.Text == "" || txtFen.Text == "" || txtIngilizce.Text == "" || txtMat.Text == "" || txtMuzik.Text == "")
            {

            }
            else
            {
                if (cmbSecmeli1.SelectedItem == "1.Seçmeli Ders (Haftada 1 Saat)") s1saat = 1;
                else
                {
                }

                try
                {
                    beden = Convert.ToDouble(txtBeden.Text);
                    bilisim = Convert.ToDouble(txtBilisim.Text);
                    din = Convert.ToDouble(txtDin.Text);
                    fen = Convert.ToDouble(txtFen.Text);
                    resim = Convert.ToDouble(txtResim.Text);
                    matematik = Convert.ToDouble(txtMat.Text);
                    muzik = Convert.ToDouble(txtMuzik.Text);
                    sosyal = Convert.ToDouble(txtSosyal.Text);
                    turkce = Convert.ToDouble(txtTurkce.Text);
                    ingilizce = Convert.ToDouble(txtIngilizce.Text);
                    secmeli1 = Convert.ToDouble(txtSecmeli1.Text);
                    arapca = Convert.ToDouble(txtArapca.Text);
                    siyer = Convert.ToDouble(txtSiyer.Text);
                    kuran = Convert.ToDouble(txtKuran.Text);
                    dinibilgiler = Convert.ToDouble(txtTemelDini.Text);
                }
                catch
                {
                }

                //ağırlıklı not ortalamaları için//
                ort1 = beden * bdnsaat;
                ort2 = bilisim * blsmsaat;
                ort3 = din * dinsaat;
                ort4 = fen * fensaat;
                ort5 = resim * rsmsaat;
                ort6 = matematik * matsaat;
                ort7 = muzik * muzsaat;
                ort8 = sosyal * sossaat;
                ort9 = turkce * turksaat;
                ort10 = ingilizce * ingsaat;
                ort11 = secmeli1 * s1saat;
                ort12 = arapca * arpcasaat;
                ort13 = kuran * kuransaat;
                ort14 = siyer * siyersaat;
                ort15 = dinibilgiler * diniBilsaat;

                puan = ort1 + ort2 + ort3 + ort4 + ort5 + ort6 + ort7 + ort8 + ort9 + ort10 + ort11 + ort12 + ort13 + ort14 + ort15;
                saat = bdnsaat + blsmsaat + dinsaat + fensaat + rsmsaat + matsaat + muzsaat + sossaat + turksaat + ingsaat + s1saat + kuransaat + siyersaat + arpcasaat + diniBilsaat;
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
                    if (dinibilgiler<50||beden < 50 || bilisim < 50 || din < 50 || fen < 50 || resim < 50 || muzik < 50 || matematik < 50 || sosyal < 50 || turkce < 50 || ingilizce < 50 || secmeli1 < 50 || arapca < 50 || siyer < 50 || kuran < 50)
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
                    if (dinibilgiler < 50 || beden < 50 || bilisim < 50 || din < 50 || fen < 50 || resim < 50 || muzik < 50 || matematik < 50 || sosyal < 50 || turkce < 50 || ingilizce < 50 || secmeli1 < 50 || arapca < 50 || siyer < 50 || kuran < 50)
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
            txtBeden.Clear();
            txtBilisim.Clear();
            txtDin.Clear();
            txtFen.Clear();
            txtIngilizce.Clear();
            txtGnlTplm.Clear();
            txtMat.Clear();
            txtMuzik.Clear();
            txtResim.Clear();
            txtArapca.Clear();
            txtSiyer.Clear();
            txtKuran.Clear();
            txtSecmeli1.Clear();
            txtSosyal.Clear();
            txtTurkce.Clear();
            txtTemelDini.Clear();
            lblGereken.Visible = true;
            cmbSecmeli1.SelectedItem = null;
            cmbSecmeli1.Text = "        -----Seçiniz-----";
            lblBelgesiz.Visible = false;
        }
    }
}
