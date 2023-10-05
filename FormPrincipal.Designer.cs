namespace TA05_EjercicioA21
{
    partial class FormPrincipal
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(94, 178);
            button1.Name = "button1";
            button1.Size = new Size(175, 55);
            button1.TabIndex = 0;
            button1.Text = "Registrar Cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(94, 282);
            button2.Name = "button2";
            button2.Size = new Size(175, 48);
            button2.TabIndex = 1;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 92);
            label1.Name = "label1";
            label1.Size = new Size(298, 30);
            label1.TabIndex = 2;
            label1.Text = "FLORERÍA ROSATEL ONLINE ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Laboratorio09_2023_2.Properties.Resources.Captura_de_pantalla_2023_09_19_220055;
            pictureBox1.Location = new Point(387, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 465);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(754, 528);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}