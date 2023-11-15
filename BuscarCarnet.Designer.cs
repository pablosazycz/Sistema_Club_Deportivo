namespace Sistema_Club_Deportivo
{
    partial class BuscarCarnet
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
            groupBox1 = new GroupBox();
            label17 = new Label();
            radioDocBuscar = new RadioButton();
            radioSocioBusca = new RadioButton();
            txtBuscarAfil = new TextBox();
            btnBuscarAfil = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            groupBox1.Size = new Size(550, 99);
            groupBox1.TabIndex = 105;
            groupBox1.TabStop = false;
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
            // txtBuscarAfil
            // 
            txtBuscarAfil.Location = new Point(166, 54);
            txtBuscarAfil.Name = "txtBuscarAfil";
            txtBuscarAfil.Size = new Size(239, 23);
            txtBuscarAfil.TabIndex = 77;
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
            // BuscarCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 111);
            Controls.Add(groupBox1);
            Name = "BuscarCarnet";
            Text = "BuscarCarnet";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label17;
        private RadioButton radioDocBuscar;
        private RadioButton radioSocioBusca;
        private TextBox txtBuscarAfil;
        private Button btnBuscarAfil;
    }
}