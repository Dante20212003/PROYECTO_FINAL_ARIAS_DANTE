namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas.Clientes
{
    partial class FormularioCliente
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
            this.radioMujer = new System.Windows.Forms.RadioButton();
            this.radioHombre = new System.Windows.Forms.RadioButton();
            this.titleFormUpdate = new System.Windows.Forms.Label();
            this.errorDireccion = new System.Windows.Forms.Label();
            this.errorCorreo = new System.Windows.Forms.Label();
            this.errorTelefono = new System.Windows.Forms.Label();
            this.errorEdad = new System.Windows.Forms.Label();
            this.errorNombre = new System.Windows.Forms.Label();
            this.errorCi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.titleForm = new System.Windows.Forms.Label();
            this.inpDireccion = new System.Windows.Forms.TextBox();
            this.inpCorreo = new System.Windows.Forms.TextBox();
            this.inpTelefono = new System.Windows.Forms.TextBox();
            this.inpEdad = new System.Windows.Forms.TextBox();
            this.inpNombre = new System.Windows.Forms.TextBox();
            this.inpCi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.radioMujer);
            this.panel1.Controls.Add(this.radioHombre);
            this.panel1.Controls.Add(this.titleFormUpdate);
            this.panel1.Controls.Add(this.errorDireccion);
            this.panel1.Controls.Add(this.errorCorreo);
            this.panel1.Controls.Add(this.errorTelefono);
            this.panel1.Controls.Add(this.errorEdad);
            this.panel1.Controls.Add(this.errorNombre);
            this.panel1.Controls.Add(this.errorCi);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.titleForm);
            this.panel1.Controls.Add(this.inpDireccion);
            this.panel1.Controls.Add(this.inpCorreo);
            this.panel1.Controls.Add(this.inpTelefono);
            this.panel1.Controls.Add(this.inpEdad);
            this.panel1.Controls.Add(this.inpNombre);
            this.panel1.Controls.Add(this.inpCi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 595);
            this.panel1.TabIndex = 0;
            // 
            // radioMujer
            // 
            this.radioMujer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioMujer.AutoSize = true;
            this.radioMujer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioMujer.Location = new System.Drawing.Point(239, 418);
            this.radioMujer.Name = "radioMujer";
            this.radioMujer.Size = new System.Drawing.Size(69, 25);
            this.radioMujer.TabIndex = 37;
            this.radioMujer.Text = "Mujer";
            this.radioMujer.UseVisualStyleBackColor = true;
            // 
            // radioHombre
            // 
            this.radioHombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioHombre.AutoSize = true;
            this.radioHombre.Checked = true;
            this.radioHombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioHombre.Location = new System.Drawing.Point(80, 418);
            this.radioHombre.Name = "radioHombre";
            this.radioHombre.Size = new System.Drawing.Size(85, 25);
            this.radioHombre.TabIndex = 36;
            this.radioHombre.TabStop = true;
            this.radioHombre.Text = "Hombre";
            this.radioHombre.UseVisualStyleBackColor = true;
            // 
            // titleFormUpdate
            // 
            this.titleFormUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleFormUpdate.AutoSize = true;
            this.titleFormUpdate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleFormUpdate.Location = new System.Drawing.Point(93, 23);
            this.titleFormUpdate.Name = "titleFormUpdate";
            this.titleFormUpdate.Size = new System.Drawing.Size(241, 32);
            this.titleFormUpdate.TabIndex = 44;
            this.titleFormUpdate.Text = "ACTUALIZAR CLIENTE";
            this.titleFormUpdate.Visible = false;
            // 
            // errorDireccion
            // 
            this.errorDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorDireccion.AutoSize = true;
            this.errorDireccion.ForeColor = System.Drawing.Color.DarkRed;
            this.errorDireccion.Location = new System.Drawing.Point(134, 381);
            this.errorDireccion.Name = "errorDireccion";
            this.errorDireccion.Size = new System.Drawing.Size(0, 15);
            this.errorDireccion.TabIndex = 43;
            // 
            // errorCorreo
            // 
            this.errorCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorCorreo.AutoSize = true;
            this.errorCorreo.ForeColor = System.Drawing.Color.DarkRed;
            this.errorCorreo.Location = new System.Drawing.Point(134, 330);
            this.errorCorreo.Name = "errorCorreo";
            this.errorCorreo.Size = new System.Drawing.Size(0, 15);
            this.errorCorreo.TabIndex = 42;
            // 
            // errorTelefono
            // 
            this.errorTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorTelefono.AutoSize = true;
            this.errorTelefono.ForeColor = System.Drawing.Color.DarkRed;
            this.errorTelefono.Location = new System.Drawing.Point(134, 274);
            this.errorTelefono.Name = "errorTelefono";
            this.errorTelefono.Size = new System.Drawing.Size(0, 15);
            this.errorTelefono.TabIndex = 41;
            // 
            // errorEdad
            // 
            this.errorEdad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorEdad.AutoSize = true;
            this.errorEdad.ForeColor = System.Drawing.Color.DarkRed;
            this.errorEdad.Location = new System.Drawing.Point(134, 223);
            this.errorEdad.Name = "errorEdad";
            this.errorEdad.Size = new System.Drawing.Size(0, 15);
            this.errorEdad.TabIndex = 40;
            // 
            // errorNombre
            // 
            this.errorNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorNombre.AutoSize = true;
            this.errorNombre.ForeColor = System.Drawing.Color.DarkRed;
            this.errorNombre.Location = new System.Drawing.Point(134, 170);
            this.errorNombre.Name = "errorNombre";
            this.errorNombre.Size = new System.Drawing.Size(0, 15);
            this.errorNombre.TabIndex = 39;
            // 
            // errorCi
            // 
            this.errorCi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorCi.AutoSize = true;
            this.errorCi.ForeColor = System.Drawing.Color.DarkRed;
            this.errorCi.Location = new System.Drawing.Point(134, 116);
            this.errorCi.Name = "errorCi";
            this.errorCi.Size = new System.Drawing.Size(0, 15);
            this.errorCi.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::PROYECTO_FINAL_ARIAS_DANTE.Properties.Resources.icons8_cancel_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(239, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 72);
            this.button1.TabIndex = 39;
            this.button1.Text = "CANCELAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.AutoSize = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Image = global::PROYECTO_FINAL_ARIAS_DANTE.Properties.Resources.icons8_save_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(54, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 72);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "GUARDAR";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // titleForm
            // 
            this.titleForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleForm.AutoSize = true;
            this.titleForm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleForm.Location = new System.Drawing.Point(131, 23);
            this.titleForm.Name = "titleForm";
            this.titleForm.Size = new System.Drawing.Size(178, 32);
            this.titleForm.TabIndex = 35;
            this.titleForm.Text = "CREAR CLIENTE";
            // 
            // inpDireccion
            // 
            this.inpDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpDireccion.Location = new System.Drawing.Point(131, 349);
            this.inpDireccion.Name = "inpDireccion";
            this.inpDireccion.PlaceholderText = "Direccion del Cliente";
            this.inpDireccion.Size = new System.Drawing.Size(238, 29);
            this.inpDireccion.TabIndex = 32;
            this.inpDireccion.TextChanged += new System.EventHandler(this.inpDireccion_TextChanged);
            // 
            // inpCorreo
            // 
            this.inpCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpCorreo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpCorreo.Location = new System.Drawing.Point(131, 298);
            this.inpCorreo.Name = "inpCorreo";
            this.inpCorreo.PlaceholderText = "Correo del Cliente";
            this.inpCorreo.Size = new System.Drawing.Size(238, 29);
            this.inpCorreo.TabIndex = 31;
            this.inpCorreo.TextChanged += new System.EventHandler(this.inpCorreo_TextChanged);
            // 
            // inpTelefono
            // 
            this.inpTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpTelefono.Location = new System.Drawing.Point(131, 243);
            this.inpTelefono.Name = "inpTelefono";
            this.inpTelefono.PlaceholderText = "Telefono del Cliente";
            this.inpTelefono.Size = new System.Drawing.Size(238, 29);
            this.inpTelefono.TabIndex = 30;
            this.inpTelefono.TextChanged += new System.EventHandler(this.inpTelefono_TextChanged);
            // 
            // inpEdad
            // 
            this.inpEdad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpEdad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpEdad.Location = new System.Drawing.Point(131, 191);
            this.inpEdad.Name = "inpEdad";
            this.inpEdad.PlaceholderText = "Edad del Cliente";
            this.inpEdad.Size = new System.Drawing.Size(238, 29);
            this.inpEdad.TabIndex = 29;
            this.inpEdad.TextChanged += new System.EventHandler(this.inpEdad_TextChanged);
            // 
            // inpNombre
            // 
            this.inpNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpNombre.Location = new System.Drawing.Point(131, 138);
            this.inpNombre.Name = "inpNombre";
            this.inpNombre.PlaceholderText = "Nombre del Cliente";
            this.inpNombre.Size = new System.Drawing.Size(238, 29);
            this.inpNombre.TabIndex = 28;
            this.inpNombre.TextChanged += new System.EventHandler(this.inpNombre_TextChanged);
            // 
            // inpCi
            // 
            this.inpCi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpCi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpCi.Location = new System.Drawing.Point(131, 86);
            this.inpCi.Name = "inpCi";
            this.inpCi.PlaceholderText = "Ci del Cliente";
            this.inpCi.Size = new System.Drawing.Size(238, 29);
            this.inpCi.TabIndex = 27;
            this.inpCi.TextChanged += new System.EventHandler(this.inpCi_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "DIRECCION:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(32, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "CORREO:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "TELEFONO:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "EDAD:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "CI:";
            // 
            // FormularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 619);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "FormularioCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulario Cliente";
            this.Load += new System.EventHandler(this.FormularioCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button btnSave;
        private Label titleForm;
        private TextBox inpDireccion;
        private TextBox inpCorreo;
        private TextBox inpTelefono;
        private TextBox inpEdad;
        private TextBox inpNombre;
        private TextBox inpCi;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label errorNombre;
        private Label errorCi;
        private Label errorDireccion;
        private Label errorCorreo;
        private Label errorTelefono;
        private Label errorEdad;
        private Label titleFormUpdate;
        private RadioButton radioMujer;
        private RadioButton radioHombre;
    }
}