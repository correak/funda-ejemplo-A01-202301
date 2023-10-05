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

namespace TA05_EjercicioA21
{
    public partial class FormPedido : Form
    {
        private PedidoService pS;

        public FormPedido(String codigoCliente)
        {
            pS = new(codigoCliente);
            InitializeComponent();
            // mostrar(PedidoService.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mostrar(List<Pedido> lista)
        {

            listViewPok.Items.Clear();

            int totalPedidos = 0;
            int totalPrecio = 0;

            foreach (Pedido en in lista)
            {
                ListViewItem fila = new(en.Codigo);
                fila.SubItems.Add(en.NameFlor);
                fila.SubItems.Add(en.Ocacion);
                fila.SubItems.Add(en.Tipo);
                fila.SubItems.Add(en.Precio.ToString());
                fila.SubItems.Add(en.Delivery.ToString());
                listViewPok.Items.Add(fila);
                totalPedidos += en.Precio;

            }
            labTotPedido.Text = lista.Count.ToString();
            labTotPSdePoke.Text = totalPrecio.ToString();

        }



        private void btnReg_Click(object sender, EventArgs e)
        {

            //validation

            if (tbCod.Text == "" || tbNameFlor.Text == "" || cbOcacion.Text == "" || cbTipo.Text == "" || tbPrecio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos", "Aviso!");
                return;
            }

            //Crear el objeto

            Pedido pedido = new()
            {
                Codigo = tbCod.Text,
                NameFlor = tbNameFlor.Text,
                Ocacion = cbOcacion.Text,
                Tipo = cbTipo.Text,
                Precio = int.Parse(tbPrecio.Text),
                Delivery = checBEsDeli.Checked,

            };


            bool insertado = pS.Insertar(pedido);

            //Insertar

            if (!insertado)
            {
                MessageBox.Show("El codigo ya existe", "Aviso!");
                return;
            }

            //Actualizar ListView

            mostrar(pS.ListarTodo());

        }
    }
}
