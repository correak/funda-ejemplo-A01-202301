namespace MultilistaCamionCarga
{
    partial class frmRegistrarVenta
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
            label1 = new Label();
            cbClientes = new ComboBox();
            lvCamiones = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            btnRegistrarVenta = new Button();
            lvClientes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            lvCamionesVendidos = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // cbClientes
            // 
            cbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(99, 26);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(194, 28);
            cbClientes.TabIndex = 1;
            // 
            // lvCamiones
            // 
            lvCamiones.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            lvCamiones.FullRowSelect = true;
            lvCamiones.Location = new Point(22, 69);
            lvCamiones.Name = "lvCamiones";
            lvCamiones.Size = new Size(516, 223);
            lvCamiones.TabIndex = 7;
            lvCamiones.UseCompatibleStateImageBehavior = false;
            lvCamiones.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Placa";
            columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Tipo Camion";
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Año Fab.";
            columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Fabricante";
            columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Precio";
            columnHeader10.Width = 80;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Location = new Point(404, 25);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(134, 29);
            btnRegistrarVenta.TabIndex = 8;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // lvClientes
            // 
            lvClientes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvClientes.FullRowSelect = true;
            lvClientes.Location = new Point(21, 353);
            lvClientes.MultiSelect = false;
            lvClientes.Name = "lvClientes";
            lvClientes.Size = new Size(248, 220);
            lvClientes.TabIndex = 9;
            lvClientes.UseCompatibleStateImageBehavior = false;
            lvClientes.View = View.Details;
            lvClientes.SelectedIndexChanged += lvClientes_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "DNI";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 150;
            // 
            // lvCamionesVendidos
            // 
            lvCamionesVendidos.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5, columnHeader11, columnHeader12 });
            lvCamionesVendidos.FullRowSelect = true;
            lvCamionesVendidos.Location = new Point(334, 350);
            lvCamionesVendidos.Name = "lvCamionesVendidos";
            lvCamionesVendidos.Size = new Size(516, 223);
            lvCamionesVendidos.TabIndex = 10;
            lvCamionesVendidos.UseCompatibleStateImageBehavior = false;
            lvCamionesVendidos.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Placa";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tipo Camion";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Año Fab.";
            columnHeader5.Width = 80;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Fabricante";
            columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Precio";
            columnHeader12.Width = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 321);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 11;
            label2.Text = "Clientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 321);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 12;
            label3.Text = "Camiones";
            // 
            // frmRegistrarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 586);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lvCamionesVendidos);
            Controls.Add(lvClientes);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(lvCamiones);
            Controls.Add(cbClientes);
            Controls.Add(label1);
            Name = "frmRegistrarVenta";
            Text = "Registrar Venta";
            Load += frmRegistrarVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbClientes;
        private ListView lvCamiones;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Button btnRegistrarVenta;
        private ListView lvClientes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView lvCamionesVendidos;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Label label2;
        private Label label3;
    }
}