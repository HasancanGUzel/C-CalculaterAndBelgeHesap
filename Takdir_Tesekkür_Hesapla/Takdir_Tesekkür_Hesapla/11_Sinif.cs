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
    public partial class _11_Sinif : Form
    {
        public _11_Sinif()
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
    }
}
