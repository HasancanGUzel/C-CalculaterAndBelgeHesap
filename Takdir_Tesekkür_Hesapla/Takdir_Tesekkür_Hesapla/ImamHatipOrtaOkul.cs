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
    public partial class ImamHatipOrtaOkul : Form
    {
        public ImamHatipOrtaOkul()
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
        DialogResult cikis = new DialogResult();
        private void btnCik_Click(object sender, EventArgs e)
        {
            cikis = MessageBox.Show("Çıkış işlemini onaylıyor musunuz ?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cikis == DialogResult.Yes) Application.Exit();
            else MessageBox.Show("Çıkış işlemi iptal edildi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (rdbSnf5.Checked==true)
            {
                _5_ImamHatip bes = new _5_ImamHatip();
                bes.Show();
                this.Close();
            }
            else if (rdbSnf6.Checked==true)
            {
                _6_ImamHatip alti = new _6_ImamHatip();
                alti.Show();
                this.Close();
            }
            else if (rdbSnf7.Checked==true)
            {
                _7_ImamHatip yedi = new _7_ImamHatip();
                yedi.Show();
                this.Close();
            }
            else if (rdbSnf8.Checked==true)
            {
                _8_ImamHatip sekiz = new _8_ImamHatip();
                sekiz.Show();
                this.Close();
            }
            else if (rdbLgsSnv.Checked==true)
            {
                Lgs.bolum = "imam";
                Lgs lgs = new Lgs();
                lgs.Show();
                this.Close();
            }
        }
    }
}
