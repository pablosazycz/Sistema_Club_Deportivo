using System.Xml;

namespace Sistema_Club_Deportivo
{
    partial class FormCarnet
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
            carnetNombre = new Label();
            carnetApellido = new Label();
            carnetVto = new Label();
            carnetNroSocio = new Label();
            carnetLogo = new PictureBox();
            fotoSocio = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)carnetLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fotoSocio).BeginInit();
            SuspendLayout();
            // 
            // carnetNombre
            // 
            carnetNombre.AutoSize = true;
            carnetNombre.Location = new Point(12, 132);
            carnetNombre.Name = "carnetNombre";
            carnetNombre.Size = new Size(38, 15);
            carnetNombre.TabIndex = 0;
            carnetNombre.Text = "label1";
            // 
            // carnetApellido
            // 
            carnetApellido.AutoSize = true;
            carnetApellido.Location = new Point(12, 156);
            carnetApellido.Name = "carnetApellido";
            carnetApellido.Size = new Size(38, 15);
            carnetApellido.TabIndex = 1;
            carnetApellido.Text = "label2";
            // 
            // carnetVto
            // 
            carnetVto.AutoSize = true;
            carnetVto.Location = new Point(12, 210);
            carnetVto.Name = "carnetVto";
            carnetVto.Size = new Size(38, 15);
            carnetVto.TabIndex = 2;
            carnetVto.Text = "label3";
            // 
            // carnetNroSocio
            // 
            carnetNroSocio.AutoSize = true;
            carnetNroSocio.Location = new Point(235, 210);
            carnetNroSocio.Name = "carnetNroSocio";
            carnetNroSocio.Size = new Size(38, 15);
            carnetNroSocio.TabIndex = 3;
            carnetNroSocio.Text = "label4";
            // 
            // carnetLogo
            // 
            carnetLogo.BackColor = Color.Transparent;
            carnetLogo.Image = Properties.Resources.Iron_House_Fitness;
            carnetLogo.Location = new Point(12, 12);
            carnetLogo.Name = "carnetLogo";
            carnetLogo.Size = new Size(217, 108);
            carnetLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            carnetLogo.TabIndex = 4;
            carnetLogo.TabStop = false;
            carnetLogo.Click += pictureBox1_Click;
            // 
            // fotoSocio
            // 
            fotoSocio.Location = new Point(235, 12);
            fotoSocio.Name = "fotoSocio";
            fotoSocio.Size = new Size(170, 195);
            fotoSocio.TabIndex = 5;
            fotoSocio.TabStop = false;
            // 
            // FormCarnet
            // 
            BackColor = Color.White;
            ClientSize = new Size(417, 234);
            Controls.Add(fotoSocio);
            Controls.Add(carnetNroSocio);
            Controls.Add(carnetVto);
            Controls.Add(carnetApellido);
            Controls.Add(carnetNombre);
            Controls.Add(carnetLogo);
            Name = "FormCarnet";
            Text = "Carnet de Afiliado al Gimnasio";
            ((System.ComponentModel.ISupportInitialize)carnetLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)fotoSocio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label carnetNombre;
        private Label carnetApellido;
        private Label carnetVto;
        private Label carnetNroSocio;
        private PictureBox carnetLogo;
        private PictureBox fotoSocio;
    }
}