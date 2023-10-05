namespace TA05_EjercicioA21
{
    partial class FormPedido
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checBEsDeli = new CheckBox();
            groupBox1 = new GroupBox();
            cbOcacion = new ComboBox();
            cbTipo = new ComboBox();
            tbPrecio = new TextBox();
            tbNameFlor = new TextBox();
            tbCod = new TextBox();
            btnReg = new Button();
            btnSalir = new Button();
            label6 = new Label();
            labTotPedido = new Label();
            listViewPok = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label7 = new Label();
            labTotPSdePoke = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 33);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 66);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre flor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 102);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Ocación:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 136);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "TipoFlor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 167);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Precio:";
            // 
            // checBEsDeli
            // 
            checBEsDeli.AutoSize = true;
            checBEsDeli.Location = new Point(82, 197);
            checBEsDeli.Name = "checBEsDeli";
            checBEsDeli.Size = new Size(68, 19);
            checBEsDeli.TabIndex = 5;
            checBEsDeli.Text = "Delivery";
            checBEsDeli.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbOcacion);
            groupBox1.Controls.Add(cbTipo);
            groupBox1.Controls.Add(tbPrecio);
            groupBox1.Controls.Add(tbNameFlor);
            groupBox1.Controls.Add(tbCod);
            groupBox1.Controls.Add(checBEsDeli);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(54, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 232);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // cbOcacion
            // 
            cbOcacion.FormattingEnabled = true;
            cbOcacion.Items.AddRange(new object[] { "Aniversario", "Cumpleaños", "Funeral", "Graduación" });
            cbOcacion.Location = new Point(112, 94);
            cbOcacion.Name = "cbOcacion";
            cbOcacion.Size = new Size(121, 23);
            cbOcacion.TabIndex = 11;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Margarita", "Azucena o lirio", "Azalea", "Dalia", "Hortensia", "Lirio amarillo", "Hibisco", "Bugambilia" });
            cbTipo.Location = new Point(112, 128);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(121, 23);
            cbTipo.TabIndex = 10;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(112, 159);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(121, 23);
            tbPrecio.TabIndex = 8;
            // 
            // tbNameFlor
            // 
            tbNameFlor.Location = new Point(112, 63);
            tbNameFlor.Name = "tbNameFlor";
            tbNameFlor.Size = new Size(121, 23);
            tbNameFlor.TabIndex = 7;
            // 
            // tbCod
            // 
            tbCod.Location = new Point(112, 25);
            tbCod.Name = "tbCod";
            tbCod.Size = new Size(121, 23);
            tbCod.TabIndex = 6;
            // 
            // btnReg
            // 
            btnReg.Location = new Point(88, 340);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(180, 34);
            btnReg.TabIndex = 7;
            btnReg.Text = "Registrar Pedido";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(88, 398);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(180, 33);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(449, 463);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 9;
            label6.Text = "Total de pedidos";
            // 
            // labTotPedido
            // 
            labTotPedido.AutoSize = true;
            labTotPedido.Location = new Point(644, 463);
            labTotPedido.Name = "labTotPedido";
            labTotPedido.Size = new Size(13, 15);
            labTotPedido.TabIndex = 10;
            labTotPedido.Text = "0";
            // 
            // listViewPok
            // 
            listViewPok.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewPok.Location = new Point(354, 82);
            listViewPok.Name = "listViewPok";
            listViewPok.Size = new Size(403, 349);
            listViewPok.TabIndex = 11;
            listViewPok.UseCompatibleStateImageBehavior = false;
            listViewPok.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre Flor";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ocación";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "TipoFlor";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Precio";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Delivery";
            columnHeader6.Width = 80;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(449, 492);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 12;
            label7.Text = "Total precio:";
            // 
            // labTotPSdePoke
            // 
            labTotPSdePoke.AutoSize = true;
            labTotPSdePoke.Location = new Point(644, 492);
            labTotPSdePoke.Name = "labTotPSdePoke";
            labTotPSdePoke.Size = new Size(13, 15);
            labTotPSdePoke.TabIndex = 13;
            labTotPSdePoke.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(332, 30);
            label8.Name = "label8";
            label8.Size = new Size(74, 25);
            label8.TabIndex = 14;
            label8.Text = "Pedido";
            // 
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(781, 556);
            Controls.Add(label8);
            Controls.Add(labTotPSdePoke);
            Controls.Add(label7);
            Controls.Add(listViewPok);
            Controls.Add(labTotPedido);
            Controls.Add(label6);
            Controls.Add(btnSalir);
            Controls.Add(btnReg);
            Controls.Add(groupBox1);
            Name = "FormPedido";
            Text = "FormPedido";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checBEsDeli;
        private GroupBox groupBox1;
        private ComboBox cbTipo;
        private TextBox tbPrecio;
        private TextBox tbNameFlor;
        private TextBox tbCod;
        private Button btnReg;
        private Button btnSalir;
        private Label label6;
        private Label labTotPedido;
        private ListView listViewPok;
        private Label label7;
        private Label labTotPSdePoke;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ComboBox cbOcacion;
        private Label label8;
    }
}