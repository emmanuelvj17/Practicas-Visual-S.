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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a, Area, Volumen;
            a = double.Parse(textBox1.Text);
            Area = 2.0 * Math.Pow(a, 2) * Math.Sqrt(3);
            Volumen = ((Math.Pow(a, 3)) * Math.Sqrt(2)) / 3;

            textBox2.Text = Area.ToString();
            textBox3.Text = Volumen.ToString();


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
