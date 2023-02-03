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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            tmrGiris.Enabled = true;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.BackColor = Color.White;
            progressBar1.ForeColor = Color.Red;
        }
        
        private void tmrGiris_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                this.Hide();
                tmrGiris.Enabled = false;
                SecenekSeviye seviye = new SecenekSeviye();
                seviye.Show();
            }
            else progressBar1.Value = progressBar1.Value + 1;
        }
    }
}
