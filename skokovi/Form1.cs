using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skokovi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = int.Parse(textBox1.Text);
            int s2 = int.Parse(textBox4.Text);
            int m1 = int.Parse(textBox2.Text);
            int m2 = int.Parse(textBox5.Text);
            int sek1 = int.Parse(textBox3.Text);
            int sek2 = int.Parse(textBox6.Text);
            if (s1 > s2)
            {
                label3.Text = "alfa veci od beta";
            }
            else if (s1 < s2)
            {
                label3.Text = "beta veci od alfa";
            }
            else if (s1 == s2)
            {
                if (m1 > m2)
                {
                    label3.Text = "alfa veci od beta";
                }
                else if (m1 < m2)
                {
                    label3.Text = "beta veci od alfa";
                }
                else if (m1 == m2)
                {
                    if (sek1 > sek2)
                    {
                        label3.Text = "alfa veci od beta";
                    }
                    else if (sek1 < sek2)
                    {
                        label3.Text = "beta veci od alfa";
                    }
                    else if (sek1 == sek2)
                    {
                        label3.Text = "uglovi su jednaki";
                    }
                }
            }
        }
    }
}
