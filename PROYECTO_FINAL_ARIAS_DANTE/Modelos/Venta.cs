using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL_ARIAS_DANTE.Modelos
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public string Pelicula { get; set; }
        public string Cliente { get; set; }
        public string Factura { get; set; }
        public string Nit { get; set; }
        public int Boletos { get; set; }
        public double PrecioBoleto { get; set; }
        public double Total { get; set; }
        public string Fecha { get; set; }
    }
}
