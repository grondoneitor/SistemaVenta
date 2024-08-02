using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadd
{
    public class Compra
    {
        public int IdCompra { get; set; }  
        public Usuarios oUsuario { get; set; }
        public Proveedor oProveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public List<DetalleCompra> oDetalleCompra { get;set; }
        public string FechaRegistro { get; set; }

    }
}
