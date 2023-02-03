namespace Takdir_Tesekkür_Hesapla
{
    partial class SecenekSeviye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecenekSeviye));
            this.btnLise = new System.Windows.Forms.Button();
            this.btnOrtaOkul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLise
            // 
            this.btnLise.BackgroundImage = global::Takdir_Tesekkür_Hesapla.Properties.Resources.back;
            this.btnLise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLise.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLise.Location = new System.Drawing.Point(240, 12);
            this.btnLise.Name = "btnLise";
            this.btnLise.Size = new System.Drawing.Size(214, 269);
            this.btnLise.TabIndex = 0;
            this.btnLise.Text = "LİSE";
            this.btnLise.UseVisualStyleBackColor = true;
            this.btnLise.Click += new System.EventHandler(this.btnLise_Click);
            // 
            // btnOrtaOkul
            // 
            this.btnOrtaOkul.BackgroundImage = global::Takdir_Tesekkür_Hesapla.Properties.Resources.back;
            this.btnOrtaOkul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrtaOkul.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrtaOkul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrtaOkul.Location = new System.Drawing.Point(12, 12);
            this.btnOrtaOkul.Name = "btnOrtaOkul";
            this.btnOrtaOkul.Size = new System.Drawing.Size(214, 269);
            this.btnOrtaOkul.TabIndex = 0;
            this.btnOrtaOkul.Text = "ORTAOKUL";
            this.btnOrtaOkul.UseVisualStyleBackColor = true;
            this.btnOrtaOkul.Click += new System.EventHandler(this.btnOrtaOkul_Click);
            // 
            // SecenekSeviye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(466, 293);
            this.Controls.Add(this.btnLise);
            this.Controls.Add(this.btnOrtaOkul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecenekSeviye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORTA OKUL/LİSE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrtaOkul;
        private System.Windows.Forms.Button btnLise;

    }
}