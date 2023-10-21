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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Radio, Altura, Area, Volumen;

            Radio = double.Parse(textBox1.Text);
            Altura = double.Parse(textBox2.Text);
            Area = 2.0 * Math.PI * Radio * Altura + 2.0 * Math.PI * Math.Pow(Radio, 2.0);
            Volumen = Math.PI * Math.Pow(Radio, 2.0) * Altura;

            textBox3.Text = Area.ToString();
            textBox4.Text = Volumen.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
