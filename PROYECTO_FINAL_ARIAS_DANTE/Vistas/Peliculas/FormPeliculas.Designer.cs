namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas.Peliculas
{
    partial class FormPeliculas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.inpBuscar = new System.Windows.Forms.TextBox();
            this.dataGridPeliculas = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTRENO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SINOPSIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGEN = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.inpBuscar);
            this.panel1.Controls.Add(this.dataGridPeliculas);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1331, 680);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(509, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "LISTA DE PELICULAS";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Image = global::PROYECTO_FINAL_ARIAS_DANTE.Properties.Resources.icons8_delete_48;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(828, 602);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(171, 59);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Image = global::PROYECTO_FINAL_ARIAS_DANTE.Properties.Resources.icons8_edit_48;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(592, 602);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(171, 59);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Image = global::PROYECTO_FINAL_ARIAS_DANTE.Properties.Resources.icons8_add_48;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(354, 602);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 59);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // inpBuscar
            // 
            this.inpBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inpBuscar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpBuscar.Location = new System.Drawing.Point(1058, 47);
            this.inpBuscar.Name = "inpBuscar";
            this.inpBuscar.PlaceholderText = "Buscar por Nombre...";
            this.inpBuscar.Size = new System.Drawing.Size(269, 31);
            this.inpBuscar.TabIndex = 3;
            this.inpBuscar.TextChanged += new System.EventHandler(this.inpBuscar_TextChanged);
            // 
            // dataGridPeliculas
            // 
            this.dataGridPeliculas.AllowDrop = true;
            this.dataGridPeliculas.AllowUserToAddRows = false;
            this.dataGridPeliculas.AllowUserToDeleteRows = false;
            this.dataGridPeliculas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPeliculas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPeliculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOMBRE,
            this.GENERO,
            this.CLASIFICACION,
            this.DURACION,
            this.ESTRENO,
            this.DIRECTOR,
            this.SINOPSIS,
            this.IMAGEN});
            this.dataGridPeliculas.Location = new System.Drawing.Point(3, 97);
            this.dataGridPeliculas.Name = "dataGridPeliculas";
            this.dataGridPeliculas.ReadOnly = true;
            this.dataGridPeliculas.RowTemplate.Height = 100;
            this.dataGridPeliculas.Size = new System.Drawing.Size(1325, 488);
            this.dataGridPeliculas.TabIndex = 1;
            // 
            // CODIGO
            // 
            this.CODIGO.FillWeight = 73.38409F;
            this.CODIGO.HeaderText = "CÓDIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.FillWeight = 111.2992F;
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // GENERO
            // 
            this.GENERO.FillWeight = 111.2992F;
            this.GENERO.HeaderText = "GENERO";
            this.GENERO.Name = "GENERO";
            this.GENERO.ReadOnly = true;
            // 
            // CLASIFICACION
            // 
            this.CLASIFICACION.FillWeight = 111.2992F;
            this.CLASIFICACION.HeaderText = "CLASIFICACIÓN";
            this.CLASIFICACION.Name = "CLASIFICACION";
            this.CLASIFICACION.ReadOnly = true;
            this.CLASIFICACION.ToolTipText = "awd";
            // 
            // DURACION
            // 
            this.DURACION.FillWeight = 85.72412F;
            this.DURACION.HeaderText = "DURACIÓN";
            this.DURACION.Name = "DURACION";
            this.DURACION.ReadOnly = true;
            // 
            // ESTRENO
            // 
            this.ESTRENO.FillWeight = 73.09645F;
            this.ESTRENO.HeaderText = "ESTRENO";
            this.ESTRENO.Name = "ESTRENO";
            this.ESTRENO.ReadOnly = true;
            // 
            // DIRECTOR
            // 
            this.DIRECTOR.FillWeight = 111.2992F;
            this.DIRECTOR.HeaderText = "DIRECTOR";
            this.DIRECTOR.Name = "DIRECTOR";
            this.DIRECTOR.ReadOnly = true;
            // 
            // SINOPSIS
            // 
            this.SINOPSIS.FillWeight = 111.2992F;
            this.SINOPSIS.HeaderText = "SINOPSIS";
            this.SINOPSIS.Name = "SINOPSIS";
            this.SINOPSIS.ReadOnly = true;
            // 
            // IMAGEN
            // 
            this.IMAGEN.FillWeight = 111.2992F;
            this.IMAGEN.HeaderText = "IMAGEN";
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.ReadOnly = true;
            this.IMAGEN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IMAGEN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1358, 704);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(750, 360);
            this.Name = "FormPeliculas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peliculas";
            this.Load += new System.EventHandler(this.FormPeliculas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeliculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridPeliculas;
        private TextBox inpBuscar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private Label label1;
        private DataGridViewTextBoxColumn CODIGO;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn GENERO;
        private DataGridViewTextBoxColumn CLASIFICACION;
        private DataGridViewTextBoxColumn DURACION;
        private DataGridViewTextBoxColumn ESTRENO;
        private DataGridViewTextBoxColumn DIRECTOR;
        private DataGridViewTextBoxColumn SINOPSIS;
        private DataGridViewImageColumn IMAGEN;
    }
}