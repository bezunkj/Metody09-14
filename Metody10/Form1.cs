using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ObsahujeCislici(string x, out int cifSoucet, out int soucLichCif, out int soucSudCif)
        {
            bool obsahujeCifru = false;
            cifSoucet = 0;
            soucLichCif = 0;
            soucSudCif = 0;
            foreach (char znak in x)
            {
                if (char.IsDigit(znak))
                {
                    obsahujeCifru = true;
                    int cislo = Convert.ToInt32(char.ToString(znak));
                    cifSoucet += cislo;
                    if(cislo % 2 == 0)
                    {
                        soucSudCif += cislo;
                    } else
                    {
                        soucLichCif += cislo;
                    }
                    
                }
            }
            return obsahujeCifru;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            int cifSouc;
            int soucLich;
            int soucSud;

            if(ObsahujeCislici(x,out cifSouc, out soucLich, out soucSud))
            {
                MessageBox.Show("Retezec obsahuje alespon 1 cislici\ncif. soucet: " + cifSouc + "\nsouc. lich. cifer: " + soucLich + "\nsouc. sud. cifer: " + soucSud);
            } else
            {
                MessageBox.Show("Retezec neobsahuje zadnou cislici");
            }

        }
    }
}
