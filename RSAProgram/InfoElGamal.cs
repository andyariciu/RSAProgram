using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAProgram
{
    public partial class InfoElGamal : Form
    {
        public InfoElGamal()
        {
            InitializeComponent();
        }

        private void InfoElGamal_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Algoritm 1. Generarea cheilor pentru criptarea cu chei publice El-Gamal";
            textBox2.AppendText(Environment.NewLine);
            textBox2.Text += "1. Generarea unui număr p prim, cu o valoare mare, şi a unui număr alpha din Z* p; ";
            textBox2.AppendText(Environment.NewLine);
            textBox2.Text += "2. Selectarea unui număr întreg aleator a, 1 ≤ a ≤ p-2, şi calcularea alpha^a mod p; ";
            textBox2.AppendText(Environment.NewLine);
            textBox2.Text += "A deţine cheia publică (p, alpha, alpha^a) şi cheia privată a.";
            textBox2.AppendText(Environment.NewLine);
            textBox2.Text += "3. Se găseşte un număr d, astfel încât (e x d) mod z = 1 şi 1 < d < z.";
            textBox2.AppendText(Environment.NewLine);
            textBox2.Text += "Algoritm 2. Criptarea cu chei publice El-Gamal";
            textBox2.AppendText(Environment.NewLine);
            textBox2.Text += "1. Obţinerea cheii publice aparţinând lui A (p, alpha, alpha^a)";
            textBox2.AppendText(Environment.NewLine);
            textBox2.Text += "2. Reprezentarea mesajului ca un număr întreg aparţinând domeniului { 0,1,...,p - 1} ";
            textBox2.AppendText(Environment.NewLine);
            textBox2.Text += "3. Selectarea unui număr întreg aleator k, 1 ≤ k ≤ p-2;";
            textBox2.AppendText(Environment.NewLine);
            textBox2.Text += "4. Calcularea gamma = alpha^k mod p şi a lui delta = m(alpha^a)k mod p.";
            textBox2.AppendText(Environment.NewLine);
            textBox2.Text += "5. Trimiterea către A a textului cifrat c=(gamma,delta)";
            textBox2.AppendText(Environment.NewLine);
            textBox2.Text += "Algoritm 3. Decriptarea cu chei publice El-Gamal";
            textBox2.AppendText(Environment.NewLine);
            textBox2.Text += "6. Folosind cheia privată alpha, se calculează gamma^(p-1-a) mod p, cu gamma^(p-1-a)=gamma^(-a)=alpha(-ak)";
            textBox2.AppendText(Environment.NewLine);
            textBox2.Text += "7. Recuperarea lui m calculând (gamma^(-a))delta mod p.";
        }
    }
}
