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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class FrmMov : Form
    {
        private Controladora.Controladora controladora;
        public FrmMov()
        {
            controladora = new Controladora.Controladora();
            InitializeComponent();
        }

        private void Refrescar()
        {
            
            dtvgClientesMov.DataSource = controladora.ListarClientes(); //para poder acceder al cliente asociado
            dtvgCuentasMov.DataSource = controladora.ListarCuentasCorrientes();
        }
        
        
        private void FrmMov_Load(object sender, EventArgs e)
        {
            Refrescar();

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnFiltrarFrmMov_Click(object sender, EventArgs e)
        {
            try
            {
                dtvgCuentasMov.DataSource = controladora.ListarCuentasCorrientesActivas();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar los clientes activos" + ex.Message);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipo.SelectedItem == null)
                {
                    MessageBox.Show("Selected item: " + cmbTipo.SelectedItem.ToString());
                }
                int id = int.Parse(txtIdCuenta2.Text);
                decimal monto = decimal.Parse(txtMonto.Text);
                TipoDeMovimiento tipo = (TipoDeMovimiento)Enum.Parse(typeof(TipoDeMovimiento), cmbTipo.SelectedItem.ToString());
                string descripcion = txtDescripcion.Text;



                controladora.RegistrarMovimiento(id,monto,tipo,descripcion);

                Refrescar();

                MessageBox.Show("Trasaccion realizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en al trasaccion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtvgCuentasMov_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtvgCuentasMov.CurrentRow != null)
            {
                CuentaCorriente cuentaSeleccionado = new CuentaCorriente();
                cuentaSeleccionado = (CuentaCorriente)dtvgCuentasMov.CurrentRow.DataBoundItem;

                txtIdCuenta2.Text = cuentaSeleccionado.CuentaCorrienteId.ToString();
                txtSaldoCuenta2.Text = cuentaSeleccionado.Saldo.ToString();
                txtFechaAperturaCuenta2.Text = cuentaSeleccionado.FechaApertura.ToString();
                txtEstadoCuenta2.Text = cuentaSeleccionado.Activo.ToString();
                txtClienteAsociadoCuenta2.Text = cuentaSeleccionado.ClienteAsociado.Nombre.ToString();
            }
        }


    }
}
