namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A, B, C, D;
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);
            C = int.Parse(textBox3.Text);
            D = int.Parse(textBox4.Text);


            textBox5.Text = D.ToString();
            textBox6.Text = C.ToString();
            textBox7.Text = B.ToString();
            textBox8.Text = A.ToString();
        }
    }
}