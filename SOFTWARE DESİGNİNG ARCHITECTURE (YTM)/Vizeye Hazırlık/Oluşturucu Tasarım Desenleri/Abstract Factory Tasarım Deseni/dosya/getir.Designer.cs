
namespace teknikservis
{
    partial class getir
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
            this.adsoyad = new System.Windows.Forms.TextBox();
            this.telefon1 = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.TextBox();
            this.telefon2 = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adsoyad
            // 
            this.adsoyad.Location = new System.Drawing.Point(324, 39);
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(100, 22);
            this.adsoyad.TabIndex = 0;
            // 
            // telefon1
            // 
            this.telefon1.Location = new System.Drawing.Point(324, 182);
            this.telefon1.Name = "telefon1";
            this.telefon1.Size = new System.Drawing.Size(100, 22);
            this.telefon1.TabIndex = 1;
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(324, 121);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(100, 22);
            this.tc.TabIndex = 1;
            // 
            // telefon2
            // 
            this.telefon2.Location = new System.Drawing.Point(324, 242);
            this.telefon2.Name = "telefon2";
            this.telefon2.Size = new System.Drawing.Size(100, 22);
            this.telefon2.TabIndex = 2;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(324, 312);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(100, 22);
            this.mail.TabIndex = 3;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(324, 376);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(100, 22);
            this.adres.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(531, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // getir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.telefon2);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.telefon1);
            this.Controls.Add(this.adsoyad);
            this.Name = "getir";
            this.Text = "getir";
            this.Load += new System.EventHandler(this.getir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adsoyad;
        private System.Windows.Forms.TextBox telefon1;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.TextBox telefon2;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}