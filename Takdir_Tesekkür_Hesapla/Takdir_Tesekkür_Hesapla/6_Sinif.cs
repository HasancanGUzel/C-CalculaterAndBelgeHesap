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
    public partial class _6_Sinif : Form
    {
        public _6_Sinif()
        {
            InitializeComponent();
        }

        DialogResult cik = new DialogResult();
        private void btnCik_Click(object sender, EventArgs e)
        {
            cik = MessageBox.Show("Çıkış işlemini onaylıyor musunuz ?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cik == DialogResult.Yes) Application.Exit();
            else MessageBox.Show("Çıkış işlemi iptal edildi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        OrtaOkulHesap geri = new OrtaOkulHesap();
        SecenekSeviye ana = new SecenekSeviye();
        private void btnGeri_Click(object sender, EventArgs e)
        {
            geri.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ana.Show();
            this.Close();
        }

        double bdnsaat = 2, blsmsaat = 2, dinsaat = 2, fensaat = 4, rsmsaat = 1, matsaat = 5, muzsaat = 1, sossaat = 3, turksaat = 6, ingsaat = 3, s1saat, s2saat, s3saat;
        double beden, bilisim, din, fen, resim, matematik, muzik, sosyal, turkce, ingilizce, secmeli1, secmeli2, secmeli3;
        double ort1, ort2, ort3, ort4, ort5, ort6, ort7, ort8, ort9, ort10, ort11, ort12, ort13;
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
            if (txtResim.Text == "" || txtSecmeli1.Text == "" || txtSecmeli2.Text == "" || txtSecmeli3.Text == "" || txtSosyal.Text == "" || txtTurkce.Text == "" || txtBeden.Text == "" || txtBilisim.Text == "" || txtDin.Text == "" || txtFen.Text == "" || txtIngilizce.Text == "" || txtMat.Text == "" || txtMuzik.Text == "")
            {

            }
            else
            {
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
                    secmeli2 = Convert.ToDouble(txtSecmeli2.Text);
                    secmeli3 = Convert.ToDouble(txtSecmeli3.Text);
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
                ort12 = secmeli2 * s2saat;
                ort13 = secmeli3 * s3saat;

                puan = ort1 + ort2 + ort3 + ort4 + ort5 + ort6 + ort7 + ort8 + ort9 + ort10 + ort11 + ort12 + ort13;
                saat = bdnsaat + blsmsaat + dinsaat + fensaat + rsmsaat + matsaat + muzsaat + sossaat + turksaat + ingsaat + s1saat + s2saat + s3saat;
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
                    if (beden < 50 || bilisim < 50 || resim < 50 || muzik < 50 || turkce < 50 || ingilizce < 50 || sosyal < 50 || din < 50 || fen < 50 || matematik < 50 || secmeli1 < 50 || secmeli2 < 50 || secmeli3 < 50)
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
                    if (beden < 50 || bilisim < 50 || resim < 50 || muzik < 50 || turkce < 50 || ingilizce < 50 || sosyal < 50 || din < 50 || fen < 50 || matematik < 50 || secmeli1 < 50 || secmeli2 < 50 || secmeli3 < 50)
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
            txtSecmeli1.Clear();
            txtSecmeli2.Clear();
            txtSecmeli3.Clear();
            txtSosyal.Clear();
            txtTurkce.Clear();
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
            cmbSaatler();
            double secmelist = s1saat + s2saat + s3saat;
            if (cmbSecmeli1.SelectedItem == "1.Seçmeli Ders (Haftada 4 Saat)" && cmbSecmeli2.SelectedItem == "2.Seçmeli Ders (Haftada 2 Saat)")
            {
                cmbSecmeli3.Enabled = false;
                if (cmbSecmeli1.SelectedItem == "1.Seçmeli Ders (Haftada 3 Saat)" && cmbSecmeli2.SelectedItem == "2.Seçmeli Ders (Haftada 3 Saat)")
                {
                    cmbSecmeli3.Enabled = false;
                }
                else if (cmbSecmeli3.SelectedItem == "3.Seçmeli Ders (Haftada 4 Saat)" && cmbSecmeli2.SelectedItem == "2.Seçmeli Ders (Haftada 2 Saat)")
                {
                    cmbSecmeli1.Enabled = false;
                }
                else if (cmbSecmeli3.SelectedItem == "3.Seçmeli Ders (Haftada 3 Saat)" && cmbSecmeli2.SelectedItem == "2.Seçmeli Ders (Haftada 3 Saat)")
                {
                    cmbSecmeli1.Enabled = false;
                }
                else if (cmbSecmeli1.SelectedItem == "1.Seçmeli Ders (Haftada 4 Saat)" && cmbSecmeli3.SelectedItem == "3.Seçmeli Ders (Haftada 2 Saat)")
                {
                    cmbSecmeli2.Enabled = false;
                }
                else if (cmbSecmeli1.SelectedItem == "1.Seçmeli Ders (Haftada 3 Saat)" && cmbSecmeli2.SelectedItem == "2.Seçmeli Ders (Haftada 3 Saat)")
                {
                    cmbSecmeli2.Enabled = false;
                }
            }
            else if (secmelist > 6)
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
