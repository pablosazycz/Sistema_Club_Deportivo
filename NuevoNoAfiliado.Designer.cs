﻿namespace Sistema_Club_Deportivo
{
    partial class NuevoNoAfiliado
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
            panel2 = new Panel();
            label14 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            label13 = new Label();
            button2 = new Button();
            button1 = new Button();
            comboBox2 = new ComboBox();
            txtFechaAfi = new DateTimePicker();
            label16 = new Label();
            label12 = new Label();
            textBox1 = new TextBox();
            btnAgregarAfiliado = new Button();
            label11 = new Label();
            txtTel2 = new TextBox();
            label10 = new Label();
            txtTel1 = new TextBox();
            label9 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            txtLocalidad = new TextBox();
            label7 = new Label();
            txtCP = new TextBox();
            label6 = new Label();
            txtFechaNac = new DateTimePicker();
            txtDireccion = new TextBox();
            label5 = new Label();
            txtNroDoc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel3 = new Panel();
            label15 = new Label();
            groupBox2 = new GroupBox();
            montoAPagar = new TextBox();
            label17 = new Label();
            label18 = new Label();
            radioCuotas6 = new RadioButton();
            radioCuotas3 = new RadioButton();
            dateFechaVto = new DateTimePicker();
            txtCodSeg = new TextBox();
            txtNroTarjeta = new TextBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            comboBox3 = new ComboBox();
            label22 = new Label();
            txtIdPersona = new TextBox();
            label23 = new Label();
            label24 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnRegistrarPago = new Button();
            txtArea = new TextBox();
            txtMonto = new TextBox();
            txtIdAfiliado = new TextBox();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(txtFechaAfi);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnAgregarAfiliado);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtTel2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtTel1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtLocalidad);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtCP);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtFechaNac);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtNroDoc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label13);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 74;
            panel2.Paint += panel2_Paint;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(21, 48);
            label14.Name = "label14";
            label14.Size = new Size(99, 15);
            label14.TabIndex = 3;
            label14.Text = "Tipo de Actividad";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Todas las Actividades", "Musculacion", "Crossfit", "Zumba", "Yoga", "ABS", "Spinnig", "Funcional Training" });
            comboBox1.Location = new Point(21, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 150);
            dataGridView1.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 7);
            label13.Name = "label13";
            label13.Size = new Size(298, 15);
            label13.TabIndex = 0;
            label13.Text = "Seleccione la actividad que desea inscribir al NO SOCIO";
            // 
            // button2
            // 
            button2.Location = new Point(503, 377);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 73;
            button2.Text = "siguiente";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(365, 377);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 72;
            button1.Text = "atras";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "DNI", "PASAPORTE" });
            comboBox2.Location = new Point(78, 82);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 71;
            // 
            // txtFechaAfi
            // 
            txtFechaAfi.Format = DateTimePickerFormat.Short;
            txtFechaAfi.Location = new Point(92, 300);
            txtFechaAfi.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            txtFechaAfi.Name = "txtFechaAfi";
            txtFechaAfi.Size = new Size(167, 23);
            txtFechaAfi.TabIndex = 68;
            txtFechaAfi.Value = new DateTime(2023, 10, 19, 21, 42, 20, 0);
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(24, 300);
            label16.Name = "label16";
            label16.Size = new Size(91, 15);
            label16.TabIndex = 66;
            label16.Text = "Fecha Afiliacion";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 22);
            label12.Name = "label12";
            label12.Size = new Size(29, 15);
            label12.TabIndex = 61;
            label12.Text = "ROL";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 19);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 60;
            textBox1.Text = "No Afiliado";
            // 
            // btnAgregarAfiliado
            // 
            btnAgregarAfiliado.Location = new Point(95, 368);
            btnAgregarAfiliado.Name = "btnAgregarAfiliado";
            btnAgregarAfiliado.Size = new Size(75, 23);
            btnAgregarAfiliado.TabIndex = 59;
            btnAgregarAfiliado.Text = "Agregar Afiliado";
            btnAgregarAfiliado.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(27, 225);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 58;
            label11.Text = "Telefono 2";
            // 
            // txtTel2
            // 
            txtTel2.Location = new Point(95, 220);
            txtTel2.Name = "txtTel2";
            txtTel2.Size = new Size(164, 23);
            txtTel2.TabIndex = 57;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(297, 192);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 56;
            label10.Text = "Telefono 1";
            // 
            // txtTel1
            // 
            txtTel1.Location = new Point(365, 187);
            txtTel1.Name = "txtTel1";
            txtTel1.Size = new Size(164, 23);
            txtTel1.TabIndex = 55;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 192);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 54;
            label9.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(92, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 23);
            txtEmail.TabIndex = 53;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(308, 154);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 52;
            label8.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(376, 149);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(164, 23);
            txtLocalidad.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 154);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 50;
            label7.Text = "Cod Postal";
            // 
            // txtCP
            // 
            txtCP.Location = new Point(92, 149);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(164, 23);
            txtCP.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 125);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 48;
            label6.Text = "Direccion";
            // 
            // txtFechaNac
            // 
            txtFechaNac.Format = DateTimePickerFormat.Short;
            txtFechaNac.Location = new Point(85, 117);
            txtFechaNac.Name = "txtFechaNac";
            txtFechaNac.Size = new Size(171, 23);
            txtFechaNac.TabIndex = 46;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(398, 120);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(164, 23);
            txtDireccion.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 117);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 45;
            label5.Text = "Fecha Nac";
            // 
            // txtNroDoc
            // 
            txtNroDoc.Location = new Point(325, 77);
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.Size = new Size(164, 23);
            txtNroDoc.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 80);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 43;
            label4.Text = "Nro Doc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 85);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 42;
            label3.Text = "Tipo Doc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 51);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 41;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 51);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 40;
            label1.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(308, 48);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(164, 23);
            txtApellido.TabIndex = 38;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(78, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 23);
            txtNombre.TabIndex = 37;
            // 
            // button3
            // 
            button3.Location = new Point(29, 285);
            button3.Name = "button3";
            button3.Size = new Size(189, 23);
            button3.TabIndex = 4;
            button3.Text = "Inscribir";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(241, 401);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "atras";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(398, 401);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "siguiente";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(comboBox3);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(txtIdPersona);
            panel3.Controls.Add(label23);
            panel3.Controls.Add(label24);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(btnRegistrarPago);
            panel3.Controls.Add(txtArea);
            panel3.Controls.Add(txtMonto);
            panel3.Controls.Add(txtIdAfiliado);
            panel3.Controls.Add(label25);
            panel3.Controls.Add(label26);
            panel3.Controls.Add(label27);
            panel3.Controls.Add(label28);
            panel3.Controls.Add(label15);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 450);
            panel3.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(24, 19);
            label15.Name = "label15";
            label15.Size = new Size(118, 15);
            label15.TabIndex = 0;
            label15.Text = "Registracion de pago";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(montoAPagar);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(radioCuotas6);
            groupBox2.Controls.Add(radioCuotas3);
            groupBox2.Controls.Add(dateFechaVto);
            groupBox2.Controls.Add(txtCodSeg);
            groupBox2.Controls.Add(txtNroTarjeta);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label21);
            groupBox2.Location = new Point(350, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(429, 151);
            groupBox2.TabIndex = 121;
            groupBox2.TabStop = false;
            // 
            // montoAPagar
            // 
            montoAPagar.Location = new Point(314, 113);
            montoAPagar.Name = "montoAPagar";
            montoAPagar.Size = new Size(100, 23);
            montoAPagar.TabIndex = 106;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(223, 113);
            label17.Name = "label17";
            label17.Size = new Size(85, 15);
            label17.TabIndex = 105;
            label17.Text = "Monto a Pagar";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(302, 29);
            label18.Name = "label18";
            label18.Size = new Size(103, 15);
            label18.TabIndex = 104;
            label18.Text = "Seleccione Cuotas";
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
            // 
            // dateFechaVto
            // 
            dateFechaVto.Format = DateTimePickerFormat.Short;
            dateFechaVto.Location = new Point(121, 78);
            dateFechaVto.Name = "dateFechaVto";
            dateFechaVto.Size = new Size(96, 23);
            dateFechaVto.TabIndex = 94;
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
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(4, 121);
            label19.Name = "label19";
            label19.Size = new Size(85, 15);
            label19.TabIndex = 90;
            label19.Text = "Cod Seguridad";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(4, 80);
            label20.Name = "label20";
            label20.Size = new Size(107, 15);
            label20.TabIndex = 89;
            label20.Text = "Fecha Vencimiento";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(4, 37);
            label21.Name = "label21";
            label21.Size = new Size(77, 15);
            label21.TabIndex = 88;
            label21.Text = "nro de tarjeta";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Credito", "Debito", "Efectivo" });
            comboBox3.Location = new Point(134, 215);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.Sorted = true;
            comboBox3.TabIndex = 120;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(159, 19);
            label22.Name = "label22";
            label22.Size = new Size(59, 15);
            label22.TabIndex = 119;
            label22.Text = "IdPersona";
            // 
            // txtIdPersona
            // 
            txtIdPersona.Enabled = false;
            txtIdPersona.Location = new Point(224, 13);
            txtIdPersona.Name = "txtIdPersona";
            txtIdPersona.ReadOnly = true;
            txtIdPersona.Size = new Size(164, 23);
            txtIdPersona.TabIndex = 118;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(28, 139);
            label23.Name = "label23";
            label23.Size = new Size(51, 15);
            label23.TabIndex = 117;
            label23.Text = "Apellido";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(28, 104);
            label24.Name = "label24";
            label24.Size = new Size(51, 15);
            label24.TabIndex = 116;
            label24.Text = "Nombre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 115;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(85, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 23);
            textBox3.TabIndex = 114;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.Location = new Point(387, 257);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(180, 30);
            btnRegistrarPago.TabIndex = 113;
            btnRegistrarPago.Text = "Registrar Pago";
            btnRegistrarPago.UseVisualStyleBackColor = true;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(134, 257);
            txtArea.Multiline = true;
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(222, 125);
            txtArea.TabIndex = 112;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(85, 172);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 111;
            // 
            // txtIdAfiliado
            // 
            txtIdAfiliado.Location = new Point(85, 66);
            txtIdAfiliado.Name = "txtIdAfiliado";
            txtIdAfiliado.Size = new Size(100, 23);
            txtIdAfiliado.TabIndex = 110;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(21, 257);
            label25.Name = "label25";
            label25.Size = new Size(70, 15);
            label25.TabIndex = 109;
            label25.Text = "Comentario";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(21, 223);
            label26.Name = "label26";
            label26.Size = new Size(95, 15);
            label26.TabIndex = 108;
            label26.Text = "Metodo de Pago";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(29, 177);
            label27.Name = "label27";
            label27.Size = new Size(43, 15);
            label27.TabIndex = 107;
            label27.Text = "Monto";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(21, 69);
            label28.Name = "label28";
            label28.Size = new Size(58, 15);
            label28.TabIndex = 106;
            label28.Text = "IdAfiliado";
            // 
            // button6
            // 
            button6.Location = new Point(174, 415);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 122;
            button6.Text = "atras";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(503, 415);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 123;
            button7.Text = "Finalizar";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(387, 300);
            button8.Name = "button8";
            button8.Size = new Size(180, 30);
            button8.TabIndex = 124;
            button8.Text = "Impresion de Voucher";
            button8.UseVisualStyleBackColor = true;
            // 
            // NuevoNoAfiliado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "NuevoNoAfiliado";
            Text = "NuevoNoAfiliado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label13;
        private Button button2;
        private Button button1;
        private ComboBox comboBox2;
        private DateTimePicker txtFechaAfi;
        private Label label16;
        private Label label12;
        private TextBox textBox1;
        private Button btnAgregarAfiliado;
        private Label label11;
        private TextBox txtTel2;
        private Label label10;
        private TextBox txtTel1;
        private Label label9;
        private TextBox txtEmail;
        private Label label8;
        private TextBox txtLocalidad;
        private Label label7;
        private TextBox txtCP;
        private Label label6;
        private DateTimePicker txtFechaNac;
        private TextBox txtDireccion;
        private Label label5;
        private TextBox txtNroDoc;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label14;
        private ComboBox comboBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Panel panel3;
        private Label label15;
        private Button button7;
        private Button button6;
        private GroupBox groupBox2;
        private TextBox montoAPagar;
        private Label label17;
        private Label label18;
        private RadioButton radioCuotas6;
        private RadioButton radioCuotas3;
        private DateTimePicker dateFechaVto;
        private TextBox txtCodSeg;
        private TextBox txtNroTarjeta;
        private Label label19;
        private Label label20;
        private Label label21;
        private ComboBox comboBox3;
        private Label label22;
        private TextBox txtIdPersona;
        private Label label23;
        private Label label24;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnRegistrarPago;
        private TextBox txtArea;
        private TextBox txtMonto;
        private TextBox txtIdAfiliado;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Button button8;
    }
}