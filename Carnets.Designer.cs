namespace Sistema_Club_Deportivo
{
    partial class Carnets
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
            tblLytPnlTopMenuButCar = new TableLayoutPanel();
            btnNuevoAf = new Button();
            btnBorrarAf = new Button();
            pnlTabCarn = new Panel();
            dataGridView1 = new DataGridView();
            nombreYApellido = new DataGridViewTextBoxColumn();
            nroCarnet = new DataGridViewTextBoxColumn();
            idAfiliado = new DataGridViewTextBoxColumn();
            fechaVenc = new DataGridViewTextBoxColumn();
            button1 = new Button();
            tblLytPnlTopMenuButCar.SuspendLayout();
            pnlTabCarn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tblLytPnlTopMenuButCar
            // 
            tblLytPnlTopMenuButCar.BackColor = Color.FromArgb(11, 7, 17);
            tblLytPnlTopMenuButCar.ColumnCount = 2;
            tblLytPnlTopMenuButCar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLytPnlTopMenuButCar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLytPnlTopMenuButCar.Controls.Add(btnNuevoAf, 0, 0);
            tblLytPnlTopMenuButCar.Controls.Add(btnBorrarAf, 1, 0);
            tblLytPnlTopMenuButCar.Dock = DockStyle.Top;
            tblLytPnlTopMenuButCar.Location = new Point(0, 0);
            tblLytPnlTopMenuButCar.Name = "tblLytPnlTopMenuButCar";
            tblLytPnlTopMenuButCar.RowCount = 1;
            tblLytPnlTopMenuButCar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLytPnlTopMenuButCar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLytPnlTopMenuButCar.Size = new Size(934, 40);
            tblLytPnlTopMenuButCar.TabIndex = 0;
            // 
            // btnNuevoAf
            // 
            btnNuevoAf.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNuevoAf.BackColor = Color.DimGray;
            btnNuevoAf.Dock = DockStyle.Fill;
            btnNuevoAf.FlatAppearance.BorderSize = 0;
            btnNuevoAf.FlatStyle = FlatStyle.Popup;
            btnNuevoAf.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoAf.ForeColor = SystemColors.ButtonFace;
            btnNuevoAf.Location = new Point(0, 0);
            btnNuevoAf.Margin = new Padding(0);
            btnNuevoAf.Name = "btnNuevoAf";
            btnNuevoAf.Size = new Size(467, 40);
            btnNuevoAf.TabIndex = 5;
            btnNuevoAf.Text = "NUEVO      Carnet";
            btnNuevoAf.UseVisualStyleBackColor = false;
            // 
            // btnBorrarAf
            // 
            btnBorrarAf.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBorrarAf.BackColor = Color.FromArgb(62, 62, 62);
            btnBorrarAf.Dock = DockStyle.Fill;
            btnBorrarAf.FlatAppearance.BorderSize = 0;
            btnBorrarAf.FlatStyle = FlatStyle.Popup;
            btnBorrarAf.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrarAf.ForeColor = SystemColors.ButtonFace;
            btnBorrarAf.Location = new Point(467, 0);
            btnBorrarAf.Margin = new Padding(0);
            btnBorrarAf.Name = "btnBorrarAf";
            btnBorrarAf.Size = new Size(467, 40);
            btnBorrarAf.TabIndex = 6;
            btnBorrarAf.Text = "BORRAR     Carnet";
            btnBorrarAf.UseVisualStyleBackColor = false;
            // 
            // pnlTabCarn
            // 
            pnlTabCarn.BackColor = Color.FromArgb(11, 7, 17);
            pnlTabCarn.Controls.Add(dataGridView1);
            pnlTabCarn.Controls.Add(button1);
            pnlTabCarn.Dock = DockStyle.Fill;
            pnlTabCarn.Location = new Point(0, 40);
            pnlTabCarn.Name = "pnlTabCarn";
            pnlTabCarn.Size = new Size(934, 547);
            pnlTabCarn.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombreYApellido, nroCarnet, idAfiliado, fechaVenc });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(934, 517);
            dataGridView1.TabIndex = 9;
            // 
            // nombreYApellido
            // 
            nombreYApellido.HeaderText = "Nombre y Apellido";
            nombreYApellido.Name = "nombreYApellido";
            // 
            // nroCarnet
            // 
            nroCarnet.HeaderText = "Número de Carnet";
            nroCarnet.Name = "nroCarnet";
            // 
            // idAfiliado
            // 
            idAfiliado.HeaderText = "Número Afiliado";
            idAfiliado.Name = "idAfiliado";
            // 
            // fechaVenc
            // 
            fechaVenc.HeaderText = "Fecha de Vencimiento";
            fechaVenc.Name = "fechaVenc";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(0, 517);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(934, 30);
            button1.TabIndex = 8;
            button1.Text = "----->     CERRAR     PANEL     <-----";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Carnets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 587);
            Controls.Add(pnlTabCarn);
            Controls.Add(tblLytPnlTopMenuButCar);
            Name = "Carnets";
            Text = "Carnets";
            tblLytPnlTopMenuButCar.ResumeLayout(false);
            pnlTabCarn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblLytPnlTopMenuButCar;
        private Panel pnlTabCarn;
        private Button btnBorrarAf;
        private Button btnNuevoAf;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombreYApellido;
        private DataGridViewTextBoxColumn nroCarnet;
        private DataGridViewTextBoxColumn idAfiliado;
        private DataGridViewTextBoxColumn fechaVenc;
    }
}