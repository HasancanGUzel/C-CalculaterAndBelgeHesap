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
    public partial class _8_Sinif : Form
    {
        public _8_Sinif()
        {
            InitializeComponent();
        }

        OrtaOkulHesap geri = new OrtaOkulHesap();
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

        double bdnsaat = 2, tknlojisaat = 2, dinsaat = 2, fensaat = 4, rsmsaat = 1, matsaat = 5, muzsaat = 1, tcsaat = 2, turksaat = 5, ingsaat = 4,kariyersaat=1, s1saat, s2saat, s3saat;
        double beden, teknoloji, din, fen, resim, matematik, muzik, inkilap, turkce, ingilizce,kariyer, secmeli1, secmeli2, secmeli3;
        double ort1, ort2, ort3, ort4, ort5, ort6, ort7, ort8, ort9, ort10, ort11, ort12, ort13, ort14;
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
            if (txtKariyer.Text== "" ||txtResim.Text == "" || txtSecmeli1.Text == "" || txtSecmeli2.Text == "" || txtSecmeli3.Text == "" || txtInkılap.Text == "" || txtTurkce.Text == "" || txtBeden.Text == "" || txtTeknoloji.Text == "" || txtDin.Text == "" || txtFen.Text == "" || txtIngilizce.Text == "" || txtMat.Text == "" || txtMuzik.Text == "")
            {

            }
            else
            {

            }
            try
            {
                beden = Convert.ToDouble(txtBeden.Text);
                teknoloji = Convert.ToDouble(txtTeknoloji.Text);
                din = Convert.ToDouble(txtDin.Text);
                fen = Convert.ToDouble(txtFen.Text);
                resim = Convert.ToDouble(txtResim.Text);
                matematik = Convert.ToDouble(txtMat.Text);
                muzik = Convert.ToDouble(txtMuzik.Text);
                inkilap = Convert.ToDouble(txtInkılap.Text);
                turkce = Convert.ToDouble(txtTurkce.Text);
                ingilizce = Convert.ToDouble(txtIngilizce.Text);
                kariyer = Convert.ToDouble(txtKariyer.Text);
                secmeli1 = Convert.ToDouble(txtSecmeli1.Text);
                secmeli2 = Convert.ToDouble(txtSecmeli2.Text);
                secmeli3 = Convert.ToDouble(txtSecmeli3.Text);
            }
            catch
            {
            }

            //ağırlıklı not ortalamaları için//
            ort1 = beden * bdnsaat;
            ort2 = teknoloji * tknlojisaat;
            ort3 = din * dinsaat;
            ort4 = fen * fensaat;
            ort5 = resim * rsmsaat;
            ort6 = matematik * matsaat;
            ort7 = muzik * muzsaat;
            ort8 = inkilap * tcsaat;
            ort9 = turkce * turksaat;
            ort10 = ingilizce * ingsaat;
            ort11 = secmeli1 * s1saat;
            ort12 = secmeli2 * s2saat;
            ort13 = secmeli3 * s3saat;
            ort14 = kariyer * kariyersaat;

            puan = ort1 + ort2 + ort3 + ort4 + ort5 + ort6 + ort7 + ort8 + ort9 + ort10 + ort11 + ort12 + ort13 + ort14;
            saat = bdnsaat + tknlojisaat + dinsaat + fensaat + rsmsaat + matsaat + muzsaat + tcsaat + turksaat + ingsaat + kariyersaat + s1saat + s2saat + s3saat;
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
                if (kariyer<50||beden < 50 || teknoloji < 50 || resim < 50 || muzik < 50 || turkce < 50 || ingilizce < 50 || inkilap < 50 || din < 50 || fen < 50 || matematik < 50 || secmeli1 < 50 || secmeli2 < 50 || secmeli3 < 50)
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
                if (kariyer < 50 || beden < 50 || teknoloji < 50 || resim < 50 || muzik < 50 || turkce < 50 || ingilizce < 50 || inkilap < 50 || din < 50 || fen < 50 || matematik < 50 || secmeli1 < 50 || secmeli2 < 50 || secmeli3 < 50)
                {
                    lblBelgesiz.Visible = true;
                    pctBelge.Visible = false;
                    lblBelgesiz.Text = "                   ÜZGÜNÜZ \nHİÇ BİR BELGE ALAMIYORSUNUZ.\nÇÜNKÜ 50 ' nin ALTINDA NOT VAR.";
                }

            }
            this.Width = 1019;
            this.CenterToScreen();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            gnltoplam = 0;
            txtGnlTplm.Text = "";
            this.Width = 446;
            this.CenterToScreen();
            txtBeden.Clear();
            txtTeknoloji.Clear();
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
            txtInkılap.Clear();
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
