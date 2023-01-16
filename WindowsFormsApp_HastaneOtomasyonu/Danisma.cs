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


    public partial class Danisma : Form
    {
        public Danisma()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"server=DESKTOP-H36F0L6;database=HastaneOtomasyon;UID=sa;PWD=gulsen98");

        HastaneOtomasyonEntities2 db = new HastaneOtomasyonEntities2();

        private void Danisma_Load(object sender, EventArgs e)
        {

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            ListeGetir();

        }

        private void ListeGetir()
        {
            dataGridView1.DataSource = db.Randevus.Select(
                           r => new
                           {
                               r.Hasta.HastaID,
                               r.Hasta.TCKN,
                               r.Hasta.HastaAdi,
                               r.Hasta.HastaSoyadi,
                               r.Hasta.DogumTarihi,
                               r.Hasta.Kilo,
                               r.Hasta.Cinsiyet,
                               r.Hasta.HastaTelefonNo,
                               r.Hasta.HastaAdres,
                               r.Hasta.KanGrubu,
                               r.Hasta.HastaGecmisi.HastaGecmisiID,
                               r.Hasta.HastaGecmisi.KullandigiIlac,
                               r.Hasta.HastaGecmisi.GecirdigiHastalik,
                               r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                               r.Hasta.HastaGecmisi.Alerjiler,
                               r.Sikayet,
                               r.Doktorlar.Poliklinik.PoliklinkAdi,
                               r.Doktorlar.DoktorID,
                               r.Doktorlar.Personel.PersonelAdi,
                               r.Doktorlar.Personel.PersonelSoyadi,
                               r.RandevuID,
                               r.RandevuDetay.RandevuTarihi,
                               r.RandevuDetay.RandevuSaati,
                               r.RandevuDetay.HastaGeldimi,

                           }).ToList();
        }

        private void button5_Click(object sender, EventArgs e)      //EKLE
        {
            Randevu yeniRandevu = new Randevu();
            Hasta yeniHasta = new Hasta();
            KanGrubu yeniKan = new KanGrubu();
            HastaGecmisi yeniHastaGecmisi = new HastaGecmisi();
            Doktor yeniDoktor = new Doktor();
            RandevuDetay yeniRandevuDetay = new RandevuDetay();
            Poliklinik yeniPoliklinik = new Poliklinik();
            Personel yeniPersonel = new Personel();

            yeniHasta.TCKN = txtTCKN.Text;
            yeniHasta.HastaAdi = txtHastaAdi.Text;
            yeniHasta.HastaSoyadi = txtHastaSoyadi.Text;
            yeniHasta.DogumTarihi = Convert.ToDateTime(txtDTarihi.Text);
            yeniHasta.Kilo = Convert.ToInt32(txtKilo.Text);
            yeniHasta.Cinsiyet = txtCinsiyet.Text;
            yeniHasta.HastaTelefonNo = txtTelefon.Text;
            yeniHasta.HastaMail = txtMail.Text;
            yeniHasta.HastaAdres = txtAdres.Text;
            yeniKan.KanGrubuTuru = txtKanGrubu.Text;


            yeniRandevu.RandevuID = Convert.ToInt32(txtRandevuId.Text);
            yeniHastaGecmisi.KullandigiIlac = txtIlac.Text;
            yeniHastaGecmisi.GecirdigiHastalik = txtHastalık.Text;
            yeniHastaGecmisi.GecirdigiAmeliyat = txtAmeliyat.Text;
            yeniHastaGecmisi.Alerjiler = txtAlerji.Text;

            yeniRandevu.Sikayet = txtSikayet.Text;
            yeniPoliklinik.PoliklinkAdi = txtPoliklinik.Text;
            yeniRandevu.DoktorID = Convert.ToInt32(txtDoktorId.Text);
            yeniPersonel.PersonelAdi = txtDoktorAdi.Text;
            yeniPersonel.PersonelSoyadi = txtDSoyad.Text;
            yeniRandevuDetay.RandevuID = Convert.ToInt32(txtRandevuId.Text);
            yeniRandevuDetay.RandevuTarihi = (DateTime)dtpRTarihi.Value;
            //yeniRandevu.RandevuDetay.RandevuSaati = Convert.ToDateTime(txtRSaati.Text);
            yeniRandevuDetay.HastaGeldimi = txtGeldimi.Text;


            db.Randevus.Add(yeniRandevu);

            //db.SaveChanges();
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

        Randevu secilenRandevu = new Randevu();
        Hasta secilenHasta = new Hasta();
        KanGrubu secilenKan = new KanGrubu();
        HastaGecmisi secilenHastaGecmisi = new HastaGecmisi();
        Doktorlar secilenDoktor = new Doktorlar();
        RandevuDetay secilenRD = new RandevuDetay();
        Poliklinik secilenPoliklinik = new Poliklinik();
        Personel secilenPersonel = new Personel();
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //secilenRandevu = db.Randevus.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            //secilenHasta = db.Hastas.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            //secilenKan = db.KanGrubus.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            //secilenHastaGecmisi = db.HastaGecmisis.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            //secilenPersonel = db.Personels.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            //secilenDoktor =db.Doktorlars.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            secilenRD = db.RandevuDetays.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            //secilenPoliklinik = db.Polikliniks.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);


            txtTCKN.Text = secilenRD.Randevu.Hasta.TCKN;
            txtHastaAdi.Text = secilenRD.Randevu.Hasta.HastaAdi;
            txtHastaSoyadi.Text = secilenRD.Randevu.Hasta.HastaSoyadi;
            txtDTarihi.Text = Convert.ToString(secilenRD.Randevu.Hasta.DogumTarihi);
            txtKilo.Text = Convert.ToString(secilenRD.Randevu.Hasta.Kilo);
            txtCinsiyet.Text = secilenRD.Randevu.Hasta.Cinsiyet;
            txtTelefon.Text = secilenRD.Randevu.Hasta.HastaTelefonNo;
            txtMail.Text = secilenRD.Randevu.Hasta.HastaMail;
            txtAdres.Text = secilenRD.Randevu.Hasta.HastaAdres;
            txtKanGrubu.Text = secilenRD.Randevu.Hasta.KanGrubu.KanGrubuTuru;
            txtGecmisId.Text = Convert.ToString(secilenRD.Randevu.Hasta.HastaGecmisi.HastaGecmisiID);
            txtIlac.Text = secilenRD.Randevu.Hasta.HastaGecmisi.KullandigiIlac;
            txtHastalık.Text = secilenRD.Randevu.Hasta.HastaGecmisi.GecirdigiHastalik;
            txtAmeliyat.Text = secilenRD.Randevu.Hasta.HastaGecmisi.GecirdigiAmeliyat;
            txtAlerji.Text = secilenRD.Randevu.Hasta.HastaGecmisi.Alerjiler;
            txtSikayet.Text = secilenRD.Randevu.Sikayet;
            txtSikayet.Text = secilenRD.Randevu.Doktorlar.Poliklinik.PoliklinkAdi;
            txtDoktorId.Text = Convert.ToString(secilenRD.Randevu.Doktorlar.DoktorID);
            txtDoktorAdi.Text = secilenRD.Randevu.Doktorlar.Personel.PersonelAdi;
            txtDSoyad.Text = secilenRD.Randevu.Doktorlar.Personel.PersonelSoyadi;
            txtRandevuId.Text = Convert.ToString(secilenRD.Randevu.RandevuDetay.RandevuID);
            dtpRTarihi.Value = (DateTime)secilenRD.Randevu.RandevuDetay.RandevuTarihi;
            txtRSaati.Text = Convert.ToString(secilenRD.Randevu.RandevuDetay.RandevuSaati);
            txtGeldimi.Text = secilenRD.Randevu.RandevuDetay.HastaGeldimi;
        }

        private void button4_Click(object sender, EventArgs e)      //GUNCELLE
        {
        

            secilenRandevu.Hasta.TCKN = txtTCKN.Text;
            secilenRandevu.Hasta.HastaAdi = txtHastaAdi.Text;
            secilenRandevu.Hasta.HastaSoyadi = txtHastaSoyadi.Text;
            secilenRandevu.Hasta.DogumTarihi = Convert.ToDateTime(txtDTarihi.Text);
            secilenRandevu.Hasta.Kilo = Convert.ToInt32(txtKilo.Text);
            secilenRandevu.Hasta.Cinsiyet = txtCinsiyet.Text;
            secilenRandevu.Hasta.HastaTelefonNo = txtTelefon.Text;
            secilenRandevu.Hasta.HastaMail = txtMail.Text;
            secilenRandevu.Hasta.HastaAdres = txtAdres.Text;
            secilenRandevu.Hasta.KanGrubu.KanGrubuTuru = txtKanGrubu.Text;

            secilenRandevu.Hasta.HastaGecmisi.HastaGecmisiID = Convert.ToInt32(txtGecmisId.Text);
            secilenRandevu.Hasta.HastaGecmisi.KullandigiIlac = txtIlac.Text;
            secilenRandevu.Hasta.HastaGecmisi.GecirdigiHastalik = txtHastalık.Text;
            secilenRandevu.Hasta.HastaGecmisi.GecirdigiAmeliyat = txtAmeliyat.Text;
            secilenRandevu.Hasta.HastaGecmisi.Alerjiler = txtAlerji.Text;

            secilenRandevu.Sikayet = txtSikayet.Text;
            secilenRandevu.Doktorlar.Poliklinik.PoliklinkAdi = txtPoliklinik.Text;
            secilenRandevu.Doktorlar.DoktorID = Convert.ToInt32(txtDoktorId.Text);
            secilenRandevu.Doktorlar.Personel.PersonelAdi = txtDoktorAdi.Text;
            secilenRandevu.Doktorlar.Personel.PersonelSoyadi = txtDSoyad.Text;
            secilenRandevu.RandevuID = Convert.ToInt32(txtRandevuId.Text);
            secilenRandevu.RandevuDetay.RandevuTarihi = Convert.ToDateTime(dtpRTarihi.Value);
            // secilenRandevu.RandevuDetay.RandevuSaati =  (txtRSaati.Text) ;
            secilenRandevu.RandevuDetay.HastaGeldimi = txtGeldimi.Text;


            //db.SaveChanges();
            ListeGetir();
            Temizle();
        }

        private void button3_Click(object sender, EventArgs e)      //SİL
        {
            db.Randevus.Remove(db.Randevus.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value));

            //db.SaveChanges();
            ListeGetir();
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //db.SaveChanges();
        }

        #region TextChanged ler

        private void txtTCKN_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Hasta.TCKN.ToString().StartsWith(txtTCKN.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();

        }

        private void txtHastaAdi_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Hasta.HastaAdi.ToString().StartsWith(txtHastaAdi.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtHastaSoyadi_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Hasta.HastaSoyadi.ToString().StartsWith(txtHastaSoyadi.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtDTarihi_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Hasta.DogumTarihi.ToString().StartsWith(txtDTarihi.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtKilo_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Hasta.Kilo.ToString().StartsWith(txtKilo.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtCinsiyet_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Hasta.Cinsiyet.ToString().StartsWith(txtCinsiyet.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Hasta.HastaTelefonNo.ToString().StartsWith(txtTelefon.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Hasta.HastaMail.ToString().StartsWith(txtMail.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Hasta.HastaAdres.ToString().StartsWith(txtAdres.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtKanGrubu_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Hasta.KanGrubu.KanGrubuTuru.ToString().StartsWith(txtKanGrubu.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtGecmisId_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Hasta.HastaGecmisi.HastaGecmisiID.ToString().StartsWith(txtGecmisId.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtIlac_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Hasta.HastaGecmisi.KullandigiIlac.ToString().StartsWith(txtIlac.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtHastalık_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Hasta.HastaGecmisi.GecirdigiHastalik.ToString().StartsWith(txtHastalık.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtAmeliyat_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Hasta.HastaGecmisi.GecirdigiAmeliyat.ToString().StartsWith(txtAmeliyat.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtAlerji_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Hasta.HastaGecmisi.Alerjiler.ToString().StartsWith(txtAlerji.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtSikayet_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Sikayet.ToString().StartsWith(txtSikayet.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtPoliklinik_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Doktorlar.Poliklinik.PoliklinkAdi.ToString().StartsWith(txtPoliklinik.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtDoktorId_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Doktorlar.DoktorID.ToString().StartsWith(txtDoktorId.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtDoktorAdi_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Doktorlar.Personel.PersonelAdi.ToString().StartsWith(txtDoktorAdi.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtDSoyad_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.Doktorlar.Personel.PersonelSoyadi.ToString().StartsWith(txtDSoyad.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtRandevuId_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.RandevuID.ToString().StartsWith(txtRandevuId.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void dtpRTarihi_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.RandevuDetay.RandevuTarihi.ToString().StartsWith(dtpRTarihi.CustomFormat)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtRSaati_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.RandevuDetay.RandevuSaati.ToString().StartsWith(txtRSaati.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();
        }

        private void txtGeldimi_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Randevus.Where(r => r.RandevuDetay.HastaGeldimi.ToString().StartsWith(txtGeldimi.Text)).Select(
                 r => new
                 {
                     r.Hasta.HastaID,
                     r.Hasta.TCKN,
                     r.Hasta.HastaAdi,
                     r.Hasta.HastaSoyadi,
                     r.Hasta.DogumTarihi,
                     r.Hasta.Kilo,
                     r.Hasta.Cinsiyet,
                     r.Hasta.HastaTelefonNo,
                     r.Hasta.HastaAdres,
                     r.Hasta.KanGrubu,
                     r.Hasta.HastaGecmisi.HastaGecmisiID,
                     r.Hasta.HastaGecmisi.KullandigiIlac,
                     r.Hasta.HastaGecmisi.GecirdigiHastalik,
                     r.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                     r.Hasta.HastaGecmisi.Alerjiler,
                     r.Sikayet,
                     r.Doktorlar.Poliklinik.PoliklinkAdi,
                     r.Doktorlar.DoktorID,
                     r.Doktorlar.Personel.PersonelAdi,
                     r.Doktorlar.Personel.PersonelSoyadi,
                     r.RandevuID,
                     r.RandevuDetay.RandevuTarihi,
                     r.RandevuDetay.RandevuSaati,
                     r.RandevuDetay.HastaGeldimi,
                 }).ToList();

            #endregion}

        }

        //private void button9_Click(object sender, EventArgs e)      //EKLE
        //{
        //    Randevu yeniRanvedu = new Randevu();

        //    txtGecmisId.Text = Convert.ToString(yeniRanvedu.RandevuID);
        //    txtIlac.Text = yeniRanvedu.Hasta.HastaGecmisi.KullandigiIlac;
        //    txtHastalık.Text = yeniRanvedu.Hasta.HastaGecmisi.GecirdigiHastalik;
        //    txtAmeliyat.Text = yeniRanvedu.Hasta.HastaGecmisi.GecirdigiAmeliyat;
        //    txtAlerji.Text = yeniRanvedu.Hasta.HastaGecmisi.Alerjiler;

        //    //db.SaveChanges();
        //}

        //private void btnHGGuncelle_Click(object sender, EventArgs e)
        //{
        //    secilenRandevu = db.Randevus.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

        //    secilenRandevu.Hasta.HastaGecmisi.HastaGecmisiID = Convert.ToInt32(txtGecmisId.Text);
        //    secilenRandevu.Hasta.HastaGecmisi.KullandigiIlac = txtIlac.Text;
        //    secilenRandevu.Hasta.HastaGecmisi.GecirdigiHastalik = txtHastalık.Text;
        //    secilenRandevu.Hasta.HastaGecmisi.GecirdigiAmeliyat = txtAmeliyat.Text;
        //    secilenRandevu.Hasta.HastaGecmisi.Alerjiler = txtAlerji.Text;

        //    //db.SaveChanges();
        //}

        //private void btnHGSil_Click(object sender, EventArgs e)
        //{
        //    db.Randevus.Remove(db.Randevus.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value));

        //    //db.SaveChanges();
        //}

        //private void btnREkle_Click(object sender, EventArgs e)
        //{
        //    Randevu yeniRanvedu = new Randevu();

        //    txtSikayet.Text = yeniRanvedu.Sikayet;
        //    txtSikayet.Text = yeniRanvedu.Doktorlar.Poliklinik.PoliklinkAdi;
        //    txtDoktorId.Text = Convert.ToString(yeniRanvedu.Doktorlar.DoktorID);
        //    txtDoktorAdi.Text = yeniRanvedu.Doktorlar.Personel.PersonelAdi;
        //    txtDSoyad.Text = yeniRanvedu.Doktorlar.Personel.PersonelSoyadi;
        //    txtRandevuId.Text = Convert.ToString(yeniRanvedu.RandevuDetay.RandevuID);
        //    dtpRTarihi.Value = (DateTime)yeniRanvedu.RandevuDetay.RandevuTarihi;
        //    txtRSaati.Text = Convert.ToString(yeniRanvedu.RandevuDetay.RandevuSaati);
        //    txtGeldimi.Text = yeniRanvedu.RandevuDetay.HastaGeldimi;

        //    //db.SaveChanges();
        //}

        //private void btnRGuncelle_Click(object sender, EventArgs e)
        //{
        //    secilenRandevu = db.Randevus.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

        //    secilenRandevu.Sikayet = txtSikayet.Text;
        //    secilenRandevu.Doktorlar.Poliklinik.PoliklinkAdi = txtPoliklinik.Text;
        //    secilenRandevu.Doktorlar.DoktorID = Convert.ToInt32( txtDoktorId.Text) ;
        //    secilenRandevu.Doktorlar.Personel.PersonelAdi = txtDoktorAdi.Text ;
        //    secilenRandevu.Doktorlar.Personel.PersonelSoyadi = txtDSoyad.Text ;
        //    secilenRandevu.RandevuID = Convert.ToInt32(txtRandevuId.Text) ;
        //    secilenRandevu.RandevuDetay.RandevuTarihi = Convert.ToDateTime( dtpRTarihi.Value );
        //   // secilenRandevu.RandevuDetay.RandevuSaati =  (txtRSaati.Text) ;
        //    secilenRandevu.RandevuDetay.HastaGeldimi = txtGeldimi.Text ;

        //    //db.SaveChanges();

        //}

        //private void btnRsil_Click(object sender, EventArgs e)
        //{
        //    db.Randevus.Remove(db.Randevus.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value));

        //    //db.SaveChanges();
        //}

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Secim sc = new Secim();
            sc.Show();
            this.Hide();


        }
    }
}

