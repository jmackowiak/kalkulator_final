using System;
using System.Windows.Forms;

namespace kalkulator_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float liczba1, liczba2, wynik;
        char rodzajDzialania = ' ';
        string przecinek = ",";

        private void kalkulatorBinarnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void bWylacz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bPrzecinek_Click(object sender, EventArgs e)
        {
            tbWynik.Text += przecinek;
        }

        private void btWyczysc_Click(object sender, EventArgs e)
        {
            tbWynik.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DopisanaLiczba("4");
        }

        private void b1_Click(object sender, EventArgs e)
        {
            DopisanaLiczba("1");
        }

        private void b2_Click(object sender, EventArgs e)
        {
            DopisanaLiczba("2");
        }

        private void b3_Click(object sender, EventArgs e)
        {
            DopisanaLiczba("3");
        }

        private void b5_Click(object sender, EventArgs e)
        {
            DopisanaLiczba("5");
        }

        private void b6_Click(object sender, EventArgs e)
        {
            DopisanaLiczba("6");
        }

        private void b7_Click(object sender, EventArgs e)
        {
            DopisanaLiczba("7");
        }

        private void b8_Click(object sender, EventArgs e)
        {
            DopisanaLiczba("8");
        }

        private void b9_Click(object sender, EventArgs e)
        {
            DopisanaLiczba("9");
        }

        private void b0_Click(object sender, EventArgs e)
        {
            DopisanaLiczba("0");
        }

        private void bDodawanie_Click(object sender, EventArgs e)
        {
            liczba1 = float.Parse(tbWynik.Text);
            tbWynik.Text = "";
            rodzajDzialania = '+';
        }

        private void bOdejmowanie_Click(object sender, EventArgs e)
        {
            liczba1 = float.Parse(tbWynik.Text);
            tbWynik.Text = "";
            rodzajDzialania = '-';
        }

        private void bMnozenie_Click(object sender, EventArgs e)
        {
            liczba1 = float.Parse(tbWynik.Text);
            tbWynik.Text = "";
            rodzajDzialania = '*';
        }

        private void bDzielenie_Click(object sender, EventArgs e)
        {
            liczba1 = float.Parse(tbWynik.Text);
            tbWynik.Text = "";
            rodzajDzialania = '/';
        }

        private void bWynik_Click(object sender, EventArgs e)
        {
            switch (rodzajDzialania)
            {
                case ('+'):
                    liczba2 = float.Parse(tbWynik.Text);
                    wynik = liczba1 + liczba2;
                    tbWynik.Text = wynik.ToString();
                    break;
                case ('-'):
                    liczba2 = float.Parse(tbWynik.Text);
                    wynik = liczba1 - liczba2;
                    tbWynik.Text = wynik.ToString();
                    break;
                case ('*'):
                    liczba2 = float.Parse(tbWynik.Text);
                    wynik = liczba1 * liczba2;
                    tbWynik.Text = wynik.ToString();
                    break;
                case ('/'):
                    liczba2 = float.Parse(tbWynik.Text);
                    if (liczba2==0)
                    {
                        tbWynik.Text = "ERROR!";
                    }
                    else
                    { 
                        wynik = liczba1 / liczba2;
                        tbWynik.Text = wynik.ToString();
                    }
                    break;

                default:
                    break;
            }

            liczba1 = 0;
            liczba2 = 0;
            rodzajDzialania = ' ';
        }

        private void DopisanaLiczba(string dopisana)
        {
            if (tbWynik.Text=="0"  && tbWynik.Text != null )
            {
                tbWynik.Text = dopisana;
            }
            else
            {
                tbWynik.Text += dopisana;
            }
        }
    }
}
