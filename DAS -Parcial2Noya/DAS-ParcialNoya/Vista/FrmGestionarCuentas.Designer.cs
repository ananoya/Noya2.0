namespace Vista
{
    partial class FrmGestionarCuentas
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
            btnRefrescar = new Button();
            txtEstadoCuenta2 = new TextBox();
            lblEstadoCuenta2 = new Label();
            lblIdCliente2 = new Label();
            txtIdCuenta2 = new TextBox();
            txtFechaAperturaCuenta2 = new TextBox();
            txtClienteAsociadoCuenta2 = new TextBox();
            txtSaldoCuenta2 = new TextBox();
            lblFechaAperturaCuenta2 = new Label();
            lblClienteAsociadoCuenta2 = new Label();
            lblNombreCliente2 = new Label();
            lblFormGestionarCuentaAgregar = new Label();
            btnEliminarCuenta = new Button();
            lblFormGestionarCuentaSeleccionar = new Label();
            btnCrearCuenta = new Button();
            btnFormClienteFiltrarClientesActivos = new Button();
            lblCuentaForm = new Label();
            dtvgClienteFrmGestionarCuenta = new DataGridView();
            label1 = new Label();
            dtvgCuentaFrmGestionarCuenta = new DataGridView();
            lblSeleccionarCliente = new Label();
            lblIdClienteCuenta = new Label();
            txtIdClienteCuenta = new TextBox();
            txtApellidoClienteCuenta = new TextBox();
            txtNombreClienteCuenta = new TextBox();
            lblApellidoClienteCuenta = new Label();
            lblNombreClienteCuenta = new Label();
            txtEstadoClienteCuenta = new TextBox();
            lblEstadoClienteCuenta = new Label();
            ((System.ComponentModel.ISupportInitialize)dtvgClienteFrmGestionarCuenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvgCuentaFrmGestionarCuenta).BeginInit();
            SuspendLayout();
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(418, 23);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(198, 25);
            btnRefrescar.TabIndex = 88;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // txtEstadoCuenta2
            // 
            txtEstadoCuenta2.Location = new Point(756, 597);
            txtEstadoCuenta2.Name = "txtEstadoCuenta2";
            txtEstadoCuenta2.ReadOnly = true;
            txtEstadoCuenta2.Size = new Size(227, 27);
            txtEstadoCuenta2.TabIndex = 87;
            // 
            // lblEstadoCuenta2
            // 
            lblEstadoCuenta2.AutoSize = true;
            lblEstadoCuenta2.Location = new Point(670, 600);
            lblEstadoCuenta2.Name = "lblEstadoCuenta2";
            lblEstadoCuenta2.Size = new Size(57, 20);
            lblEstadoCuenta2.TabIndex = 86;
            lblEstadoCuenta2.Text = "Estado:";
            // 
            // lblIdCliente2
            // 
            lblIdCliente2.AutoSize = true;
            lblIdCliente2.Location = new Point(691, 429);
            lblIdCliente2.Name = "lblIdCliente2";
            lblIdCliente2.Size = new Size(27, 20);
            lblIdCliente2.TabIndex = 85;
            lblIdCliente2.Text = "ID:";
            // 
            // txtIdCuenta2
            // 
            txtIdCuenta2.Location = new Point(756, 426);
            txtIdCuenta2.Name = "txtIdCuenta2";
            txtIdCuenta2.ReadOnly = true;
            txtIdCuenta2.Size = new Size(227, 27);
            txtIdCuenta2.TabIndex = 84;
            // 
            // txtFechaAperturaCuenta2
            // 
            txtFechaAperturaCuenta2.Location = new Point(756, 516);
            txtFechaAperturaCuenta2.Name = "txtFechaAperturaCuenta2";
            txtFechaAperturaCuenta2.ReadOnly = true;
            txtFechaAperturaCuenta2.Size = new Size(227, 27);
            txtFechaAperturaCuenta2.TabIndex = 83;
            // 
            // txtClienteAsociadoCuenta2
            // 
            txtClienteAsociadoCuenta2.Location = new Point(756, 557);
            txtClienteAsociadoCuenta2.Name = "txtClienteAsociadoCuenta2";
            txtClienteAsociadoCuenta2.ReadOnly = true;
            txtClienteAsociadoCuenta2.Size = new Size(227, 27);
            txtClienteAsociadoCuenta2.TabIndex = 82;
            // 
            // txtSaldoCuenta2
            // 
            txtSaldoCuenta2.Location = new Point(756, 469);
            txtSaldoCuenta2.Name = "txtSaldoCuenta2";
            txtSaldoCuenta2.ReadOnly = true;
            txtSaldoCuenta2.Size = new Size(227, 27);
            txtSaldoCuenta2.TabIndex = 80;
            // 
            // lblFechaAperturaCuenta2
            // 
            lblFechaAperturaCuenta2.AutoSize = true;
            lblFechaAperturaCuenta2.Location = new Point(622, 516);
            lblFechaAperturaCuenta2.Name = "lblFechaAperturaCuenta2";
            lblFechaAperturaCuenta2.Size = new Size(131, 20);
            lblFechaAperturaCuenta2.TabIndex = 78;
            lblFechaAperturaCuenta2.Text = "Fecha de apertura:";
            // 
            // lblClienteAsociadoCuenta2
            // 
            lblClienteAsociadoCuenta2.AutoSize = true;
            lblClienteAsociadoCuenta2.Location = new Point(626, 560);
            lblClienteAsociadoCuenta2.Name = "lblClienteAsociadoCuenta2";
            lblClienteAsociadoCuenta2.Size = new Size(124, 20);
            lblClienteAsociadoCuenta2.TabIndex = 77;
            lblClienteAsociadoCuenta2.Text = "Cliente Asociado:";
            // 
            // lblNombreCliente2
            // 
            lblNombreCliente2.AutoSize = true;
            lblNombreCliente2.Location = new Point(657, 476);
            lblNombreCliente2.Name = "lblNombreCliente2";
            lblNombreCliente2.Size = new Size(50, 20);
            lblNombreCliente2.TabIndex = 76;
            lblNombreCliente2.Text = "Saldo:";
            // 
            // lblFormGestionarCuentaAgregar
            // 
            lblFormGestionarCuentaAgregar.AutoSize = true;
            lblFormGestionarCuentaAgregar.BackColor = SystemColors.ActiveBorder;
            lblFormGestionarCuentaAgregar.Location = new Point(644, 67);
            lblFormGestionarCuentaAgregar.Name = "lblFormGestionarCuentaAgregar";
            lblFormGestionarCuentaAgregar.Size = new Size(204, 20);
            lblFormGestionarCuentaAgregar.TabIndex = 75;
            lblFormGestionarCuentaAgregar.Text = "Formulario para Crear Cuenta";
            // 
            // btnEliminarCuenta
            // 
            btnEliminarCuenta.Location = new Point(805, 636);
            btnEliminarCuenta.Name = "btnEliminarCuenta";
            btnEliminarCuenta.Size = new Size(178, 29);
            btnEliminarCuenta.TabIndex = 73;
            btnEliminarCuenta.Text = "Eliminar Cuenta";
            btnEliminarCuenta.UseVisualStyleBackColor = true;
            btnEliminarCuenta.Click += btnEliminarCuenta_Click;
            // 
            // lblFormGestionarCuentaSeleccionar
            // 
            lblFormGestionarCuentaSeleccionar.AutoSize = true;
            lblFormGestionarCuentaSeleccionar.BackColor = SystemColors.ActiveBorder;
            lblFormGestionarCuentaSeleccionar.Location = new Point(35, 63);
            lblFormGestionarCuentaSeleccionar.Name = "lblFormGestionarCuentaSeleccionar";
            lblFormGestionarCuentaSeleccionar.Size = new Size(300, 20);
            lblFormGestionarCuentaSeleccionar.TabIndex = 72;
            lblFormGestionarCuentaSeleccionar.Text = "Seleccionar Cliente para Asociar a la Cuenta";
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.Location = new Point(808, 321);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(155, 29);
            btnCrearCuenta.TabIndex = 71;
            btnCrearCuenta.Text = "Craer Cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // btnFormClienteFiltrarClientesActivos
            // 
            btnFormClienteFiltrarClientesActivos.Location = new Point(214, 23);
            btnFormClienteFiltrarClientesActivos.Name = "btnFormClienteFiltrarClientesActivos";
            btnFormClienteFiltrarClientesActivos.Size = new Size(198, 25);
            btnFormClienteFiltrarClientesActivos.TabIndex = 62;
            btnFormClienteFiltrarClientesActivos.Text = "Filtrar Clientes Activos";
            btnFormClienteFiltrarClientesActivos.UseVisualStyleBackColor = true;
            btnFormClienteFiltrarClientesActivos.Click += btnFormClienteFiltrarClientesActivos_Click;
            // 
            // lblCuentaForm
            // 
            lblCuentaForm.AutoSize = true;
            lblCuentaForm.BackColor = SystemColors.ActiveBorder;
            lblCuentaForm.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            lblCuentaForm.Location = new Point(35, 28);
            lblCuentaForm.Name = "lblCuentaForm";
            lblCuentaForm.Size = new Size(132, 20);
            lblCuentaForm.TabIndex = 61;
            lblCuentaForm.Text = "Cuentas Corrientes";
            // 
            // dtvgClienteFrmGestionarCuenta
            // 
            dtvgClienteFrmGestionarCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgClienteFrmGestionarCuenta.Location = new Point(35, 103);
            dtvgClienteFrmGestionarCuenta.Name = "dtvgClienteFrmGestionarCuenta";
            dtvgClienteFrmGestionarCuenta.RowHeadersWidth = 51;
            dtvgClienteFrmGestionarCuenta.Size = new Size(581, 230);
            dtvgClienteFrmGestionarCuenta.TabIndex = 60;
            dtvgClienteFrmGestionarCuenta.CellClick += dtvgClienteFrmGestionarCuenta_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Location = new Point(35, 361);
            label1.Name = "label1";
            label1.Size = new Size(227, 20);
            label1.TabIndex = 90;
            label1.Text = "Seleccionar Cuenta para Eliminar";
            // 
            // dtvgCuentaFrmGestionarCuenta
            // 
            dtvgCuentaFrmGestionarCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgCuentaFrmGestionarCuenta.Location = new Point(35, 406);
            dtvgCuentaFrmGestionarCuenta.Name = "dtvgCuentaFrmGestionarCuenta";
            dtvgCuentaFrmGestionarCuenta.RowHeadersWidth = 51;
            dtvgCuentaFrmGestionarCuenta.Size = new Size(581, 230);
            dtvgCuentaFrmGestionarCuenta.TabIndex = 91;
            dtvgCuentaFrmGestionarCuenta.CellClick += dtvgCuentaFrmGestionarCuenta_CellClick;
            // 
            // lblSeleccionarCliente
            // 
            lblSeleccionarCliente.AutoSize = true;
            lblSeleccionarCliente.Location = new Point(644, 103);
            lblSeleccionarCliente.Name = "lblSeleccionarCliente";
            lblSeleccionarCliente.Size = new Size(138, 20);
            lblSeleccionarCliente.TabIndex = 92;
            lblSeleccionarCliente.Text = "Seleccionar Cliente:";
            // 
            // lblIdClienteCuenta
            // 
            lblIdClienteCuenta.AutoSize = true;
            lblIdClienteCuenta.Location = new Point(671, 143);
            lblIdClienteCuenta.Name = "lblIdClienteCuenta";
            lblIdClienteCuenta.Size = new Size(27, 20);
            lblIdClienteCuenta.TabIndex = 94;
            lblIdClienteCuenta.Text = "ID:";
            // 
            // txtIdClienteCuenta
            // 
            txtIdClienteCuenta.Location = new Point(736, 140);
            txtIdClienteCuenta.Name = "txtIdClienteCuenta";
            txtIdClienteCuenta.ReadOnly = true;
            txtIdClienteCuenta.Size = new Size(227, 27);
            txtIdClienteCuenta.TabIndex = 93;
            // 
            // txtApellidoClienteCuenta
            // 
            txtApellidoClienteCuenta.Location = new Point(736, 231);
            txtApellidoClienteCuenta.Name = "txtApellidoClienteCuenta";
            txtApellidoClienteCuenta.ReadOnly = true;
            txtApellidoClienteCuenta.Size = new Size(227, 27);
            txtApellidoClienteCuenta.TabIndex = 98;
            // 
            // txtNombreClienteCuenta
            // 
            txtNombreClienteCuenta.Location = new Point(736, 184);
            txtNombreClienteCuenta.Name = "txtNombreClienteCuenta";
            txtNombreClienteCuenta.ReadOnly = true;
            txtNombreClienteCuenta.Size = new Size(227, 27);
            txtNombreClienteCuenta.TabIndex = 97;
            // 
            // lblApellidoClienteCuenta
            // 
            lblApellidoClienteCuenta.AutoSize = true;
            lblApellidoClienteCuenta.Location = new Point(638, 238);
            lblApellidoClienteCuenta.Name = "lblApellidoClienteCuenta";
            lblApellidoClienteCuenta.Size = new Size(69, 20);
            lblApellidoClienteCuenta.TabIndex = 96;
            lblApellidoClienteCuenta.Text = "Apellido:";
            // 
            // lblNombreClienteCuenta
            // 
            lblNombreClienteCuenta.AutoSize = true;
            lblNombreClienteCuenta.Location = new Point(637, 191);
            lblNombreClienteCuenta.Name = "lblNombreClienteCuenta";
            lblNombreClienteCuenta.Size = new Size(67, 20);
            lblNombreClienteCuenta.TabIndex = 95;
            lblNombreClienteCuenta.Text = "Nombre:";
            // 
            // txtEstadoClienteCuenta
            // 
            txtEstadoClienteCuenta.Location = new Point(736, 279);
            txtEstadoClienteCuenta.Name = "txtEstadoClienteCuenta";
            txtEstadoClienteCuenta.ReadOnly = true;
            txtEstadoClienteCuenta.Size = new Size(227, 27);
            txtEstadoClienteCuenta.TabIndex = 100;
            // 
            // lblEstadoClienteCuenta
            // 
            lblEstadoClienteCuenta.AutoSize = true;
            lblEstadoClienteCuenta.Location = new Point(650, 282);
            lblEstadoClienteCuenta.Name = "lblEstadoClienteCuenta";
            lblEstadoClienteCuenta.Size = new Size(57, 20);
            lblEstadoClienteCuenta.TabIndex = 99;
            lblEstadoClienteCuenta.Text = "Estado:";
            // 
            // FrmGestionarCuentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 677);
            Controls.Add(txtEstadoClienteCuenta);
            Controls.Add(lblEstadoClienteCuenta);
            Controls.Add(txtApellidoClienteCuenta);
            Controls.Add(txtNombreClienteCuenta);
            Controls.Add(lblApellidoClienteCuenta);
            Controls.Add(lblNombreClienteCuenta);
            Controls.Add(lblIdClienteCuenta);
            Controls.Add(txtIdClienteCuenta);
            Controls.Add(lblSeleccionarCliente);
            Controls.Add(dtvgCuentaFrmGestionarCuenta);
            Controls.Add(label1);
            Controls.Add(btnRefrescar);
            Controls.Add(txtEstadoCuenta2);
            Controls.Add(lblEstadoCuenta2);
            Controls.Add(lblIdCliente2);
            Controls.Add(txtIdCuenta2);
            Controls.Add(txtFechaAperturaCuenta2);
            Controls.Add(txtClienteAsociadoCuenta2);
            Controls.Add(txtSaldoCuenta2);
            Controls.Add(lblFechaAperturaCuenta2);
            Controls.Add(lblClienteAsociadoCuenta2);
            Controls.Add(lblNombreCliente2);
            Controls.Add(lblFormGestionarCuentaAgregar);
            Controls.Add(btnEliminarCuenta);
            Controls.Add(lblFormGestionarCuentaSeleccionar);
            Controls.Add(btnCrearCuenta);
            Controls.Add(btnFormClienteFiltrarClientesActivos);
            Controls.Add(lblCuentaForm);
            Controls.Add(dtvgClienteFrmGestionarCuenta);
            Name = "FrmGestionarCuentas";
            Text = "FrmGestionarCuentas";
            Load += FrmGestionarCuentas_Load;
            ((System.ComponentModel.ISupportInitialize)dtvgClienteFrmGestionarCuenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvgCuentaFrmGestionarCuenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnRefrescar;
        private TextBox txtEstadoCuenta2;
        private Label lblEstadoCuenta2;
        private Label lblIdCliente2;
        private TextBox txtIdCuenta2;
        private TextBox txtFechaAperturaCuenta2;
        private TextBox txtClienteAsociadoCuenta2;
        private TextBox txtSaldoCuenta2;
        private Label lblFechaAperturaCuenta2;
        private Label lblClienteAsociadoCuenta2;
        private Label lblNombreCliente2;
        private Label lblFormGestionarCuentaAgregar;
        private Button btnModificarCliente;
        private Button btnEliminarCuenta;
        private Label lblFormGestionarCuentaSeleccionar;
        private Button btnCrearCuenta;
        private Button btnFormClienteFiltrarClientesActivos;
        private Label lblCuentaForm;
        private DataGridView dtvgClienteFrmGestionarCuenta;
        private Label label1;
        private DataGridView dtvgCuentaFrmGestionarCuenta;
        private Label lblSeleccionarCliente;
        private Label lblIdClienteCuenta;
        private TextBox txtIdClienteCuenta;
        private TextBox txtApellidoClienteCuenta;
        private TextBox txtNombreClienteCuenta;
        private Label lblApellidoClienteCuenta;
        private Label lblNombreClienteCuenta;
        private TextBox txtEstadoClienteCuenta;
        private Label lblEstadoClienteCuenta;
    }
}