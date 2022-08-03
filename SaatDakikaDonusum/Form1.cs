using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaatDakikaDonusum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int deger, saat, dakika;
            deger = Convert.ToInt32(txtDeger.Text);

            saat = deger / 60;
            lblSaat.Text = saat.ToString();

            dakika = deger % 60;
            lblDakika.Text = dakika.ToString();
        }
    }
}
