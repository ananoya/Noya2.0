using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaCorriente
    {

        public int CuentaCorrienteId { get; set; }
        public decimal Saldo { get; set; }
        public DateTime FechaApertura { get; set; }
        public Cliente ClienteAsociado { get; set; } //cuenta asociada a un cliente
        public bool Activo { get; set; } = true;
        public List<Movimiento> MovimientosAsociados { get; set; } //lista de movimientos asociados a la cuenta

        public int ClienteId  { get; set; }//clave foránea para la relación con Cliente


        //metodo para calcular saldo
        public decimal CalcularSaldo()
        {
            if (MovimientosAsociados == null)
                return 0;

            decimal totalCreditos = MovimientosAsociados
                .Where(m => m.Tipo == TipoDeMovimiento.Credito)
                .Sum(m => m.Monto);

            decimal totalDebitos = MovimientosAsociados
                .Where(m => m.Tipo == TipoDeMovimiento.Debito)
                .Sum(m => m.Monto);

            Saldo = totalCreditos - totalDebitos;

            return Saldo;
        }

        public (decimal totalDebitos, decimal totalCreditos, decimal saldoActual) ObtenerResumen()
        {
            if (MovimientosAsociados == null || !MovimientosAsociados.Any())
                return (0, 0, 0);

            decimal totalCreditos = MovimientosAsociados
                .Where(m => m.Tipo == TipoDeMovimiento.Credito)
                .Sum(m => m.Monto);

            decimal totalDebitos = MovimientosAsociados
                .Where(m => m.Tipo == TipoDeMovimiento.Debito)
                .Sum(m => m.Monto);

            decimal saldo = totalCreditos - totalDebitos;

            return (totalDebitos, totalCreditos, saldo);
        }

    }

}
