using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA05_EjercicioA21;

namespace Laboratorio09_2023_2
{
    public partial class FormularioDeReportes : Form
    {
        public FormularioDeReportes()
        {
            InitializeComponent();
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            FormReport form = new();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Reporte_2 form = new();
            form.Show();
        }
    }
}
