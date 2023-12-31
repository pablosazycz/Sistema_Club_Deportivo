﻿namespace Sistema_Club_Deportivo
{
    partial class Pagos
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBorrarAf = new Button();
            btnNuevoAf = new Button();
            pnlTabPagos = new Panel();
            dataGridView1 = new DataGridView();
            idTicket = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            formaPago = new DataGridViewTextBoxColumn();
            cantCuotas = new DataGridViewComboBoxColumn();
            titularTarjeta = new DataGridViewTextBoxColumn();
            bcoTarjeta = new DataGridViewTextBoxColumn();
            pagoRealizado = new DataGridViewTextBoxColumn();
            button1 = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlTabPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 7, 17);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 40);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnBorrarAf, 1, 0);
            tableLayoutPanel1.Controls.Add(btnNuevoAf, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(934, 40);
            tableLayoutPanel1.TabIndex = 0;
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
            btnBorrarAf.TabIndex = 8;
            btnBorrarAf.Text = "BORRAR     Registro de pago";
            btnBorrarAf.UseVisualStyleBackColor = false;
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
            btnNuevoAf.TabIndex = 7;
            btnNuevoAf.Text = "REGISTRAR  NUEVO     Pago";
            btnNuevoAf.UseVisualStyleBackColor = false;
            // 
            // pnlTabPagos
            // 
            pnlTabPagos.BackColor = Color.FromArgb(11, 7, 17);
            pnlTabPagos.Controls.Add(dataGridView1);
            pnlTabPagos.Controls.Add(button1);
            pnlTabPagos.Dock = DockStyle.Fill;
            pnlTabPagos.Location = new Point(0, 40);
            pnlTabPagos.Name = "pnlTabPagos";
            pnlTabPagos.Size = new Size(934, 547);
            pnlTabPagos.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idTicket, fecha, monto, formaPago, cantCuotas, titularTarjeta, bcoTarjeta, pagoRealizado });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(934, 517);
            dataGridView1.TabIndex = 10;
            // 
            // idTicket
            // 
            idTicket.HeaderText = "idTicket";
            idTicket.Name = "idTicket";
            idTicket.Resizable = DataGridViewTriState.True;
            idTicket.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            fecha.Resizable = DataGridViewTriState.True;
            fecha.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // monto
            // 
            monto.HeaderText = "Monto";
            monto.Name = "monto";
            monto.Resizable = DataGridViewTriState.True;
            monto.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // formaPago
            // 
            formaPago.HeaderText = "Forma de Pago";
            formaPago.Name = "formaPago";
            // 
            // cantCuotas
            // 
            cantCuotas.HeaderText = "Cantidad de Cuotas";
            cantCuotas.Name = "cantCuotas";
            // 
            // titularTarjeta
            // 
            titularTarjeta.HeaderText = "Titular Tarjeta";
            titularTarjeta.Name = "titularTarjeta";
            titularTarjeta.Resizable = DataGridViewTriState.True;
            titularTarjeta.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // bcoTarjeta
            // 
            bcoTarjeta.HeaderText = "Banco Tarjeta";
            bcoTarjeta.Name = "bcoTarjeta";
            bcoTarjeta.Resizable = DataGridViewTriState.True;
            bcoTarjeta.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // pagoRealizado
            // 
            pagoRealizado.HeaderText = "Pago realizado";
            pagoRealizado.Name = "pagoRealizado";
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
            button1.TabIndex = 9;
            button1.Text = "----->     CERRAR     PANEL     <-----";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Pagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 587);
            Controls.Add(pnlTabPagos);
            Controls.Add(panel1);
            Name = "Pagos";
            Text = "Pagos";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnlTabPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlTabPagos;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnBorrarAf;
        private Button btnNuevoAf;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn idTicket;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewTextBoxColumn formaPago;
        private DataGridViewComboBoxColumn cantCuotas;
        private DataGridViewTextBoxColumn titularTarjeta;
        private DataGridViewTextBoxColumn bcoTarjeta;
        private DataGridViewTextBoxColumn pagoRealizado;
    }
}