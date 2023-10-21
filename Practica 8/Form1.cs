namespace Practica_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double Radio, Area, Volumen;

            Radio = double.Parse(textBox1.Text);
            Area = 4.0 * Math.PI * Math.Pow(Radio, 2.0);
            Volumen = 4.0 / 3.0 * Math.PI * Math.Pow(Radio, 3.0);

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