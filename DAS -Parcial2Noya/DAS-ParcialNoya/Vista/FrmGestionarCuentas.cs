using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmGestionarCuentas : Form
    {
        private Controladora.Controladora controladora;
        public FrmGestionarCuentas()
        {
            InitializeComponent();
            controladora = new Controladora.Controladora();
        }


        private void Refrescar()
        {
            dtvgClienteFrmGestionarCuenta.DataSource = controladora.ListarClientes();
            dtvgCuentaFrmGestionarCuenta.DataSource = controladora.ListarCuentasCorrientes();
        }

        private void FrmGestionarCuentas_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnFormClienteFiltrarClientesActivos_Click(object sender, EventArgs e)
        {
            try
            {
                dtvgClienteFrmGestionarCuenta.DataSource = controladora.ListarClientesActivos();
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

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(txtIdClienteCuenta.Text);

                controladora.AltaCuentaCorriente(id);

                Refrescar();

                MessageBox.Show("Cuenta creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear cuenta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtvgClienteFrmGestionarCuenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtvgClienteFrmGestionarCuenta.CurrentRow != null)
            {
                Cliente clienteSeleccionado = new Cliente();
                clienteSeleccionado = (Cliente)dtvgClienteFrmGestionarCuenta.CurrentRow.DataBoundItem; //creo un objeto persona

                txtIdClienteCuenta.Text = clienteSeleccionado.ClienteId.ToString();
                txtNombreClienteCuenta.Text = clienteSeleccionado.Nombre;
                txtApellidoClienteCuenta.Text = clienteSeleccionado.Apellido;
                txtEstadoClienteCuenta.Text = clienteSeleccionado.Activo.ToString();
            }
        }

        private void dtvgCuentaFrmGestionarCuenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtvgCuentaFrmGestionarCuenta.CurrentRow != null)
            {
                 
                CuentaCorriente cuentaSeleccionado = new CuentaCorriente();
                cuentaSeleccionado = (CuentaCorriente)dtvgCuentaFrmGestionarCuenta.CurrentRow.DataBoundItem; //creo un objeto persona

                txtIdCuenta2.Text = cuentaSeleccionado.CuentaCorrienteId.ToString();
                txtSaldoCuenta2.Text = cuentaSeleccionado.Saldo.ToString();
                txtFechaAperturaCuenta2.Text = cuentaSeleccionado.FechaApertura.ToString();
                txtEstadoCuenta2.Text = cuentaSeleccionado.Activo.ToString();
                txtClienteAsociadoCuenta2.Text = cuentaSeleccionado.ClienteAsociado.Nombre.ToString();
            }
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(txtIdCuenta2.Text);

                controladora.BajaCuentaCorriente(id);

                Refrescar();

                MessageBox.Show("Cuenta eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cuenta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


    }
}
