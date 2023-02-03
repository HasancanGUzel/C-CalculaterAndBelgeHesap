namespace Takdir_Tesekkür_Hesapla
{
    partial class Lise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lise));
            this.btnMeslek = new System.Windows.Forms.Button();
            this.btnImam = new System.Windows.Forms.Button();
            this.btnAnadolu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMeslek
            // 
            this.btnMeslek.BackgroundImage = global::Takdir_Tesekkür_Hesapla.Properties.Resources.back1;
            this.btnMeslek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMeslek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeslek.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeslek.ForeColor = System.Drawing.Color.Blue;
            this.btnMeslek.Location = new System.Drawing.Point(12, 249);
            this.btnMeslek.Name = "btnMeslek";
            this.btnMeslek.Size = new System.Drawing.Size(244, 100);
            this.btnMeslek.TabIndex = 4;
            this.btnMeslek.Text = "ENDÜSTRİ MESLEK";
            this.btnMeslek.UseVisualStyleBackColor = true;
            this.btnMeslek.Click += new System.EventHandler(this.btnMeslek_Click);
            this.btnMeslek.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnMeslek_KeyDown);
            // 
            // btnImam
            // 
            this.btnImam.BackgroundImage = global::Takdir_Tesekkür_Hesapla.Properties.Resources.back1;
            this.btnImam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImam.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnImam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImam.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImam.ForeColor = System.Drawing.Color.Blue;
            this.btnImam.Location = new System.Drawing.Point(12, 130);
            this.btnImam.Name = "btnImam";
            this.btnImam.Size = new System.Drawing.Size(244, 100);
            this.btnImam.TabIndex = 3;
            this.btnImam.Text = "İMAM HATİP";
            this.btnImam.UseVisualStyleBackColor = true;
            this.btnImam.Click += new System.EventHandler(this.btnImam_Click);
            this.btnImam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnImam_KeyDown);
            // 
            // btnAnadolu
            // 
            this.btnAnadolu.BackgroundImage = global::Takdir_Tesekkür_Hesapla.Properties.Resources.back1;
            this.btnAnadolu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnadolu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnadolu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadolu.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadolu.ForeColor = System.Drawing.Color.Blue;
            this.btnAnadolu.Location = new System.Drawing.Point(12, 12);
            this.btnAnadolu.Name = "btnAnadolu";
            this.btnAnadolu.Size = new System.Drawing.Size(244, 100);
            this.btnAnadolu.TabIndex = 2;
            this.btnAnadolu.Text = "ANADOLU";
            this.btnAnadolu.UseVisualStyleBackColor = true;
            this.btnAnadolu.Click += new System.EventHandler(this.btnAnadolu_Click);
            this.btnAnadolu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAnadolu_KeyDown);
            // 
            // Lise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(268, 361);
            this.Controls.Add(this.btnMeslek);
            this.Controls.Add(this.btnImam);
            this.Controls.Add(this.btnAnadolu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LİSE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImam;
        private System.Windows.Forms.Button btnAnadolu;
        private System.Windows.Forms.Button btnMeslek;
    }
}