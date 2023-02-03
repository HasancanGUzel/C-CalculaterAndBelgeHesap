namespace hesap_makinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_giris = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_carpma = new System.Windows.Forms.Button();
            this.btn_bolme = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_cikarma = new System.Windows.Forms.Button();
            this.btn_karekok = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btn_toplama = new System.Windows.Forms.Button();
            this.btn_karesi = new System.Windows.Forms.Button();
            this.btn_isaretdeğis = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btn_virgul = new System.Windows.Forms.Button();
            this.btn_sonuc = new System.Windows.Forms.Button();
            this.btn_faktoriyel = new System.Windows.Forms.Button();
            this.btn_kuvvet = new System.Windows.Forms.Button();
            this.btn_teksil = new System.Windows.Forms.Button();
            this.btn_hepsisilme = new System.Windows.Forms.Button();
            this.btn_txtdegersilme = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_giris
            // 
            this.txt_giris.Location = new System.Drawing.Point(49, 69);
            this.txt_giris.Name = "txt_giris";
            this.txt_giris.Size = new System.Drawing.Size(228, 20);
            this.txt_giris.TabIndex = 0;
            this.txt_giris.Text = "0";
            this.txt_giris.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_giris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_girissadesayı);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(49, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(95, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(141, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_carpma
            // 
            this.btn_carpma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_carpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_carpma.Location = new System.Drawing.Point(237, 142);
            this.btn_carpma.Name = "btn_carpma";
            this.btn_carpma.Size = new System.Drawing.Size(40, 40);
            this.btn_carpma.TabIndex = 4;
            this.btn_carpma.Text = "*";
            this.btn_carpma.UseVisualStyleBackColor = true;
            this.btn_carpma.Click += new System.EventHandler(this.btn_carpma_Click);
            // 
            // btn_bolme
            // 
            this.btn_bolme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bolme.Location = new System.Drawing.Point(187, 142);
            this.btn_bolme.Name = "btn_bolme";
            this.btn_bolme.Size = new System.Drawing.Size(40, 40);
            this.btn_bolme.TabIndex = 5;
            this.btn_bolme.Text = "÷";
            this.btn_bolme.UseVisualStyleBackColor = true;
            this.btn_bolme.Click += new System.EventHandler(this.btn_bolme_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(49, 234);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(95, 234);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 7;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Location = new System.Drawing.Point(141, 234);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 40);
            this.button8.TabIndex = 8;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_cikarma
            // 
            this.btn_cikarma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cikarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikarma.Location = new System.Drawing.Point(187, 187);
            this.btn_cikarma.Name = "btn_cikarma";
            this.btn_cikarma.Size = new System.Drawing.Size(40, 40);
            this.btn_cikarma.TabIndex = 9;
            this.btn_cikarma.Text = "-";
            this.btn_cikarma.UseVisualStyleBackColor = true;
            this.btn_cikarma.Click += new System.EventHandler(this.btn_cikarma_Click);
            // 
            // btn_karekok
            // 
            this.btn_karekok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_karekok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_karekok.Location = new System.Drawing.Point(141, 143);
            this.btn_karekok.Name = "btn_karekok";
            this.btn_karekok.Size = new System.Drawing.Size(40, 40);
            this.btn_karekok.TabIndex = 10;
            this.btn_karekok.Text = "√";
            this.btn_karekok.UseVisualStyleBackColor = true;
            this.btn_karekok.Click += new System.EventHandler(this.btn_karekok_Click);
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Location = new System.Drawing.Point(49, 280);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 40);
            this.button11.TabIndex = 11;
            this.button11.Text = "1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Location = new System.Drawing.Point(95, 280);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(40, 40);
            this.button12.TabIndex = 12;
            this.button12.Text = "2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.Location = new System.Drawing.Point(141, 280);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(40, 40);
            this.button13.TabIndex = 13;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // btn_toplama
            // 
            this.btn_toplama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_toplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_toplama.Location = new System.Drawing.Point(237, 188);
            this.btn_toplama.Name = "btn_toplama";
            this.btn_toplama.Size = new System.Drawing.Size(40, 40);
            this.btn_toplama.TabIndex = 14;
            this.btn_toplama.Text = "+";
            this.btn_toplama.UseVisualStyleBackColor = true;
            this.btn_toplama.Click += new System.EventHandler(this.btn_toplama_Click);
            // 
            // btn_karesi
            // 
            this.btn_karesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_karesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_karesi.Location = new System.Drawing.Point(95, 143);
            this.btn_karesi.Name = "btn_karesi";
            this.btn_karesi.Size = new System.Drawing.Size(40, 40);
            this.btn_karesi.TabIndex = 15;
            this.btn_karesi.Text = "x²";
            this.btn_karesi.UseVisualStyleBackColor = true;
            this.btn_karesi.Click += new System.EventHandler(this.btn_karesi_Click);
            // 
            // btn_isaretdeğis
            // 
            this.btn_isaretdeğis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_isaretdeğis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_isaretdeğis.Location = new System.Drawing.Point(187, 234);
            this.btn_isaretdeğis.Name = "btn_isaretdeğis";
            this.btn_isaretdeğis.Size = new System.Drawing.Size(40, 85);
            this.btn_isaretdeğis.TabIndex = 16;
            this.btn_isaretdeğis.Text = "+/-";
            this.btn_isaretdeğis.UseVisualStyleBackColor = true;
            this.btn_isaretdeğis.Click += new System.EventHandler(this.btn_isaretdeğis_Click);
            // 
            // button17
            // 
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.Location = new System.Drawing.Point(49, 326);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(132, 40);
            this.button17.TabIndex = 17;
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // btn_virgul
            // 
            this.btn_virgul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_virgul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_virgul.Location = new System.Drawing.Point(187, 325);
            this.btn_virgul.Name = "btn_virgul";
            this.btn_virgul.Size = new System.Drawing.Size(40, 40);
            this.btn_virgul.TabIndex = 18;
            this.btn_virgul.Text = ",";
            this.btn_virgul.UseVisualStyleBackColor = true;
            this.btn_virgul.Click += new System.EventHandler(this.btn_virgul_Click);
            // 
            // btn_sonuc
            // 
            this.btn_sonuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sonuc.Location = new System.Drawing.Point(237, 234);
            this.btn_sonuc.Name = "btn_sonuc";
            this.btn_sonuc.Size = new System.Drawing.Size(40, 132);
            this.btn_sonuc.TabIndex = 19;
            this.btn_sonuc.Text = "=";
            this.btn_sonuc.UseVisualStyleBackColor = true;
            this.btn_sonuc.Click += new System.EventHandler(this.btn_sonuc_Click);
            // 
            // btn_faktoriyel
            // 
            this.btn_faktoriyel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_faktoriyel.Location = new System.Drawing.Point(49, 95);
            this.btn_faktoriyel.Name = "btn_faktoriyel";
            this.btn_faktoriyel.Size = new System.Drawing.Size(40, 40);
            this.btn_faktoriyel.TabIndex = 20;
            this.btn_faktoriyel.Text = "x!";
            this.btn_faktoriyel.UseVisualStyleBackColor = true;
            this.btn_faktoriyel.Click += new System.EventHandler(this.btn_faktoriyel_Click);
            // 
            // btn_kuvvet
            // 
            this.btn_kuvvet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kuvvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kuvvet.Location = new System.Drawing.Point(49, 144);
            this.btn_kuvvet.Name = "btn_kuvvet";
            this.btn_kuvvet.Size = new System.Drawing.Size(40, 40);
            this.btn_kuvvet.TabIndex = 21;
            this.btn_kuvvet.Text = "^";
            this.btn_kuvvet.UseVisualStyleBackColor = true;
            this.btn_kuvvet.Click += new System.EventHandler(this.btn_kuvvet_Click);
            // 
            // btn_teksil
            // 
            this.btn_teksil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_teksil.Location = new System.Drawing.Point(237, 98);
            this.btn_teksil.Name = "btn_teksil";
            this.btn_teksil.Size = new System.Drawing.Size(40, 40);
            this.btn_teksil.TabIndex = 22;
            this.btn_teksil.Text = "←";
            this.btn_teksil.UseVisualStyleBackColor = true;
            this.btn_teksil.Click += new System.EventHandler(this.btn_teksil_Click);
            // 
            // btn_hepsisilme
            // 
            this.btn_hepsisilme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hepsisilme.Location = new System.Drawing.Point(187, 96);
            this.btn_hepsisilme.Name = "btn_hepsisilme";
            this.btn_hepsisilme.Size = new System.Drawing.Size(40, 40);
            this.btn_hepsisilme.TabIndex = 23;
            this.btn_hepsisilme.Text = "C";
            this.btn_hepsisilme.UseVisualStyleBackColor = true;
            this.btn_hepsisilme.Click += new System.EventHandler(this.btn_hepsisilme_Click);
            // 
            // btn_txtdegersilme
            // 
            this.btn_txtdegersilme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_txtdegersilme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_txtdegersilme.Location = new System.Drawing.Point(141, 96);
            this.btn_txtdegersilme.Name = "btn_txtdegersilme";
            this.btn_txtdegersilme.Size = new System.Drawing.Size(40, 40);
            this.btn_txtdegersilme.TabIndex = 24;
            this.btn_txtdegersilme.Text = "CE";
            this.btn_txtdegersilme.UseVisualStyleBackColor = true;
            this.btn_txtdegersilme.Click += new System.EventHandler(this.btn_txtdegersilme_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mod.Location = new System.Drawing.Point(95, 95);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(40, 40);
            this.btn_mod.TabIndex = 25;
            this.btn_mod.Text = "%";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(242, 50);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(0, 13);
            this.lbl_sonuc.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(324, 450);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_txtdegersilme);
            this.Controls.Add(this.btn_hepsisilme);
            this.Controls.Add(this.btn_teksil);
            this.Controls.Add(this.btn_kuvvet);
            this.Controls.Add(this.btn_faktoriyel);
            this.Controls.Add(this.btn_sonuc);
            this.Controls.Add(this.btn_virgul);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.btn_isaretdeğis);
            this.Controls.Add(this.btn_karesi);
            this.Controls.Add(this.btn_toplama);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btn_karekok);
            this.Controls.Add(this.btn_cikarma);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_bolme);
            this.Controls.Add(this.btn_carpma);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_giris);
            this.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_giris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_carpma;
        private System.Windows.Forms.Button btn_bolme;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btn_cikarma;
        private System.Windows.Forms.Button btn_karekok;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btn_toplama;
        private System.Windows.Forms.Button btn_karesi;
        private System.Windows.Forms.Button btn_isaretdeğis;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btn_virgul;
        private System.Windows.Forms.Button btn_sonuc;
        private System.Windows.Forms.Button btn_faktoriyel;
        private System.Windows.Forms.Button btn_kuvvet;
        private System.Windows.Forms.Button btn_teksil;
        private System.Windows.Forms.Button btn_hepsisilme;
        private System.Windows.Forms.Button btn_txtdegersilme;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

