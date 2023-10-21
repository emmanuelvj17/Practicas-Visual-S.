namespace Practica_8
{
    partial class Form5
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(368, 53);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 0;
            label1.Text = "Rombo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 142);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Diagonal Mayor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 142);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 2;
            label3.Text = "Diagonal Menor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 240);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Area";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(257, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(546, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(350, 237);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 23);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(227, 307);
            button1.Name = "button1";
            button1.Size = new Size(106, 45);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(368, 307);
            button2.Name = "button2";
            button2.Size = new Size(106, 45);
            button2.TabIndex = 8;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(504, 307);
            button3.Name = "button3";
            button3.Size = new Size(106, 45);
            button3.TabIndex = 9;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Rombo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}