namespace Vista
{
    partial class FrmMov
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
            lblSeleccionarCliente = new Label();
            btnRefrescar = new Button();
            lblFormGestionarCuentaAgregar = new Label();
            lblFormGestionarCuentaSeleccionar = new Label();
            btnConfirmar = new Button();
            btnFiltrarFrmMov = new Button();
            lblCuentaForm = new Label();
            dtvgCuentasMov = new DataGridView();
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
            label1 = new Label();
            lblMonto = new Label();
            txtMonto = new TextBox();
            cmbTipo = new ComboBox();
            lblTipo = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            dtvgClientesMov = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtvgCuentasMov).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvgClientesMov).BeginInit();
            SuspendLayout();
            // 
            // lblSeleccionarCliente
            // 
            lblSeleccionarCliente.AutoSize = true;
            lblSeleccionarCliente.BackColor = Color.Red;
            lblSeleccionarCliente.ForeColor = SystemColors.ButtonHighlight;
            lblSeleccionarCliente.Location = new Point(46, 386);
            lblSeleccionarCliente.Name = "lblSeleccionarCliente";
            lblSeleccionarCliente.Size = new Size(138, 20);
            lblSeleccionarCliente.TabIndex = 108;
            lblSeleccionarCliente.Text = "Seleccionar Cuenta:";
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(405, 31);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(198, 25);
            btnRefrescar.TabIndex = 107;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // lblFormGestionarCuentaAgregar
            // 
            lblFormGestionarCuentaAgregar.AutoSize = true;
            lblFormGestionarCuentaAgregar.BackColor = SystemColors.ActiveBorder;
            lblFormGestionarCuentaAgregar.Location = new Point(24, 350);
            lblFormGestionarCuentaAgregar.Name = "lblFormGestionarCuentaAgregar";
            lblFormGestionarCuentaAgregar.Size = new Size(196, 20);
            lblFormGestionarCuentaAgregar.TabIndex = 106;
            lblFormGestionarCuentaAgregar.Text = "Formulario para Transacción";
            // 
            // lblFormGestionarCuentaSeleccionar
            // 
            lblFormGestionarCuentaSeleccionar.AutoSize = true;
            lblFormGestionarCuentaSeleccionar.BackColor = SystemColors.ActiveBorder;
            lblFormGestionarCuentaSeleccionar.Location = new Point(22, 79);
            lblFormGestionarCuentaSeleccionar.Name = "lblFormGestionarCuentaSeleccionar";
            lblFormGestionarCuentaSeleccionar.Size = new Size(307, 20);
            lblFormGestionarCuentaSeleccionar.TabIndex = 105;
            lblFormGestionarCuentaSeleccionar.Text = "Seleccionar Cuenta para Realizar Transacción";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(520, 566);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(227, 50);
            btnConfirmar.TabIndex = 104;
            btnConfirmar.Text = "Confirmar Transacción";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnFiltrarFrmMov
            // 
            btnFiltrarFrmMov.Location = new Point(201, 31);
            btnFiltrarFrmMov.Name = "btnFiltrarFrmMov";
            btnFiltrarFrmMov.Size = new Size(198, 25);
            btnFiltrarFrmMov.TabIndex = 103;
            btnFiltrarFrmMov.Text = "Filtrar Cuentas Activas";
            btnFiltrarFrmMov.UseVisualStyleBackColor = true;
            btnFiltrarFrmMov.Click += btnFiltrarFrmMov_Click;
            // 
            // lblCuentaForm
            // 
            lblCuentaForm.AutoSize = true;
            lblCuentaForm.BackColor = SystemColors.ActiveBorder;
            lblCuentaForm.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            lblCuentaForm.Location = new Point(22, 36);
            lblCuentaForm.Name = "lblCuentaForm";
            lblCuentaForm.Size = new Size(132, 20);
            lblCuentaForm.TabIndex = 102;
            lblCuentaForm.Text = "Cuentas Corrientes";
            // 
            // dtvgCuentasMov
            // 
            dtvgCuentasMov.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgCuentasMov.Location = new Point(22, 117);
            dtvgCuentasMov.Name = "dtvgCuentasMov";
            dtvgCuentasMov.RowHeadersWidth = 51;
            dtvgCuentasMov.Size = new Size(689, 230);
            dtvgCuentasMov.TabIndex = 101;
            dtvgCuentasMov.CellClick += dtvgCuentasMov_CellClick;
            // 
            // txtEstadoCuenta2
            // 
            txtEstadoCuenta2.Location = new Point(154, 589);
            txtEstadoCuenta2.Name = "txtEstadoCuenta2";
            txtEstadoCuenta2.ReadOnly = true;
            txtEstadoCuenta2.Size = new Size(227, 27);
            txtEstadoCuenta2.TabIndex = 118;
            // 
            // lblEstadoCuenta2
            // 
            lblEstadoCuenta2.AutoSize = true;
            lblEstadoCuenta2.Location = new Point(68, 592);
            lblEstadoCuenta2.Name = "lblEstadoCuenta2";
            lblEstadoCuenta2.Size = new Size(57, 20);
            lblEstadoCuenta2.TabIndex = 117;
            lblEstadoCuenta2.Text = "Estado:";
            // 
            // lblIdCliente2
            // 
            lblIdCliente2.AutoSize = true;
            lblIdCliente2.Location = new Point(112, 421);
            lblIdCliente2.Name = "lblIdCliente2";
            lblIdCliente2.Size = new Size(27, 20);
            lblIdCliente2.TabIndex = 116;
            lblIdCliente2.Text = "ID:";
            // 
            // txtIdCuenta2
            // 
            txtIdCuenta2.Location = new Point(154, 418);
            txtIdCuenta2.Name = "txtIdCuenta2";
            txtIdCuenta2.ReadOnly = true;
            txtIdCuenta2.Size = new Size(227, 27);
            txtIdCuenta2.TabIndex = 115;
            // 
            // txtFechaAperturaCuenta2
            // 
            txtFechaAperturaCuenta2.Location = new Point(154, 508);
            txtFechaAperturaCuenta2.Name = "txtFechaAperturaCuenta2";
            txtFechaAperturaCuenta2.ReadOnly = true;
            txtFechaAperturaCuenta2.Size = new Size(227, 27);
            txtFechaAperturaCuenta2.TabIndex = 114;
            // 
            // txtClienteAsociadoCuenta2
            // 
            txtClienteAsociadoCuenta2.Location = new Point(154, 549);
            txtClienteAsociadoCuenta2.Name = "txtClienteAsociadoCuenta2";
            txtClienteAsociadoCuenta2.ReadOnly = true;
            txtClienteAsociadoCuenta2.Size = new Size(227, 27);
            txtClienteAsociadoCuenta2.TabIndex = 113;
            // 
            // txtSaldoCuenta2
            // 
            txtSaldoCuenta2.Location = new Point(154, 461);
            txtSaldoCuenta2.Name = "txtSaldoCuenta2";
            txtSaldoCuenta2.ReadOnly = true;
            txtSaldoCuenta2.Size = new Size(227, 27);
            txtSaldoCuenta2.TabIndex = 112;
            // 
            // lblFechaAperturaCuenta2
            // 
            lblFechaAperturaCuenta2.AutoSize = true;
            lblFechaAperturaCuenta2.Location = new Point(20, 508);
            lblFechaAperturaCuenta2.Name = "lblFechaAperturaCuenta2";
            lblFechaAperturaCuenta2.Size = new Size(131, 20);
            lblFechaAperturaCuenta2.TabIndex = 111;
            lblFechaAperturaCuenta2.Text = "Fecha de apertura:";
            // 
            // lblClienteAsociadoCuenta2
            // 
            lblClienteAsociadoCuenta2.AutoSize = true;
            lblClienteAsociadoCuenta2.Location = new Point(24, 552);
            lblClienteAsociadoCuenta2.Name = "lblClienteAsociadoCuenta2";
            lblClienteAsociadoCuenta2.Size = new Size(124, 20);
            lblClienteAsociadoCuenta2.TabIndex = 110;
            lblClienteAsociadoCuenta2.Text = "Cliente Asociado:";
            // 
            // lblNombreCliente2
            // 
            lblNombreCliente2.AutoSize = true;
            lblNombreCliente2.Location = new Point(89, 464);
            lblNombreCliente2.Name = "lblNombreCliente2";
            lblNombreCliente2.Size = new Size(50, 20);
            lblNombreCliente2.TabIndex = 109;
            lblNombreCliente2.Text = "Saldo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(448, 386);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 119;
            label1.Text = "Transacción:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(458, 425);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(56, 20);
            lblMonto.TabIndex = 120;
            lblMonto.Text = "Monto:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(520, 418);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(227, 27);
            txtMonto.TabIndex = 121;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Debito", "Credito" });
            cmbTipo.Location = new Point(520, 461);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(227, 28);
            cmbTipo.TabIndex = 122;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(472, 468);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(42, 20);
            lblTipo.TabIndex = 123;
            lblTipo.Text = "Tipo:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(520, 508);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(227, 27);
            txtDescripcion.TabIndex = 125;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(424, 515);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 124;
            lblDescripcion.Text = "Descripcion:";
            // 
            // dtvgClientesMov
            // 
            dtvgClientesMov.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgClientesMov.Location = new Point(717, 117);
            dtvgClientesMov.Name = "dtvgClientesMov";
            dtvgClientesMov.RowHeadersWidth = 51;
            dtvgClientesMov.Size = new Size(381, 230);
            dtvgClientesMov.TabIndex = 126;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label2.Location = new Point(1037, 79);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 127;
            label2.Text = "Clientes";
            // 
            // FrmMov
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 633);
            Controls.Add(label2);
            Controls.Add(dtvgClientesMov);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipo);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(label1);
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
            Controls.Add(lblSeleccionarCliente);
            Controls.Add(btnRefrescar);
            Controls.Add(lblFormGestionarCuentaAgregar);
            Controls.Add(lblFormGestionarCuentaSeleccionar);
            Controls.Add(btnConfirmar);
            Controls.Add(btnFiltrarFrmMov);
            Controls.Add(lblCuentaForm);
            Controls.Add(dtvgCuentasMov);
            Name = "FrmMov";
            Text = "FrmMov";
            Load += FrmMov_Load;
            ((System.ComponentModel.ISupportInitialize)dtvgCuentasMov).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvgClientesMov).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEstadoClienteCuenta;
        private Label lblEstadoClienteCuenta;
        private TextBox txtApellidoClienteCuenta;
        private TextBox txtNombreClienteCuenta;
        private Label lblApellidoClienteCuenta;
        private Label lblNombreCuenta;
        private Label lblIdCuenta;
        private TextBox txtIdClienteCuenta;
        private Label lblSeleccionarCliente;
        private Button btnRefrescar;
        private Label lblFormGestionarCuentaAgregar;
        private Label lblFormGestionarCuentaSeleccionar;
        private Button btnConfirmar;
        private Button btnFiltrarFrmMov;
        private Label lblCuentaForm;
        private DataGridView dtvgCuentasMov;
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
        private Label label1;
        private Label lblMonto;
        private TextBox txtMonto;
        private ComboBox cmbTipo;
        private Label lblTipo;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private DataGridView dtvgClientesMov;
        private Label label2;
    }
}