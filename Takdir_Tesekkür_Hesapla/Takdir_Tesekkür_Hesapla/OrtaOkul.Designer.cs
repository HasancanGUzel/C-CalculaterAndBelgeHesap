namespace Takdir_Tesekkür_Hesapla
{
    partial class OrtaOkul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrtaOkul));
            this.btnOrta = new System.Windows.Forms.Button();
            this.btnImam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrta
            // 
            this.btnOrta.BackgroundImage = global::Takdir_Tesekkür_Hesapla.Properties.Resources.back1;
            this.btnOrta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrta.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrta.ForeColor = System.Drawing.Color.Blue;
            this.btnOrta.Location = new System.Drawing.Point(12, 12);
            this.btnOrta.Name = "btnOrta";
            this.btnOrta.Size = new System.Drawing.Size(244, 100);
            this.btnOrta.TabIndex = 0;
            this.btnOrta.Text = "ORTAOKUL";
            this.btnOrta.UseVisualStyleBackColor = true;
            this.btnOrta.Click += new System.EventHandler(this.btnOrta_Click);
            this.btnOrta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOrta_KeyDown);
            // 
            // btnImam
            // 
            this.btnImam.BackgroundImage = global::Takdir_Tesekkür_Hesapla.Properties.Resources.back1;
            this.btnImam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImam.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImam.ForeColor = System.Drawing.Color.Blue;
            this.btnImam.Location = new System.Drawing.Point(12, 130);
            this.btnImam.Name = "btnImam";
            this.btnImam.Size = new System.Drawing.Size(244, 100);
            this.btnImam.TabIndex = 1;
            this.btnImam.Text = "İMAM HATİP";
            this.btnImam.UseVisualStyleBackColor = true;
            this.btnImam.Click += new System.EventHandler(this.btnImam_Click);
            this.btnImam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnImam_KeyDown);
            // 
            // OrtaOkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(268, 245);
            this.Controls.Add(this.btnImam);
            this.Controls.Add(this.btnOrta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrtaOkul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORTAOKUL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrta;
        private System.Windows.Forms.Button btnImam;
    }
}