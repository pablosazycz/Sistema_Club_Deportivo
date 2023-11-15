namespace Sistema_Club_Deportivo
{
    partial class NuevoPago
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
            components = new System.ComponentModel.Container();
            btnBuscarAfil = new Button();
            txtBuscarAfil = new TextBox();
            radioSocioBusca = new RadioButton();
            radioDocBuscar = new RadioButton();
            label17 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIdAfiliado = new TextBox();
            txtMonto = new TextBox();
            btnRegistrarPago = new Button();
            txtCodSeg = new TextBox();
            txtNroTarjeta = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtArea = new TextBox();
            dateFechaVto = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label19 = new Label();
            txtIdPersona = new TextBox();
            comboBox1 = new ComboBox();
            radioCuotas3 = new RadioButton();
            radioCuotas6 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            montoAPagar = new TextBox();
            label11 = new Label();
            label10 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarAfil
            // 
            btnBuscarAfil.Location = new Point(444, 53);
            btnBuscarAfil.Name = "btnBuscarAfil";
            btnBuscarAfil.Size = new Size(75, 23);
            btnBuscarAfil.TabIndex = 78;
            btnBuscarAfil.Text = "Buscar";
            btnBuscarAfil.UseVisualStyleBackColor = true;
            btnBuscarAfil.Click += btnBuscarAfil_Click;
            // 
            // txtBuscarAfil
            // 
            txtBuscarAfil.Location = new Point(166, 54);
            txtBuscarAfil.Name = "txtBuscarAfil";
            txtBuscarAfil.Size = new Size(239, 23);
            txtBuscarAfil.TabIndex = 77;
            // 
            // radioSocioBusca
            // 
            radioSocioBusca.AutoSize = true;
            radioSocioBusca.Location = new Point(30, 70);
            radioSocioBusca.Name = "radioSocioBusca";
            radioSocioBusca.Size = new Size(77, 19);
            radioSocioBusca.TabIndex = 75;
            radioSocioBusca.Text = "Nro Socio";
            radioSocioBusca.UseVisualStyleBackColor = true;
            // 
            // radioDocBuscar
            // 
            radioDocBuscar.AutoSize = true;
            radioDocBuscar.Checked = true;
            radioDocBuscar.Location = new Point(30, 45);
            radioDocBuscar.Name = "radioDocBuscar";
            radioDocBuscar.Size = new Size(69, 19);
            radioDocBuscar.TabIndex = 76;
            radioDocBuscar.TabStop = true;
            radioDocBuscar.Text = "Nro Doc";
            radioDocBuscar.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 19);
            label17.Name = "label17";
            label17.Size = new Size(141, 15);
            label17.TabIndex = 74;
            label17.Text = "Elija Criterio de Búsqueda";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 122);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 79;
            label1.Text = "IdAfiliado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 235);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 80;
            label2.Text = "Monto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 276);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 81;
            label3.Text = "Metodo de Pago";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 310);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 82;
            label4.Text = "Comentario";
            // 
            // txtIdAfiliado
            // 
            txtIdAfiliado.Location = new Point(120, 119);
            txtIdAfiliado.Name = "txtIdAfiliado";
            txtIdAfiliado.Size = new Size(100, 23);
            txtIdAfiliado.TabIndex = 83;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(139, 227);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 84;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.Location = new Point(426, 343);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(180, 30);
            btnRegistrarPago.TabIndex = 87;
            btnRegistrarPago.Text = "Registrar Pago";
            btnRegistrarPago.UseVisualStyleBackColor = true;
            btnRegistrarPago.Click += btnRegistrarPago_Click_1;
            // 
            // txtCodSeg
            // 
            txtCodSeg.Location = new Point(117, 113);
            txtCodSeg.Name = "txtCodSeg";
            txtCodSeg.Size = new Size(100, 23);
            txtCodSeg.TabIndex = 93;
            // 
            // txtNroTarjeta
            // 
            txtNroTarjeta.HideSelection = false;
            txtNroTarjeta.ImeMode = ImeMode.NoControl;
            txtNroTarjeta.Location = new Point(112, 29);
            txtNroTarjeta.Name = "txtNroTarjeta";
            txtNroTarjeta.Size = new Size(166, 23);
            txtNroTarjeta.TabIndex = 91;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 121);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 90;
            label5.Text = "Cod Seguridad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 80);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 89;
            label6.Text = "Fecha Vencimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 37);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 88;
            label7.Text = "nro de tarjeta";
            // 
            // txtArea
            // 
            txtArea.Location = new Point(169, 310);
            txtArea.Multiline = true;
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(222, 125);
            txtArea.TabIndex = 86;
            // 
            // dateFechaVto
            // 
            dateFechaVto.Format = DateTimePickerFormat.Short;
            dateFechaVto.Location = new Point(121, 78);
            dateFechaVto.Name = "dateFechaVto";
            dateFechaVto.Size = new Size(96, 23);
            dateFechaVto.TabIndex = 94;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 192);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 98;
            label8.Text = "Apellido";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(63, 157);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 97;
            label9.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(120, 189);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(164, 23);
            txtApellido.TabIndex = 96;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(120, 154);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 23);
            txtNombre.TabIndex = 95;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(254, 122);
            label19.Name = "label19";
            label19.Size = new Size(59, 15);
            label19.TabIndex = 100;
            label19.Text = "IdPersona";
            // 
            // txtIdPersona
            // 
            txtIdPersona.Enabled = false;
            txtIdPersona.Location = new Point(319, 119);
            txtIdPersona.Name = "txtIdPersona";
            txtIdPersona.ReadOnly = true;
            txtIdPersona.Size = new Size(164, 23);
            txtIdPersona.TabIndex = 99;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Credito", "Debito", "Efectivo" });
            comboBox1.Location = new Point(169, 268);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 101;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // radioCuotas3
            // 
            radioCuotas3.AutoSize = true;
            radioCuotas3.Cursor = Cursors.Hand;
            radioCuotas3.Location = new Point(319, 55);
            radioCuotas3.Name = "radioCuotas3";
            radioCuotas3.Size = new Size(71, 19);
            radioCuotas3.TabIndex = 102;
            radioCuotas3.TabStop = true;
            radioCuotas3.Text = "3 Cuotas";
            radioCuotas3.UseVisualStyleBackColor = true;
            radioCuotas3.CheckedChanged += radioCuotas_CheckedChanged;
            // 
            // radioCuotas6
            // 
            radioCuotas6.AutoSize = true;
            radioCuotas6.Location = new Point(319, 80);
            radioCuotas6.Name = "radioCuotas6";
            radioCuotas6.Size = new Size(71, 19);
            radioCuotas6.TabIndex = 103;
            radioCuotas6.TabStop = true;
            radioCuotas6.Text = "6 Cuotas";
            radioCuotas6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(radioDocBuscar);
            groupBox1.Controls.Add(radioSocioBusca);
            groupBox1.Controls.Add(txtBuscarAfil);
            groupBox1.Controls.Add(btnBuscarAfil);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 99);
            groupBox1.TabIndex = 104;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(montoAPagar);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(radioCuotas6);
            groupBox2.Controls.Add(radioCuotas3);
            groupBox2.Controls.Add(dateFechaVto);
            groupBox2.Controls.Add(txtCodSeg);
            groupBox2.Controls.Add(txtNroTarjeta);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(358, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(429, 151);
            groupBox2.TabIndex = 105;
            groupBox2.TabStop = false;
            // 
            // montoAPagar
            // 
            montoAPagar.Location = new Point(314, 113);
            montoAPagar.Name = "montoAPagar";
            montoAPagar.Size = new Size(100, 23);
            montoAPagar.TabIndex = 106;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(223, 113);
            label11.Name = "label11";
            label11.Size = new Size(85, 15);
            label11.TabIndex = 105;
            label11.Text = "Monto a Pagar";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(302, 29);
            label10.Name = "label10";
            label10.Size = new Size(103, 15);
            label10.TabIndex = 104;
            label10.Text = "Seleccione Cuotas";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // NuevoPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(label19);
            Controls.Add(txtIdPersona);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnRegistrarPago);
            Controls.Add(txtArea);
            Controls.Add(txtMonto);
            Controls.Add(txtIdAfiliado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Name = "NuevoPago";
            Text = "NuevoPago";
            Load += NuevoPago_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarAfil;
        private TextBox txtBuscarAfil;
        private RadioButton radioSocioBusca;
        private RadioButton radioDocBuscar;
        private Label label17;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIdAfiliado;
        private TextBox txtMonto;
        private Button btnRegistrarPago;
        private TextBox txtCodSeg;
        private TextBox txtNroTarjeta;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtArea;
        private DateTimePicker dateFechaVto;
        private Label label8;
        private Label label9;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label19;
        private TextBox txtIdPersona;
        private ComboBox comboBox1;
        private RadioButton radioCuotas3;
        private RadioButton radioCuotas6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label10;
        private TextBox montoAPagar;
        private Label label11;
        private ErrorProvider errorProvider1;
    }
}