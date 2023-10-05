namespace MultilistaCamionCarga
{
    partial class frmregistrarCamion
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
            btnRegistrarCamion = new Button();
            groupBox2 = new GroupBox();
            cbFabricante = new ComboBox();
            cbTipoCamion = new ComboBox();
            txtPrecio = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtAnioFabricacion = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtPlaca = new TextBox();
            label10 = new Label();
            lvCamiones = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrarCamion
            // 
            btnRegistrarCamion.Location = new Point(266, 254);
            btnRegistrarCamion.Name = "btnRegistrarCamion";
            btnRegistrarCamion.Size = new Size(172, 29);
            btnRegistrarCamion.TabIndex = 5;
            btnRegistrarCamion.Text = "Registrar Camión";
            btnRegistrarCamion.UseVisualStyleBackColor = true;
            btnRegistrarCamion.Click += btnRegistrarCamion_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbFabricante);
            groupBox2.Controls.Add(cbTipoCamion);
            groupBox2.Controls.Add(txtPrecio);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtAnioFabricacion);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtPlaca);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(426, 222);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Camión";
            // 
            // cbFabricante
            // 
            cbFabricante.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFabricante.FormattingEnabled = true;
            cbFabricante.Items.AddRange(new object[] { "Isuzu", "Mercedez Benz", "Scania", "Volvo" });
            cbFabricante.Location = new Point(202, 142);
            cbFabricante.Name = "cbFabricante";
            cbFabricante.Size = new Size(206, 28);
            cbFabricante.TabIndex = 11;
            // 
            // cbTipoCamion
            // 
            cbTipoCamion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoCamion.FormattingEnabled = true;
            cbTipoCamion.Items.AddRange(new object[] { "Articulado", "Rígido", "Tráiler", "Tren de Carretera" });
            cbTipoCamion.Location = new Point(202, 76);
            cbTipoCamion.Name = "cbTipoCamion";
            cbTipoCamion.Size = new Size(206, 28);
            cbTipoCamion.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(202, 175);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(78, 27);
            txtPrecio.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 175);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 8;
            label6.Text = "Precio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 142);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 6;
            label7.Text = "Fabricante:";
            // 
            // txtAnioFabricacion
            // 
            txtAnioFabricacion.Location = new Point(202, 109);
            txtAnioFabricacion.Name = "txtAnioFabricacion";
            txtAnioFabricacion.Size = new Size(138, 27);
            txtAnioFabricacion.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 109);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
            label8.TabIndex = 4;
            label8.Text = "Año Fabricación:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 76);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 2;
            label9.Text = "Tipo Camión:";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(202, 43);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(138, 27);
            txtPlaca.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 43);
            label10.Name = "label10";
            label10.Size = new Size(47, 20);
            label10.TabIndex = 0;
            label10.Text = "Placa:";
            // 
            // lvCamiones
            // 
            lvCamiones.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            lvCamiones.FullRowSelect = true;
            lvCamiones.Location = new Point(12, 302);
            lvCamiones.Name = "lvCamiones";
            lvCamiones.Size = new Size(516, 223);
            lvCamiones.TabIndex = 6;
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
            // frmregistrarCamion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 537);
            Controls.Add(lvCamiones);
            Controls.Add(btnRegistrarCamion);
            Controls.Add(groupBox2);
            Name = "frmregistrarCamion";
            Text = "frmCamion";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarCamion;
        private GroupBox groupBox2;
        private ComboBox cbFabricante;
        private ComboBox cbTipoCamion;
        private TextBox txtPrecio;
        private Label label6;
        private Label label7;
        private TextBox txtAnioFabricacion;
        private Label label8;
        private Label label9;
        private TextBox txtPlaca;
        private Label label10;
        private ListView lvCamiones;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
    }
}