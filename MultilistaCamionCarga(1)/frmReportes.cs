using MultilistaCamionCarga.Clases;
using MultilistaCamionCarga.Controladoras;
using MultilistaCamionCarga.Reportes;
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
    public partial class frmReportes : Form
    {
        ClienteController clienteController = new ClienteController();
        CamionController camionController = new CamionController();

        public frmReportes()
        {
            InitializeComponent();
        }

        private void btnCamionesMasVendidos_Click(object sender, EventArgs e)
        {
            List<CamionesMasVendido> lista = camionController.dameListaCamionesMasVendidos();

            lvCamionesMasVendidos.Items.Clear();
            foreach (var item in lista)
            {
                ListViewItem fila = new ListViewItem(item.Fabricante);
                fila.SubItems.Add(item.Cantidad.ToString());

                lvCamionesMasVendidos.Items.Add(fila);
            }
        }

        private void btnPrecioPromedioCamionesVendidos_Click(object sender, EventArgs e)
        {
            List<PrecioCamionesMasVendido> lista = camionController.damePrecioPromedioCamionesMasVendidos();

            lvPrecioPromedioCamionesVendidos.Items.Clear();
            foreach (var item in lista)
            {
                ListViewItem fila = new ListViewItem(item.Fabricante);
                fila.SubItems.Add(item.Precio.ToString());

                lvPrecioPromedioCamionesVendidos.Items.Add(fila);
            }
        }

        private void btnTipoCamionesMenosVendidos_Click(object sender, EventArgs e)
        {
            List<TipoCamionesMenosVendidos> lista = camionController.dameTipoCamionesMenosVendidos();

            lvTipoCamionesMenosVendidos.Items.Clear();
            foreach (var item in lista)
            {
                ListViewItem fila = new ListViewItem(item.TipoCamion);
                fila.SubItems.Add(item.Cantidad.ToString());

                lvTipoCamionesMenosVendidos.Items.Add(fila);
            }
        }

        private void btnClienteConCamionesAntiguos_Click(object sender, EventArgs e)
        {
            if (cbTipoCamion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de camión", "Transpote");
                return;
            }
            string tipoCamion = cbTipoCamion.Items[cbTipoCamion.SelectedIndex].ToString();

            List<Cliente> lista = clienteController.dameClientesConCamionesMasAntiguos(tipoCamion);

            lvClientesConCamionesAntiguos.Items.Clear();
            foreach (Cliente item in lista)
            {
                ListViewItem fila = new ListViewItem(item.Nombre);
                fila.SubItems.Add(item.Camiones[0].Placa);

                lvClientesConCamionesAntiguos.Items.Add(fila);
            }
        }
    }
}
