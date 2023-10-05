namespace TA05_EjercicioA21
{
    partial class FormCliente
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
            listViewCliente = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbDNI = new TextBox();
            tbName = new TextBox();
            tbCorreo = new TextBox();
            cbRegion = new ComboBox();
            btnRegistrar = new Button();
            btnVerClient = new Button();
            btnReport = new Button();
            btnSalir = new Button();
            label5 = new Label();
            labtotClient = new Label();
            groupBox1 = new GroupBox();
            tbDireccion = new TextBox();
            label6 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listViewCliente
            // 
            listViewCliente.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewCliente.Location = new Point(344, 73);
            listViewCliente.Name = "listViewCliente";
            listViewCliente.Size = new Size(322, 350);
            listViewCliente.TabIndex = 0;
            listViewCliente.UseCompatibleStateImageBehavior = false;
            listViewCliente.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "DNI";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Correo";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Región";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Dirección";
            columnHeader5.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 37);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 70);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 109);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 144);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 4;
            label4.Text = "Región:";
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(101, 37);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(121, 23);
            tbDNI.TabIndex = 5;
            // 
            // tbName
            // 
            tbName.Location = new Point(101, 72);
            tbName.Name = "tbName";
            tbName.Size = new Size(121, 23);
            tbName.TabIndex = 6;
            // 
            // tbCorreo
            // 
            tbCorreo.Location = new Point(101, 101);
            tbCorreo.Name = "tbCorreo";
            tbCorreo.Size = new Size(121, 23);
            tbCorreo.TabIndex = 7;
            // 
            // cbRegion
            // 
            cbRegion.FormattingEnabled = true;
            cbRegion.Items.AddRange(new object[] { " Amazonas", " Ancash", "Apurimac", "Arequipa", "Ayacucho", "Cajamarca", "Callao", "Cusco", "Huancavelica", "Huanuco", "Ica, Junín", "La Libertad", "Lambayeque", "Lima", "Loreto", "Madre de Dios", "Moquegua", "Pasco", "Piura", "Puno", "San Martín", "Tacna", "Tumbes ", "Ucayali" });
            cbRegion.Location = new Point(101, 141);
            cbRegion.Name = "cbRegion";
            cbRegion.Size = new Size(121, 23);
            cbRegion.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(78, 330);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(122, 23);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVerClient
            // 
            btnVerClient.Location = new Point(78, 359);
            btnVerClient.Name = "btnVerClient";
            btnVerClient.Size = new Size(122, 23);
            btnVerClient.TabIndex = 10;
            btnVerClient.Text = "Ver Clientes";
            btnVerClient.UseVisualStyleBackColor = true;
            btnVerClient.Click += btnVerPok_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(78, 388);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(122, 23);
            btnReport.TabIndex = 11;
            btnReport.Text = "Reporte";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(78, 418);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(122, 23);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(513, 442);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 13;
            label5.Text = "Total Clientes:";
            // 
            // labtotClient
            // 
            labtotClient.AutoSize = true;
            labtotClient.Location = new Point(620, 442);
            labtotClient.Name = "labtotClient";
            labtotClient.Size = new Size(13, 15);
            labtotClient.TabIndex = 14;
            labtotClient.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbDireccion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbRegion);
            groupBox1.Controls.Add(tbCorreo);
            groupBox1.Controls.Add(tbDNI);
            groupBox1.Controls.Add(tbName);
            groupBox1.Location = new Point(39, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 231);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(101, 175);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(121, 23);
            tbDireccion.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 183);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 9;
            label6.Text = "Direción:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(273, 17);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 16;
            label7.Text = "Clientes";
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 64);
            ClientSize = new Size(703, 532);
            Controls.Add(label7);
            Controls.Add(labtotClient);
            Controls.Add(label5);
            Controls.Add(btnSalir);
            Controls.Add(btnReport);
            Controls.Add(btnVerClient);
            Controls.Add(btnRegistrar);
            Controls.Add(listViewCliente);
            Controls.Add(groupBox1);
            Name = "FormCliente";
            Text = "FormCliente";
            Load += FormEntrenador_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewCliente;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbDNI;
        private TextBox tbName;
        private TextBox tbCorreo;
        private ComboBox cbRegion;
        private Button btnRegistrar;
        private Button btnVerClient;
        private Button btnReport;
        private Button btnSalir;
        private Label label5;
        private Label labtotClient;
        private GroupBox groupBox1;
        private ColumnHeader columnHeader5;
        private TextBox tbDireccion;
        private Label label6;
        private Label label7;
    }
}