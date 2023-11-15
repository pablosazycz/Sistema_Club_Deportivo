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
            printDialog1 = new PrintDialog();
            menuStrip1 = new MenuStrip();
            impToolStripMenuItem = new ToolStripMenuItem();
            imprimirCarnetToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)carnetLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fotoSocio).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // carnetNombre
            // 
            carnetNombre.AutoSize = true;
            carnetNombre.Location = new Point(12, 155);
            carnetNombre.Name = "carnetNombre";
            carnetNombre.Size = new Size(38, 15);
            carnetNombre.TabIndex = 0;
            carnetNombre.Text = "label1";
            // 
            // carnetApellido
            // 
            carnetApellido.AutoSize = true;
            carnetApellido.Location = new Point(12, 179);
            carnetApellido.Name = "carnetApellido";
            carnetApellido.Size = new Size(38, 15);
            carnetApellido.TabIndex = 1;
            carnetApellido.Text = "label2";
            // 
            // carnetVto
            // 
            carnetVto.AutoSize = true;
            carnetVto.Location = new Point(12, 233);
            carnetVto.Name = "carnetVto";
            carnetVto.Size = new Size(38, 15);
            carnetVto.TabIndex = 2;
            carnetVto.Text = "label3";
            // 
            // carnetNroSocio
            // 
            carnetNroSocio.AutoSize = true;
            carnetNroSocio.Location = new Point(235, 233);
            carnetNroSocio.Name = "carnetNroSocio";
            carnetNroSocio.Size = new Size(38, 15);
            carnetNroSocio.TabIndex = 3;
            carnetNroSocio.Text = "label4";
            // 
            // carnetLogo
            // 
            carnetLogo.BackColor = Color.Transparent;
            carnetLogo.Image = Properties.Resources.Iron_House_Fitness;
            carnetLogo.Location = new Point(12, 35);
            carnetLogo.Name = "carnetLogo";
            carnetLogo.Size = new Size(217, 108);
            carnetLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            carnetLogo.TabIndex = 4;
            carnetLogo.TabStop = false;
            carnetLogo.Click += pictureBox1_Click;
            // 
            // fotoSocio
            // 
            fotoSocio.Image = Properties.Resources.pngwing_com;
            fotoSocio.Location = new Point(235, 35);
            fotoSocio.Name = "fotoSocio";
            fotoSocio.Size = new Size(170, 195);
            fotoSocio.SizeMode = PictureBoxSizeMode.StretchImage;
            fotoSocio.TabIndex = 5;
            fotoSocio.TabStop = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { impToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(429, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // impToolStripMenuItem
            // 
            impToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imprimirCarnetToolStripMenuItem });
            impToolStripMenuItem.Name = "impToolStripMenuItem";
            impToolStripMenuItem.Size = new Size(65, 20);
            impToolStripMenuItem.Text = "Imprimir";
            // 
            // imprimirCarnetToolStripMenuItem
            // 
            imprimirCarnetToolStripMenuItem.Name = "imprimirCarnetToolStripMenuItem";
            imprimirCarnetToolStripMenuItem.Size = new Size(180, 22);
            imprimirCarnetToolStripMenuItem.Text = "Imprimir Carnet";
            imprimirCarnetToolStripMenuItem.Click += imprimirCarnetToolStripMenuItem_Click;
            // 
            // FormCarnet
            // 
            BackColor = Color.White;
            ClientSize = new Size(429, 261);
            Controls.Add(fotoSocio);
            Controls.Add(carnetNroSocio);
            Controls.Add(carnetVto);
            Controls.Add(carnetApellido);
            Controls.Add(carnetNombre);
            Controls.Add(carnetLogo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormCarnet";
            Text = "Carnet de Afiliado al Gimnasio";
            ((System.ComponentModel.ISupportInitialize)carnetLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)fotoSocio).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private PrintDialog printDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem impToolStripMenuItem;
        private ToolStripMenuItem imprimirCarnetToolStripMenuItem;
    }
}