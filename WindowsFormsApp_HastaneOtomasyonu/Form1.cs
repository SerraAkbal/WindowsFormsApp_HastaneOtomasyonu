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
    public partial class HastaneOtomasyonu : Form
    {
        public HastaneOtomasyonu()
        {
            InitializeComponent();
        }
               

        private void btnDanisma_Click(object sender, EventArgs e)
        {
            Secim dr = new Secim();
            dr.Show();
            this.Hide();
        }


    }
}
