using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TA05_EjercicioA21.Entitiees;
using TA05_EjercicioA21.Service;

namespace Laboratorio09_2023_2
{
    public partial class Reporte_2 : Form
    {

        private ClienteServices cS = new();

        private void mostrar(List<Cliente> lista)
        {

            listViewClient.Items.Clear();

            foreach (Cliente en in lista)
            {
                ListViewItem fila = new(en.DNI);
                fila.SubItems.Add(en.Nombre);
                fila.SubItems.Add(en.Correo.ToString());
                fila.SubItems.Add(en.Region);
                fila.SubItems.Add(en.Direccion);
                listViewClient.Items.Add(fila);

            }
            labTotClient.Text = lista.Count.ToString();
        }


        public Reporte_2()
        {
            InitializeComponent();
        }

        private void btnBuscarOcacion_Click(object sender, EventArgs e)
        {
            //Validation de campos

            if (cbOcacion.Text == "")
            {
                MessageBox.Show("Ingrese el campo", "Aviso!");
                return;
            }

            //Mostrar en el listView

            mostrar(cS.ListarPorOcacion(cbOcacion.Text));

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscReg_Click(object sender, EventArgs e)
        {
            //Validation de campos

            if (tbDNI.Text == "")
            {
                MessageBox.Show("Ingrese el campo", "Aviso!");
                return;
            }

            //Mostrar en el listView

            mostrar(cS.ListarPorNombreFlor(tbDNI.Text));
        }

        private void btnBuscMasPed_Click(object sender, EventArgs e)
        {
            //Moatrar
            mostrar(cS.ListarPorMasPedidos());
        }
    }
}
