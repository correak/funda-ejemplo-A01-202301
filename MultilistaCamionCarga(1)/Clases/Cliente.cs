using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilistaCamionCarga.Clases
{
    public class Cliente
    {
        public string DNI {  get; set; }
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public int AnioRegistro { get; set; }

        public List<Camion> Camiones {  get; set; }
    }
}
