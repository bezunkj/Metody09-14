using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool JeAlfanum(string s, out int countLower, out int countUpper, out int countNonAlfanum)
        {
            bool result = true;
            countLower = 0;
            countUpper = 0;
            countNonAlfanum = 0;
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    if (char.IsLower(c))
                    {
                        countLower++;
                    }
                    if (char.IsUpper(c))
                    {
                        countUpper++;
                    }
                } else
                {
                    result = false;
                    countNonAlfanum++;
                }
            }

            return result;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            int lower;
            int upper;
            int nonAlfanum;
            if (JeAlfanum(x, out lower, out upper, out nonAlfanum))
            {
                MessageBox.Show("Retezec obsahuje jen alfanumericke znaky\npocet malych zn.: " + lower + "\npocet velkych zn.: " + upper + "\npocet jinych zn.: " + nonAlfanum);
            } else {
                MessageBox.Show("Retezec NEobsahuje jen alfanumericke znaky\npocet malych zn.: " + lower + "\npocet velkych zn.: " + upper + "\npocet jinych zn.: " + nonAlfanum);
            }
        }
    }
}
