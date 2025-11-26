using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoDeMovimiento
    {
        Debito,
        Credito
    }

    public class Movimiento
    {
        public int MovimientoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripción { get; set; }
        public decimal Monto { get; set; }
        public CuentaCorriente CuentaAsociada { get; set; }
        public TipoDeMovimiento Tipo { get; set; } //débito/crédito 
        

        public int CuentaCorrienteAsociada { get; set; } //clave foranea
    }
    }
