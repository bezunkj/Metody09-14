using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int PocetSlov(string x, out string newString)
        {
            char[] separators = { ' ' };
            string[] slova = x.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            newString = x;

            for (int i = 0; i < newString.Length; i++)
            {
                if (char.IsDigit(newString[i]))
                {
                    newString = newString.Remove(i, 1);
                    i--;
                }
            }

            return slova.Length;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            string bezCislic;
            int pocet = PocetSlov(x, out bezCislic);
            MessageBox.Show("Pocet slov: " + pocet + "\nRetezec bez cislic: " + bezCislic);
        }
    }
}
