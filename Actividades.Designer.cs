namespace Sistema_Club_Deportivo
{
    partial class Actividades
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtCupoMaximo = new TextBox();
            label4 = new Label();
            txtCosto = new TextBox();
            label5 = new Label();
            txtProfesorID = new TextBox();
            label6 = new Label();
            txtEquipamiento = new TextBox();
            label7 = new Label();
            txtDia = new TextBox();
            label8 = new Label();
            horaInicioPick = new DateTimePicker();
            horaFinPick = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtNombre = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "nombre";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(63, 104);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 107);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "descripcion";
            // 
            // txtCupoMaximo
            // 
            txtCupoMaximo.Location = new Point(63, 145);
            txtCupoMaximo.Name = "txtCupoMaximo";
            txtCupoMaximo.Size = new Size(100, 23);
            txtCupoMaximo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 148);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 7;
            label4.Text = "cupomaximo";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(63, 187);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 190);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "costo";
            // 
            // txtProfesorID
            // 
            txtProfesorID.Location = new Point(63, 235);
            txtProfesorID.Name = "txtProfesorID";
            txtProfesorID.Size = new Size(100, 23);
            txtProfesorID.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 238);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 11;
            label6.Text = "profe id";
            // 
            // txtEquipamiento
            // 
            txtEquipamiento.Location = new Point(63, 278);
            txtEquipamiento.Name = "txtEquipamiento";
            txtEquipamiento.Size = new Size(100, 23);
            txtEquipamiento.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 281);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 13;
            label7.Text = "equipamiento";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(63, 317);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 320);
            label8.Name = "label8";
            label8.Size = new Size(26, 15);
            label8.TabIndex = 15;
            label8.Text = "dia ";
            // 
            // horaInicioPick
            // 
            horaInicioPick.Format = DateTimePickerFormat.Time;
            horaInicioPick.Location = new Point(186, 23);
            horaInicioPick.Name = "horaInicioPick";
            horaInicioPick.Size = new Size(87, 23);
            horaInicioPick.TabIndex = 17;
            // 
            // horaFinPick
            // 
            horaFinPick.Format = DateTimePickerFormat.Time;
            horaFinPick.Location = new Point(186, 62);
            horaFinPick.Name = "horaFinPick";
            horaFinPick.Size = new Size(87, 23);
            horaFinPick.TabIndex = 18;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(186, 148);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(87, 23);
            dtpFechaFin.TabIndex = 20;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(186, 109);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(87, 23);
            dtpFechaInicio.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(292, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(496, 153);
            dataGridView1.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(261, 321);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "graba";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(364, 321);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 23;
            button2.Text = "editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(465, 321);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 24;
            button3.Text = "borrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(589, 320);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 25;
            button4.Text = "listado";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtNombre
            // 
            txtNombre.DropDownStyle = ComboBoxStyle.DropDownList;
            txtNombre.FormattingEnabled = true;
            txtNombre.Items.AddRange(new object[] { "Todas las Actividades", "ABS", "Crossfit", "Funcional Training", "Musculacion", "Spinnig", "Yoga", "Zumba" });
            txtNombre.Location = new Point(46, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(117, 23);
            txtNombre.TabIndex = 26;
            // 
            // Actividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombre);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(horaFinPick);
            Controls.Add(horaInicioPick);
            Controls.Add(txtDia);
            Controls.Add(label8);
            Controls.Add(txtEquipamiento);
            Controls.Add(label7);
            Controls.Add(txtProfesorID);
            Controls.Add(label6);
            Controls.Add(txtCosto);
            Controls.Add(label5);
            Controls.Add(txtCupoMaximo);
            Controls.Add(label4);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Actividades";
            Text = "Actividades";
            Load += Actividades_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox textBox4;
        private TextBox txtCosto;
        private Label label5;
        private TextBox txtProfesorID;
        private Label label6;
        private TextBox txtEquipamiento;
        private Label label7;
        private TextBox txtDia;
        private Label label8;
        private DateTimePicker horaInicioPick;
        private DateTimePicker horaFinPick;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label4;
        private TextBox txtCupoMaximo;
        private ComboBox txtNombre;
    }
}