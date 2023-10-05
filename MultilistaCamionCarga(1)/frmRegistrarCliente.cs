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
    public partial class frmRegistrarCliente : Form
    {
        ClienteController cliController = new ClienteController();
        public frmRegistrarCliente()
        {
            InitializeComponent();
        }

        private bool hayDataClienteParaGrabar()
        {
            bool flag = true;

            if (txtDNI.Text.Trim().Equals("")) flag = false;

            if (txtNombre.Text.Trim().Equals("")) flag = false;

            if (txtCelular.Text.Trim().Equals("")) flag = false;

            if (txtEmail.Text.Trim().Equals("")) flag = false;

            if (txtAnioRegistro.Text.Trim().Equals("")) flag = false;

            return flag;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!hayDataClienteParaGrabar())
            {
                MessageBox.Show("Complete toda la información del cliente para poder registrarlo", "Transpote");
                return;
            }

            Cliente cli = new()
            {
                DNI = txtDNI.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Celular = txtCelular.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                AnioRegistro = Convert.ToInt32(txtAnioRegistro.Text.Trim()),
                Camiones = new(),
            };

            string mensaje = cliController.agregarCliente(cli);
            if (!mensaje.Equals(""))
            {
                MessageBox.Show(mensaje, "Transpote");
                return;
            }

            mostrarClientes(ClienteController.Clientes);
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtAnioRegistro.Text = "";
            txtDNI.Focus();
        }

        private void frmRegistrarCliente_Load(object sender, EventArgs e)
        {
            mostrarClientes(ClienteController.Clientes);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
