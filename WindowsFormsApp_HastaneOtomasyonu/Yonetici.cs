using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_HastaneOtomasyonu
{

    // ListeGetir()     // datagridview1 e tabloları getiren method
    // Temizle()        //dgv1 daki tabloları silen method



    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"server=DESKTOP-H36F0L6;database=HastaneOtomasyon;UID=sa;PWD=gulsen98");

        HastaneOtomasyonEntities2 db = new HastaneOtomasyonEntities2();

        private void Yonetici_Load(object sender, EventArgs e)
        {
                        

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            ListeGetir();
        }


        private void ListeGetir()
        {
            dataGridView1.DataSource = db.Izinlers.Select(
                i => new
                {
                    i.Personel.PersonelID,
                    i.Personel.Meslek.MeslekTuru,
                    i.Personel.PersonelAdi,
                    i.Personel.PersonelSoyadi,
                    i.Personel.TCKN,
                    i.Personel.Cinsiyet,                    
                    i.Personel.TelefonNo,
                    i.Personel.Mail,
                    i.Personel.İseGirisTarihi,
                    i.Personel.EnSonMezuniyetBilgisi,
                    i.Personel.HastaneBilgi.HastaneAdi,
                    i.Personel.KanGrubu.KanGrubuTuru,
                    i.IzinID,
                    i.IzınTuru,
                    i.IzinBaslangic,
                    i.IzinBitis,                                      
                    
                }).ToList() ;
         
        }


        private void btnYPEkle_Click(object sender, EventArgs e)
        {
            Personel yeniPersonel = new Personel();
            yeniPersonel.PersonelID = Convert.ToInt32(txtPID.Text);
            yeniPersonel.PersonelAdi = txtPAdi.Text;
            yeniPersonel.PersonelSoyadi = txtPSoayadi.Text;
            db.Personels.Add(yeniPersonel);

            Meslek yeniMeslek = new Meslek();
            yeniMeslek.MeslekTuru = txtMeslek.Text;
            db.Mesleks.Add(yeniMeslek);

            Izinler yeniIzın = new Izinler();
            yeniIzın.IzınTuru = txtIzınTuru.Text;
            yeniIzın.IzinBaslangic = Convert.ToDateTime(txtIzızBaslangıc);
            yeniIzın.IzinBitis = Convert.ToDateTime(txtIzınBitis.Text);

            db.SaveChanges();
            ListeGetir();
            Temizle();

        }

        private void Temizle()
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }

        Personel secilenPersonel = new Personel();
        Meslek secilenMeslek = new Meslek();
        Izinler secilenIzın = new Izinler();

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //secilenPersonel = db.Personels.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            //secilenMeslek = db.Mesleks.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            secilenIzın = db.Izinlers.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

            txtPID.Text = Convert.ToString(secilenIzın.Personel.PersonelID);
            txtPAdi.Text = secilenIzın.Personel.PersonelAdi;
            txtPSoayadi.Text = secilenIzın.Personel.PersonelSoyadi;
            txtTCKN.Text = secilenIzın.Personel.TCKN;
            txtMeslek.Text = secilenIzın.Personel.Meslek.MeslekTuru;
            txtIzınTuru.Text = secilenIzın.IzınTuru;
            txtIzızBaslangıc.Text = Convert.ToString(secilenIzın.IzinBaslangic);
            txtIzınBitis.Text = Convert.ToString(secilenIzın.IzinBitis);
            
        }
       

        private void btnYPGuncelle_Click(object sender, EventArgs e)
        {
            secilenPersonel.PersonelID = Convert.ToInt32(txtPID.Text);
            secilenPersonel.PersonelAdi = txtPAdi.Text;
            secilenPersonel.PersonelSoyadi = txtPSoayadi.Text;
            secilenMeslek.MeslekTuru = txtMeslek.Text;

            secilenIzın.IzınTuru = txtIzınTuru.Text;
            secilenIzın.IzinBaslangic = Convert.ToDateTime(txtIzızBaslangıc.Text);
            secilenIzın.IzinBitis = Convert.ToDateTime(txtIzınBitis.Text);

            //db.SaveChanges();
            ListeGetir();
            Temizle();
        }

        private void btnYPSil_Click(object sender, EventArgs e)
        {
            db.Personels.Remove(db.Personels.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value));
            db.Mesleks.Remove(db.Mesleks.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value));
            db.Izinlers.Remove(db.Izinlers.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value));

            //db.SaveChanges();
            ListeGetir();
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //db.SaveChanges();
        }

        

        private void txtPID_TextChanged_1(object sender, EventArgs e)
        {
            

            dataGridView1.DataSource = db.Izinlers.Where(i => i.Personel.PersonelID.ToString().StartsWith(txtPID.Text)).Select(
                i => new
                {
                    i.Personel.PersonelID,
                    i.Personel.Meslek.MeslekTuru,
                    i.Personel.PersonelAdi,
                    i.Personel.PersonelSoyadi,
                    i.Personel.TCKN,
                    i.Personel.Cinsiyet,
                    i.Personel.TelefonNo,
                    i.Personel.Mail,
                    i.Personel.İseGirisTarihi,
                    i.Personel.EnSonMezuniyetBilgisi,
                    i.Personel.HastaneBilgi.HastaneAdi,
                    i.Personel.KanGrubu.KanGrubuTuru,
                    i.IzinID,
                    i.IzınTuru,
                    i.IzinBaslangic,
                    i.IzinBitis,
                }).ToList();            

        }

        

        private void txtPAdi_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.Izinlers.Where(i => i.Personel.PersonelAdi.StartsWith(txtPAdi.Text)).Select(
                i => new
                {
                    i.Personel.PersonelID,
                    i.Personel.Meslek.MeslekTuru,
                    i.Personel.PersonelAdi,
                    i.Personel.PersonelSoyadi,
                    i.Personel.TCKN,
                    i.Personel.Cinsiyet,
                    i.Personel.TelefonNo,
                    i.Personel.Mail,
                    i.Personel.İseGirisTarihi,
                    i.Personel.EnSonMezuniyetBilgisi,
                    i.Personel.HastaneBilgi.HastaneAdi,
                    i.Personel.KanGrubu.KanGrubuTuru,
                    i.IzinID,
                    i.IzınTuru,
                    i.IzinBaslangic,
                    i.IzinBitis,
                }).ToList();
           

        } 


        private void txtPSoayadi_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Izinlers.Where(i => i.Personel.PersonelSoyadi.ToString().StartsWith(txtPSoayadi.Text)).Select(
                i => new
                {
                    i.Personel.PersonelID,
                    i.Personel.Meslek.MeslekTuru,
                    i.Personel.PersonelAdi,
                    i.Personel.PersonelSoyadi,
                    i.Personel.TCKN,
                    i.Personel.Cinsiyet,
                    i.Personel.TelefonNo,
                    i.Personel.Mail,
                    i.Personel.İseGirisTarihi,
                    i.Personel.EnSonMezuniyetBilgisi,
                    i.Personel.HastaneBilgi.HastaneAdi,
                    i.Personel.KanGrubu.KanGrubuTuru,
                    i.IzinID,
                    i.IzınTuru,
                    i.IzinBaslangic,
                    i.IzinBitis,
                }).ToList();

        }

     

        private void txtTCKN_TextChanged(object sender, EventArgs e)
        {  
            dataGridView1.DataSource = db.Izinlers.Where(i => i.Personel.TCKN.ToString().StartsWith(txtTCKN.Text)).Select(
                i => new
                {
                    i.Personel.PersonelID,
                    i.Personel.Meslek.MeslekTuru,
                    i.Personel.PersonelAdi,
                    i.Personel.PersonelSoyadi,
                    i.Personel.TCKN,
                    i.Personel.Cinsiyet,
                    i.Personel.TelefonNo,
                    i.Personel.Mail,
                    i.Personel.İseGirisTarihi,
                    i.Personel.EnSonMezuniyetBilgisi,
                    i.Personel.HastaneBilgi.HastaneAdi,
                    i.Personel.KanGrubu.KanGrubuTuru,
                    i.IzinID,
                    i.IzınTuru,
                    i.IzinBaslangic,
                    i.IzinBitis,
                }).ToList();           

        }

        private void txtMeslek_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Izinlers.Where(i => i.Personel.Meslek.MeslekTuru.ToString().StartsWith(txtMeslek.Text)).Select(
                i => new
                {
                    i.Personel.PersonelID,
                    i.Personel.Meslek.MeslekTuru,
                    i.Personel.PersonelAdi,
                    i.Personel.PersonelSoyadi,
                    i.Personel.TCKN,
                    i.Personel.Cinsiyet,
                    i.Personel.TelefonNo,
                    i.Personel.Mail,
                    i.Personel.İseGirisTarihi,
                    i.Personel.EnSonMezuniyetBilgisi,
                    i.Personel.HastaneBilgi.HastaneAdi,
                    i.Personel.KanGrubu.KanGrubuTuru,
                    i.IzinID,
                    i.IzınTuru,
                    i.IzinBaslangic,
                    i.IzinBitis,
                }).ToList();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Secim sc = new Secim();
            sc.Show();
            this.Hide();

        }
    }

}

