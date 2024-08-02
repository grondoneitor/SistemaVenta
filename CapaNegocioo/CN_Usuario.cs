using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidadd;
namespace CapaNegocioo
{
    public class CN_Usuario
    {
        public CD_Usuario oUsuario = new CD_Usuario();

        public List<Usuarios> Listar()
        {
            return oUsuario.Listar();
        }

    }
}
