using Entidades;
using Modelo;
using Modelo.Migrations;

namespace Controladora
{
    public class Controladora
    {
        //patron singelton-- tenga una única instancia

        private Repositorio repositorio = new Repositorio();

        private static Controladora instancia;
        public static Controladora Instancia
        {
            get
            {
                if (instancia == null) //si no existe una instancia de la clase Controladora, la crea
                {
                    return instancia = new Controladora();
                }

                return instancia; // si ya existe una instancia, la devuelve
            }
        }


        
        //Metodo Listar CLIENTES
        public IReadOnlyCollection<Cliente> ListarClientes()
        { try
            {
                return repositorio.ListarClientes();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los clientes" + ex.Message);
            }
        
        }

        //metodo listar CLIENTES ACTIVOS
        public IReadOnlyCollection<Cliente> ListarClientesActivos()
        {
            try
            {
                return repositorio.ListarClientesActivos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los clientes activos" + ex.Message);
            }
        }

        //Metodo alta CLIENTE
        public void AltaCliente(Cliente cliente)
        {
            try
            {
                repositorio.AltaCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de alta el cliente" + ex.Message);
            }
            
        }


        //Metodo modificar CLIENTE
        public void ModificarCliente(int id, string nuevoNombre, string nuevoApellido, int nuevoTelefono)
        {
            try
            {
                var cliente = repositorio.ObtenerPorIdCliente(id);
                if (cliente == null)
                    throw new Exception("Cliente no encontrado.");

                cliente.Nombre = nuevoNombre;
                cliente.Apellido = nuevoApellido;
                cliente.Telefono = nuevoTelefono;

                repositorio.ModificarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el cliente: " + ex.Message);
            }
        }


        //Metodo baja CLIENTE
        /*hago una baja por si el usuario no quiere estar mas activo pero tiene cuentas asociadas
        agrego un bool en la propiedad, pensar como voy hacer la vista*/

        // elimina cuando no tiene cuentas
        public void EliminarCliente(int idCliente)
        {
            var cliente = repositorio.ObtenerPorIdCliente(idCliente);

            if (cliente == null)
                throw new Exception("El cliente no existe.");

            if (cliente.CuentasCorrientes != null && cliente.CuentasCorrientes.Any()) //hay cuentas asocadas?
                throw new Exception("No se puede eliminar un cliente que tiene cuentas corrientes asociadas.");

            repositorio.BajaCliente(cliente);
        }


        //Metodo listar CUENTA CORRIENTE
        public IReadOnlyCollection<CuentaCorriente> ListarCuentasCorrientes()
        {
            try
            {
                return repositorio.ListarCuentasCorrientes();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las cuentas corrientes" + ex.Message);
             
            }
        }

        //Metodo listar CUENTA CORRIENTE ACTIVAS
        public IReadOnlyCollection<CuentaCorriente> ListarCuentasCorrientesActivas()
        {
            try
            {
                return repositorio.ListarCuentasCorrientesActivas();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las cuentas corrientes activas" + ex.Message);
            }
        }

        //Metodo alta CUENTA CORRIENTE
        public void AltaCuentaCorriente(int id)
        {
            try
            {
                var cliente = repositorio.ObtenerPorIdCliente(id);
                if (cliente == null)
                    throw new Exception("El cliente no existe.");
                

                if (cliente.Activo == false) 
                    throw new Exception("El cliente esta inactivo");
                

                //Crear una cuenta y asociarla a un cliente existente
                var cuentaNueva = new CuentaCorriente()
                {
                    ClienteAsociado = cliente,
                    FechaApertura = DateTime.Now,
                    Saldo = 0,
                    Activo = true
                };                

                //luego de validar agrego a la tabla prestamos
                repositorio.AltaCuentaCorriente(cuentaNueva);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de alta la cuenta corriente" + ex.Message);
            }
        }

        //Metodo baja CUENTA CORRIENTE - si no tiene mov-> eliminarla - si tiene movimientos-> inactivarla 
        public void BajaCuentaCorriente(int idCuenta, bool inactivarSiTieneMovimientos = false)
        {
            var cuenta = repositorio.ObtenerPorIdCuenta(idCuenta);

            if (cuenta == null)
                throw new Exception("La cuenta no existe.");          

            // verificar si tiene mov la cuenta
            if (cuenta.MovimientosAsociados != null && cuenta.MovimientosAsociados.Any())
            {

                if (!inactivarSiTieneMovimientos)
                {
                    throw new Exception("No se puede eliminar un cuenta que tiene movimientos asociados.");
                }
                
                repositorio.InactivarCuentaCorriente(cuenta);

            }

            repositorio.EliminarCuentaCorriente(cuenta);
            
        }




        //Gestionar Movimientos
        //RegistrarMov

        //Listar movimientos totales con saldo
        public void RegistrarMovimiento(int idCuenta, decimal monto, TipoDeMovimiento tipo, string descripcion)
        {
            var cuenta = repositorio.ObtenerPorIdCuenta(idCuenta);
            if (cuenta == null)
                throw new Exception("No se encontró la cuenta.");

            //validar monto ingrsado
            if (monto <= 0)
                throw new Exception("El monto debe ser mayor que cero.");

            // validación de negocio para que no retire mas de lo que tiene
            if (tipo == TipoDeMovimiento.Debito && monto > repositorio.CalcularSaldo(idCuenta))
                throw new Exception("Saldo insuficiente para realizar el débito.");

           

            var movimientoNuevo = new Movimiento
            {
                CuentaAsociada = cuenta,
                Monto = monto,
                Tipo = tipo,
                Fecha = DateTime.Now,
                Descripción= descripcion
            };

            repositorio.RegistrarMovimiento(movimientoNuevo);
        }


        //quiero listar los movimientos x cd cuenta que selecciono en el dtv

        public List<Movimiento> ListarMovimientos()
        {
            try
            {
                return repositorio.ListarMovimientos();
            }
            catch (Exception ex) 
            {
                throw new Exception("Error al listar movimientos por cuenta"+ ex.Message);
            }

        }

        public decimal CalcularSaldo(int idCuentaCorriente)
        {
            try
            {
                if (idCuentaCorriente == null)
                    throw new Exception("No se encontró la cuenta.");
                return repositorio.CalcularSaldo(idCuentaCorriente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al calcular el saldo" + ex.Message);

            }
        }

        public (decimal totalDebitos, decimal totalCreditos, decimal saldoActual) MostrarResumenCuenta(int idCuenta)
        {
            return repositorio.ObtenerResumenCuenta(idCuenta);
        }



    }
}
