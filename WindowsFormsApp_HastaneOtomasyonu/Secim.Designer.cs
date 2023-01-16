
namespace WindowsFormsApp_HastaneOtomasyonu
{
    partial class Secim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Secim));
            this.btnYonetici = new System.Windows.Forms.Button();
            this.btnDanisma = new System.Windows.Forms.Button();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYonetici
            // 
            this.btnYonetici.BackColor = System.Drawing.Color.SkyBlue;
            this.btnYonetici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYonetici.BackgroundImage")));
            this.btnYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYonetici.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnYonetici.Location = new System.Drawing.Point(572, 178);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(157, 180);
            this.btnYonetici.TabIndex = 14;
            this.btnYonetici.Text = "Yönetici Girişi";
            this.btnYonetici.UseVisualStyleBackColor = false;
            this.btnYonetici.Click += new System.EventHandler(this.btnYonetici_Click);
            // 
            // btnDanisma
            // 
            this.btnDanisma.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDanisma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDanisma.BackgroundImage")));
            this.btnDanisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDanisma.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDanisma.Location = new System.Drawing.Point(322, 175);
            this.btnDanisma.Name = "btnDanisma";
            this.btnDanisma.Size = new System.Drawing.Size(157, 180);
            this.btnDanisma.TabIndex = 13;
            this.btnDanisma.Text = "Danışma Girişi";
            this.btnDanisma.UseVisualStyleBackColor = false;
            this.btnDanisma.Click += new System.EventHandler(this.btnDanisma_Click);
            // 
            // btnDoktor
            // 
            this.btnDoktor.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDoktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktor.BackgroundImage")));
            this.btnDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDoktor.Location = new System.Drawing.Point(71, 178);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(157, 180);
            this.btnDoktor.TabIndex = 12;
            this.btnDoktor.Text = "Doktor Girişi";
            this.btnDoktor.UseVisualStyleBackColor = false;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(42, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hastane Oromasyonuna Hoş Geldiniz. Lütfen Giriş Yapacağınız Platformu Seçiniz";
            // 
            // Secim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.btnYonetici);
            this.Controls.Add(this.btnDanisma);
            this.Controls.Add(this.btnDoktor);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Secim";
            this.Text = "Seçim Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Button btnDanisma;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Label label1;
    }
}