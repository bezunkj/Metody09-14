using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool ObsahujeSlovo(string s, out string longestW, out string shortestW)
        {
            char[] splitter = { ' ' };
            string[] words = s.Split(splitter, StringSplitOptions.RemoveEmptyEntries);

            longestW = words.Max();
            shortestW = words.Min();

            return (words.Length > 0);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            string longest;
            string shortest;
            if (ObsahujeSlovo(x, out longest, out shortest))
            {
                MessageBox.Show("Retezec obsahuje alespon 1 slovo\nNejdelsi slovo: " + longest + "\nNejkratsi slovo: " + shortest);
            }
        }
    }
}
