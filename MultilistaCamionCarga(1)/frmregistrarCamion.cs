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
    public partial class frmregistrarCamion : Form
    {
        CamionController camionController = new CamionController();

        public frmregistrarCamion()
        {
            InitializeComponent();
        }

        private bool hayDataCamionParaGrabar()
        {
            bool flag = true;

            if (txtPlaca.Text.Trim().Equals("")) flag = false;

            if (cbTipoCamion.Text.Trim().Equals("")) flag = false;

            if (txtAnioFabricacion.Text.Trim().Equals("")) flag = false;

            if (cbFabricante.Text.Trim().Equals("")) flag = false;

            if (txtPrecio.Text.Trim().Equals("")) flag = false;

            return flag;
        }

        private void mostrarCamiones(List<Camion> lista)
        {
            lvCamiones.Items.Clear();
            foreach (Camion camion in lista)
            {
                ListViewItem item = new ListViewItem(camion.Placa);
                item.SubItems.Add(camion.Tipo);
                item.SubItems.Add(camion.AnioFabricacion);
                item.SubItems.Add(camion.Fabricante);
                item.SubItems.Add(Convert.ToString(camion.Precio));

                lvCamiones.Items.Add(item);
            }
        }

        private void btnRegistrarCamion_Click(object sender, EventArgs e)
        {
            if (!hayDataCamionParaGrabar())
            {
                MessageBox.Show("Complete toda la información del camión para poder registrarlo", "Transpote");
                return;
            }

            Camion cam = new Camion();
            cam.Placa = txtPlaca.Text.Trim();
            cam.Tipo = cbTipoCamion.Items[cbTipoCamion.SelectedIndex].ToString();
            cam.AnioFabricacion = txtAnioFabricacion.Text.Trim();
            cam.Fabricante = cbFabricante.Items[cbFabricante.SelectedIndex].ToString();
            cam.Precio = Convert.ToDouble(txtPrecio.Text.Trim());

            string mensaje = camionController.agregarCamion(cam);

            if (!mensaje.Equals(""))
            {
                MessageBox.Show(mensaje, "Transpote");
                return;
            }

            mostrarCamiones(CamionController.Camiones);
            txtPlaca.Text = "";
            cbTipoCamion.SelectedIndex = -1;
            txtAnioFabricacion.Text = "";
            cbFabricante.SelectedIndex = -1;
            txtPrecio.Text = "";
            txtPlaca.Focus();
        }
    }
}
