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
    public class ClienteController
    {
        public static List<Cliente> Clientes { get; set; }

        private CamionController camionController = new CamionController();
        public ClienteController()
        {
            if (Clientes == null)
            {
                Clientes = new List<Cliente>();
            }
        }

        public string agregarCliente(Cliente newCli)
        {
            string mensaje = "";
            bool estaDNIYaRegistrado = Clientes.Exists(cli => cli.DNI == newCli.DNI);
            if (estaDNIYaRegistrado)
            {
                mensaje = "DNI ya registrado";
                return mensaje;
            }

            Clientes.Add(newCli);

            return mensaje;
        }

        public Cliente dameClientePorDNI(string DNI)
        {
            return Clientes.Find(cli => cli.DNI.Equals(DNI));
        }
        
        public string asignarCamionACliente(Cliente cli, string placa)
        {   
            string mensaje = "";
            bool estaCamionYaVendido = camionController.estaCamionYaVendido(placa);
            if (estaCamionYaVendido)
            {
                mensaje = "Camión con placa " + placa + " ya esta vendida";
                return mensaje;
            }

            Camion camion = camionController.dameCamionPorPlaca(placa);
            cli.Camiones.Add(camion);
            return mensaje;
        }

        public List<Camion> dameCamionesPorCliente(string DNI)
        {
            return Clientes.Find(cli => cli.DNI == DNI).Camiones;
        }

        public List<Cliente> dameClientesConCamionesMasAntiguos(string tipoCamion)
        {
            List<Cliente> clientesConCamionesAntiguos = new List<Cliente>();

            List<Cliente> clientes = ClienteController.Clientes.FindAll(cli => cli.Camiones.Exists(cam => cam.Tipo.Equals(tipoCamion)));
            foreach (Cliente cli in clientes)
            {
                Cliente objCliente = new()
                {
                    Nombre = cli.Nombre,
                    Camiones = new()
                };

                Camion camion = cli.Camiones.MinBy(cam => cam.AnioFabricacion);
                objCliente.Camiones.Add(camion);

                clientesConCamionesAntiguos.Add(objCliente);
            }

            return clientes;
        }
    }
}
