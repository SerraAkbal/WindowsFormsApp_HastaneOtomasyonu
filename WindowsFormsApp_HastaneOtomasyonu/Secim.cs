using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_HastaneOtomasyonu
{
    public partial class Secim : Form
    {
        public Secim()
        {
            InitializeComponent();
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            Doktor dr = new Doktor();
            dr.Show();
            this.Hide();
        }

        private void btnDanisma_Click(object sender, EventArgs e)
        {
            Danisma dr = new Danisma();
            dr.Show();
            this.Hide();
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            Yonetici dr = new Yonetici();
            dr.Show();
            this.Hide();
        }
    }
}
