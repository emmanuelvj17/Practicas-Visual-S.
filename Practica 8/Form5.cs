using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_8
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Diagonalmayor, Diagonalmenor, Area;

            Diagonalmayor = double.Parse(textBox1.Text);
            Diagonalmenor = double.Parse(textBox2.Text);
            Area = Diagonalmayor * Diagonalmenor / 2.0;

            textBox3.Text = Area.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
