namespace Practica_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(188, 26);
            label1.Name = "label1";
            label1.Size = new Size(337, 25);
            label1.TabIndex = 0;
            label1.Text = "Introduce las Dimensiones del Cilindro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 96);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Radio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 143);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Altura";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(370, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(370, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(140, 193);
            button1.Name = "button1";
            button1.Size = new Size(117, 44);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(315, 193);
            button2.Name = "button2";
            button2.Size = new Size(130, 44);
            button2.TabIndex = 6;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(491, 193);
            button3.Name = "button3";
            button3.Size = new Size(111, 44);
            button3.TabIndex = 7;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 276);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 8;
            label4.Text = "Base Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 326);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 9;
            label5.Text = "Lateral Area";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(188, 379);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 10;
            label6.Text = "Total Area";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(188, 433);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 11;
            label7.Text = "Volumen";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(370, 276);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(370, 326);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(127, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(370, 379);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(127, 23);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(370, 430);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(127, 23);
            textBox6.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(707, 508);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}