namespace MultilistaCamionCarga
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnClientes = new ToolStripMenuItem();
            mnRegistrarCliente = new ToolStripMenuItem();
            mnCamiones = new ToolStripMenuItem();
            mnRegistrarCamion = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            mnRegistarVenta = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            mnReportes = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnClientes, mnCamiones, ventasToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnClientes
            // 
            mnClientes.DropDownItems.AddRange(new ToolStripItem[] { mnRegistrarCliente });
            mnClientes.Name = "mnClientes";
            mnClientes.Size = new Size(75, 24);
            mnClientes.Text = "Clientes";
            // 
            // mnRegistrarCliente
            // 
            mnRegistrarCliente.Name = "mnRegistrarCliente";
            mnRegistrarCliente.Size = new Size(224, 26);
            mnRegistrarCliente.Text = "Registrar Cliente";
            mnRegistrarCliente.Click += mnRegistrarCliente_Click;
            // 
            // mnCamiones
            // 
            mnCamiones.DropDownItems.AddRange(new ToolStripItem[] { mnRegistrarCamion });
            mnCamiones.Name = "mnCamiones";
            mnCamiones.Size = new Size(88, 24);
            mnCamiones.Text = "Camiones";
            // 
            // mnRegistrarCamion
            // 
            mnRegistrarCamion.Name = "mnRegistrarCamion";
            mnRegistrarCamion.Size = new Size(206, 26);
            mnRegistrarCamion.Text = "Registrar Camión";
            mnRegistrarCamion.Click += mnRegistrarCamion_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnRegistarVenta });
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(66, 24);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // mnRegistarVenta
            // 
            mnRegistarVenta.Name = "mnRegistarVenta";
            mnRegistarVenta.Size = new Size(192, 26);
            mnRegistarVenta.Text = "Registrar Venta";
            mnRegistarVenta.Click += mnRegistarVenta_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnReportes });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // mnReportes
            // 
            mnReportes.Name = "mnReportes";
            mnReportes.Size = new Size(151, 26);
            mnReportes.Text = "Reportes";
            mnReportes.Click += mnCamionesMasVendidos_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 303);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnClientes;
        private ToolStripMenuItem mnCamiones;
        private ToolStripMenuItem mnRegistrarCamion;
        private ToolStripMenuItem mnRegistrarCliente;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem mnRegistarVenta;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem mnReportes;
    }
}