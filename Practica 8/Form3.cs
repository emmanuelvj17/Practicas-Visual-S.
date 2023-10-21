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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Areacara, Areatotal, Volumen;
            Areacara = double.Parse(textBox1.Text);
            Areatotal = 6 * Math.Pow(Areacara, 2);
            Volumen = Math.Pow(Areacara, 3);

            textBox2.Text = Areatotal.ToString();
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
