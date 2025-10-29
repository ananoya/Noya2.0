using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamo
    { 
        private int idPrestamo;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolución;
        private Libro libroAsociado;
        private Socio socioAsociado;
        public int IdPrestamo { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public Libro LibroAsociado { get; set; }
        public Socio SocioAsociado { get; set; }
    }
}
