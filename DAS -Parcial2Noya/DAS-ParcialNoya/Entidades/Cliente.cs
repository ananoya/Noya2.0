using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {

        public int ClienteId { get; set; }
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Dni { get; set; }
        public int Telefono { get; set; }
        public bool Activo { get; set; } = true; 

        // Relación 1 a muchos: un cliente tiene muchas cuentas corrientes
        public List<CuentaCorriente> CuentasCorrientes { get; set; }


        //para q me aparezca el nombre y apellido en las tablas
        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
