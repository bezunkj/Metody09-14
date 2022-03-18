using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Disktriminant(int a, int b, int c)
        {
            double diskriminant = b * b - 4 * a * c;
            return diskriminant;
        }

        private bool KvadratickaRovnice(int a, int b, int c, out double x1, out double x2)
        {
            double d = Disktriminant(a, b, c);
            bool vysledek;
            x1 = 0;
            x2 = 0;
            if(d == 0)
            {
                vysledek = true;
                x1 = (-1 * b) / (2 * a);

            } else if (d > 0)
            {
                vysledek = true;
                x1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
                x2 = (-1 * b - Math.Sqrt(d)) / (2 * a);

            } else {

                vysledek = false;
            }

            return vysledek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);

            double r1;
            double r2;

            if (KvadratickaRovnice(a, b, c, out r1, out r2))
            {
                if(Disktriminant(a,b,c) == 0)
                {
                    // 1 reseni
                    MessageBox.Show("kb. rovnice ma 1 reseni a to \nx: " + r1);
                } else
                {
                    // 2 reseni
                    MessageBox.Show("kb. rovnice ma 1 reseni a to \nx1: " + r1 + "\nx2: " + r2);
                }


            } else
            {
                MessageBox.Show("Kv. rovnice nema reseni");
            }

        }
    }
}
