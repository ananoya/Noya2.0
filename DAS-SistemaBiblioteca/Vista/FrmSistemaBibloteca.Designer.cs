namespace DAS_SistemaBiblioteca
{
    partial class FrmSistemaBibloteca
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
            dtvgSocios = new DataGridView();
            dtvgPrestamos = new DataGridView();
            dtvgLibros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtvgSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvgPrestamos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvgLibros).BeginInit();
            SuspendLayout();
            // 
            // dtvgSocios
            // 
            dtvgSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgSocios.Location = new Point(12, 130);
            dtvgSocios.Name = "dtvgSocios";
            dtvgSocios.RowHeadersWidth = 51;
            dtvgSocios.Size = new Size(300, 448);
            dtvgSocios.TabIndex = 0;
            // 
            // dtvgPrestamos
            // 
            dtvgPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgPrestamos.Location = new Point(332, 130);
            dtvgPrestamos.Name = "dtvgPrestamos";
            dtvgPrestamos.RowHeadersWidth = 51;
            dtvgPrestamos.Size = new Size(300, 448);
            dtvgPrestamos.TabIndex = 1;
            // 
            // dtvgLibros
            // 
            dtvgLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgLibros.Location = new Point(652, 130);
            dtvgLibros.Name = "dtvgLibros";
            dtvgLibros.RowHeadersWidth = 51;
            dtvgLibros.Size = new Size(300, 448);
            dtvgLibros.TabIndex = 2;
            dtvgLibros.CellContentClick += dtvgLibros_CellContentClick;
            // 
            // FrmSistemaBibloteca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 732);
            Controls.Add(dtvgLibros);
            Controls.Add(dtvgPrestamos);
            Controls.Add(dtvgSocios);
            Name = "FrmSistemaBibloteca";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtvgSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvgPrestamos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvgLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtvgSocios;
        private DataGridView dtvgPrestamos;
        private DataGridView dtvgLibros;
    }
}
