namespace Vista
{
    partial class FrmPrincipal
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
            dtvgClienteFrmPrincipal = new DataGridView();
            dtvgCuentaFrmPrincipal = new DataGridView();
            lblCliente = new Label();
            lblCuentasCorrientes = new Label();
            btnRefrescar = new Button();
            btnFiltrarCuentasActivas = new Button();
            btnFiltrarClientesActivos = new Button();
            lblMenuPrincipal = new Label();
            button1 = new Button();
            btnGestionarCuentas = new Button();
            btnConsultarSaldo = new Button();
            lblMov = new Label();
            btnRegistrarMovimiento = new Button();
            dtvgMov = new DataGridView();
            btnHistorialCompleto = new Button();
            txtIdCuenta = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtvgClienteFrmPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvgCuentaFrmPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvgMov).BeginInit();
            SuspendLayout();
            // 
            // dtvgClienteFrmPrincipal
            // 
            dtvgClienteFrmPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgClienteFrmPrincipal.Location = new Point(12, 80);
            dtvgClienteFrmPrincipal.Name = "dtvgClienteFrmPrincipal";
            dtvgClienteFrmPrincipal.RowHeadersWidth = 51;
            dtvgClienteFrmPrincipal.Size = new Size(1139, 170);
            dtvgClienteFrmPrincipal.TabIndex = 0;
            // 
            // dtvgCuentaFrmPrincipal
            // 
            dtvgCuentaFrmPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgCuentaFrmPrincipal.Location = new Point(13, 299);
            dtvgCuentaFrmPrincipal.Name = "dtvgCuentaFrmPrincipal";
            dtvgCuentaFrmPrincipal.RowHeadersWidth = 51;
            dtvgCuentaFrmPrincipal.Size = new Size(1139, 161);
            dtvgCuentaFrmPrincipal.TabIndex = 1;
            dtvgCuentaFrmPrincipal.CellClick += dtvgCuentaFrmPrincipal_CellClick;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = SystemColors.ActiveBorder;
            lblCliente.Location = new Point(13, 51);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(61, 20);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Clientes";
            // 
            // lblCuentasCorrientes
            // 
            lblCuentasCorrientes.AutoSize = true;
            lblCuentasCorrientes.BackColor = SystemColors.ActiveBorder;
            lblCuentasCorrientes.Location = new Point(13, 269);
            lblCuentasCorrientes.Name = "lblCuentasCorrientes";
            lblCuentasCorrientes.Size = new Size(132, 20);
            lblCuentasCorrientes.TabIndex = 3;
            lblCuentasCorrientes.Text = "Cuentas Corrientes";
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(1057, 12);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(94, 29);
            btnRefrescar.TabIndex = 21;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnFiltrarCuentasActivas
            // 
            btnFiltrarCuentasActivas.Location = new Point(953, 264);
            btnFiltrarCuentasActivas.Name = "btnFiltrarCuentasActivas";
            btnFiltrarCuentasActivas.Size = new Size(198, 25);
            btnFiltrarCuentasActivas.TabIndex = 22;
            btnFiltrarCuentasActivas.Text = "Filtrar Cuentas Activas";
            btnFiltrarCuentasActivas.UseVisualStyleBackColor = true;
            btnFiltrarCuentasActivas.Click += btnFiltrarCuentasActivas_Click;
            // 
            // btnFiltrarClientesActivos
            // 
            btnFiltrarClientesActivos.Location = new Point(953, 51);
            btnFiltrarClientesActivos.Name = "btnFiltrarClientesActivos";
            btnFiltrarClientesActivos.Size = new Size(198, 25);
            btnFiltrarClientesActivos.TabIndex = 23;
            btnFiltrarClientesActivos.Text = "Filtrar Clientes Activos";
            btnFiltrarClientesActivos.UseVisualStyleBackColor = true;
            btnFiltrarClientesActivos.Click += btnFiltrarClientesActivos_Click;
            // 
            // lblMenuPrincipal
            // 
            lblMenuPrincipal.AutoSize = true;
            lblMenuPrincipal.BackColor = SystemColors.ActiveBorder;
            lblMenuPrincipal.ForeColor = SystemColors.ControlText;
            lblMenuPrincipal.Location = new Point(13, 21);
            lblMenuPrincipal.Name = "lblMenuPrincipal";
            lblMenuPrincipal.Size = new Size(124, 20);
            lblMenuPrincipal.TabIndex = 24;
            lblMenuPrincipal.Text = "MENÚ PRINCIPAL";
            // 
            // button1
            // 
            button1.Location = new Point(168, 49);
            button1.Name = "button1";
            button1.Size = new Size(206, 27);
            button1.TabIndex = 25;
            button1.Text = "Gestionar Clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGestionarCuentas
            // 
            btnGestionarCuentas.Location = new Point(168, 266);
            btnGestionarCuentas.Name = "btnGestionarCuentas";
            btnGestionarCuentas.Size = new Size(206, 27);
            btnGestionarCuentas.TabIndex = 26;
            btnGestionarCuentas.Text = "Gestionar Cuentas";
            btnGestionarCuentas.UseVisualStyleBackColor = true;
            btnGestionarCuentas.Click += btnGestionarCuentas_Click_1;
            // 
            // btnConsultarSaldo
            // 
            btnConsultarSaldo.Location = new Point(390, 266);
            btnConsultarSaldo.Name = "btnConsultarSaldo";
            btnConsultarSaldo.Size = new Size(206, 27);
            btnConsultarSaldo.TabIndex = 27;
            btnConsultarSaldo.Text = "Consultar Saldo";
            btnConsultarSaldo.UseVisualStyleBackColor = true;
            btnConsultarSaldo.Click += btnConsultarSaldo_Click;
            // 
            // lblMov
            // 
            lblMov.AutoSize = true;
            lblMov.BackColor = SystemColors.ActiveBorder;
            lblMov.Location = new Point(13, 481);
            lblMov.Name = "lblMov";
            lblMov.Size = new Size(95, 20);
            lblMov.TabIndex = 28;
            lblMov.Text = "Movimientos";
            // 
            // btnRegistrarMovimiento
            // 
            btnRegistrarMovimiento.Location = new Point(168, 474);
            btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            btnRegistrarMovimiento.Size = new Size(206, 27);
            btnRegistrarMovimiento.TabIndex = 29;
            btnRegistrarMovimiento.Text = "Registrar Movimiento";
            btnRegistrarMovimiento.UseVisualStyleBackColor = true;
            btnRegistrarMovimiento.Click += btnRegistrarMovimiento_Click;
            // 
            // dtvgMov
            // 
            dtvgMov.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgMov.Location = new Point(13, 507);
            dtvgMov.Name = "dtvgMov";
            dtvgMov.RowHeadersWidth = 51;
            dtvgMov.Size = new Size(1139, 161);
            dtvgMov.TabIndex = 30;
            // 
            // btnHistorialCompleto
            // 
            btnHistorialCompleto.Location = new Point(390, 474);
            btnHistorialCompleto.Name = "btnHistorialCompleto";
            btnHistorialCompleto.Size = new Size(206, 27);
            btnHistorialCompleto.TabIndex = 31;
            btnHistorialCompleto.Text = "Historial Completo";
            btnHistorialCompleto.UseVisualStyleBackColor = true;
            btnHistorialCompleto.Click += btnHistorialCompleto_Click;
            // 
            // txtIdCuenta
            // 
            txtIdCuenta.Location = new Point(635, 474);
            txtIdCuenta.Name = "txtIdCuenta";
            txtIdCuenta.ReadOnly = true;
            txtIdCuenta.Size = new Size(108, 27);
            txtIdCuenta.TabIndex = 85;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Location = new Point(602, 477);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 86;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 707);
            Controls.Add(label1);
            Controls.Add(txtIdCuenta);
            Controls.Add(btnHistorialCompleto);
            Controls.Add(dtvgMov);
            Controls.Add(btnRegistrarMovimiento);
            Controls.Add(lblMov);
            Controls.Add(btnConsultarSaldo);
            Controls.Add(btnGestionarCuentas);
            Controls.Add(button1);
            Controls.Add(lblMenuPrincipal);
            Controls.Add(btnFiltrarClientesActivos);
            Controls.Add(btnFiltrarCuentasActivas);
            Controls.Add(btnRefrescar);
            Controls.Add(lblCuentasCorrientes);
            Controls.Add(lblCliente);
            Controls.Add(dtvgCuentaFrmPrincipal);
            Controls.Add(dtvgClienteFrmPrincipal);
            Name = "FrmPrincipal";
            Text = "Form1";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dtvgClienteFrmPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvgCuentaFrmPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvgMov).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtvgClienteFrmPrincipal;
        private DataGridView dtvgCuentaFrmPrincipal;
        private Label lblCliente;
        private Label lblCuentasCorrientes;
        private Button btnRefrescar;
        private Button btnFiltrarCuentasActivas;
        private Button btnFiltrarClientesActivos;
        private Label lblMenuPrincipal;
        private Button button1;
        private Button btnGestionarCuentas;
        private Button btnConsultarSaldo;
        private Label lblMov;
        private Button btnRegistrarMovimiento;
        private DataGridView dtvgMov;
        private Button btnHistorialCompleto;
        private TextBox txtIdCuenta;
        private Label label1;
    }
}
