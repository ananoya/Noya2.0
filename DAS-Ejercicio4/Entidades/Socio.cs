using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    public class Socio
    {
        public string Dni {  get; set; }
        public string NombreCompleto { get; set; }
        public string Email {  get; set; }
        public int Telefono { get; set; }

    }
}
