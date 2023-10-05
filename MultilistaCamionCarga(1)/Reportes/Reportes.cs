using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilistaCamionCarga.Reportes
{
    public class CamionesMasVendido
    {
        public string Fabricante {  get; set; }
        public int Cantidad { get; set; }
    }

    public class PrecioCamionesMasVendido
    {
        public string Fabricante { get; set; }
        public double Precio { get; set; }
    }

    public class TipoCamionesMenosVendidos
    {
        public string TipoCamion { get; set; }
        public int Cantidad { get; set; }
    }
}
