namespace Practica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonhello_Click(object sender, EventArgs e)
        {
            botonhello.Text = "Hello, " + textBox1.Text + "!";

        }
    }
}