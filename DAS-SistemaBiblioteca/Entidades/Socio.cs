using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Socio
    {
        private string dni;
        private string nombreCompleto;
        private string email;
        private int telefono;


        public string Dni { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
    }

}
