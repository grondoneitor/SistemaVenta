using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidadd;

namespace CapaNegocioo
{
    public class CN_Rol
    {

        public List<Rol> listarRol()
        {
            List<Rol> list = new CD_Rol().listandoRoles();

            return list;
        }


    }
}
