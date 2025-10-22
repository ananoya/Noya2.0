namespace DAS_Ejercicio4
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
            dataGridView1 = new DataGridView();
            btnNuevoLibro = new Button();
            btnNuevoSocio = new Button();
            btnNuevoPrestamo = new Button();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PapayaWhip;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(17, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(584, 264);
            dataGridView1.TabIndex = 0;
            // 
            // btnNuevoLibro
            // 
            btnNuevoLibro.BackColor = Color.DarkSlateGray;
            btnNuevoLibro.ForeColor = SystemColors.ButtonHighlight;
            btnNuevoLibro.Location = new Point(17, 12);
            btnNuevoLibro.Name = "btnNuevoLibro";
            btnNuevoLibro.Size = new Size(101, 60);
            btnNuevoLibro.TabIndex = 1;
            btnNuevoLibro.Text = "Nuevo Libro";
            btnNuevoLibro.UseVisualStyleBackColor = false;
            // 
            // btnNuevoSocio
            // 
            btnNuevoSocio.BackColor = Color.DarkSlateGray;
            btnNuevoSocio.ForeColor = SystemColors.ButtonHighlight;
            btnNuevoSocio.Location = new Point(124, 12);
            btnNuevoSocio.Name = "btnNuevoSocio";
            btnNuevoSocio.Size = new Size(101, 60);
            btnNuevoSocio.TabIndex = 2;
            btnNuevoSocio.Text = "Nuevo Socio";
            btnNuevoSocio.UseVisualStyleBackColor = false;
            // 
            // btnNuevoPrestamo
            // 
            btnNuevoPrestamo.BackColor = Color.DarkSlateGray;
            btnNuevoPrestamo.ForeColor = SystemColors.ButtonHighlight;
            btnNuevoPrestamo.Location = new Point(231, 12);
            btnNuevoPrestamo.Name = "btnNuevoPrestamo";
            btnNuevoPrestamo.Size = new Size(101, 60);
            btnNuevoPrestamo.TabIndex = 3;
            btnNuevoPrestamo.Text = "Nuevo Prestamo";
            btnNuevoPrestamo.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.PapayaWhip;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = SystemColors.InactiveCaptionText;
            dataGridView2.Location = new Point(632, 87);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(568, 264);
            dataGridView2.TabIndex = 4;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.AntiqueWhite;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.GridColor = SystemColors.InactiveCaptionText;
            dataGridView3.Location = new Point(17, 366);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(1183, 320);
            dataGridView3.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 698);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(btnNuevoPrestamo);
            Controls.Add(btnNuevoSocio);
            Controls.Add(btnNuevoLibro);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnNuevoLibro;
        private Button btnNuevoSocio;
        private Button btnNuevoPrestamo;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
    }
}
