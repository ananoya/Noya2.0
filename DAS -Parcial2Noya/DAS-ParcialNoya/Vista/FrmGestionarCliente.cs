using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Vista
{
    public partial class FrmGestionarCliente : Form
    {
        private Controladora.Controladora controladora;

        public FrmGestionarCliente()
        {
            InitializeComponent();
            controladora = new Controladora.Controladora();

        }
        private void Refrescar()
        {
            dtvgClienteFrmGestionarCliente.DataSource = controladora.ListarClientes();
        }

        private void FrmGestionarCliente_Load(object sender, EventArgs e)
        {

            Refrescar();
        }

        private void btnFormClienteFiltrarClientesActivos_Click(object sender, EventArgs e)
        {
            try
            {
                dtvgClienteFrmGestionarCliente.DataSource = controladora.ListarClientesActivos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar los clientes activos" + ex.Message);
            }
        }
        private void dtvgClienteFrmGestionarCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtvgClienteFrmGestionarCliente.CurrentRow != null)
            {
                Cliente clienteSeleccionado = new Cliente();
                clienteSeleccionado = (Cliente)dtvgClienteFrmGestionarCliente.CurrentRow.DataBoundItem; //creo un objeto persona

                txtIdCliente2.Text = clienteSeleccionado.ClienteId.ToString();
                txtNombreCliente2.Text = clienteSeleccionado.Nombre;
                txtTelefonoCliente2.Text = clienteSeleccionado.Telefono.ToString();
                txtApellidoCliente2.Text = clienteSeleccionado.Apellido;
                txtEstadoCliente2.Text = clienteSeleccionado.Activo.ToString();
                txtDniCliente2.Text = clienteSeleccionado.Dni.ToString();

            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                Nombre = txtNombreCliente.Text,
                Apellido = txtApellidoCliente.Text,
                Dni = txtDniCliente.Text,
                Telefono = int.Parse(txtTelefonoCliente.Text)

            };

            controladora.AltaCliente(cliente);
            Refrescar();
            MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(txtIdCliente2.Text);

                controladora.EliminarCliente(id);

                Refrescar();

                MessageBox.Show("Cliente elimiando correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {

            try
            {

                int id = int.Parse(txtIdCliente2.Text);
                string nuevoNombre = txtNombreCliente2.Text;
                string nuevoApellido = txtApellidoCliente2.Text;
                int nuevoTelefono = int.Parse(txtTelefonoCliente2.Text);


                controladora.ModificarCliente(id, nuevoNombre, nuevoApellido, nuevoTelefono);

                Refrescar();

                MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }



        
    }
}
