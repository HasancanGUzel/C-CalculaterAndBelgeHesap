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
    public partial class SecenekSeviye : Form
    {
        public SecenekSeviye()
        {
            InitializeComponent();
        }

        OrtaOkul ort2 = new OrtaOkul();
        private void btnOrtaOkul_Click(object sender, EventArgs e)
        {           
            ort2.Show();
            this.Close();
        }

        Lise lise = new Lise();
        private void btnLise_Click(object sender, EventArgs e)
        {           
            lise.Show();
            this.Close();
        }
    }
}
