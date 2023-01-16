
namespace WindowsFormsApp_HastaneOtomasyonu
{
    partial class HastaneOtomasyonu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaneOtomasyonu));
            this.btnDanisma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDanisma
            // 
            this.btnDanisma.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDanisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDanisma.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDanisma.Location = new System.Drawing.Point(56, 42);
            this.btnDanisma.Name = "btnDanisma";
            this.btnDanisma.Size = new System.Drawing.Size(703, 285);
            this.btnDanisma.TabIndex = 9;
            this.btnDanisma.Text = "Başlamak için Tıklayınız";
            this.btnDanisma.UseVisualStyleBackColor = false;
            this.btnDanisma.Click += new System.EventHandler(this.btnDanisma_Click);
            // 
            // HastaneOtomasyonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.btnDanisma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HastaneOtomasyonu";
            this.Text = "HASTANE OTOMASYONU";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDanisma;
    }
}

