namespace Practica_2
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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            botonhello = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(156, 60);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 0;
            label1.Text = "Hello, Mundo!!";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(156, 134);
            label2.Name = "label2";
            label2.Size = new Size(133, 17);
            label2.TabIndex = 2;
            label2.Text = "¿Cual es tu nombre?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(157, 206);
            label3.Name = "label3";
            label3.Size = new Size(156, 17);
            label3.TabIndex = 3;
            label3.Text = "Hello, alguien especial!!";
            // 
            // botonhello
            // 
            botonhello.Location = new Point(376, 167);
            botonhello.Name = "botonhello";
            botonhello.Size = new Size(122, 42);
            botonhello.TabIndex = 4;
            botonhello.Text = "Diga \"Hello\"";
            botonhello.UseVisualStyleBackColor = true;
            botonhello.Click += botonhello_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 450);
            Controls.Add(botonhello);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hello, Mundo!!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button botonhello;
    }
}