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
    public partial class Lise : Form
    {
        public Lise()
        {
            InitializeComponent();
        }

        private void btnAnadolu_Click(object sender, EventArgs e)
        {
            AnadoluLisesi anadolu = new AnadoluLisesi();
            anadolu.Show();
            this.Close();
        }

        private void btnImam_Click(object sender, EventArgs e)
        {
            ImamHatipLisesi imam = new ImamHatipLisesi();
            imam.Show();
            this.Close();
        }

        private void btnMeslek_Click(object sender, EventArgs e)
        {

        }

        private void btnAnadolu_KeyDown(object sender, KeyEventArgs e)
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

        private void btnMeslek_KeyDown(object sender, KeyEventArgs e)
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
