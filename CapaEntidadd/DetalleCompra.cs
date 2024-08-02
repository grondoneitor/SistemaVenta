using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadd
{
    public class DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public Producto oProducto { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }
        public int Cantidad { get;set; }
        public decimal MontoToal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
