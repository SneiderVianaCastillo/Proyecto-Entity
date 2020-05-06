using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Producto
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public int PrecioVenta { get; set; }
        public int PrecioCosto { get; set; }
        public bool Estado { get; set; }
        public string Tipo { get; set; }
    }
}
