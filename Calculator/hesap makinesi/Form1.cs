using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string secim;
        double deger1, deger2;

        private void button11_Click(object sender, EventArgs e)
        {
            if (txt_giris.Text == "0")   
            {
                txt_giris.Text = "1";
            }
            else
            {
                txt_giris.Text += "1";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txt_giris.Text == "0")
            {
                txt_giris.Text = "2";
            }
            else
            {
                txt_giris.Text += "2";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txt_giris.Text == "0")
            {
                txt_giris.Text = "3";
            }
            else
            {
                txt_giris.Text += "3";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txt_giris.Text == "0")
            {
                txt_giris.Text = "4";
            }
            else
            {
                txt_giris.Text += "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txt_giris.Text == "0")
            {
                txt_giris.Text = "5";
            }
            else
            {
                txt_giris.Text += "5";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txt_giris.Text == "0")
            {
                txt_giris.Text = "6";
            }
            else
            {
                txt_giris.Text += "6";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_giris.Text == "0")
            {
                txt_giris.Text = "7";
            }
            else
            {
                txt_giris.Text += "7";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_giris.Text == "0")
            {
                txt_giris.Text = "8";
            }
            else
            {
                txt_giris.Text += "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_giris.Text == "0")
            {
                txt_giris.Text = "9";
            }
            else
            {
                txt_giris.Text += "9";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txt_giris.Text == "0")
            {
                txt_giris.Text = "0";
            }
            else
            {
                txt_giris.Text += "0";
            }

        }

        private void btn_teksil_Click(object sender, EventArgs e)
        {

            
            if (string.IsNullOrEmpty(txt_giris.Text))
            {
                txt_giris.Text = "0";
               
            }
            else
            {
                double silme = Convert.ToDouble(txt_giris.Text);
                if (silme > 0)
                {
                    txt_giris.Text = txt_giris.Text.Remove(txt_giris.Text.Length - 1, 1);
                    if (txt_giris.Text.Length == 0)
                    {
                        txt_giris.Text = "0";

                    }
                }
            }
           
        }


        private void btn_txtdegersilme_Click(object sender, EventArgs e)
        {
            txt_giris.Text = "0";

        }

        private void btn_hepsisilme_Click(object sender, EventArgs e)
        {
            txt_giris.Text = "0";
            lbl_sonuc.Text = " ";


        }

        private void btn_toplama_Click(object sender, EventArgs e)
        {
            
            deger1 = Convert.ToDouble(txt_giris.Text);
            secim = "+";
            lbl_sonuc.Text = deger1 + "+";
            txt_giris.Text = "0";

        }

        private void btn_cikarma_Click(object sender, EventArgs e)
        {
            deger1 = Convert.ToDouble(txt_giris.Text);
            secim = "-";
            lbl_sonuc.Text = deger1 + "-";
            txt_giris.Text = "0";
        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {
            deger1 = Convert.ToDouble(txt_giris.Text);
            secim = "/";
            lbl_sonuc.Text = deger1 + "/";
            txt_giris.Text = "0";
        }

        private void btn_carpma_Click(object sender, EventArgs e)
        {
            deger1 = Convert.ToDouble(txt_giris.Text);
            secim = "*";
            lbl_sonuc.Text = deger1 + "*";
            txt_giris.Text = "0";
        }

        private void btn_karesi_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(txt_giris.Text);
            lbl_sonuc.Text = (kare + "*" + kare + "=");
            kare = Math.Pow(kare, 2);
            txt_giris.Text = kare.ToString();
            
        }

        private void btn_karekok_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(txt_giris.Text);
            lbl_sonuc.Text = ("Sqrt" + karekok +  "=");
            karekok = Math.Sqrt(karekok);
            txt_giris.Text = karekok.ToString();
        }

        private void btn_isaretdeğis_Click(object sender, EventArgs e)
        {
            double degis =Convert.ToDouble(txt_giris.Text);
            degis *= -1;
            txt_giris.Text = degis.ToString();
        }

        private void btn_kuvvet_Click(object sender, EventArgs e)
        {

            deger1 = Convert.ToDouble(txt_giris.Text);
            secim = "^";
            lbl_sonuc.Text = deger1 + "^";
            txt_giris.Text = "0";
        }

        private void btn_faktoriyel_Click(object sender, EventArgs e)
        {
            
            double faktoriyel = 1;
            int sayi = Convert.ToInt32(txt_giris.Text);
            lbl_sonuc.Text = sayi+"! =";
            for (int i = sayi; i >= 1; i--)
            {
                faktoriyel *= i;
            }
            txt_giris.Text = faktoriyel.ToString();

        }

        private void btn_mod_Click(object sender, EventArgs e)
        {

            deger1 = Convert.ToDouble(txt_giris.Text);
            secim = "%";
            lbl_sonuc.Text = deger1 + "%";
            txt_giris.Text = "0";
        }

        private void btn_virgul_Click(object sender, EventArgs e)
        {
            if (txt_giris.Text == "0")
            {
                txt_giris.Text = "0";
            }
            else 
            {
                deger1 = Convert.ToDouble(txt_giris.Text);
                txt_giris.Text = deger1.ToString() + ",";
            }
        }

        private void txt_girissadesayı(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '%' && e.KeyChar != '^' && e.KeyChar != '+' &&
             e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/';
        }

        private void btn_sonuc_Click(object sender, EventArgs e)
        {
            deger2 = Convert.ToDouble(txt_giris.Text);
            if (secim=="+")
            {
                lbl_sonuc.Text = (deger1 + "+" + deger2 + "=");
                txt_giris.Text = (deger1 + deger2).ToString();
              
            }
           else if (secim == "-")
            {

                lbl_sonuc.Text = (deger1 + "-" + deger2 + "=");
                txt_giris.Text = (deger1 - deger2).ToString();
            }
            else if (secim == "*")
            {

                lbl_sonuc.Text = (deger1 + "*" + deger2 + "=");
                txt_giris.Text = (deger1 * deger2).ToString();
            }
            else if (secim == "/")
            {

                lbl_sonuc.Text = (deger1 + "/" + deger2 + "=");
                txt_giris.Text = (deger1 / deger2).ToString();
            }
            else if (secim == "%")
            {

                lbl_sonuc.Text = (deger1 + "%" + deger2 + "=");
                txt_giris.Text = (deger1 % deger2).ToString();
            }
            else if (secim == "^")
            {

                lbl_sonuc.Text = (deger1 + "^" + deger2 + "=");
                double kuvvet = 1;
                for(int i=1;i<=deger2;i++)
                {
                    kuvvet *= deger1;
                }

                txt_giris.Text = kuvvet.ToString();


                   
            }
        }
    }
}
