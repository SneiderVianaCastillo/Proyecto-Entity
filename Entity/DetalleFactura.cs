using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class DetalleFactura
    {
        public int CodigoFactura  { get; set; }
        public int CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public int Iva { get; set; }
        public int PrecioVenta { get; set; }
        public int Descuento { get; set; }

    }
}
