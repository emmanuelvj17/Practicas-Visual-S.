namespace Practica_8
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(372, 48);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Cilindro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 115);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Radio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 115);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Altura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 208);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(441, 211);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Volumen";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(279, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(486, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(279, 208);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(123, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(501, 208);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(128, 23);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(152, 295);
            button1.Name = "button1";
            button1.Size = new Size(112, 42);
            button1.TabIndex = 9;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(344, 295);
            button2.Name = "button2";
            button2.Size = new Size(111, 42);
            button2.TabIndex = 10;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(529, 295);
            button3.Name = "button3";
            button3.Size = new Size(113, 42);
            button3.TabIndex = 11;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Cilindro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}