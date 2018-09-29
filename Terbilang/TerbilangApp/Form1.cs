using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerbilangLibrary;

namespace TerbilangApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            int nilai = int.Parse(txtNominal.Text);
            Terbilang terbilang = new Terbilang();
            lstTerbilang.Items.Clear();
            lstTerbilang.Items.Add(terbilang.TerbilangIndonesia(nilai));
        }
    }
}
