using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidadd;

namespace CapaNegocioo
{
    public class CN_Permiso
    {
        CD_Permiso cdPermiso = new CD_Permiso();

        public  List<Permiso> Listar(int IdUsuario) { 
            return cdPermiso.Listar(IdUsuario);
        }

    }
}
