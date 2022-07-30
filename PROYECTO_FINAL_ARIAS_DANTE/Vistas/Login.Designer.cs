namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorNombre = new System.Windows.Forms.Label();
            this.errorCi = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.titleForm = new System.Windows.Forms.Label();
            this.inpPassword = new System.Windows.Forms.TextBox();
            this.inpUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.errorNombre);
            this.panel1.Controls.Add(this.errorCi);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.titleForm);
            this.panel1.Controls.Add(this.inpPassword);
            this.panel1.Controls.Add(this.inpUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 339);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Contraseña: admin";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Usuario: admin";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "CREDENCIALES DE PRUEBA:";
            // 
            // errorNombre
            // 
            this.errorNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorNombre.AutoSize = true;
            this.errorNombre.ForeColor = System.Drawing.Color.DarkRed;
            this.errorNombre.Location = new System.Drawing.Point(114, 166);
            this.errorNombre.Name = "errorNombre";
            this.errorNombre.Size = new System.Drawing.Size(0, 15);
            this.errorNombre.TabIndex = 39;
            // 
            // errorCi
            // 
            this.errorCi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorCi.AutoSize = true;
            this.errorCi.ForeColor = System.Drawing.Color.DarkRed;
            this.errorCi.Location = new System.Drawing.Point(114, 112);
            this.errorCi.Name = "errorCi";
            this.errorCi.Size = new System.Drawing.Size(0, 15);
            this.errorCi.TabIndex = 38;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = global::PROYECTO_FINAL_ARIAS_DANTE.Properties.Resources.icons8_login_50__1_;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(126, 195);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(155, 58);
            this.btnLogin.TabIndex = 38;
            this.btnLogin.Text = "INGRESAR";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // titleForm
            // 
            this.titleForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleForm.AutoSize = true;
            this.titleForm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleForm.Location = new System.Drawing.Point(154, 22);
            this.titleForm.Name = "titleForm";
            this.titleForm.Size = new System.Drawing.Size(82, 32);
            this.titleForm.TabIndex = 35;
            this.titleForm.Text = "LOGIN";
            // 
            // inpPassword
            // 
            this.inpPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpPassword.Location = new System.Drawing.Point(111, 134);
            this.inpPassword.Name = "inpPassword";
            this.inpPassword.PlaceholderText = "Ingrese su contraseña";
            this.inpPassword.Size = new System.Drawing.Size(238, 29);
            this.inpPassword.TabIndex = 28;
            this.inpPassword.UseSystemPasswordChar = true;
            // 
            // inpUsuario
            // 
            this.inpUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpUsuario.Location = new System.Drawing.Point(111, 82);
            this.inpUsuario.Name = "inpUsuario";
            this.inpUsuario.PlaceholderText = "Ingrese su Usuario";
            this.inpUsuario.Size = new System.Drawing.Size(238, 29);
            this.inpUsuario.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Usuario:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 363);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label errorNombre;
        private Label errorCi;
        private Button btnLogin;
        private Label titleForm;
        private TextBox inpPassword;
        private TextBox inpUsuario;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}