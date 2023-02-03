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
    public partial class ImamHatipLisesi : Form
    {
        public ImamHatipLisesi()
        {
            InitializeComponent();
        }

        SecenekSeviye anasayfa = new SecenekSeviye();
        private void btnHome_Click(object sender, EventArgs e)
        {
            anasayfa.Show();
            this.Close();
        }

        Lise geri = new Lise();
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

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (rdbSnf9.Checked == true)
            {
                _9_Sinif_Imam dokuz = new _9_Sinif_Imam();
                dokuz.Show();
                this.Close();
            }
            else if (rdbSnf10.Checked == true)
            {
                _10_Sinif_Imam on = new _10_Sinif_Imam();
                on.Show();
                this.Close();
            }
            else if (rdbSnf11.Checked == true)
            {
                _11_Sinif_Imam onbir = new _11_Sinif_Imam();
                onbir.Show();
                this.Close();
            }
            else if (rdbSnf12.Checked == true)
            {
                _12_Sinif_Imam oniki = new _12_Sinif_Imam();
                oniki.Show();
                this.Close();
            }
            else if (rdbYks.Checked == true)
            {
                Yks yks = new Yks();
                yks.Show();
                this.Close();
            }
        }

        private void rdbSnf9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbSnf10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbSnf11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbSnf12_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
