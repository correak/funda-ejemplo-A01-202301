namespace MultilistaCamionCarga
{
    partial class frmReportes
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
            btnCamionesMasVendidos = new Button();
            lvCamionesMasVendidos = new ListView();
            columnHeader11 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            lvPrecioPromedioCamionesVendidos = new ListView();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            btnPrecioPromedioCamionesVendidos = new Button();
            lvTipoCamionesMenosVendidos = new ListView();
            columnHeader14 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            btnTipoCamionesMenosVendidos = new Button();
            cbTipoCamion = new ComboBox();
            lvClientesConCamionesAntiguos = new ListView();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            btnClienteConCamionesAntiguos = new Button();
            label11 = new Label();
            SuspendLayout();
            // 
            // btnCamionesMasVendidos
            // 
            btnCamionesMasVendidos.Location = new Point(12, 12);
            btnCamionesMasVendidos.Name = "btnCamionesMasVendidos";
            btnCamionesMasVendidos.Size = new Size(195, 29);
            btnCamionesMasVendidos.TabIndex = 11;
            btnCamionesMasVendidos.Text = "Camiones Más Vendidos";
            btnCamionesMasVendidos.UseVisualStyleBackColor = true;
            btnCamionesMasVendidos.Click += btnCamionesMasVendidos_Click;
            // 
            // lvCamionesMasVendidos
            // 
            lvCamionesMasVendidos.Columns.AddRange(new ColumnHeader[] { columnHeader11, columnHeader15 });
            lvCamionesMasVendidos.FullRowSelect = true;
            lvCamionesMasVendidos.Location = new Point(12, 47);
            lvCamionesMasVendidos.Name = "lvCamionesMasVendidos";
            lvCamionesMasVendidos.Size = new Size(238, 239);
            lvCamionesMasVendidos.TabIndex = 10;
            lvCamionesMasVendidos.UseCompatibleStateImageBehavior = false;
            lvCamionesMasVendidos.View = View.Details;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Fabricante";
            columnHeader11.Width = 120;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Cantidad";
            columnHeader15.Width = 80;
            // 
            // lvPrecioPromedioCamionesVendidos
            // 
            lvPrecioPromedioCamionesVendidos.Columns.AddRange(new ColumnHeader[] { columnHeader12, columnHeader13 });
            lvPrecioPromedioCamionesVendidos.FullRowSelect = true;
            lvPrecioPromedioCamionesVendidos.Location = new Point(279, 47);
            lvPrecioPromedioCamionesVendidos.Name = "lvPrecioPromedioCamionesVendidos";
            lvPrecioPromedioCamionesVendidos.Size = new Size(267, 239);
            lvPrecioPromedioCamionesVendidos.TabIndex = 13;
            lvPrecioPromedioCamionesVendidos.UseCompatibleStateImageBehavior = false;
            lvPrecioPromedioCamionesVendidos.View = View.Details;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Fabricante";
            columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Precio";
            columnHeader13.Width = 100;
            // 
            // btnPrecioPromedioCamionesVendidos
            // 
            btnPrecioPromedioCamionesVendidos.Location = new Point(279, 12);
            btnPrecioPromedioCamionesVendidos.Name = "btnPrecioPromedioCamionesVendidos";
            btnPrecioPromedioCamionesVendidos.Size = new Size(267, 29);
            btnPrecioPromedioCamionesVendidos.TabIndex = 12;
            btnPrecioPromedioCamionesVendidos.Text = "Precio Promedio Camiones Vendidos";
            btnPrecioPromedioCamionesVendidos.UseVisualStyleBackColor = true;
            btnPrecioPromedioCamionesVendidos.Click += btnPrecioPromedioCamionesVendidos_Click;
            // 
            // lvTipoCamionesMenosVendidos
            // 
            lvTipoCamionesMenosVendidos.Columns.AddRange(new ColumnHeader[] { columnHeader14, columnHeader16 });
            lvTipoCamionesMenosVendidos.FullRowSelect = true;
            lvTipoCamionesMenosVendidos.Location = new Point(573, 47);
            lvTipoCamionesMenosVendidos.Name = "lvTipoCamionesMenosVendidos";
            lvTipoCamionesMenosVendidos.Size = new Size(267, 239);
            lvTipoCamionesMenosVendidos.TabIndex = 15;
            lvTipoCamionesMenosVendidos.UseCompatibleStateImageBehavior = false;
            lvTipoCamionesMenosVendidos.View = View.Details;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Tipo Camión";
            columnHeader14.Width = 120;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Cantidad";
            columnHeader16.Width = 100;
            // 
            // btnTipoCamionesMenosVendidos
            // 
            btnTipoCamionesMenosVendidos.Location = new Point(573, 12);
            btnTipoCamionesMenosVendidos.Name = "btnTipoCamionesMenosVendidos";
            btnTipoCamionesMenosVendidos.Size = new Size(267, 29);
            btnTipoCamionesMenosVendidos.TabIndex = 14;
            btnTipoCamionesMenosVendidos.Text = "Tipo Camiones Menos Vendidos";
            btnTipoCamionesMenosVendidos.UseVisualStyleBackColor = true;
            btnTipoCamionesMenosVendidos.Click += btnTipoCamionesMenosVendidos_Click;
            // 
            // cbTipoCamion
            // 
            cbTipoCamion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoCamion.FormattingEnabled = true;
            cbTipoCamion.Items.AddRange(new object[] { "Articulado", "Rígido", "Tráiler", "Tren de Carretera" });
            cbTipoCamion.Location = new Point(975, 17);
            cbTipoCamion.Name = "cbTipoCamion";
            cbTipoCamion.Size = new Size(159, 28);
            cbTipoCamion.TabIndex = 20;
            // 
            // lvClientesConCamionesAntiguos
            // 
            lvClientesConCamionesAntiguos.Columns.AddRange(new ColumnHeader[] { columnHeader17, columnHeader18 });
            lvClientesConCamionesAntiguos.FullRowSelect = true;
            lvClientesConCamionesAntiguos.Location = new Point(867, 86);
            lvClientesConCamionesAntiguos.Name = "lvClientesConCamionesAntiguos";
            lvClientesConCamionesAntiguos.Size = new Size(267, 200);
            lvClientesConCamionesAntiguos.TabIndex = 19;
            lvClientesConCamionesAntiguos.UseCompatibleStateImageBehavior = false;
            lvClientesConCamionesAntiguos.View = View.Details;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Cliente";
            columnHeader17.Width = 150;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Placa";
            columnHeader18.Width = 70;
            // 
            // btnClienteConCamionesAntiguos
            // 
            btnClienteConCamionesAntiguos.Location = new Point(867, 51);
            btnClienteConCamionesAntiguos.Name = "btnClienteConCamionesAntiguos";
            btnClienteConCamionesAntiguos.Size = new Size(267, 29);
            btnClienteConCamionesAntiguos.TabIndex = 18;
            btnClienteConCamionesAntiguos.Text = "Clientes con Camiones Más Antiguos";
            btnClienteConCamionesAntiguos.UseVisualStyleBackColor = true;
            btnClienteConCamionesAntiguos.Click += btnClienteConCamionesAntiguos_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(872, 21);
            label11.Name = "label11";
            label11.Size = new Size(97, 20);
            label11.TabIndex = 21;
            label11.Text = "Tipo Camión:";
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 308);
            Controls.Add(label11);
            Controls.Add(cbTipoCamion);
            Controls.Add(lvClientesConCamionesAntiguos);
            Controls.Add(btnClienteConCamionesAntiguos);
            Controls.Add(lvTipoCamionesMenosVendidos);
            Controls.Add(btnTipoCamionesMenosVendidos);
            Controls.Add(lvPrecioPromedioCamionesVendidos);
            Controls.Add(btnPrecioPromedioCamionesVendidos);
            Controls.Add(btnCamionesMasVendidos);
            Controls.Add(lvCamionesMasVendidos);
            Name = "frmReportes";
            Text = "Reportes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCamionesMasVendidos;
        private ListView lvCamionesMasVendidos;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader15;
        private ListView lvPrecioPromedioCamionesVendidos;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private Button btnPrecioPromedioCamionesVendidos;
        private ListView lvTipoCamionesMenosVendidos;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader16;
        private Button btnTipoCamionesMenosVendidos;
        private ComboBox cbTipoCamion;
        private ListView lvClientesConCamionesAntiguos;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private Button btnClienteConCamionesAntiguos;
        private Label label11;
    }
}