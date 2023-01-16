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
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"server=DESKTOP-H36F0L6;database=HastaneOtomasyon;UID=sa;PWD=gulsen98");

        HastaneOtomasyonEntities2 db = new HastaneOtomasyonEntities2();

        private void btnDGoster_Click(object sender, EventArgs e)
        {
            ListeGetir();
        }

        private void ListeGetir()
        {
            dataGridView1.DataSource = db.ReceteDetays.Select(
                r => new
                {
                    r.Randevu.Hasta.HastaID,
                    r.Randevu.Hasta.TCKN,
                    r.Randevu.Hasta.HastaAdi,
                    r.Randevu.Hasta.HastaSoyadi,
                    r.RandevuID,
                    r.Randevu.Sikayet,
                    r.Randevu.Hasta.Cinsiyet,
                    r.Randevu.Hasta.KanGrubu.KanGrubuTuru,
                    r.Randevu.Hasta.Kilo,
                    r.Randevu.Hasta.DogumTarihi,
                    r.Randevu.Hasta.HastaGecmisi.Alerjiler,
                    r.Randevu.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                    r.Randevu.Hasta.HastaGecmisi.GecirdigiHastalik,
                    r.Randevu.Hasta.HastaGecmisi.KullandigiIlac,
                }).ToList();

        }


        private void btnDTEkle_Click(object sender, EventArgs e)
        {
            ReceteDetay yeniReceteDetay = new ReceteDetay();
            Ilaclar yeniIlac = new Ilaclar();
            Randevu yeniRandevu = new Randevu();

            yeniRandevu.Sikayet = txtSikayet.Text;
            yeniRandevu.Teshis = txtTeshis.Text;
            yeniRandevu.Tedavi = txtTedavi.Text;

            yeniIlac.IlacAdi = txtIlacAdi.Text;

            yeniReceteDetay.IlacAdet = Convert.ToInt32(txtIlacAdedi.Text);
            yeniReceteDetay.IlacDozu = txtIDozu.Text;
            yeniReceteDetay.KullanımSekli = txtKullanimSekli.Text;

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

        ReceteDetay secilenRD = new ReceteDetay();
        Ilaclar secilenIlac = new Ilaclar();
        Randevu secilenRandevu = new Randevu();
        Hasta secilenHasta = new Hasta();

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //secilenHasta = db.Hastas.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            secilenRD = db.ReceteDetays.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

            //txtTCKN.Text = secilenRD.Randevu.Hasta.TCKN;
            //txtHastaAdi.Text = secilenRD.Randevu.Hasta.HastaAdi;
            //txtHastaSoyadi.Text = secilenRD.Randevu.Hasta.HastaSoyadi;

            //secilenRandevu = db.Randevus.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

            txtRID.Text = Convert.ToString( secilenRD.Randevu.RandevuID);
            txtSikayet.Text = secilenRD.Randevu.Sikayet;
            txtTeshis.Text = secilenRD.Randevu.Teshis;
            txtTedavi.Text = secilenRD.Randevu.Tedavi;

            //secilenIlac = db.Ilaclars.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

            txtIlacAdi.Text =secilenRD.Ilaclar.IlacAdi;

            txtIlacAdedi.Text = Convert.ToString(secilenRD.IlacAdet);
            txtIDozu.Text = Convert.ToString(secilenRD.IlacDozu);
            txtKullanimSekli.Text = secilenRD.KullanımSekli;
        }



        private void btnDTGuncelle_Click(object sender, EventArgs e)
        {

            txtSikayet.Text = secilenRandevu.Sikayet;
            txtTeshis.Text = secilenRandevu.Teshis;
            txtTedavi.Text = secilenRandevu.Tedavi;

            txtIlacAdi.Text = secilenIlac.IlacAdi;

            txtIlacAdedi.Text = Convert.ToString(secilenRD.IlacAdet);
            txtIDozu.Text = secilenRD.IlacDozu;
            txtKullanimSekli.Text = secilenRD.KullanımSekli;


            //db.SaveChanges();
            ListeGetir();
            Temizle();
        }

        private void btnDTSil_Click(object sender, EventArgs e)
        {
            db.Ilaclars.Remove(db.Ilaclars.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value));
            db.Randevus.Remove(db.Randevus.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value));
            db.Hastas.Remove(db.Hastas.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value));
            db.ReceteDetays.Remove(db.ReceteDetays.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value));

            //db.SaveChanges();
            ListeGetir();
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            db.SaveChanges();
        }

        private void txtTCKN_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ReceteDetays.Where(r => r.Randevu.Hasta.TCKN.ToString().StartsWith(txtTCKN.Text)).Select(
                 r => new
                 {
                         r.Randevu.Hasta.HastaID,
                         r.Randevu.Hasta.TCKN,
                         r.Randevu.Hasta.HastaAdi,
                         r.Randevu.Hasta.HastaSoyadi,
                         r.RandevuID,
                         r.Randevu.Sikayet,
                         r.Randevu.Hasta.Cinsiyet,
                         r.Randevu.Hasta.KanGrubu,
                         r.Randevu.Hasta.Kilo,
                         r.Randevu.Hasta.DogumTarihi,
                         r.Randevu.Hasta.HastaGecmisi.Alerjiler,
                         r.Randevu.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                         r.Randevu.Hasta.HastaGecmisi.GecirdigiHastalik,
                         r.Randevu.Hasta.HastaGecmisi.KullandigiIlac,
                     }).ToList();

        }

        private void txtHastaAdi_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ReceteDetays.Where(h => h.Randevu.Hasta.HastaAdi.ToString().StartsWith(txtHastaAdi.Text)).Select(
                r => new
                {
                    r.Randevu.Hasta.HastaID,
                    r.Randevu.Hasta.TCKN,
                    r.Randevu.Hasta.HastaAdi,
                    r.Randevu.Hasta.HastaSoyadi,
                    r.RandevuID,
                    r.Randevu.Sikayet,
                    r.Randevu.Hasta.Cinsiyet,
                    r.Randevu.Hasta.KanGrubu,
                    r.Randevu.Hasta.Kilo,
                    r.Randevu.Hasta.DogumTarihi,
                    r.Randevu.Hasta.HastaGecmisi.Alerjiler,
                    r.Randevu.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                    r.Randevu.Hasta.HastaGecmisi.GecirdigiHastalik,
                    r.Randevu.Hasta.HastaGecmisi.KullandigiIlac,
                }).ToList();
        }

        private void txtHastaSoyadi_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ReceteDetays.Where(h => h.Randevu.Hasta.HastaSoyadi.ToString().StartsWith(txtHastaSoyadi.Text)).Select(
                r => new
                {
                    r.Randevu.Hasta.HastaID,
                    r.Randevu.Hasta.TCKN,
                    r.Randevu.Hasta.HastaAdi,
                    r.Randevu.Hasta.HastaSoyadi,
                    r.RandevuID,
                    r.Randevu.Sikayet,
                    r.Randevu.Hasta.Cinsiyet,
                    r.Randevu.Hasta.KanGrubu,
                    r.Randevu.Hasta.Kilo,
                    r.Randevu.Hasta.DogumTarihi,
                    r.Randevu.Hasta.HastaGecmisi.Alerjiler,
                    r.Randevu.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                    r.Randevu.Hasta.HastaGecmisi.GecirdigiHastalik,
                    r.Randevu.Hasta.HastaGecmisi.KullandigiIlac,
                }).ToList();
        }

        private void txtRID_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ReceteDetays.Where(h => h.RandevuID.ToString().StartsWith(txtHastaSoyadi.Text)).Select(
               r => new
               {
                   r.Randevu.Hasta.HastaID,
                   r.Randevu.Hasta.TCKN,
                   r.Randevu.Hasta.HastaAdi,
                   r.Randevu.Hasta.HastaSoyadi,
                   r.RandevuID,
                   r.Randevu.Sikayet,
                   r.Randevu.Hasta.Cinsiyet,
                   r.Randevu.Hasta.KanGrubu,
                   r.Randevu.Hasta.Kilo,
                   r.Randevu.Hasta.DogumTarihi,
                   r.Randevu.Hasta.HastaGecmisi.Alerjiler,
                   r.Randevu.Hasta.HastaGecmisi.GecirdigiAmeliyat,
                   r.Randevu.Hasta.HastaGecmisi.GecirdigiHastalik,
                   r.Randevu.Hasta.HastaGecmisi.KullandigiIlac,
               }).ToList();
        }


        //ILAC

        private void btnIlacEkle_Click(object sender, EventArgs e)
        {
            //ReceteDetay yeniReceteDetay = new ReceteDetay();

            //yeniReceteDetay.Ilaclar.IlacAdi = txtIlacAdi.Text;
            //yeniReceteDetay.IlacAdet = Convert.ToInt32( txtIlacAdedi.Text);
            //yeniReceteDetay.IlacDozu = txtIDozu.Text;
            //yeniReceteDetay.KullanımSekli = txtKullanimSekli.Text;

            //db.SaveChanges();
            //ListeGetir();
            //Temizle();
        }

        private void btnDIGuncelle_Click(object sender, EventArgs e)
        {
            //txtIlacAdi.Text = secilenRD.Ilaclar.IlacAdi;
            //txtIlacAdedi.Text = Convert.ToString( secilenRD.IlacAdet);
            //txtIDozu.Text = secilenRD.IlacDozu;
            //txtKullanimSekli.Text = secilenRD.KullanımSekli;

            //db.SaveChanges();
            //ListeGetir();
            //Temizle();
        }

        private void btnDISil_Click(object sender, EventArgs e)
        {
            //db.ReceteDetays.Remove(db.ReceteDetays.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value));

            //db.SaveChanges();
            //ListeGetir();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Secim sc = new Secim();
            sc.Show();
            this.Hide();

        }

        private void Doktor_Load(object sender, EventArgs e)
        {

        }
    }
}
