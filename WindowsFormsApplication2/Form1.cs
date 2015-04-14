using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class PermutaNumero : Form
    {
        public PermutaNumero()
        {
            InitializeComponent();
        }

        private void verificar_Click(object sender, EventArgs e)
        {
            String a = txtNumeroA.Text;
            String b = txtNumeroB.Text;

            bool ehPermutacao = true;

            if (a.Length != b.Length)
            {
                ehPermutacao = false;
            }

            int c;
            for (c = 0; c < a.Length; c++)
            {
                String idx = a.Substring(c, 1);
                if (b.Contains(idx) == false)
                {
                    ehPermutacao = false;
                    break;
                }
                else
                {
                    b = b.Remove(b.IndexOf(idx), 1);
                }
            }

            if (!ehPermutacao)
            {
                MessageBox.Show("Não é permutação.");
            }
            else
            {
                MessageBox.Show("É permutação.");
            }
        }
    }
}
