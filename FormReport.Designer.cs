namespace TA05_EjercicioA21
{
    partial class FormReport
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
            labTotClient = new Label();
            label5 = new Label();
            btnBuscMenosPed = new Button();
            btnBuscReg = new Button();
            btnBuscarNomFlor = new Button();
            cbRegion = new ComboBox();
            tbName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            listViewClient = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnSalir = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // labTotClient
            // 
            labTotClient.AutoSize = true;
            labTotClient.Location = new Point(587, 476);
            labTotClient.Name = "labTotClient";
            labTotClient.Size = new Size(13, 15);
            labTotClient.TabIndex = 29;
            labTotClient.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(418, 476);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 28;
            label5.Text = "Total Clientes:";
            // 
            // btnBuscMenosPed
            // 
            btnBuscMenosPed.Location = new Point(85, 351);
            btnBuscMenosPed.Name = "btnBuscMenosPed";
            btnBuscMenosPed.Size = new Size(197, 56);
            btnBuscMenosPed.TabIndex = 26;
            btnBuscMenosPed.Text = "Buscar los clientes que tienen menos Pedidos";
            btnBuscMenosPed.UseVisualStyleBackColor = true;
            btnBuscMenosPed.Click += btnBuscMenosPok_Click;
            // 
            // btnBuscReg
            // 
            btnBuscReg.Location = new Point(27, 60);
            btnBuscReg.Name = "btnBuscReg";
            btnBuscReg.Size = new Size(255, 23);
            btnBuscReg.TabIndex = 25;
            btnBuscReg.Text = "Buscar por Region";
            btnBuscReg.UseVisualStyleBackColor = true;
            btnBuscReg.Click += btnBuscReg_Click;
            // 
            // btnBuscarNomFlor
            // 
            btnBuscarNomFlor.Location = new Point(21, 83);
            btnBuscarNomFlor.Name = "btnBuscarNomFlor";
            btnBuscarNomFlor.Size = new Size(266, 23);
            btnBuscarNomFlor.TabIndex = 24;
            btnBuscarNomFlor.Text = "Buscar por Nombre de flor";
            btnBuscarNomFlor.UseVisualStyleBackColor = true;
            btnBuscarNomFlor.Click += btnBuscarNomPok_Click;
            // 
            // cbRegion
            // 
            cbRegion.FormattingEnabled = true;
            cbRegion.Items.AddRange(new object[] { " Amazonas", " Ancash", "Apurimac", "Arequipa", "Ayacucho", "Cajamarca", "Callao", "Cusco", "Huancavelica", "Huanuco", "Ica", "Junín", "La Libertad", "Lambayeque", "Lima", "Loreto", "Madre de Dios", "Moquegua", "Pasco", "Piura", "Puno", "San Martín", "Tacna", "Tumbes ", "Ucayali" });
            cbRegion.Location = new Point(110, 22);
            cbRegion.Name = "cbRegion";
            cbRegion.Size = new Size(172, 23);
            cbRegion.TabIndex = 23;
            // 
            // tbName
            // 
            tbName.Location = new Point(115, 32);
            tbName.Name = "tbName";
            tbName.Size = new Size(172, 23);
            tbName.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 21);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 19;
            label4.Text = "Región:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 106);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 40);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 17;
            label2.Text = "Nombre:";
            // 
            // listViewClient
            // 
            listViewClient.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewClient.Location = new Point(391, 81);
            listViewClient.Name = "listViewClient";
            listViewClient.Size = new Size(322, 370);
            listViewClient.TabIndex = 15;
            listViewClient.UseCompatibleStateImageBehavior = false;
            listViewClient.View = View.Details;
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
            columnHeader5.Text = "Direccion";
            columnHeader5.Width = 80;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscarNomFlor);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(39, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 127);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscReg);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cbRegion);
            groupBox2.Location = new Point(44, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 100);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(85, 425);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(197, 39);
            btnSalir.TabIndex = 32;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(301, 21);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 33;
            label1.Text = "Reporte";
            // 
            // FormReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(755, 583);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(labTotClient);
            Controls.Add(label5);
            Controls.Add(btnBuscMenosPed);
            Controls.Add(label3);
            Controls.Add(listViewClient);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FormReport";
            Text = "FormReport";
            Load += FormReport_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labTotClient;
        private Label label5;
        private Button btnBuscMenosPed;
        private Button btnBuscReg;
        private Button btnBuscarNomFlor;
        private ComboBox cbRegion;
        private TextBox tbName;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListView listViewClient;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSalir;
        private Label label1;
        private ColumnHeader columnHeader5;
    }
}