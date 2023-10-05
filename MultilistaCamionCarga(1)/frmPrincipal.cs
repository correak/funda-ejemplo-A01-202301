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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnRegistrarCliente_Click(object sender, EventArgs e)
        {
            frmRegistrarCliente obj1 = new frmRegistrarCliente();
            obj1.Show();
        }

        private void mnRegistrarCamion_Click(object sender, EventArgs e)
        {
            frmregistrarCamion obj1 = new frmregistrarCamion();
            obj1.Show();
        }

        private void mnRegistarVenta_Click(object sender, EventArgs e)
        {
            frmRegistrarVenta obj1 = new frmRegistrarVenta();
            obj1.Show();
        }

        private void mnCamionesMasVendidos_Click(object sender, EventArgs e)
        {
            frmReportes obj1 = new frmReportes();
            obj1.Show();
        }
    }
}
