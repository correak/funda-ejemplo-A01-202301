using MultilistaCamionCarga.Clases;
using MultilistaCamionCarga.Controladoras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultilistaCamionCarga
{
    public partial class frmRegistrarVenta : Form
    {
        ClienteController clienteController = new ClienteController();

        CamionController camionController = new CamionController();
        public frmRegistrarVenta()
        {
            InitializeComponent();
        }
        private void mostrarClientes(List<Cliente> lista)
        {
            lvClientes.Items.Clear();
            foreach (Cliente cliente in lista)
            {
                ListViewItem item = new ListViewItem(cliente.DNI);
                item.SubItems.Add(cliente.Nombre);
                item.SubItems.Add(cliente.Celular);
                item.SubItems.Add(cliente.Email);
                item.SubItems.Add(cliente.AnioRegistro.ToString());

                lvClientes.Items.Add(item);
            }
        }
        private void frmRegistrarVenta_Load(object sender, EventArgs e)
        {
            cbClientes.DisplayMember = "Nombre";
            cbClientes.ValueMember = "DNI";
            cbClientes.DataSource = ClienteController.Clientes;

            mostrarClientes(ClienteController.Clientes);
            mostrarCamiones(lvCamiones, CamionController.Camiones);
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (cbClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el cliente al que le asignará el camión o camiones", "Transpote");
                return;
            }

            if (lvCamiones.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleccione el camion o camiones que desea vender", "Transpote");
                return;
            }

            //Cliente cli = (Cliente)cbClientes.SelectedItem;
           
            string DNI = cbClientes.SelectedValue.ToString();
            Cliente cli = clienteController.dameClientePorDNI(DNI);
            foreach (int index in lvCamiones.SelectedIndices)
            {
                string placa = lvCamiones.Items[index].Text;
                string mensaje = clienteController.asignarCamionACliente(cli, placa);
                if (!mensaje.Equals(""))
                {
                    MessageBox.Show(mensaje, "Transpote");
                }
            }

            MessageBox.Show("Venta registrada", "Transpote");
        }

        private void mostrarCamiones(ListView vista, List<Camion> lista)
        {
            vista.Items.Clear();
            foreach (Camion camion in lista)
            {
                ListViewItem item = new ListViewItem(camion.Placa);
                item.SubItems.Add(camion.Tipo);
                item.SubItems.Add(camion.AnioFabricacion);
                item.SubItems.Add(camion.Fabricante);
                item.SubItems.Add(camion.Precio.ToString());

                vista.Items.Add(item);
            }
        }

        private void lvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvClientes.SelectedItems.Count > 0)
            {
                string DNI = lvClientes.SelectedItems[0].Text;
                mostrarCamiones(lvCamionesVendidos, clienteController.dameCamionesPorCliente(DNI));
            }
        }
    }
}
