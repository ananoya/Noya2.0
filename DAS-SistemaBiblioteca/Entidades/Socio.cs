using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Socio
    {

        private int socioId;
        private string dni;
        private string nombreCompleto;
        private string email;
        private int telefono;

        public int SocioId { get; set; }
        public string Dni { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
    }

}
