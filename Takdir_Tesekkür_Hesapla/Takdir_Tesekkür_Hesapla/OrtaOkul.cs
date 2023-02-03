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
    public partial class OrtaOkul : Form
    {
        public OrtaOkul()
        {
            InitializeComponent();
        }

        private void btnOrta_Click(object sender, EventArgs e)
        {
            OrtaOkulHesap hsp = new OrtaOkulHesap();
            hsp.Show();
            this.Close();
        }

        private void btnImam_Click(object sender, EventArgs e)
        {
            ImamHatipOrtaOkul imam = new ImamHatipOrtaOkul();
            imam.Show();
            this.Close();
        }

        private void btnOrta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SecenekSeviye seviye = new SecenekSeviye();
                seviye.Show();
                this.Close();
            }
            else
            {

            }
        }

        private void btnImam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SecenekSeviye seviye = new SecenekSeviye();
                seviye.Show();
                this.Close();
            }
            else
            {

            }
        }
    }
}
