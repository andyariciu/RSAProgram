using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAProgram
{
    public partial class ElGamal : Form
    {
        public ElGamal()
        {
            InitializeComponent();
            btnCriptare.Enabled = false; //la initializare, butonul de criptare este neutilizabil pana la generarea cheilor
            btnDecriptare.Enabled = false; //la initializare, butonul de decriptare este neutilizabil pana criptarea unui mesaj
        }

        double p, alpha, k, gamma, delta, m, a;

        private void button1_Click(object sender, EventArgs e) //buton info
        {
            Info f2 = new Info();
            f2.ShowDialog();
        }

        private void genereazaChei_Click(object sender, EventArgs e)
        {
            p = double.Parse(textBoxP.Text); //preiau valoarea lui P din textbox
            alpha = double.Parse(textBoxAlpha.Text); //preiau valoarea lui alpha din textbox
            Random rnd = new Random(); //declararea unui obiect - numar de tip random
            double a = rnd.Next(1, (int)p-2); // generarea unui numar random
            BigInteger nr = BigInteger.ModPow((BigInteger)alpha, (BigInteger)a, (BigInteger)p); //calcul a^a mod p
            double k = rnd.Next(1, (int)p-2);
            BigInteger gamma = BigInteger.ModPow((BigInteger)a, (BigInteger)k, (BigInteger)p); //calcul a^k mod p
            BigInteger alphaLaA = BigInteger.Pow((BigInteger)alpha, (int)a); //calcul (a^a)
            BigInteger delta = BigInteger.ModPow(alphaLaA, (BigInteger)k, (BigInteger)p); //calcul (a^a)^k mod p
            textBoxA.Text = a.ToString();
            cheiePublica.Text = p.ToString() + "," + alpha.ToString() + "," + nr.ToString();
            textBoxK.Text = k.ToString();
            textBoxGamma.Text = gamma.ToString();;
            cheiePrivata.Text = a.ToString();
            btnCriptare.Enabled = true;
        }
       
        private void btnCriptare_Click(object sender, EventArgs e)
        {
            p = double.Parse(textBoxP.Text); //preiau valoarea lui P din textbox
            alpha = double.Parse(textBoxAlpha.Text); //preiau valoarea lui alpha din textbox
            a = double.Parse(textBoxA.Text);
            k = double.Parse(textBoxK.Text);
            gamma = double.Parse(textBoxGamma.Text);
            BigInteger alphaLaA = BigInteger.Pow((BigInteger)alpha, (int)a); //calcul (a^a)
            BigInteger delta = BigInteger.ModPow(alphaLaA, (BigInteger)k, (BigInteger)p); //calcul (a^a)^k mod p
            m = double.Parse(textBoxM.Text);
            BigInteger deltaM = BigInteger.Remainder(((BigInteger)m * delta), (BigInteger)p); //(m*(alpha^a))modP
            textBoxDelta.Text = deltaM.ToString();
            textCifrat.Text = gamma.ToString() + "," + deltaM.ToString();
            btnDecriptare.Enabled = true;
        }

        private void btnDecriptare_Click(object sender, EventArgs e)
        {
            p = double.Parse(textBoxP.Text); //preiau valoarea lui P din textbox
            alpha = double.Parse(textBoxAlpha.Text); //preiau valoarea lui alpha din textbox
            a = double.Parse(textBoxA.Text);
            k = double.Parse(textBoxK.Text);
            gamma = double.Parse(textBoxGamma.Text);
            delta = double.Parse(textBoxDelta.Text);
            BigInteger calcul1 = BigInteger.ModPow((BigInteger)gamma, (BigInteger)(p-1-a), (BigInteger)p);
            BigInteger mesajDescifrat = BigInteger.ModPow((calcul1 * (BigInteger)delta), 1, (BigInteger)p);
            mesajDecriptat.Text = textBoxM.Text.ToString();
        }
    }
}
