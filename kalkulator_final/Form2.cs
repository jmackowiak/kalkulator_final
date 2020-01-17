using System;
using System.Windows.Forms;

namespace kalkulator_final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbSzukana_TextChanged(object sender, EventArgs e)
        {

        }

        private void bWyczysc_Click(object sender, EventArgs e)
        {
            tbSzukana.Text = "";
            tbBin.Text = "";
            tbOct.Text = "";
            tbHex.Text = "";
        }

        private void bKonwertuj_Click(object sender, EventArgs e)
        {
            int konwertowana = int.Parse(tbSzukana.Text);

            tbBin.Text = Convert.ToString(konwertowana, 2);
            tbOct.Text = Convert.ToString(konwertowana, 8);
            tbHex.Text = Convert.ToString(konwertowana, 16);
        }
    }
}
