using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Factura
    {
        public int Codigo { get; set; }
        public string CodigoCliente { get; set; }
        public string Empleado  { get; set; }
        public DateTime Fecha { get; set; }
        public FormaPago FormaPago { get; set; }
        public bool EstadoFactura { get; set; }


    }

}
