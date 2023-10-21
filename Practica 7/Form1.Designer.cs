namespace Practica_7
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
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 19);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 0;
            label1.Text = "Datos.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(129, 62);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingresa Valor:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 128);
            label3.Name = "label3";
            label3.Size = new Size(161, 15);
            label3.TabIndex = 3;
            label3.Text = "Operaciones de Conversion.";
            // 
            // button1
            // 
            button1.Location = new Point(63, 174);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 4;
            button1.Text = "Fahrenheit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(327, 174);
            button2.Name = "button2";
            button2.Size = new Size(123, 34);
            button2.TabIndex = 5;
            button2.Text = "Centigrados";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(191, 233);
            button3.Name = "button3";
            button3.Size = new Size(117, 35);
            button3.TabIndex = 6;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(51, 281);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 7;
            label4.Text = "Resultado en Grados.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(171, 323);
            label5.Name = "label5";
            label5.Size = new Size(137, 15);
            label5.TabIndex = 8;
            label5.Text = "Equivalencia en Grados:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 357);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(103, 23);
            textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(477, 450);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conversiones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
    }
}