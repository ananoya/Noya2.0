namespace DAS_Ejercicio4
{
    partial class FrmNuevoLibro
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century751 SeBd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 50);
            label1.Name = "label1";
            label1.Size = new Size(45, 18);
            label1.TabIndex = 0;
            label1.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century751 SeBd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 89);
            label2.Name = "label2";
            label2.Size = new Size(50, 18);
            label2.TabIndex = 1;
            label2.Text = "Titulo";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century751 SeBd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 119);
            label3.Name = "label3";
            label3.Size = new Size(49, 18);
            label3.TabIndex = 2;
            label3.Text = "Autor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century751 SeBd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 157);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(105, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 23);
            textBox3.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(105, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 23);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(232, 196);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmNuevoLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 252);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmNuevoLibro";
            Text = "FrmNuevoLibro";
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
        private ComboBox comboBox1;
        private Button button1;
    }
}