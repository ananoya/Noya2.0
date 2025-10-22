using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolución {  get; set; }
        public Libro LibroAsociado { get; set; }
        public Socio SocioAsociado { get; set; }

    }
}
