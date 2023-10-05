namespace Laboratorio09_2023_2
{
    partial class FormularioDeReportes
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
            btnReport1 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnReport1
            // 
            btnReport1.Location = new Point(189, 269);
            btnReport1.Name = "btnReport1";
            btnReport1.Size = new Size(112, 39);
            btnReport1.TabIndex = 0;
            btnReport1.Text = "Reporte 1";
            btnReport1.UseVisualStyleBackColor = true;
            btnReport1.Click += btnReport1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.Location = new Point(333, 269);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 1;
            button1.Text = "Reporte 2";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(231, 77);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 2;
            label1.Text = "Ver Reportes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2023_09_19_225944;
            pictureBox1.Location = new Point(36, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(542, 315);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormularioDeReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(607, 502);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnReport1);
            Controls.Add(pictureBox1);
            Name = "FormularioDeReportes";
            Text = "FormularioDeReportes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReport1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}