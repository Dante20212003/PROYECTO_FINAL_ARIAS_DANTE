namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas.EmpresaConfig
{
    partial class FormularioConfiguracion
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
            this.errorCiudad = new System.Windows.Forms.Label();
            this.errorPais = new System.Windows.Forms.Label();
            this.comboMoneda = new System.Windows.Forms.ComboBox();
            this.inpPais = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inpCiudad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorDireccion = new System.Windows.Forms.Label();
            this.errorCorreo = new System.Windows.Forms.Label();
            this.errorTelefono = new System.Windows.Forms.Label();
            this.errorMoneda = new System.Windows.Forms.Label();
            this.errorNombre = new System.Windows.Forms.Label();
            this.errorNit = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.titleForm = new System.Windows.Forms.Label();
            this.inpDireccion = new System.Windows.Forms.TextBox();
            this.inpCorreo = new System.Windows.Forms.TextBox();
            this.inpTelefono = new System.Windows.Forms.TextBox();
            this.inpNombre = new System.Windows.Forms.TextBox();
            this.inpNit = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.errorCiudad);
            this.panel1.Controls.Add(this.errorPais);
            this.panel1.Controls.Add(this.comboMoneda);
            this.panel1.Controls.Add(this.inpPais);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.inpCiudad);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.errorDireccion);
            this.panel1.Controls.Add(this.errorCorreo);
            this.panel1.Controls.Add(this.errorTelefono);
            this.panel1.Controls.Add(this.errorMoneda);
            this.panel1.Controls.Add(this.errorNombre);
            this.panel1.Controls.Add(this.errorNit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.titleForm);
            this.panel1.Controls.Add(this.inpDireccion);
            this.panel1.Controls.Add(this.inpCorreo);
            this.panel1.Controls.Add(this.inpTelefono);
            this.panel1.Controls.Add(this.inpNombre);
            this.panel1.Controls.Add(this.inpNit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 657);
            this.panel1.TabIndex = 1;
            // 
            // errorCiudad
            // 
            this.errorCiudad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorCiudad.AutoSize = true;
            this.errorCiudad.ForeColor = System.Drawing.Color.DarkRed;
            this.errorCiudad.Location = new System.Drawing.Point(140, 387);
            this.errorCiudad.Name = "errorCiudad";
            this.errorCiudad.Size = new System.Drawing.Size(0, 15);
            this.errorCiudad.TabIndex = 50;
            // 
            // errorPais
            // 
            this.errorPais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorPais.AutoSize = true;
            this.errorPais.ForeColor = System.Drawing.Color.DarkRed;
            this.errorPais.Location = new System.Drawing.Point(140, 337);
            this.errorPais.Name = "errorPais";
            this.errorPais.Size = new System.Drawing.Size(0, 15);
            this.errorPais.TabIndex = 49;
            // 
            // comboMoneda
            // 
            this.comboMoneda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboMoneda.FormattingEnabled = true;
            this.comboMoneda.Items.AddRange(new object[] {
            "Bs.",
            "$.",
            "€."});
            this.comboMoneda.Location = new System.Drawing.Point(140, 199);
            this.comboMoneda.Name = "comboMoneda";
            this.comboMoneda.Size = new System.Drawing.Size(235, 29);
            this.comboMoneda.TabIndex = 29;
            this.comboMoneda.Text = "--Seleccione una moneda--";
            this.comboMoneda.SelectedIndexChanged += new System.EventHandler(this.comboMoneda_SelectedIndexChanged);
            // 
            // inpPais
            // 
            this.inpPais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpPais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpPais.Location = new System.Drawing.Point(140, 305);
            this.inpPais.Name = "inpPais";
            this.inpPais.PlaceholderText = "Pais de la Empresa";
            this.inpPais.Size = new System.Drawing.Size(238, 29);
            this.inpPais.TabIndex = 31;
            this.inpPais.TextChanged += new System.EventHandler(this.inpPais_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(48, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 46;
            this.label8.Text = "CORREO:";
            // 
            // inpCiudad
            // 
            this.inpCiudad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpCiudad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpCiudad.Location = new System.Drawing.Point(140, 356);
            this.inpCiudad.Name = "inpCiudad";
            this.inpCiudad.PlaceholderText = "Cuidad de la Empresa";
            this.inpCiudad.Size = new System.Drawing.Size(238, 29);
            this.inpCiudad.TabIndex = 32;
            this.inpCiudad.TextChanged += new System.EventHandler(this.inpNitudad_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(34, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 44;
            this.label7.Text = "TELEFONO:";
            // 
            // errorDireccion
            // 
            this.errorDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorDireccion.AutoSize = true;
            this.errorDireccion.ForeColor = System.Drawing.Color.DarkRed;
            this.errorDireccion.Location = new System.Drawing.Point(140, 284);
            this.errorDireccion.Name = "errorDireccion";
            this.errorDireccion.Size = new System.Drawing.Size(0, 15);
            this.errorDireccion.TabIndex = 43;
            // 
            // errorCorreo
            // 
            this.errorCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorCorreo.AutoSize = true;
            this.errorCorreo.ForeColor = System.Drawing.Color.DarkRed;
            this.errorCorreo.Location = new System.Drawing.Point(137, 495);
            this.errorCorreo.Name = "errorCorreo";
            this.errorCorreo.Size = new System.Drawing.Size(0, 15);
            this.errorCorreo.TabIndex = 42;
            // 
            // errorTelefono
            // 
            this.errorTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorTelefono.AutoSize = true;
            this.errorTelefono.ForeColor = System.Drawing.Color.DarkRed;
            this.errorTelefono.Location = new System.Drawing.Point(137, 440);
            this.errorTelefono.Name = "errorTelefono";
            this.errorTelefono.Size = new System.Drawing.Size(0, 15);
            this.errorTelefono.TabIndex = 41;
            // 
            // errorMoneda
            // 
            this.errorMoneda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorMoneda.AutoSize = true;
            this.errorMoneda.ForeColor = System.Drawing.Color.DarkRed;
            this.errorMoneda.Location = new System.Drawing.Point(140, 231);
            this.errorMoneda.Name = "errorMoneda";
            this.errorMoneda.Size = new System.Drawing.Size(0, 15);
            this.errorMoneda.TabIndex = 40;
            // 
            // errorNombre
            // 
            this.errorNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorNombre.AutoSize = true;
            this.errorNombre.ForeColor = System.Drawing.Color.DarkRed;
            this.errorNombre.Location = new System.Drawing.Point(140, 173);
            this.errorNombre.Name = "errorNombre";
            this.errorNombre.Size = new System.Drawing.Size(0, 15);
            this.errorNombre.TabIndex = 39;
            // 
            // errorNit
            // 
            this.errorNit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorNit.AutoSize = true;
            this.errorNit.ForeColor = System.Drawing.Color.DarkRed;
            this.errorNit.Location = new System.Drawing.Point(140, 119);
            this.errorNit.Name = "errorNit";
            this.errorNit.Size = new System.Drawing.Size(0, 15);
            this.errorNit.TabIndex = 38;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.AutoSize = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Image = global::PROYECTO_FINAL_ARIAS_DANTE.Properties.Resources.icons8_save_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(156, 539);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 72);
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
            this.titleForm.Location = new System.Drawing.Point(112, 25);
            this.titleForm.Name = "titleForm";
            this.titleForm.Size = new System.Drawing.Size(224, 32);
            this.titleForm.TabIndex = 35;
            this.titleForm.Text = "Configurar Empresa";
            // 
            // inpDireccion
            // 
            this.inpDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpDireccion.Location = new System.Drawing.Point(140, 252);
            this.inpDireccion.Name = "inpDireccion";
            this.inpDireccion.PlaceholderText = "Direccion de la Empresa";
            this.inpDireccion.Size = new System.Drawing.Size(238, 29);
            this.inpDireccion.TabIndex = 30;
            this.inpDireccion.TextChanged += new System.EventHandler(this.inpDireccion_TextChanged);
            // 
            // inpCorreo
            // 
            this.inpCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpCorreo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpCorreo.Location = new System.Drawing.Point(137, 463);
            this.inpCorreo.Name = "inpCorreo";
            this.inpCorreo.PlaceholderText = "Correo de la Empresa";
            this.inpCorreo.Size = new System.Drawing.Size(238, 29);
            this.inpCorreo.TabIndex = 34;
            this.inpCorreo.TextChanged += new System.EventHandler(this.inpCorreo_TextChanged);
            // 
            // inpTelefono
            // 
            this.inpTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpTelefono.Location = new System.Drawing.Point(137, 408);
            this.inpTelefono.Name = "inpTelefono";
            this.inpTelefono.PlaceholderText = "Telefono de la Empresa";
            this.inpTelefono.Size = new System.Drawing.Size(238, 29);
            this.inpTelefono.TabIndex = 33;
            this.inpTelefono.TextChanged += new System.EventHandler(this.inpTelefono_TextChanged);
            // 
            // inpNombre
            // 
            this.inpNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpNombre.Location = new System.Drawing.Point(137, 141);
            this.inpNombre.Name = "inpNombre";
            this.inpNombre.PlaceholderText = "Nombre de la Empresa";
            this.inpNombre.Size = new System.Drawing.Size(238, 29);
            this.inpNombre.TabIndex = 28;
            this.inpNombre.TextChanged += new System.EventHandler(this.inpNombre_TextChanged);
            // 
            // inpNit
            // 
            this.inpNit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpNit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpNit.Location = new System.Drawing.Point(137, 89);
            this.inpNit.Name = "inpNit";
            this.inpNit.PlaceholderText = "Nit de la Empresa";
            this.inpNit.Size = new System.Drawing.Size(238, 29);
            this.inpNit.TabIndex = 27;
            this.inpNit.TextChanged += new System.EventHandler(this.inpNit_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(53, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "CIUDAD:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(79, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "PAIS:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "DIRECCION:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "MONEDA:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 144);
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
            this.label1.Location = new System.Drawing.Point(86, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "NIT:";
            // 
            // FormularioConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 672);
            this.Controls.Add(this.panel1);
            this.Name = "FormularioConfiguracion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.FormularioConfiguracion_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label errorDireccion;
        private Label errorCorreo;
        private Label errorTelefono;
        private Label errorMoneda;
        private Label errorNombre;
        private Label errorNit;
        private Button btnSave;
        private Label titleForm;
        private TextBox inpDireccion;
        private TextBox inpCorreo;
        private TextBox inpTelefono;
        private TextBox inpNombre;
        private TextBox inpNit;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox inpPais;
        private Label label8;
        private TextBox inpCiudad;
        private Label label7;
        private ComboBox comboMoneda;
        private Label errorCiudad;
        private Label errorPais;
    }
}