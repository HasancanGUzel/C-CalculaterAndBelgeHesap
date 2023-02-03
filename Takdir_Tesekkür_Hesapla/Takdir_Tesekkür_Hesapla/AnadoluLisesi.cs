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
    public partial class AnadoluLisesi : Form
    {
        public AnadoluLisesi()
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

        Lise geri = new Lise();
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

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (rdbSnf9.Checked==true)
            {
                _9_Sinif dokuz = new _9_Sinif();
                dokuz.Show();
                this.Close();
            }
            else if (rdbSnf10.Checked==true)
            {
                _10_Sinif on = new _10_Sinif();
                on.Show();
                this.Close();
            }
            else if (rdbSnf11.Checked==true)
            {
                _11_Sinif onbir = new _11_Sinif();
                onbir.Show();
                this.Close();
            }
            else if (rdbSnf12.Checked==true)
            {
                _12_Sinif onoiki = new _12_Sinif();
                onoiki.Show();
                this.Close();   
            }
            else if (rdbYks.Checked==true)
            {
                Yks yks = new Yks();
                yks.Show();
                this.Close();
            }
        }
    }
}
