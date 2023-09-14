using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false; //la initializare, butonul de criptare este neutilizabil pana la generarea cheilor
            button3.Enabled = false; //la initializare, butonul de decriptare este neutilizabil pana criptarea unui mesaj
        }
        double p, q, n, E, z, c, d;

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info f2 = new Info();
            f2.ShowDialog();
        }

        private void genereazaChei_Click(object sender, EventArgs e)
        {
            //Random rng = new Random();
            if (textBoxP.TextLength < 2 || textBoxQ.TextLength < 2)
                MessageBox.Show("Va rugam introduceti un numar prim de minim doua cifre atat pentru P, cat si pentru Q!");
            else
            {
                p = double.Parse(textBoxP.Text); //preiau valoarea lui P din textbox
                q = double.Parse(textBoxQ.Text); //prieau valoarea lui Q din textbox

                n = p * q;
                z = (p - 1) * (q - 1);
                d = generarePrim();
                E = 17;
                Thread.Sleep(1000);
                textBoxE.Text = E.ToString();
                textBoxZ.Text = z.ToString();
                textBoxD.Text = d.ToString();
                cheiePublica.Text = n.ToString() + "," + E.ToString();
                cheiePrivata.Text = n.ToString() + "," + d.ToString();
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e) //buton criptare
        {
            p = double.Parse(textBoxP.Text); //preiau valoarea lui P din textbox
            q = double.Parse(textBoxQ.Text); //preiau valoarea lui Q din textbox
            n = p * q; 
            z = (p - 1) * (q - 1);
            E = 17;
            d = generarePrim();
            Thread.Sleep(1000);
            cheiePublica.Text = n.ToString() + "," + E.ToString();
            cheiePrivata.Text = n.ToString() + "," + d.ToString();
            if (textBox5.TextLength != 0)
            {
                string mesaj = textBox5.Text;
                double m = 0;
                m = m + Convert.ToDouble(mesaj);
                //mesaj = (Math.Pow(m, E) % n).ToString();
                mesaj = BigInteger.ModPow((BigInteger)m, (BigInteger)E, (BigInteger)n).ToString();
                textBox1.Text = mesaj;
                button3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Eroare! Introduceti mesaj!");
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e) //buton decriptare
        {
            p = double.Parse(textBoxP.Text); //preiau valoarea lui P din textbox
            q = double.Parse(textBoxQ.Text); //preiau valoarea lui Q din textbox
            n = p * q;
            z = (p - 1) * (q - 1);
            E = 17;

            d = generarePrim();
            Thread.Sleep(1000);
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Eroare! Nu exista niciun text criptat!");
            }
            string mesajCriptat = textBox1.Text;
            c = Convert.ToDouble(mesajCriptat);
            BigInteger res = BigInteger.ModPow((BigInteger)c, (BigInteger)d, (BigInteger)n);
            string mesajDecriptat = res.ToString();
            textBox6.Text = mesajDecriptat;
            
        }

        public double generarePrim()
        {
            double d, i, ctr, stno, maxim, valoare = 0;

            p = double.Parse(textBoxP.Text); //preiau valoarea lui P din textbox
            q = double.Parse(textBoxQ.Text); //preiau valoarea lui Q din textbox
            n = p * q;
            z = (p - 1) * (q - 1);
            E = 17;

            stno = 2; //valoarea de inceput 1 < d < z
            maxim = z;//Convert.ToInt32(textBoxZ.Text);
            //valoarea lui z

            for (d = stno; d < maxim; d++) // 1 < d < z
            {
                ctr = 0; //nr divizori

                for (i = 2; i <= d / 2; i++)
                {
                    if (d % i == 0)
                    {
                        ctr++; //are divizori
                        break;
                    }
                }

                if (ctr == 0 && d != 1) //nu are divizori si nu este 1
                    if ((E * d) % z == 1) 
                    {
                        valoare += d;
                    }
            }
            return valoare;
        }
    }
}
