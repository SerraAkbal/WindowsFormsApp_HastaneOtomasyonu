
namespace WindowsFormsApp_HastaneOtomasyonu
{
    partial class Doktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDGoster = new System.Windows.Forms.Button();
            this.txtHastaSoyadi = new System.Windows.Forms.TextBox();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIlacAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIlacAdedi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKullanimSekli = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIDozu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSikayet = new System.Windows.Forms.TextBox();
            this.txtTedavi = new System.Windows.Forms.TextBox();
            this.txtTeshis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDTGuncelle = new System.Windows.Forms.Button();
            this.btnDTSil = new System.Windows.Forms.Button();
            this.btnDTEkle = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Controls.Add(this.txtRID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnDGoster);
            this.groupBox1.Controls.Add(this.txtHastaSoyadi);
            this.groupBox1.Controls.Add(this.txtHastaAdi);
            this.groupBox1.Controls.Add(this.txtTCKN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(23, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgisi";
            // 
            // txtRID
            // 
            this.txtRID.Location = new System.Drawing.Point(122, 110);
            this.txtRID.Name = "txtRID";
            this.txtRID.Size = new System.Drawing.Size(100, 22);
            this.txtRID.TabIndex = 13;
            this.txtRID.TextChanged += new System.EventHandler(this.txtRID_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.MediumBlue;
            this.label11.Location = new System.Drawing.Point(11, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 14);
            this.label11.TabIndex = 12;
            this.label11.Text = "Randevu ID :";
            // 
            // btnDGoster
            // 
            this.btnDGoster.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDGoster.Location = new System.Drawing.Point(73, 141);
            this.btnDGoster.Name = "btnDGoster";
            this.btnDGoster.Size = new System.Drawing.Size(78, 23);
            this.btnDGoster.TabIndex = 11;
            this.btnDGoster.Text = "Göster";
            this.btnDGoster.UseVisualStyleBackColor = true;
            this.btnDGoster.Click += new System.EventHandler(this.btnDGoster_Click);
            // 
            // txtHastaSoyadi
            // 
            this.txtHastaSoyadi.Location = new System.Drawing.Point(122, 82);
            this.txtHastaSoyadi.Name = "txtHastaSoyadi";
            this.txtHastaSoyadi.Size = new System.Drawing.Size(100, 22);
            this.txtHastaSoyadi.TabIndex = 5;
            this.txtHastaSoyadi.TextChanged += new System.EventHandler(this.txtHastaSoyadi_TextChanged);
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(122, 54);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(100, 22);
            this.txtHastaAdi.TabIndex = 4;
            this.txtHastaAdi.TextChanged += new System.EventHandler(this.txtHastaAdi_TextChanged);
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(122, 26);
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(100, 22);
            this.txtTCKN.TabIndex = 3;
            this.txtTCKN.TextChanged += new System.EventHandler(this.txtTCKN_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCKN :";
            // 
            // txtIlacAdi
            // 
            this.txtIlacAdi.Location = new System.Drawing.Point(140, 20);
            this.txtIlacAdi.Name = "txtIlacAdi";
            this.txtIlacAdi.Size = new System.Drawing.Size(100, 22);
            this.txtIlacAdi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "İlaç Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(16, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "İlaç Adedi :";
            // 
            // txtIlacAdedi
            // 
            this.txtIlacAdedi.Location = new System.Drawing.Point(140, 49);
            this.txtIlacAdedi.Name = "txtIlacAdedi";
            this.txtIlacAdedi.Size = new System.Drawing.Size(100, 22);
            this.txtIlacAdedi.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(15, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kullanım Şekli :";
            // 
            // txtKullanimSekli
            // 
            this.txtKullanimSekli.Location = new System.Drawing.Point(140, 105);
            this.txtKullanimSekli.Name = "txtKullanimSekli";
            this.txtKullanimSekli.Size = new System.Drawing.Size(100, 22);
            this.txtKullanimSekli.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox2.Controls.Add(this.txtIDozu);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtIlacAdi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtKullanimSekli);
            this.groupBox2.Controls.Add(this.txtIlacAdedi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(543, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 132);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlaç";
            // 
            // txtIDozu
            // 
            this.txtIDozu.Location = new System.Drawing.Point(140, 77);
            this.txtIDozu.Name = "txtIDozu";
            this.txtIDozu.Size = new System.Drawing.Size(100, 22);
            this.txtIDozu.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.MediumBlue;
            this.label10.Location = new System.Drawing.Point(16, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 14);
            this.label10.TabIndex = 12;
            this.label10.Text = "İlaç Dozu :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox3.Controls.Add(this.txtSikayet);
            this.groupBox3.Controls.Add(this.txtTedavi);
            this.groupBox3.Controls.Add(this.txtTeshis);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox3.Location = new System.Drawing.Point(293, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 123);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tedavi";
            // 
            // txtSikayet
            // 
            this.txtSikayet.Location = new System.Drawing.Point(103, 25);
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(100, 22);
            this.txtSikayet.TabIndex = 5;
            // 
            // txtTedavi
            // 
            this.txtTedavi.Location = new System.Drawing.Point(103, 82);
            this.txtTedavi.Name = "txtTedavi";
            this.txtTedavi.Size = new System.Drawing.Size(100, 22);
            this.txtTedavi.TabIndex = 4;
            // 
            // txtTeshis
            // 
            this.txtTeshis.Location = new System.Drawing.Point(103, 54);
            this.txtTeshis.Name = "txtTeshis";
            this.txtTeshis.Size = new System.Drawing.Size(100, 22);
            this.txtTeshis.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(13, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tedavi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(13, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "Şikayet :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(13, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "Teşhis :";
            // 
            // btnDTGuncelle
            // 
            this.btnDTGuncelle.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDTGuncelle.Location = new System.Drawing.Point(476, 178);
            this.btnDTGuncelle.Name = "btnDTGuncelle";
            this.btnDTGuncelle.Size = new System.Drawing.Size(143, 39);
            this.btnDTGuncelle.TabIndex = 11;
            this.btnDTGuncelle.Text = "Güncelle";
            this.btnDTGuncelle.UseVisualStyleBackColor = true;
            this.btnDTGuncelle.Click += new System.EventHandler(this.btnDTGuncelle_Click);
            // 
            // btnDTSil
            // 
            this.btnDTSil.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDTSil.Location = new System.Drawing.Point(661, 178);
            this.btnDTSil.Name = "btnDTSil";
            this.btnDTSil.Size = new System.Drawing.Size(137, 39);
            this.btnDTSil.TabIndex = 10;
            this.btnDTSil.Text = "Sil";
            this.btnDTSil.UseVisualStyleBackColor = true;
            this.btnDTSil.Click += new System.EventHandler(this.btnDTSil_Click);
            // 
            // btnDTEkle
            // 
            this.btnDTEkle.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDTEkle.Location = new System.Drawing.Point(293, 178);
            this.btnDTEkle.Name = "btnDTEkle";
            this.btnDTEkle.Size = new System.Drawing.Size(137, 39);
            this.btnDTEkle.TabIndex = 9;
            this.btnDTEkle.Text = "Ekle";
            this.btnDTEkle.UseVisualStyleBackColor = true;
            this.btnDTEkle.Click += new System.EventHandler(this.btnDTEkle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(23, 3);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(86, 23);
            this.btnGeri.TabIndex = 20;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnDTGuncelle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnDTSil);
            this.Controls.Add(this.btnDTEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doktor";
            this.Text = "Doktor ";
            this.Load += new System.EventHandler(this.Doktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHastaSoyadi;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIlacAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIlacAdedi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKullanimSekli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSikayet;
        private System.Windows.Forms.TextBox txtTedavi;
        private System.Windows.Forms.TextBox txtTeshis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDTEkle;
        private System.Windows.Forms.Button btnDTGuncelle;
        private System.Windows.Forms.Button btnDTSil;
        private System.Windows.Forms.Button btnDGoster;
        private System.Windows.Forms.TextBox txtIDozu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGeri;
    }
}