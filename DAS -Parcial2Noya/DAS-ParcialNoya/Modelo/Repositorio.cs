using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Identity.Client;

namespace Modelo
{
    public class Repositorio
    {
        private Context context;

        public Repositorio()
        {
            context = new Context();
        }


        //Gestión de alta baja y modificación de CLIENTES

        //Metodo Listar CLIENTES
        public IReadOnlyCollection<Cliente> ListarClientes()
        {
            return context.Clientes.ToList().AsReadOnly();
        }

        //Metodo listar CLIENTES ACTIVOS
        public IReadOnlyCollection<Cliente> ListarClientesActivos()
        {
            return context.Clientes.Where(c => c.Activo).ToList().AsReadOnly();
        }

        //Metodo alta CLIENTE
        public void AltaCliente(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }


        //Metodo modificar CLIENTE
        public void ModificarCliente(Cliente cliente)
        {
            context.Clientes.Update(cliente);
            context.SaveChanges();
        }

        //Metodo eliminar CLIENTE
        public void BajaCliente(Cliente cliente) //tengo q validar que no tenga una cuenta con movimientos
        {
            context.Clientes.Remove(cliente);
            context.SaveChanges();
        }





        //Gestión de alta baja y modificación de cuentas corrientes
        //Metodo listar CUENTAS CORRIENTES
        public IReadOnlyCollection<CuentaCorriente> ListarCuentasCorrientes()
        {
            return context.CuentaCorrientes.ToList().AsReadOnly();
        }

        //Metodo listar CUENTAS CORRIENTES ACTIVAS
        public IReadOnlyCollection<CuentaCorriente> ListarCuentasCorrientesActivas()
        {
            return context.CuentaCorrientes.Where(c => c.Activo).ToList().AsReadOnly();
        }

        //Metodo alta CUENTAS CORRIENTES
        public void AltaCuentaCorriente(CuentaCorriente cuenta)
        {
            context.CuentaCorrientes.Add(cuenta);
            context.SaveChanges();
        }


        //Metodo modificar CUENTAS CORRIENTES
        public void ModificarCuentaCorriente(CuentaCorriente cuenta)
        {
            context.CuentaCorrientes.Update(cuenta);
            context.SaveChanges();
        }

        //Metodo eliminar CUENTAS CORRIENTES
        public void EliminarCuentaCorriente(CuentaCorriente cuenta)
        {
            context.CuentaCorrientes.Remove(cuenta);
            context.SaveChanges();
        }

        //inactivar cuando la cuentas ya tienen movimentos
        public void InactivarCuentaCorriente(CuentaCorriente cuenta)
        {
            cuenta.Activo = false;
            context.CuentaCorrientes.Update(cuenta);
            context.SaveChanges();
        }

        public void RegistrarMovimiento(Movimiento movimiento)
        {
            context.Movimentos.Add(movimiento);
             context.SaveChanges();

        }
        
        public void ActualizarBdd(CuentaCorriente cuenta)
        {
            
        }



        public decimal CalcularSaldo(int idCuentaCorriente)
        {
            // Traemos la cuenta con sus movimientos asociados
            var cuenta = context.CuentaCorrientes
                .Include(c => c.MovimientosAsociados)  
                .FirstOrDefault(c => c.CuentaCorrienteId == idCuentaCorriente);

            if (cuenta == null)
                throw new Exception("No se encontró la cuenta corriente.");

            // Calculamos el saldo usando el método de la entidad
            return cuenta.CalcularSaldo();
        }


        public List<Movimiento> ListarMovimientos()
        {
            return context.Movimentos.ToList();
        }

        public Cliente ObtenerPorIdCliente(int id)
        {
            return context.Clientes.Find(id);
        }

        public CuentaCorriente ObtenerPorIdCuenta(int id)
        {
            return context.CuentaCorrientes.Find(id);
        }

        public (decimal totalDebitos, decimal totalCreditos, decimal saldoActual) ObtenerResumenCuenta(int idCuenta)
        {
            var cuenta = context.CuentaCorrientes
                .Include(c => c.MovimientosAsociados)
                .FirstOrDefault(c => c.CuentaCorrienteId == idCuenta);

            if (cuenta == null)
                throw new Exception("Cuenta no encontrada.");

            return cuenta.ObtenerResumen();
        }




    }
}
