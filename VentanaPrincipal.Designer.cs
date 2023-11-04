namespace Sistema_Club_Deportivo
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            panel1 = new Panel();
            panel2 = new Panel();
            pnl3SubMenuServNutric = new Panel();
            btnSubVTurDisp = new Button();
            btnSubVTurAsig = new Button();
            btnNutricion = new Button();
            pnl2SubMenuProfes = new Panel();
            btnSubVProfes = new Button();
            btnSubVRutinas = new Button();
            btnSubVAsistencia = new Button();
            btnProfesores = new Button();
            pnl1SubMenuAfiliados = new Panel();
            btnSubVAfiliados = new Button();
            btnSubVCarnets = new Button();
            btnSubVPagos = new Button();
            btnSubPanelAfiliados = new Button();
            pnlLogo = new Panel();
            picLogo = new PictureBox();
            panelHijoForm = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            pnl3SubMenuServNutric.SuspendLayout();
            pnl2SubMenuProfes.SuspendLayout();
            pnl1SubMenuAfiliados.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelHijoForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Red;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 587);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnl3SubMenuServNutric);
            panel2.Controls.Add(btnNutricion);
            panel2.Controls.Add(pnl2SubMenuProfes);
            panel2.Controls.Add(btnProfesores);
            panel2.Controls.Add(pnl1SubMenuAfiliados);
            panel2.Controls.Add(btnSubPanelAfiliados);
            panel2.Controls.Add(pnlLogo);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 587);
            panel2.TabIndex = 13;
            // 
            // pnl3SubMenuServNutric
            // 
            pnl3SubMenuServNutric.BackColor = Color.FromArgb(11, 7, 17);
            pnl3SubMenuServNutric.Controls.Add(btnSubVTurDisp);
            pnl3SubMenuServNutric.Controls.Add(btnSubVTurAsig);
            pnl3SubMenuServNutric.Dock = DockStyle.Top;
            pnl3SubMenuServNutric.Location = new Point(0, 420);
            pnl3SubMenuServNutric.Name = "pnl3SubMenuServNutric";
            pnl3SubMenuServNutric.Size = new Size(200, 70);
            pnl3SubMenuServNutric.TabIndex = 7;
            // 
            // btnSubVTurDisp
            // 
            btnSubVTurDisp.BackColor = Color.FromArgb(64, 64, 64);
            btnSubVTurDisp.Dock = DockStyle.Bottom;
            btnSubVTurDisp.FlatAppearance.BorderSize = 0;
            btnSubVTurDisp.FlatStyle = FlatStyle.Popup;
            btnSubVTurDisp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubVTurDisp.ForeColor = SystemColors.ButtonFace;
            btnSubVTurDisp.Location = new Point(0, 10);
            btnSubVTurDisp.Name = "btnSubVTurDisp";
            btnSubVTurDisp.Padding = new Padding(21, 0, 0, 0);
            btnSubVTurDisp.Size = new Size(200, 30);
            btnSubVTurDisp.TabIndex = 6;
            btnSubVTurDisp.Text = " Turnos DISPONIBLES";
            btnSubVTurDisp.TextAlign = ContentAlignment.MiddleLeft;
            btnSubVTurDisp.UseVisualStyleBackColor = false;
            // 
            // btnSubVTurAsig
            // 
            btnSubVTurAsig.BackColor = Color.FromArgb(64, 64, 64);
            btnSubVTurAsig.Dock = DockStyle.Bottom;
            btnSubVTurAsig.FlatAppearance.BorderSize = 0;
            btnSubVTurAsig.FlatStyle = FlatStyle.Popup;
            btnSubVTurAsig.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubVTurAsig.ForeColor = SystemColors.ButtonFace;
            btnSubVTurAsig.Location = new Point(0, 40);
            btnSubVTurAsig.Name = "btnSubVTurAsig";
            btnSubVTurAsig.Padding = new Padding(22, 0, 0, 0);
            btnSubVTurAsig.Size = new Size(200, 30);
            btnSubVTurAsig.TabIndex = 7;
            btnSubVTurAsig.Text = " Turnos ASIGNADOS";
            btnSubVTurAsig.TextAlign = ContentAlignment.MiddleLeft;
            btnSubVTurAsig.UseVisualStyleBackColor = false;
            // 
            // btnNutricion
            // 
            btnNutricion.BackColor = Color.FromArgb(11, 7, 17);
            btnNutricion.Dock = DockStyle.Top;
            btnNutricion.FlatAppearance.BorderSize = 0;
            btnNutricion.FlatStyle = FlatStyle.Flat;
            btnNutricion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNutricion.ForeColor = SystemColors.ButtonFace;
            btnNutricion.Location = new Point(0, 380);
            btnNutricion.Name = "btnNutricion";
            btnNutricion.Size = new Size(200, 40);
            btnNutricion.TabIndex = 5;
            btnNutricion.Text = " Serv. NUTRICION";
            btnNutricion.TextAlign = ContentAlignment.MiddleLeft;
            btnNutricion.UseVisualStyleBackColor = false;
            btnNutricion.Click += btnNutricion_Click_1;
            // 
            // pnl2SubMenuProfes
            // 
            pnl2SubMenuProfes.BackColor = Color.FromArgb(11, 7, 17);
            pnl2SubMenuProfes.Controls.Add(btnSubVProfes);
            pnl2SubMenuProfes.Controls.Add(btnSubVRutinas);
            pnl2SubMenuProfes.Controls.Add(btnSubVAsistencia);
            pnl2SubMenuProfes.Dock = DockStyle.Top;
            pnl2SubMenuProfes.Location = new Point(0, 280);
            pnl2SubMenuProfes.Name = "pnl2SubMenuProfes";
            pnl2SubMenuProfes.Size = new Size(200, 100);
            pnl2SubMenuProfes.TabIndex = 6;
            // 
            // btnSubVProfes
            // 
            btnSubVProfes.BackColor = Color.FromArgb(64, 64, 64);
            btnSubVProfes.Dock = DockStyle.Bottom;
            btnSubVProfes.FlatAppearance.BorderSize = 0;
            btnSubVProfes.FlatStyle = FlatStyle.Popup;
            btnSubVProfes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubVProfes.ForeColor = SystemColors.ButtonFace;
            btnSubVProfes.Location = new Point(0, 10);
            btnSubVProfes.Name = "btnSubVProfes";
            btnSubVProfes.Padding = new Padding(22, 0, 0, 0);
            btnSubVProfes.Size = new Size(200, 30);
            btnSubVProfes.TabIndex = 6;
            btnSubVProfes.Text = " PROFESORES";
            btnSubVProfes.TextAlign = ContentAlignment.MiddleLeft;
            btnSubVProfes.UseVisualStyleBackColor = false;
            // 
            // btnSubVRutinas
            // 
            btnSubVRutinas.BackColor = Color.FromArgb(64, 64, 64);
            btnSubVRutinas.Dock = DockStyle.Bottom;
            btnSubVRutinas.FlatAppearance.BorderSize = 0;
            btnSubVRutinas.FlatStyle = FlatStyle.Popup;
            btnSubVRutinas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubVRutinas.ForeColor = SystemColors.ButtonFace;
            btnSubVRutinas.Location = new Point(0, 40);
            btnSubVRutinas.Name = "btnSubVRutinas";
            btnSubVRutinas.Padding = new Padding(22, 0, 0, 0);
            btnSubVRutinas.Size = new Size(200, 30);
            btnSubVRutinas.TabIndex = 7;
            btnSubVRutinas.Text = " Rutinas SOCIOS";
            btnSubVRutinas.TextAlign = ContentAlignment.MiddleLeft;
            btnSubVRutinas.UseVisualStyleBackColor = false;
            // 
            // btnSubVAsistencia
            // 
            btnSubVAsistencia.BackColor = Color.FromArgb(64, 64, 64);
            btnSubVAsistencia.Dock = DockStyle.Bottom;
            btnSubVAsistencia.FlatAppearance.BorderSize = 0;
            btnSubVAsistencia.FlatStyle = FlatStyle.Popup;
            btnSubVAsistencia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubVAsistencia.ForeColor = SystemColors.ButtonFace;
            btnSubVAsistencia.Location = new Point(0, 70);
            btnSubVAsistencia.Name = "btnSubVAsistencia";
            btnSubVAsistencia.Padding = new Padding(22, 0, 0, 0);
            btnSubVAsistencia.Size = new Size(200, 30);
            btnSubVAsistencia.TabIndex = 8;
            btnSubVAsistencia.Text = " ASISTENCIA";
            btnSubVAsistencia.TextAlign = ContentAlignment.MiddleLeft;
            btnSubVAsistencia.UseVisualStyleBackColor = false;
            // 
            // btnProfesores
            // 
            btnProfesores.BackColor = Color.FromArgb(11, 7, 17);
            btnProfesores.Dock = DockStyle.Top;
            btnProfesores.FlatAppearance.BorderSize = 0;
            btnProfesores.FlatStyle = FlatStyle.Flat;
            btnProfesores.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProfesores.ForeColor = SystemColors.ButtonFace;
            btnProfesores.Location = new Point(0, 240);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Size = new Size(200, 40);
            btnProfesores.TabIndex = 4;
            btnProfesores.Text = " Gestión PROFESORES";
            btnProfesores.TextAlign = ContentAlignment.MiddleLeft;
            btnProfesores.UseVisualStyleBackColor = false;
            btnProfesores.Click += btnProfesores_Click_1;
            // 
            // pnl1SubMenuAfiliados
            // 
            pnl1SubMenuAfiliados.BackColor = Color.FromArgb(11, 7, 17);
            pnl1SubMenuAfiliados.Controls.Add(btnSubVAfiliados);
            pnl1SubMenuAfiliados.Controls.Add(btnSubVCarnets);
            pnl1SubMenuAfiliados.Controls.Add(btnSubVPagos);
            pnl1SubMenuAfiliados.Dock = DockStyle.Top;
            pnl1SubMenuAfiliados.Location = new Point(0, 140);
            pnl1SubMenuAfiliados.Margin = new Padding(0);
            pnl1SubMenuAfiliados.Name = "pnl1SubMenuAfiliados";
            pnl1SubMenuAfiliados.Size = new Size(200, 100);
            pnl1SubMenuAfiliados.TabIndex = 5;
            // 
            // btnSubVAfiliados
            // 
            btnSubVAfiliados.BackColor = Color.FromArgb(64, 64, 64);
            btnSubVAfiliados.Dock = DockStyle.Bottom;
            btnSubVAfiliados.FlatAppearance.BorderSize = 0;
            btnSubVAfiliados.FlatStyle = FlatStyle.Popup;
            btnSubVAfiliados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubVAfiliados.ForeColor = SystemColors.ButtonFace;
            btnSubVAfiliados.Location = new Point(0, 10);
            btnSubVAfiliados.Margin = new Padding(0);
            btnSubVAfiliados.Name = "btnSubVAfiliados";
            btnSubVAfiliados.Padding = new Padding(22, 0, 0, 0);
            btnSubVAfiliados.Size = new Size(200, 30);
            btnSubVAfiliados.TabIndex = 6;
            btnSubVAfiliados.Text = " AFILIADOS";
            btnSubVAfiliados.TextAlign = ContentAlignment.MiddleLeft;
            btnSubVAfiliados.UseVisualStyleBackColor = false;
            btnSubVAfiliados.Click += btnSubVAfiliados_Click_1;
            // 
            // btnSubVCarnets
            // 
            btnSubVCarnets.BackColor = Color.FromArgb(64, 64, 64);
            btnSubVCarnets.Dock = DockStyle.Bottom;
            btnSubVCarnets.FlatAppearance.BorderSize = 0;
            btnSubVCarnets.FlatStyle = FlatStyle.Popup;
            btnSubVCarnets.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubVCarnets.ForeColor = SystemColors.ButtonFace;
            btnSubVCarnets.Location = new Point(0, 40);
            btnSubVCarnets.Margin = new Padding(0);
            btnSubVCarnets.Name = "btnSubVCarnets";
            btnSubVCarnets.Padding = new Padding(22, 0, 0, 0);
            btnSubVCarnets.Size = new Size(200, 30);
            btnSubVCarnets.TabIndex = 7;
            btnSubVCarnets.Text = " CARNETS";
            btnSubVCarnets.TextAlign = ContentAlignment.MiddleLeft;
            btnSubVCarnets.UseVisualStyleBackColor = false;
            btnSubVCarnets.Click += btnSubVCarnets_Click_1;
            // 
            // btnSubVPagos
            // 
            btnSubVPagos.BackColor = Color.FromArgb(64, 64, 64);
            btnSubVPagos.Dock = DockStyle.Bottom;
            btnSubVPagos.FlatAppearance.BorderSize = 0;
            btnSubVPagos.FlatStyle = FlatStyle.Popup;
            btnSubVPagos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubVPagos.ForeColor = SystemColors.ButtonFace;
            btnSubVPagos.Location = new Point(0, 70);
            btnSubVPagos.Margin = new Padding(0);
            btnSubVPagos.Name = "btnSubVPagos";
            btnSubVPagos.Padding = new Padding(22, 0, 0, 0);
            btnSubVPagos.Size = new Size(200, 30);
            btnSubVPagos.TabIndex = 8;
            btnSubVPagos.Text = " PAGOS";
            btnSubVPagos.TextAlign = ContentAlignment.MiddleLeft;
            btnSubVPagos.UseVisualStyleBackColor = false;
            btnSubVPagos.Click += btnSubVPagos_Click_1;
            // 
            // btnSubPanelAfiliados
            // 
            btnSubPanelAfiliados.BackColor = Color.FromArgb(11, 7, 17);
            btnSubPanelAfiliados.Dock = DockStyle.Top;
            btnSubPanelAfiliados.FlatAppearance.BorderSize = 0;
            btnSubPanelAfiliados.FlatStyle = FlatStyle.Flat;
            btnSubPanelAfiliados.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubPanelAfiliados.ForeColor = SystemColors.ButtonFace;
            btnSubPanelAfiliados.Location = new Point(0, 100);
            btnSubPanelAfiliados.Margin = new Padding(0);
            btnSubPanelAfiliados.Name = "btnSubPanelAfiliados";
            btnSubPanelAfiliados.Size = new Size(200, 40);
            btnSubPanelAfiliados.TabIndex = 3;
            btnSubPanelAfiliados.Text = " Gestión AFILIADOS";
            btnSubPanelAfiliados.TextAlign = ContentAlignment.MiddleLeft;
            btnSubPanelAfiliados.UseVisualStyleBackColor = false;
            btnSubPanelAfiliados.Click += btnSubPanelAfiliados_Click_1;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.Red;
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(200, 100);
            pnlLogo.TabIndex = 4;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.Iron_House_Fitness;
            picLogo.Location = new Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(200, 100);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panelHijoForm
            // 
            panelHijoForm.BackColor = Color.FromArgb(11, 7, 17);
            panelHijoForm.Controls.Add(pictureBox1);
            panelHijoForm.Dock = DockStyle.Fill;
            panelHijoForm.Location = new Point(200, 0);
            panelHijoForm.Name = "panelHijoForm";
            panelHijoForm.Size = new Size(734, 587);
            panelHijoForm.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(734, 587);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(11, 7, 17);
            ClientSize = new Size(934, 587);
            Controls.Add(panelHijoForm);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "VentanaPrincipal";
            Text = "VentanaPrincipal";
            FormClosing += VentanaPrincipal_FormClosing;
            panel2.ResumeLayout(false);
            pnl3SubMenuServNutric.ResumeLayout(false);
            pnl2SubMenuProfes.ResumeLayout(false);
            pnl1SubMenuAfiliados.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelHijoForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel pnl1SubMenuAfiliados;
        private Button btnSubPanelAfiliados;
        private Panel pnlLogo;
        private PictureBox picLogo;
        private Panel panelHijoForm;
        private Panel pnl3SubMenuServNutric;
        private Button btnSubVTurDisp;
        private Panel pnl2SubMenuProfes;
        private Button btnSubVTurAsig;
        private Button btnSubVProfes;
        private Button btnSubVRutinas;
        private Button btnSubVPagos;
        private Button btnSubVAsistencia;
        private Button btnSubVAfiliados;
        private Button btnSubVCarnets;
        private Button btnNutricion;
        private PictureBox pictureBox1;
        private Button btnProfesores;
    }
}