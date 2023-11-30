namespace Sistema_Club_Deportivo
{
    partial class Afiliados
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
            btnAfilNoSocio = new Button();
            btnAfilSocio = new Button();
            btnCuotasAVenc = new Button();
            btnBorrarAf = new Button();
            btnNuevoAf = new Button();
            pnlTabAfil = new Panel();
            button1 = new Button();
            dgdAfiliados = new DataGridView();
            btnEditarAf = new Button();
            pnlTopMenuAf = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnTodosLosAf = new Button();
            pnlTabAfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgdAfiliados).BeginInit();
            pnlTopMenuAf.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAfilNoSocio
            // 
            btnAfilNoSocio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAfilNoSocio.BackColor = Color.FromArgb(62, 62, 62);
            btnAfilNoSocio.Dock = DockStyle.Fill;
            btnAfilNoSocio.FlatAppearance.BorderSize = 0;
            btnAfilNoSocio.FlatStyle = FlatStyle.Popup;
            btnAfilNoSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAfilNoSocio.ForeColor = SystemColors.ButtonFace;
            btnAfilNoSocio.Location = new Point(521, 0);
            btnAfilNoSocio.Margin = new Padding(0);
            btnAfilNoSocio.Name = "btnAfilNoSocio";
            btnAfilNoSocio.Size = new Size(205, 40);
            btnAfilNoSocio.TabIndex = 6;
            btnAfilNoSocio.Text = "No-SOCIOS";
            btnAfilNoSocio.UseVisualStyleBackColor = false;
            btnAfilNoSocio.Click += btnAfilNoSocio_Click;
            // 
            // btnAfilSocio
            // 
            btnAfilSocio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAfilSocio.BackColor = Color.FromArgb(62, 62, 62);
            btnAfilSocio.Dock = DockStyle.Fill;
            btnAfilSocio.FlatAppearance.BorderSize = 0;
            btnAfilSocio.FlatStyle = FlatStyle.Popup;
            btnAfilSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAfilSocio.ForeColor = SystemColors.ButtonFace;
            btnAfilSocio.Location = new Point(316, 0);
            btnAfilSocio.Margin = new Padding(0);
            btnAfilSocio.Name = "btnAfilSocio";
            btnAfilSocio.Size = new Size(205, 40);
            btnAfilSocio.TabIndex = 5;
            btnAfilSocio.Text = "SOCIOS";
            btnAfilSocio.UseVisualStyleBackColor = false;
            btnAfilSocio.Click += btnAfilSocio_Click;
            // 
            // btnCuotasAVenc
            // 
            btnCuotasAVenc.AllowDrop = true;
            btnCuotasAVenc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCuotasAVenc.BackColor = Color.FromArgb(62, 62, 62);
            tableLayoutPanel1.SetColumnSpan(btnCuotasAVenc, 3);
            btnCuotasAVenc.Dock = DockStyle.Fill;
            btnCuotasAVenc.FlatAppearance.BorderSize = 0;
            btnCuotasAVenc.FlatStyle = FlatStyle.Popup;
            btnCuotasAVenc.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCuotasAVenc.ForeColor = SystemColors.ButtonFace;
            btnCuotasAVenc.Location = new Point(316, 40);
            btnCuotasAVenc.Margin = new Padding(0);
            btnCuotasAVenc.Name = "btnCuotasAVenc";
            btnCuotasAVenc.Size = new Size(618, 40);
            btnCuotasAVenc.TabIndex = 1;
            btnCuotasAVenc.Text = "CUOTAS  por  VENCER";
            btnCuotasAVenc.UseVisualStyleBackColor = false;
            btnCuotasAVenc.Click += btnCuotasAVenc_Click;
            // 
            // btnBorrarAf
            // 
            btnBorrarAf.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBorrarAf.BackColor = Color.DimGray;
            btnBorrarAf.Dock = DockStyle.Fill;
            btnBorrarAf.FlatAppearance.BorderSize = 0;
            btnBorrarAf.FlatStyle = FlatStyle.Popup;
            btnBorrarAf.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrarAf.ForeColor = SystemColors.ButtonFace;
            btnBorrarAf.Location = new Point(0, 40);
            btnBorrarAf.Margin = new Padding(0);
            btnBorrarAf.Name = "btnBorrarAf";
            btnBorrarAf.Size = new Size(158, 40);
            btnBorrarAf.TabIndex = 4;
            btnBorrarAf.Text = "BORRAR   afiliado";
            btnBorrarAf.UseVisualStyleBackColor = false;
            btnBorrarAf.Click += btnBorrarAf_Click;
            // 
            // btnNuevoAf
            // 
            btnNuevoAf.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNuevoAf.BackColor = Color.DimGray;
            tableLayoutPanel1.SetColumnSpan(btnNuevoAf, 2);
            btnNuevoAf.Dock = DockStyle.Fill;
            btnNuevoAf.FlatAppearance.BorderSize = 0;
            btnNuevoAf.FlatStyle = FlatStyle.Popup;
            btnNuevoAf.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoAf.ForeColor = SystemColors.ButtonFace;
            btnNuevoAf.Location = new Point(0, 0);
            btnNuevoAf.Margin = new Padding(0);
            btnNuevoAf.Name = "btnNuevoAf";
            btnNuevoAf.Size = new Size(316, 40);
            btnNuevoAf.TabIndex = 2;
            btnNuevoAf.Text = "NUEVO   Afiliado";
            btnNuevoAf.UseVisualStyleBackColor = false;
            btnNuevoAf.Click += btnNuevoAf_Click;
            // 
            // pnlTabAfil
            // 
            pnlTabAfil.BackColor = Color.FromArgb(11, 7, 17);
            pnlTabAfil.Controls.Add(button1);
            pnlTabAfil.Controls.Add(dgdAfiliados);
            pnlTabAfil.Dock = DockStyle.Fill;
            pnlTabAfil.Location = new Point(0, 80);
            pnlTabAfil.Name = "pnlTabAfil";
            pnlTabAfil.Size = new Size(934, 507);
            pnlTabAfil.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(0, 477);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(934, 30);
            button1.TabIndex = 7;
            button1.Text = "----->     CERRAR     PANEL     <-----";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgdAfiliados
            // 
            dgdAfiliados.AllowUserToAddRows = false;
            dgdAfiliados.AllowUserToDeleteRows = false;
            dgdAfiliados.AllowUserToOrderColumns = true;
            dgdAfiliados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgdAfiliados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdAfiliados.Location = new Point(0, 0);
            dgdAfiliados.Name = "dgdAfiliados";
            dgdAfiliados.ReadOnly = true;
            dgdAfiliados.RowTemplate.Height = 25;
            dgdAfiliados.Size = new Size(934, 474);
            dgdAfiliados.TabIndex = 0;
            dgdAfiliados.CellContentClick += dgdAfiliados_CellContentClick;
            // 
            // btnEditarAf
            // 
            btnEditarAf.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarAf.BackColor = Color.DimGray;
            btnEditarAf.Dock = DockStyle.Fill;
            btnEditarAf.FlatAppearance.BorderSize = 0;
            btnEditarAf.FlatStyle = FlatStyle.Popup;
            btnEditarAf.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarAf.ForeColor = SystemColors.ButtonFace;
            btnEditarAf.Location = new Point(158, 40);
            btnEditarAf.Margin = new Padding(0);
            btnEditarAf.Name = "btnEditarAf";
            btnEditarAf.Size = new Size(158, 40);
            btnEditarAf.TabIndex = 8;
            btnEditarAf.Text = "Editar";
            btnEditarAf.UseVisualStyleBackColor = false;
            btnEditarAf.Click += btnEditarAf_Click;
            // 
            // pnlTopMenuAf
            // 
            pnlTopMenuAf.BackColor = Color.FromArgb(45, 45, 45);
            pnlTopMenuAf.Controls.Add(tableLayoutPanel1);
            pnlTopMenuAf.Dock = DockStyle.Top;
            pnlTopMenuAf.Location = new Point(0, 0);
            pnlTopMenuAf.Name = "pnlTopMenuAf";
            pnlTopMenuAf.Size = new Size(934, 80);
            pnlTopMenuAf.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AccessibleDescription = "tblLytPnlTopMenuButAf";
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel1.Controls.Add(btnNuevoAf, 0, 0);
            tableLayoutPanel1.Controls.Add(btnBorrarAf, 0, 1);
            tableLayoutPanel1.Controls.Add(btnTodosLosAf, 4, 0);
            tableLayoutPanel1.Controls.Add(btnAfilNoSocio, 3, 0);
            tableLayoutPanel1.Controls.Add(btnAfilSocio, 2, 0);
            tableLayoutPanel1.Controls.Add(btnEditarAf, 1, 1);
            tableLayoutPanel1.Controls.Add(btnCuotasAVenc, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(934, 80);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // btnTodosLosAf
            // 
            btnTodosLosAf.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTodosLosAf.BackColor = Color.FromArgb(62, 62, 62);
            btnTodosLosAf.Dock = DockStyle.Fill;
            btnTodosLosAf.FlatAppearance.BorderSize = 0;
            btnTodosLosAf.FlatStyle = FlatStyle.Popup;
            btnTodosLosAf.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTodosLosAf.ForeColor = SystemColors.ButtonFace;
            btnTodosLosAf.Location = new Point(726, 0);
            btnTodosLosAf.Margin = new Padding(0);
            btnTodosLosAf.Name = "btnTodosLosAf";
            btnTodosLosAf.Size = new Size(208, 40);
            btnTodosLosAf.TabIndex = 3;
            btnTodosLosAf.Text = "TODOS  los  afiliados";
            btnTodosLosAf.UseVisualStyleBackColor = false;
            btnTodosLosAf.Click += btnTodosLosAf_Click;
            // 
            // Afiliados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(934, 587);
            Controls.Add(pnlTabAfil);
            Controls.Add(pnlTopMenuAf);
            Name = "Afiliados";
            Text = "Afiliados";
            pnlTabAfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgdAfiliados).EndInit();
            pnlTopMenuAf.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlTabAfil;
        private DataGridView dgdAfiliados;
        private Button btnCuotasAVenc;
        private Button btnNuevoAf;
        private Button btnBorrarAf;
        private Button btnAfilNoSocio;
        private Button btnAfilSocio;
        private Button button1;
        private Panel pnlTopMenuAf;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEditarAf;
        private Button btnTodosLosAf;
    }
}