namespace Vista
{
    partial class FrmGestionarCliente
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
            btnFormClienteFiltrarClientesActivos = new Button();
            lblClienteForm = new Label();
            dtvgClienteFrmGestionarCliente = new DataGridView();
            btnAgregarCliente = new Button();
            txtApellidoCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtDniCliente = new TextBox();
            txtNombreCliente = new TextBox();
            lblDniCliente = new Label();
            lblApellidoCliente = new Label();
            lblTelefonoCliente = new Label();
            lblNombreCliente = new Label();
            lblFormGestionarClienteSeleccionar = new Label();
            btnEliminarCliente = new Button();
            btnModificarCliente = new Button();
            lblFormGestionarClienteAgregar = new Label();
            txtApellidoCliente2 = new TextBox();
            txtTelefonoCliente2 = new TextBox();
            txtDniCliente2 = new TextBox();
            txtNombreCliente2 = new TextBox();
            lblDniCliente2 = new Label();
            lblApellidoCliente2 = new Label();
            lblTelefonoCliente2 = new Label();
            lblNombreCliente2 = new Label();
            txtIdCliente2 = new TextBox();
            lblIdCliente2 = new Label();
            txtEstadoCliente2 = new TextBox();
            lblEstadoCliente2 = new Label();
            btnRefrescar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvgClienteFrmGestionarCliente).BeginInit();
            SuspendLayout();
            // 
            // btnFormClienteFiltrarClientesActivos
            // 
            btnFormClienteFiltrarClientesActivos.Location = new Point(110, 34);
            btnFormClienteFiltrarClientesActivos.Name = "btnFormClienteFiltrarClientesActivos";
            btnFormClienteFiltrarClientesActivos.Size = new Size(198, 25);
            btnFormClienteFiltrarClientesActivos.TabIndex = 29;
            btnFormClienteFiltrarClientesActivos.Text = "Filtrar Clientes Activos";
            btnFormClienteFiltrarClientesActivos.UseVisualStyleBackColor = true;
            btnFormClienteFiltrarClientesActivos.Click += btnFormClienteFiltrarClientesActivos_Click;
            // 
            // lblClienteForm
            // 
            lblClienteForm.AutoSize = true;
            lblClienteForm.BackColor = SystemColors.ActiveBorder;
            lblClienteForm.Location = new Point(29, 39);
            lblClienteForm.Name = "lblClienteForm";
            lblClienteForm.Size = new Size(61, 20);
            lblClienteForm.TabIndex = 28;
            lblClienteForm.Text = "Clientes";
            // 
            // dtvgClienteFrmGestionarCliente
            // 
            dtvgClienteFrmGestionarCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgClienteFrmGestionarCliente.Location = new Point(29, 74);
            dtvgClienteFrmGestionarCliente.Name = "dtvgClienteFrmGestionarCliente";
            dtvgClienteFrmGestionarCliente.RowHeadersWidth = 51;
            dtvgClienteFrmGestionarCliente.Size = new Size(581, 580);
            dtvgClienteFrmGestionarCliente.TabIndex = 27;
            dtvgClienteFrmGestionarCliente.CellClick += dtvgClienteFrmGestionarCliente_CellClick;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(816, 259);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(155, 29);
            btnAgregarCliente.TabIndex = 38;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(744, 121);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(227, 27);
            txtApellidoCliente.TabIndex = 37;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(744, 162);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(227, 27);
            txtTelefonoCliente.TabIndex = 36;
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new Point(744, 210);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(227, 27);
            txtDniCliente.TabIndex = 35;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(744, 74);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(227, 27);
            txtNombreCliente.TabIndex = 34;
            // 
            // lblDniCliente
            // 
            lblDniCliente.AutoSize = true;
            lblDniCliente.Location = new Point(674, 217);
            lblDniCliente.Name = "lblDniCliente";
            lblDniCliente.Size = new Size(38, 20);
            lblDniCliente.TabIndex = 33;
            lblDniCliente.Text = "DNI:";
            // 
            // lblApellidoCliente
            // 
            lblApellidoCliente.AutoSize = true;
            lblApellidoCliente.Location = new Point(646, 128);
            lblApellidoCliente.Name = "lblApellidoCliente";
            lblApellidoCliente.Size = new Size(69, 20);
            lblApellidoCliente.TabIndex = 32;
            lblApellidoCliente.Text = "Apellido:";
            // 
            // lblTelefonoCliente
            // 
            lblTelefonoCliente.AutoSize = true;
            lblTelefonoCliente.Location = new Point(645, 169);
            lblTelefonoCliente.Name = "lblTelefonoCliente";
            lblTelefonoCliente.Size = new Size(70, 20);
            lblTelefonoCliente.TabIndex = 31;
            lblTelefonoCliente.Text = "Telefono:";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(645, 81);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(67, 20);
            lblNombreCliente.TabIndex = 30;
            lblNombreCliente.Text = "Nombre:";
            // 
            // lblFormGestionarClienteSeleccionar
            // 
            lblFormGestionarClienteSeleccionar.AutoSize = true;
            lblFormGestionarClienteSeleccionar.BackColor = SystemColors.ActiveBorder;
            lblFormGestionarClienteSeleccionar.Location = new Point(647, 315);
            lblFormGestionarClienteSeleccionar.Name = "lblFormGestionarClienteSeleccionar";
            lblFormGestionarClienteSeleccionar.Size = new Size(312, 20);
            lblFormGestionarClienteSeleccionar.TabIndex = 39;
            lblFormGestionarClienteSeleccionar.Text = "Seleccionar Cliente para Eliminar o Modificar ";
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(632, 603);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(178, 29);
            btnEliminarCliente.TabIndex = 42;
            btnEliminarCliente.Text = "Eliminar Cliente";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(816, 603);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(178, 29);
            btnModificarCliente.TabIndex = 43;
            btnModificarCliente.Text = "Modificar Cliente";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // lblFormGestionarClienteAgregar
            // 
            lblFormGestionarClienteAgregar.AutoSize = true;
            lblFormGestionarClienteAgregar.BackColor = SystemColors.ActiveBorder;
            lblFormGestionarClienteAgregar.Location = new Point(632, 39);
            lblFormGestionarClienteAgregar.Name = "lblFormGestionarClienteAgregar";
            lblFormGestionarClienteAgregar.Size = new Size(223, 20);
            lblFormGestionarClienteAgregar.TabIndex = 45;
            lblFormGestionarClienteAgregar.Text = "Formulario para Agregar Cliente";
            // 
            // txtApellidoCliente2
            // 
            txtApellidoCliente2.Location = new Point(750, 437);
            txtApellidoCliente2.Name = "txtApellidoCliente2";
            txtApellidoCliente2.Size = new Size(227, 27);
            txtApellidoCliente2.TabIndex = 53;
            // 
            // txtTelefonoCliente2
            // 
            txtTelefonoCliente2.Location = new Point(750, 478);
            txtTelefonoCliente2.Name = "txtTelefonoCliente2";
            txtTelefonoCliente2.Size = new Size(227, 27);
            txtTelefonoCliente2.TabIndex = 52;
            // 
            // txtDniCliente2
            // 
            txtDniCliente2.Location = new Point(750, 526);
            txtDniCliente2.Name = "txtDniCliente2";
            txtDniCliente2.Size = new Size(227, 27);
            txtDniCliente2.TabIndex = 51;
            // 
            // txtNombreCliente2
            // 
            txtNombreCliente2.Location = new Point(750, 390);
            txtNombreCliente2.Name = "txtNombreCliente2";
            txtNombreCliente2.Size = new Size(227, 27);
            txtNombreCliente2.TabIndex = 50;
            // 
            // lblDniCliente2
            // 
            lblDniCliente2.AutoSize = true;
            lblDniCliente2.Location = new Point(680, 533);
            lblDniCliente2.Name = "lblDniCliente2";
            lblDniCliente2.Size = new Size(38, 20);
            lblDniCliente2.TabIndex = 49;
            lblDniCliente2.Text = "DNI:";
            // 
            // lblApellidoCliente2
            // 
            lblApellidoCliente2.AutoSize = true;
            lblApellidoCliente2.Location = new Point(652, 444);
            lblApellidoCliente2.Name = "lblApellidoCliente2";
            lblApellidoCliente2.Size = new Size(69, 20);
            lblApellidoCliente2.TabIndex = 48;
            lblApellidoCliente2.Text = "Apellido:";
            // 
            // lblTelefonoCliente2
            // 
            lblTelefonoCliente2.AutoSize = true;
            lblTelefonoCliente2.Location = new Point(651, 485);
            lblTelefonoCliente2.Name = "lblTelefonoCliente2";
            lblTelefonoCliente2.Size = new Size(70, 20);
            lblTelefonoCliente2.TabIndex = 47;
            lblTelefonoCliente2.Text = "Telefono:";
            // 
            // lblNombreCliente2
            // 
            lblNombreCliente2.AutoSize = true;
            lblNombreCliente2.Location = new Point(651, 397);
            lblNombreCliente2.Name = "lblNombreCliente2";
            lblNombreCliente2.Size = new Size(67, 20);
            lblNombreCliente2.TabIndex = 46;
            lblNombreCliente2.Text = "Nombre:";
            // 
            // txtIdCliente2
            // 
            txtIdCliente2.Location = new Point(750, 347);
            txtIdCliente2.Name = "txtIdCliente2";
            txtIdCliente2.ReadOnly = true;
            txtIdCliente2.Size = new Size(227, 27);
            txtIdCliente2.TabIndex = 54;
            // 
            // lblIdCliente2
            // 
            lblIdCliente2.AutoSize = true;
            lblIdCliente2.Location = new Point(685, 350);
            lblIdCliente2.Name = "lblIdCliente2";
            lblIdCliente2.Size = new Size(27, 20);
            lblIdCliente2.TabIndex = 55;
            lblIdCliente2.Text = "ID:";
            // 
            // txtEstadoCliente2
            // 
            txtEstadoCliente2.Location = new Point(750, 570);
            txtEstadoCliente2.Name = "txtEstadoCliente2";
            txtEstadoCliente2.ReadOnly = true;
            txtEstadoCliente2.Size = new Size(227, 27);
            txtEstadoCliente2.TabIndex = 57;
            // 
            // lblEstadoCliente2
            // 
            lblEstadoCliente2.AutoSize = true;
            lblEstadoCliente2.Location = new Point(664, 573);
            lblEstadoCliente2.Name = "lblEstadoCliente2";
            lblEstadoCliente2.Size = new Size(57, 20);
            lblEstadoCliente2.TabIndex = 56;
            lblEstadoCliente2.Text = "Estado:";
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(338, 34);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(198, 25);
            btnRefrescar.TabIndex = 58;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(816, 636);
            button1.Name = "button1";
            button1.Size = new Size(178, 29);
            button1.TabIndex = 59;
            button1.Text = "Reactivar Cliente";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmGestionarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 677);
            Controls.Add(button1);
            Controls.Add(btnRefrescar);
            Controls.Add(txtEstadoCliente2);
            Controls.Add(lblEstadoCliente2);
            Controls.Add(lblIdCliente2);
            Controls.Add(txtIdCliente2);
            Controls.Add(txtApellidoCliente2);
            Controls.Add(txtTelefonoCliente2);
            Controls.Add(txtDniCliente2);
            Controls.Add(txtNombreCliente2);
            Controls.Add(lblDniCliente2);
            Controls.Add(lblApellidoCliente2);
            Controls.Add(lblTelefonoCliente2);
            Controls.Add(lblNombreCliente2);
            Controls.Add(lblFormGestionarClienteAgregar);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnEliminarCliente);
            Controls.Add(lblFormGestionarClienteSeleccionar);
            Controls.Add(btnAgregarCliente);
            Controls.Add(txtApellidoCliente);
            Controls.Add(txtTelefonoCliente);
            Controls.Add(txtDniCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(lblDniCliente);
            Controls.Add(lblApellidoCliente);
            Controls.Add(lblTelefonoCliente);
            Controls.Add(lblNombreCliente);
            Controls.Add(btnFormClienteFiltrarClientesActivos);
            Controls.Add(lblClienteForm);
            Controls.Add(dtvgClienteFrmGestionarCliente);
            Name = "FrmGestionarCliente";
            Text = "FrmGestionarCliente";
            Load += FrmGestionarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dtvgClienteFrmGestionarCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFormClienteFiltrarClientesActivos;
        private Label lblClienteForm;
        private DataGridView dtvgClienteFrmGestionarCliente;
        private Button btnAgregarCliente;
        private TextBox txtApellidoCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtDniCliente;
        private TextBox txtNombreCliente;
        private Label lblDniCliente;
        private Label lblApellidoCliente;
        private Label lblTelefonoCliente;
        private Label lblNombreCliente;
        private Label lblFormGestionarClienteSeleccionar;
        private Button btnEliminarCliente;
        private Button btnModificarCliente;
        private Label lblFormGestionarClienteAgregar;
        private TextBox txtApellidoCliente2;
        private TextBox txtTelefonoCliente2;
        private TextBox txtDniCliente2;
        private TextBox txtNombreCliente2;
        private Label lblDniCliente2;
        private Label lblApellidoCliente2;
        private Label lblTelefonoCliente2;
        private Label lblNombreCliente2;
        private TextBox txtIdCliente2;
        private Label lblIdCliente2;
        private TextBox txtEstadoCliente2;
        private Label lblEstadoCliente2;
        private Button btnRefrescar;
        private Button button1;
    }
}