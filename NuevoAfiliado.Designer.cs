namespace Sistema_Club_Deportivo
{
    partial class NuevoAfiliado
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTipoDoc = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNroDoc = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            txtFechaNac = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            txtCP = new TextBox();
            label8 = new Label();
            txtLocalidad = new TextBox();
            label9 = new Label();
            txtEmail = new TextBox();
            label10 = new Label();
            txtTel1 = new TextBox();
            label11 = new Label();
            txtTel2 = new TextBox();
            btnAgregarAfiliado = new Button();
            label12 = new Label();
            textBox1 = new TextBox();
            label13 = new Label();
            txtCuotas = new TextBox();
            label14 = new Label();
            txtNroCarnet = new TextBox();
            label15 = new Label();
            txtFechaAfi = new DateTimePicker();
            txtSocio = new TextBox();
            label16 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(66, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(296, 41);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(164, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtTipoDoc
            // 
            txtTipoDoc.Location = new Point(60, 70);
            txtTipoDoc.Name = "txtTipoDoc";
            txtTipoDoc.Size = new Size(164, 23);
            txtTipoDoc.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 44);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 78);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 5;
            label3.Text = "Tipo Doc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 73);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Nro Doc";
            label4.Click += label4_Click;
            // 
            // txtNroDoc
            // 
            txtNroDoc.Location = new Point(313, 70);
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.Size = new Size(164, 23);
            txtNroDoc.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 110);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 8;
            label5.Text = "Fecha Nac";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(386, 113);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(164, 23);
            txtDireccion.TabIndex = 10;
            // 
            // txtFechaNac
            // 
            txtFechaNac.Format = DateTimePickerFormat.Short;
            txtFechaNac.Location = new Point(73, 110);
            txtFechaNac.Name = "txtFechaNac";
            txtFechaNac.Size = new Size(231, 23);
            txtFechaNac.TabIndex = 9;
            txtFechaNac.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(318, 118);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 11;
            label6.Text = "Direccion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 147);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 13;
            label7.Text = "Cod Postal";
            // 
            // txtCP
            // 
            txtCP.Location = new Point(80, 142);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(164, 23);
            txtCP.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(296, 147);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 15;
            label8.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(364, 142);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(164, 23);
            txtLocalidad.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 185);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 17;
            label9.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(80, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 23);
            txtEmail.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(285, 185);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 19;
            label10.Text = "Telefono 1";
            // 
            // txtTel1
            // 
            txtTel1.Location = new Point(353, 180);
            txtTel1.Name = "txtTel1";
            txtTel1.Size = new Size(164, 23);
            txtTel1.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 218);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 21;
            label11.Text = "Telefono 2";
            // 
            // txtTel2
            // 
            txtTel2.Location = new Point(83, 213);
            txtTel2.Name = "txtTel2";
            txtTel2.Size = new Size(164, 23);
            txtTel2.TabIndex = 20;
            // 
            // btnAgregarAfiliado
            // 
            btnAgregarAfiliado.Location = new Point(593, 401);
            btnAgregarAfiliado.Name = "btnAgregarAfiliado";
            btnAgregarAfiliado.Size = new Size(75, 23);
            btnAgregarAfiliado.TabIndex = 22;
            btnAgregarAfiliado.Text = "Agregar Afiliado";
            btnAgregarAfiliado.UseVisualStyleBackColor = true;
            btnAgregarAfiliado.Click += btnAgregarAfiliado_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 15);
            label12.Name = "label12";
            label12.Size = new Size(29, 15);
            label12.TabIndex = 24;
            label12.Text = "ROL";
            label12.Click += label12_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 23;
            textBox1.Text = "Afiliado";
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(288, 330);
            label13.Name = "label13";
            label13.Size = new Size(81, 15);
            label13.TabIndex = 32;
            label13.Text = "Cuota a Pagar";
            // 
            // txtCuotas
            // 
            txtCuotas.Location = new Point(375, 327);
            txtCuotas.Name = "txtCuotas";
            txtCuotas.Size = new Size(164, 23);
            txtCuotas.TabIndex = 31;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 330);
            label14.Name = "label14";
            label14.Size = new Size(42, 15);
            label14.TabIndex = 30;
            label14.Text = "Carnet";
            // 
            // txtNroCarnet
            // 
            txtNroCarnet.Location = new Point(83, 325);
            txtNroCarnet.Name = "txtNroCarnet";
            txtNroCarnet.Size = new Size(164, 23);
            txtNroCarnet.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(325, 301);
            label15.Name = "label15";
            label15.Size = new Size(36, 15);
            label15.TabIndex = 36;
            label15.Text = "Socio";
            // 
            // txtFechaAfi
            // 
            txtFechaAfi.Location = new Point(80, 293);
            txtFechaAfi.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            txtFechaAfi.Name = "txtFechaAfi";
            txtFechaAfi.Size = new Size(230, 23);
            txtFechaAfi.TabIndex = 35;
            txtFechaAfi.Value = new DateTime(2023, 10, 19, 21, 42, 20, 0);
            // 
            // txtSocio
            // 
            txtSocio.Location = new Point(393, 296);
            txtSocio.Name = "txtSocio";
            txtSocio.Size = new Size(164, 23);
            txtSocio.TabIndex = 34;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(12, 293);
            label16.Name = "label16";
            label16.Size = new Size(91, 15);
            label16.TabIndex = 33;
            label16.Text = "Fecha Afiliacion";
            // 
            // NuevoAfiliado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label15);
            Controls.Add(txtFechaAfi);
            Controls.Add(txtSocio);
            Controls.Add(label16);
            Controls.Add(label13);
            Controls.Add(txtCuotas);
            Controls.Add(label14);
            Controls.Add(txtNroCarnet);
            Controls.Add(label12);
            Controls.Add(textBox1);
            Controls.Add(btnAgregarAfiliado);
            Controls.Add(label11);
            Controls.Add(txtTel2);
            Controls.Add(label10);
            Controls.Add(txtTel1);
            Controls.Add(label9);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(txtLocalidad);
            Controls.Add(label7);
            Controls.Add(txtCP);
            Controls.Add(label6);
            Controls.Add(txtFechaNac);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(txtNroDoc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTipoDoc);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "NuevoAfiliado";
            Text = "NuevoAfiliado";
            Load += NuevoAfiliado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTipoDoc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNroDoc;
        private Label label5;
        private TextBox txtDireccion;
        private DateTimePicker txtFechaNac;
        private Label label6;
        private Label label7;
        private TextBox txtCP;
        private Label label8;
        private TextBox txtLocalidad;
        private Label label9;
        private TextBox txtEmail;
        private Label label10;
        private TextBox txtTel1;
        private Label label11;
        private TextBox txtTel2;
        private Button btnAgregarAfiliado;
        private Label label12;
        private TextBox textBox1;
        private Label label13;
        private TextBox txtCuotas;
        private Label label14;
        private TextBox txtNroCarnet;
        private Label label15;
        private DateTimePicker txtFechaAfi;
        private TextBox txtSocio;
        private Label label16;
    }
}