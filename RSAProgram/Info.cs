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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            textBox1.Text += "1. Se aleg doua numere prime p si q";
            textBox1.AppendText(Environment.NewLine);
            textBox1.Text += "2. Se calculează n = p x q şi z = (p-1) x (q-1) \n";
            textBox1.AppendText(Environment.NewLine);
            textBox1.Text += "3. Se alege un număr e relativ prim cu z, astfel încât 1 < e < z;";
            textBox1.AppendText(Environment.NewLine);
            textBox1.Text += "4. Se găseşte un număr d, astfel încât (e x d) mod z = 1 şi 1 < d < z.";
            textBox1.AppendText(Environment.NewLine);
            textBox1.Text += "e - exponent public, d - exponent privat";
            textBox1.AppendText(Environment.NewLine);
            textBox1.Text += "Cheia publica (n,e); Cheie privata (n,d)";
            textBox1.AppendText(Environment.NewLine);
            textBox1.Text += "5. Pentru a obtine mesajul criptat c: c(n,e) = m^e mod n";
            textBox1.AppendText(Environment.NewLine);
            textBox1.Text += "6. Pentru decriptare, mesajul m (n,d) = c^d mod n";

        }
    }
}
