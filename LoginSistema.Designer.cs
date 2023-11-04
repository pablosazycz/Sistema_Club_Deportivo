namespace Sistema_Club_Deportivo
{
    partial class LoginSistema
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
            pictureBox1 = new PictureBox();
            txtLoginUser = new TextBox();
            txtPassUser = new TextBox();
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Iron_House_Fitness;
            pictureBox1.Location = new Point(20, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtLoginUser
            // 
            txtLoginUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginUser.Location = new Point(20, 190);
            txtLoginUser.Name = "txtLoginUser";
            txtLoginUser.Size = new Size(312, 29);
            txtLoginUser.TabIndex = 1;
            txtLoginUser.Text = "Ingrese su USUARIO";
            txtLoginUser.Enter += txtLoginUser_Enter;
            txtLoginUser.Leave += txtLoginUser_Leave;
            // 
            // txtPassUser
            // 
            txtPassUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassUser.Location = new Point(20, 234);
            txtPassUser.Name = "txtPassUser";
            txtPassUser.ScrollBars = ScrollBars.Vertical;
            txtPassUser.Size = new Size(312, 29);
            txtPassUser.TabIndex = 2;
            txtPassUser.Text = "Ingrese su CONTRASEÑA";
            txtPassUser.Enter += txtPassUser_Enter;
            txtPassUser.Leave += txtPassUser_Leave;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnIngresar.Location = new Point(20, 295);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(312, 45);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // LoginSistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(344, 364);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassUser);
            Controls.Add(txtLoginUser);
            Controls.Add(pictureBox1);
            Name = "LoginSistema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginSistema";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtLoginUser;
        private TextBox txtPassUser;
        private Button btnIngresar;
    }
}