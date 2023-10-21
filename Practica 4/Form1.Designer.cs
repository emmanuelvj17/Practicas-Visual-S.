namespace Practica_4
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(208, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(208, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(153, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(208, 335);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(153, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(557, 99);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(142, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(557, 182);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(142, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(557, 256);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(142, 23);
            textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(557, 335);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(142, 23);
            textBox8.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(341, 399);
            button1.Name = "button1";
            button1.Size = new Size(167, 64);
            button1.TabIndex = 8;
            button1.Text = "Invertir orden";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(267, 35);
            label1.Name = "label1";
            label1.Size = new Size(335, 25);
            label1.TabIndex = 9;
            label1.Text = "Escribir numeros en orden inverso.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 102);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 10;
            label2.Text = "Numero A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 185);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 11;
            label3.Text = "Numero B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 259);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 12;
            label4.Text = "Numero C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 338);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 13;
            label5.Text = "Numero D";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(472, 102);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 14;
            label6.Text = "Numero A";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(472, 190);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 15;
            label7.Text = "Numero B";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(472, 264);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 16;
            label8.Text = "Numero C";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(472, 338);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 17;
            label9.Text = "Numero D";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(813, 511);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Invertir Numeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}