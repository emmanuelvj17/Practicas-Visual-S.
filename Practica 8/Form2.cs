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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Base, Altura, Area;
            Base = double.Parse(textBox1.Text);
            Altura = double.Parse(textBox2.Text);
            Area = Base * Altura / 2;

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
