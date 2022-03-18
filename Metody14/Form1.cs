using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Identicke(string x, string y, out int indexPrvniOdlisnosti, out int pocetOdlisnosti)
        {
            bool vysledek;
            pocetOdlisnosti = 0;
            indexPrvniOdlisnosti = -1;
            if (x == y)
            {
                vysledek = true;
            }
            else
            {
                vysledek = false;

                int minLenght = Math.Min(x.Length, y.Length);
                for (int i = 0; i < minLenght; i++)
                {
                    if (x[i] != y[i])
                    {
                        pocetOdlisnosti++;
                        if (indexPrvniOdlisnosti == -1)
                        {
                            indexPrvniOdlisnosti = i;
                        }
                    }
                }

                int lenghtDifference = Math.Abs(x.Length - y.Length);
                pocetOdlisnosti += lenghtDifference;
                if (indexPrvniOdlisnosti == -1)
                {
                    indexPrvniOdlisnosti = minLenght;
                }
            }
            return vysledek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            string y = textBox2.Text;
            int indexPrvniOdlisnosti;
            int pocetOdlisnosti;


            if (Identicke(x, y, out indexPrvniOdlisnosti, out pocetOdlisnosti))
            {
                MessageBox.Show("Retezce jsou naprosto shodne");
                //MessageBox.Show("Retezce jsou naprosto shodne\nIndex prvni odlisnosti: " + indexPrvniOdlisnosti + "\nPocet odlisnosti: " + pocetOdlisnosti);

            }
            else
            {
                MessageBox.Show("Retezce nejsou naprosto shodne\nIndex prvni odlisnosti: " + indexPrvniOdlisnosti + "\nPocet odlisnosti: " + pocetOdlisnosti);
            } 
        }
    }
}
