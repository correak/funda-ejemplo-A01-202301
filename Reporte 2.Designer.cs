namespace Laboratorio09_2023_2
{
    partial class Reporte_2
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
            btnSalir = new Button();
            labTotClient = new Label();
            label5 = new Label();
            btnBuscMasPed = new Button();
            label3 = new Label();
            listViewClient = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            groupBox1 = new GroupBox();
            cbOcacion = new ComboBox();
            btnBuscarOcacion = new Button();
            label = new Label();
            groupBox2 = new GroupBox();
            tbDNI = new TextBox();
            btnBuscNumDNI = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(325, 6);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 42;
            label1.Text = "Reporte";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(109, 410);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(197, 39);
            btnSalir.TabIndex = 41;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // labTotClient
            // 
            labTotClient.AutoSize = true;
            labTotClient.Location = new Point(611, 461);
            labTotClient.Name = "labTotClient";
            labTotClient.Size = new Size(13, 15);
            labTotClient.TabIndex = 38;
            labTotClient.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(442, 461);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 37;
            label5.Text = "Total Clientes:";
            // 
            // btnBuscMasPed
            // 
            btnBuscMasPed.Location = new Point(109, 336);
            btnBuscMasPed.Name = "btnBuscMasPed";
            btnBuscMasPed.Size = new Size(197, 56);
            btnBuscMasPed.TabIndex = 36;
            btnBuscMasPed.Text = "Buscar los clientes que tienen mas Pedidos";
            btnBuscMasPed.UseVisualStyleBackColor = true;
            btnBuscMasPed.Click += btnBuscMasPed_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 91);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 35;
            // 
            // listViewClient
            // 
            listViewClient.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewClient.Location = new Point(415, 66);
            listViewClient.Name = "listViewClient";
            listViewClient.Size = new Size(322, 370);
            listViewClient.TabIndex = 34;
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
            groupBox1.Controls.Add(cbOcacion);
            groupBox1.Controls.Add(btnBuscarOcacion);
            groupBox1.Controls.Add(label);
            groupBox1.Location = new Point(63, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 127);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            // 
            // cbOcacion
            // 
            cbOcacion.FormattingEnabled = true;
            cbOcacion.Items.AddRange(new object[] { "Aniversario", "Cumpleaños", "Funeral", "Graduación" });
            cbOcacion.Location = new Point(122, 40);
            cbOcacion.Name = "cbOcacion";
            cbOcacion.Size = new Size(165, 23);
            cbOcacion.TabIndex = 25;
            // 
            // btnBuscarOcacion
            // 
            btnBuscarOcacion.Location = new Point(21, 83);
            btnBuscarOcacion.Name = "btnBuscarOcacion";
            btnBuscarOcacion.Size = new Size(266, 23);
            btnBuscarOcacion.TabIndex = 24;
            btnBuscarOcacion.Text = "Buscar por Ocacion";
            btnBuscarOcacion.UseVisualStyleBackColor = true;
            btnBuscarOcacion.Click += btnBuscarOcacion_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(32, 40);
            label.Name = "label";
            label.Size = new Size(54, 15);
            label.TabIndex = 17;
            label.Text = "Ocacion:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbDNI);
            groupBox2.Controls.Add(btnBuscNumDNI);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(68, 209);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 100);
            groupBox2.TabIndex = 40;
            groupBox2.TabStop = false;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(117, 21);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(165, 23);
            tbDNI.TabIndex = 26;
            // 
            // btnBuscNumDNI
            // 
            btnBuscNumDNI.Location = new Point(27, 60);
            btnBuscNumDNI.Name = "btnBuscNumDNI";
            btnBuscNumDNI.Size = new Size(255, 23);
            btnBuscNumDNI.TabIndex = 25;
            btnBuscNumDNI.Text = "Buscar por Numero DNI";
            btnBuscNumDNI.UseVisualStyleBackColor = true;
            btnBuscNumDNI.Click += btnBuscReg_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 29);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 19;
            label4.Text = "DNI:";
            // 
            // Reporte_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 483);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(labTotClient);
            Controls.Add(label5);
            Controls.Add(btnBuscMasPed);
            Controls.Add(label3);
            Controls.Add(listViewClient);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Reporte_2";
            Text = "Reporte_2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSalir;
        private Label labTotClient;
        private Label label5;
        private Button btnBuscMasPed;
        private Label label3;
        private ListView listViewClient;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private GroupBox groupBox1;
        private ComboBox cbOcacion;
        private Button btnBuscarOcacion;
        private Label label;
        private GroupBox groupBox2;
        private Button btnBuscNumDNI;
        private Label label4;
        private TextBox tbDNI;
    }
}