namespace Practica_8
{
    partial class Form2
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
            label1.Location = new Point(324, 41);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Triangulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 119);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Base";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 119);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Altura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 251);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Area";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(460, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(113, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(324, 280);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(119, 23);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(136, 183);
            button1.Name = "button1";
            button1.Size = new Size(91, 34);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(324, 183);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 8;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(503, 183);
            button3.Name = "button3";
            button3.Size = new Size(103, 34);
            button3.TabIndex = 9;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(726, 375);
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
            Name = "Form2";
            Text = "Triangulo";
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