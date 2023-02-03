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
    public partial class _10_Sinif : Form
    {
        public _10_Sinif()
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

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

        }

        private void cmbSecmeli3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSecmeli2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSecmeli1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
