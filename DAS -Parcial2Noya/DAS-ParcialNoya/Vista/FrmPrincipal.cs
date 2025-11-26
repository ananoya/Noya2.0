using System;
using System.Linq;
using System.Windows.Forms;
using Controladora;
using Entidades;
namespace Vista
{
    public partial class FrmPrincipal : Form
    {
        private Controladora.Controladora controladora;
        private int cuentaSeleccionadaId; //  la variable que guarda la cuenta seleccionada
        public FrmPrincipal()
        {
            InitializeComponent();

            controladora = new Controladora.Controladora();

        }

        private void Refrescar()
        {
            dtvgClienteFrmPrincipal.DataSource = controladora.ListarClientes();
            dtvgCuentaFrmPrincipal.DataSource = controladora.ListarCuentasCorrientes();
            dtvgMov.DataSource = controladora.ListarMovimientos();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnFiltrarClientesActivos_Click(object sender, EventArgs e)
        {
            try
            {
                dtvgClienteFrmPrincipal.DataSource = controladora.ListarClientesActivos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar los clientes activos" + ex.Message);
            }
        }

        private void btnFiltrarCuentasActivas_Click(object sender, EventArgs e)
        {
            try
            {
                dtvgClienteFrmPrincipal.DataSource = controladora.ListarCuentasCorrientesActivas();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar los clientes activos" + ex.Message);
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGestionarCliente frmGestionarCliente = new FrmGestionarCliente();
            frmGestionarCliente.ShowDialog();
        }

        private void btnGestionarCuentas_Click_1(object sender, EventArgs e)
        {
            FrmGestionarCuentas frmGestionarCuentas = new FrmGestionarCuentas();
            frmGestionarCuentas.ShowDialog();
        }



        private void btnConsultarSaldo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cuentaSeleccionadaId <= 0)
                {
                    MessageBox.Show("Por favor, seleccione una cuenta.");
                    return;
                }

                decimal saldo = controladora.CalcularSaldo(cuentaSeleccionadaId);
                MessageBox.Show($"El saldo de la cuenta seleccionada es: ${saldo}", "Consulta de Saldo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnRegistrarMovimiento_Click(object sender, EventArgs e)
        {
            FrmMov frmMovimientos = new FrmMov();
            frmMovimientos.ShowDialog();
        }
        private void MostrarResumen(int idCuenta)
        {
            var resumen = controladora.MostrarResumenCuenta(idCuenta);

            string mensaje = $" Resumen de Cuenta ID: {idCuenta}\n\n" +
                             $" Total Débitos: {resumen.totalDebitos:C}\n" +
                             $" Total Créditos: {resumen.totalCreditos:C}\n" +
                             $" Saldo Actual: {resumen.saldoActual:C}";

            MessageBox.Show(mensaje, "Resumen de Cuenta Corriente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHistorialCompleto_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(txtIdCuenta.Text);

                if (id == null)
                {
                    MessageBox.Show("Por favor, seleccione una cuenta.");
                    return;
                }
                MostrarResumen(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtvgCuentaFrmPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtvgCuentaFrmPrincipal.CurrentRow != null)
            {

                CuentaCorriente cuentaSeleccionado = new CuentaCorriente();
                cuentaSeleccionado = (CuentaCorriente)dtvgCuentaFrmPrincipal.CurrentRow.DataBoundItem; //creo un objeto persona

                txtIdCuenta.Text = cuentaSeleccionado.CuentaCorrienteId.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


    
