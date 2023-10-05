using MultilistaCamionCarga.Clases;
using MultilistaCamionCarga.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MultilistaCamionCarga.Controladoras
{
    public class CamionController
    {   
        public static List<Camion> Camiones { get; set; }

        public CamionController()
        {
            if (Camiones == null)
            {
                Camiones = new List<Camion>();
            }
        }

        public Camion dameCamionPorPlaca(string placa)
        {
            return Camiones.Find(cam => cam.Placa.Equals(placa));
        }

        public bool estaCamionYaVendido(string placa)
        {
            return ClienteController.Clientes.Exists(cli => cli.Camiones.Exists(cam => cam.Placa.Equals(placa)));
        }

        public string agregarCamion(Camion newCam)
        {
            string mensaje = "";
            bool estaPlacaYaRegistrada = Camiones.Exists(cam => cam.Placa.Equals(newCam.Placa));
            if (estaPlacaYaRegistrada)
            {
                mensaje = "Placa ya registrada";
                return mensaje;
            }

            Camiones.Add(newCam);
            return mensaje;
        }

        public List<CamionesMasVendido> dameListaCamionesMasVendidos()
        {
            List<Camion> listaCamiones = new List<Camion>();
            foreach (Cliente cli in ClienteController.Clientes)
            {
                if (cli.Camiones.Count > 0)
                {
                    listaCamiones.AddRange(cli.Camiones);
                }
            }

            List<CamionesMasVendido> lista = listaCamiones
                .GroupBy(cam => cam.Fabricante, (key, v) => new CamionesMasVendido
                {
                    Fabricante = key,
                    Cantidad = v.Count()
                })
                .OrderByDescending(x => x.Cantidad).ToList();

            return lista;
        }

        public List<PrecioCamionesMasVendido> damePrecioPromedioCamionesMasVendidos()
        {
            List<Camion> listaCamiones = new List<Camion>();
            foreach (Cliente cli in ClienteController.Clientes)
            {
                if (cli.Camiones.Count > 0)
                {
                    listaCamiones.AddRange(cli.Camiones);
                }
            }

            var lista = listaCamiones
                .GroupBy(cam => cam.Fabricante, (key, v) => new PrecioCamionesMasVendido
                {
                    Fabricante = key,
                    Precio = v.Average(c => c.Precio)
                })
                .OrderByDescending(x => x.Precio).ToList();

            return lista;
        }

        public List<TipoCamionesMenosVendidos> dameTipoCamionesMenosVendidos()
        {
            List<Camion> camiones = new List<Camion>();
            foreach (Cliente cli in ClienteController.Clientes)
            {
                if (cli.Camiones.Count > 0)
                    camiones.AddRange(cli.Camiones);
            }

            List<TipoCamionesMenosVendidos> CamionesVendidos = camiones.GroupBy(cam => cam.Tipo, (key, v) => new TipoCamionesMenosVendidos
            {
                TipoCamion = key,
                Cantidad = v.Count()
            }).OrderBy(x => x.Cantidad).ToList();

            List<TipoCamionesMenosVendidos> lista = CamionController.Camiones.GroupBy(cam => cam.Tipo, (key, v) => new TipoCamionesMenosVendidos
            {
                TipoCamion = key,
                Cantidad = (CamionesVendidos.Find(c => c.TipoCamion.Equals(key)) != null) ? CamionesVendidos.Find(c => c.TipoCamion.Equals(key)).Cantidad : 0
            }).OrderBy(x => x.Cantidad).ToList();

            return lista;
        }
    }
}
