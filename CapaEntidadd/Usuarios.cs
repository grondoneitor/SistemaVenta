using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadd
{
    public class Usuarios
    {
        public int IdUsuarios { get; set; }
        public string Documento { get; set; }
        public string nombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public Rol oRol { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }


    }
}
