﻿namespace Sistema_Club_Deportivo
{
    partial class EdicionNoAfiliado
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
            label19 = new Label();
            txtIdPersona = new TextBox();
            label18 = new Label();
            txtIdNoAfiliado = new TextBox();
            btnBuscarAfil = new Button();
            txtBuscarAfil = new TextBox();
            radioSocioBusca = new RadioButton();
            radioDocBuscar = new RadioButton();
            label17 = new Label();
            txtFechaAfi = new DateTimePicker();
            label16 = new Label();
            label12 = new Label();
            txtIdRol = new TextBox();
            btnEditarNoAfiliado = new Button();
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
            txtTipoDoc = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnNoafiliado = new Button();
            SuspendLayout();
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(267, 124);
            label19.Name = "label19";
            label19.Size = new Size(59, 15);
            label19.TabIndex = 113;
            label19.Text = "IdPersona";
            // 
            // txtIdPersona
            // 
            txtIdPersona.Location = new Point(332, 121);
            txtIdPersona.Name = "txtIdPersona";
            txtIdPersona.ReadOnly = true;
            txtIdPersona.Size = new Size(164, 23);
            txtIdPersona.TabIndex = 112;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(516, 129);
            label18.Name = "label18";
            label18.Size = new Size(74, 15);
            label18.TabIndex = 111;
            label18.Text = "IdNoAfiliado";
            // 
            // txtIdNoAfiliado
            // 
            txtIdNoAfiliado.Location = new Point(597, 121);
            txtIdNoAfiliado.Name = "txtIdNoAfiliado";
            txtIdNoAfiliado.ReadOnly = true;
            txtIdNoAfiliado.Size = new Size(164, 23);
            txtIdNoAfiliado.TabIndex = 110;
            // 
            // btnBuscarAfil
            // 
            btnBuscarAfil.Location = new Point(440, 56);
            btnBuscarAfil.Name = "btnBuscarAfil";
            btnBuscarAfil.Size = new Size(75, 23);
            btnBuscarAfil.TabIndex = 109;
            btnBuscarAfil.Text = "Buscar";
            btnBuscarAfil.UseVisualStyleBackColor = true;
            btnBuscarAfil.Click += btnBuscarAfil_Click_1;
            // 
            // txtBuscarAfil
            // 
            txtBuscarAfil.Location = new Point(162, 57);
            txtBuscarAfil.Name = "txtBuscarAfil";
            txtBuscarAfil.Size = new Size(239, 23);
            txtBuscarAfil.TabIndex = 108;
            txtBuscarAfil.TextChanged += txtBuscarAfil_TextChanged;
            // 
            // radioSocioBusca
            // 
            radioSocioBusca.AutoSize = true;
            radioSocioBusca.Location = new Point(26, 73);
            radioSocioBusca.Name = "radioSocioBusca";
            radioSocioBusca.Size = new Size(77, 19);
            radioSocioBusca.TabIndex = 107;
            radioSocioBusca.Text = "Nro Socio";
            radioSocioBusca.UseVisualStyleBackColor = true;
            // 
            // radioDocBuscar
            // 
            radioDocBuscar.AutoSize = true;
            radioDocBuscar.Checked = true;
            radioDocBuscar.Location = new Point(26, 48);
            radioDocBuscar.Name = "radioDocBuscar";
            radioDocBuscar.Size = new Size(69, 19);
            radioDocBuscar.TabIndex = 106;
            radioDocBuscar.TabStop = true;
            radioDocBuscar.Text = "Nro Doc";
            radioDocBuscar.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(2, 13);
            label17.Name = "label17";
            label17.Size = new Size(141, 15);
            label17.TabIndex = 105;
            label17.Text = "Elija Criterio de Búsqueda";
            // 
            // txtFechaAfi
            // 
            txtFechaAfi.Format = DateTimePickerFormat.Short;
            txtFechaAfi.Location = new Point(88, 363);
            txtFechaAfi.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            txtFechaAfi.Name = "txtFechaAfi";
            txtFechaAfi.Size = new Size(173, 23);
            txtFechaAfi.TabIndex = 104;
            txtFechaAfi.Value = new DateTime(2023, 10, 19, 21, 42, 20, 0);
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(20, 363);
            label16.Name = "label16";
            label16.Size = new Size(91, 15);
            label16.TabIndex = 103;
            label16.Text = "Fecha Afiliacion";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 124);
            label12.Name = "label12";
            label12.Size = new Size(29, 15);
            label12.TabIndex = 102;
            label12.Text = "ROL";
            // 
            // txtIdRol
            // 
            txtIdRol.Location = new Point(80, 121);
            txtIdRol.Name = "txtIdRol";
            txtIdRol.ReadOnly = true;
            txtIdRol.Size = new Size(164, 23);
            txtIdRol.TabIndex = 101;
            // 
            // btnEditarNoAfiliado
            // 
            btnEditarNoAfiliado.Location = new Point(400, 365);
            btnEditarNoAfiliado.Name = "btnEditarNoAfiliado";
            btnEditarNoAfiliado.Size = new Size(122, 23);
            btnEditarNoAfiliado.TabIndex = 100;
            btnEditarNoAfiliado.Text = "Editar No Afiliado";
            btnEditarNoAfiliado.UseVisualStyleBackColor = true;
            btnEditarNoAfiliado.Click += btnEditarNoAfiliado_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 327);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 99;
            label11.Text = "Telefono 2";
            // 
            // txtTel2
            // 
            txtTel2.Location = new Point(97, 322);
            txtTel2.Name = "txtTel2";
            txtTel2.Size = new Size(164, 23);
            txtTel2.TabIndex = 98;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(299, 294);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 97;
            label10.Text = "Telefono 1";
            // 
            // txtTel1
            // 
            txtTel1.Location = new Point(367, 289);
            txtTel1.Name = "txtTel1";
            txtTel1.Size = new Size(164, 23);
            txtTel1.TabIndex = 96;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 294);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 95;
            label9.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(94, 289);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 23);
            txtEmail.TabIndex = 94;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(310, 256);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 93;
            label8.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(378, 251);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(164, 23);
            txtLocalidad.TabIndex = 92;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 256);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 91;
            label7.Text = "Cod Postal";
            // 
            // txtCP
            // 
            txtCP.Location = new Point(94, 251);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(164, 23);
            txtCP.TabIndex = 90;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(332, 227);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 89;
            label6.Text = "Direccion";
            // 
            // txtFechaNac
            // 
            txtFechaNac.Format = DateTimePickerFormat.Short;
            txtFechaNac.Location = new Point(87, 219);
            txtFechaNac.Name = "txtFechaNac";
            txtFechaNac.Size = new Size(171, 23);
            txtFechaNac.TabIndex = 87;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(400, 222);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(164, 23);
            txtDireccion.TabIndex = 88;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 219);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 86;
            label5.Text = "Fecha Nac";
            // 
            // txtNroDoc
            // 
            txtNroDoc.Location = new Point(327, 179);
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.Size = new Size(164, 23);
            txtNroDoc.TabIndex = 85;
            txtNroDoc.TextChanged += txtNroDoc_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(267, 182);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 84;
            label4.Text = "Nro Doc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 187);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 83;
            label3.Text = "Tipo Doc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 153);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 82;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 153);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 81;
            label1.Text = "Nombre";
            // 
            // txtTipoDoc
            // 
            txtTipoDoc.Location = new Point(74, 179);
            txtTipoDoc.Name = "txtTipoDoc";
            txtTipoDoc.Size = new Size(164, 23);
            txtTipoDoc.TabIndex = 80;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(310, 150);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(164, 23);
            txtApellido.TabIndex = 79;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 150);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 23);
            txtNombre.TabIndex = 78;
            // 
            // btnNoafiliado
            // 
            btnNoafiliado.Location = new Point(597, 289);
            btnNoafiliado.Name = "btnNoafiliado";
            btnNoafiliado.Size = new Size(152, 23);
            btnNoafiliado.TabIndex = 114;
            btnNoafiliado.Text = "Convertir a socio";
            btnNoafiliado.UseVisualStyleBackColor = true;
            btnNoafiliado.Click += btnNoafiliado_Click;
            // 
            // EdicionNoAfiliado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNoafiliado);
            Controls.Add(label19);
            Controls.Add(txtIdPersona);
            Controls.Add(label18);
            Controls.Add(txtIdNoAfiliado);
            Controls.Add(btnBuscarAfil);
            Controls.Add(txtBuscarAfil);
            Controls.Add(radioSocioBusca);
            Controls.Add(radioDocBuscar);
            Controls.Add(label17);
            Controls.Add(txtFechaAfi);
            Controls.Add(label16);
            Controls.Add(label12);
            Controls.Add(txtIdRol);
            Controls.Add(btnEditarNoAfiliado);
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
            Name = "EdicionNoAfiliado";
            Text = "EdicionNoAfiliado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label19;
        private TextBox txtIdPersona;
        private Label label18;
        private TextBox txtIdNoAfiliado;
        private Button btnBuscarAfil;
        private TextBox txtBuscarAfil;
        private RadioButton radioSocioBusca;
        private RadioButton radioDocBuscar;
        private Label label17;
        private DateTimePicker txtFechaAfi;
        private Label label16;
        private Label label12;
        private TextBox txtIdRol;
        private Button btnEditarNoAfiliado;
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
        private TextBox txtTipoDoc;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnNoafiliado;
    }
}