namespace Practica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Radio, Altura, BaseArea, LateralArea, TotalArea, Volumen;

            Radio = double.Parse(textBox1.Text);
            Altura = double.Parse(textBox2.Text);

            BaseArea = Radio * Radio * Math.PI;
            LateralArea = 2 * Math.PI * Radio * Altura;
            TotalArea = 2 * Math.PI * Radio * (Altura + Radio);
            Volumen = Math.PI * Radio * Radio * Altura;

            textBox3.Text = BaseArea.ToString("0.##");
            textBox4.Text = LateralArea.ToString("0.##");
            textBox5.Text = TotalArea.ToString("0.##");
            textBox6.Text = Volumen.ToString("0.##");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}