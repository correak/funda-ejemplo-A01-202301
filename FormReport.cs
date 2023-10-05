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
    public partial class FormReport : Form
    {
        private ClienteServices cS = new();

        public FormReport()
        {
            InitializeComponent();
        }

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarNomPok_Click(object sender, EventArgs e)
        {
            //Validation de campos

            if (tbName.Text == "")
            {
                MessageBox.Show("Ingrese el campo", "Aviso!");
                return;
            }

            //Mostrar en el listView

            mostrar(cS.ListarPorNombreFlor(tbName.Text));
        }

        private void btnBuscReg_Click(object sender, EventArgs e)
        {

            //Validation de campos

            if (cbRegion.Text == "")
            {
                MessageBox.Show("Ingrese el campo", "Aviso!");
                return;
            }

            //Mostrar en el listView

            mostrar(cS.ListarPorNombreFlor(cbRegion.Text));

        }

        private void btnBuscMenosPok_Click(object sender, EventArgs e)
        {
            //Moatrar
            mostrar(cS.ListarPorMenosPedidos());
        }

        private void FormReport_Load(object sender, EventArgs e)
        {

        }
    }
}
