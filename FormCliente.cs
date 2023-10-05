using TA05_EjercicioA21.Entitiees;
using TA05_EjercicioA21.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laboratorio09_2023_2;

namespace TA05_EjercicioA21
{
    public partial class FormCliente : Form
    {
        private ClienteServices eS = new();

        public FormCliente()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormularioDeReportes form = new();
            form.Show();

        }

        private void mostrar(List<Cliente> lista)
        {

            listViewCliente.Items.Clear();

            foreach (Cliente en in lista)
            {
                ListViewItem fila = new(en.DNI);
                fila.SubItems.Add(en.Nombre);
                fila.SubItems.Add(en.Correo.ToString());
                fila.SubItems.Add(en.Region);
                fila.SubItems.Add(en.Direccion);
                listViewCliente.Items.Add(fila);

            }
            labtotClient.Text = lista.Count.ToString();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validation

            if (tbDNI.Text == "" || tbName.Text == "" || tbCorreo.Text == "" || cbRegion.Text == "" || tbDireccion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos", "Aviso!");
                return;
            }

            //Creacion del objeto

            Cliente cliente = new()
            {
                DNI = tbDNI.Text,
                Nombre = tbName.Text,
                Correo = tbCorreo.Text,
                Region = cbRegion.Text,
                Direccion = tbDireccion.Text,
                Pedidos = new List<Pedido>()

            };

            //La insertacion

            bool insertado = eS.Insertar(cliente);

            if (!insertado)
            {
                MessageBox.Show("El codigo ya existe", "Aviso!");
                return;
            }

            //Actualizar lista listView

            mostrar(eS.ListarTodo());

        }

        private void btnVerPok_Click(object sender, EventArgs e)
        {

            //Validation de select

            if (listViewCliente.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente ", "Aviso!");
                return;
            }
            FormPedido form = new(listViewCliente.SelectedItems[0].Text);

            form.Show();
        }

        private void FormEntrenador_Load(object sender, EventArgs e)
        {

        }
    }
}
