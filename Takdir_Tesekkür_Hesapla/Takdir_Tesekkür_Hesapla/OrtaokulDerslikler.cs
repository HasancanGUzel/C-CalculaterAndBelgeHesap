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
    public partial class OrtaOkulHesap : Form
    {
        public OrtaOkulHesap()
        {
            InitializeComponent();
        }

        OrtaOkul ortokl = new OrtaOkul();
        private void btnGeri_Click(object sender, EventArgs e)
        {
            ortokl.Show();
            this.Close();
        }

        SecenekSeviye svye = new SecenekSeviye();
        private void btnHome_Click(object sender, EventArgs e)
        {
            svye.Show();
            this.Close();
        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (rdbSinif5.Checked==true)
            {
                _5_Sinif hesap = new _5_Sinif();
                hesap.Show();
                this.Close();
            }
            else if (rdbSinif6.Checked==true)
            {
                _6_Sinif altıncı = new _6_Sinif();
                altıncı.Show();
                this.Close();
            }
            else if (rdbSinif7.Checked == true)
            {
                _7_Sinif yedi = new _7_Sinif();
                yedi.Show();
                this.Close();
            }
            else if (rdbSinif8.Checked == true)
            {
                _8_Sinif sekiz = new _8_Sinif();
                sekiz.Show();
                this.Close();
            }
            else if (rdbLgs.Checked == true)
            {
                Lgs.bolum = "orta";
                Lgs lgs = new Lgs();
                lgs.Show();
                this.Close();
            }
        }

        DialogResult cikis = new DialogResult();
        private void btnCik_Click(object sender, EventArgs e)
        {
            cikis = MessageBox.Show("Çıkış işlemini onaylıyor musunuz ?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cikis == DialogResult.Yes) Application.Exit();
            else MessageBox.Show("Çıkış işlemi iptal edildi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
