namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas.Ventas
{
    partial class FormVentas
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
            this.btnVer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridVentas = new System.Windows.Forms.DataGridView();
            this.IDVENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PELICULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOLETOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_BOLETO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inpBuscar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnVer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridVentas);
            this.panel1.Controls.Add(this.inpBuscar);
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 692);
            this.panel1.TabIndex = 3;
            // 
            // btnVer
            // 
            this.btnVer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVer.BackColor = System.Drawing.Color.Transparent;
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVer.Image = global::PROYECTO_FINAL_ARIAS_DANTE.Properties.Resources.icons8_eye_48;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.Location = new System.Drawing.Point(562, 613);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(197, 59);
            this.btnVer.TabIndex = 12;
            this.btnVer.Text = "VER";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(547, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 46);
            this.label2.TabIndex = 11;
            this.label2.Text = "LISTA DE VENTAS";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Image = global::PROYECTO_FINAL_ARIAS_DANTE.Properties.Resources.icons8_delete_48;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(815, 613);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(171, 59);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Image = global::PROYECTO_FINAL_ARIAS_DANTE.Properties.Resources.icons8_buy_48;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(315, 613);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(197, 59);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "NUEVA VENTA";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1933, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTA DE PELICULAS";
            // 
            // dataGridVentas
            // 
            this.dataGridVentas.AllowDrop = true;
            this.dataGridVentas.AllowUserToAddRows = false;
            this.dataGridVentas.AllowUserToDeleteRows = false;
            this.dataGridVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVentas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDVENTA,
            this.PELICULA,
            this.CLIENTE,
            this.FACTURA,
            this.Nit,
            this.BOLETOS,
            this.PRECIO_BOLETO,
            this.TOTAL,
            this.FECHA});
            this.dataGridVentas.Location = new System.Drawing.Point(3, 86);
            this.dataGridVentas.Name = "dataGridVentas";
            this.dataGridVentas.ReadOnly = true;
            this.dataGridVentas.RowTemplate.Height = 25;
            this.dataGridVentas.Size = new System.Drawing.Size(1343, 505);
            this.dataGridVentas.TabIndex = 1;
            // 
            // IDVENTA
            // 
            this.IDVENTA.FillWeight = 73.09644F;
            this.IDVENTA.HeaderText = "ID_VENTA";
            this.IDVENTA.Name = "IDVENTA";
            this.IDVENTA.ReadOnly = true;
            // 
            // PELICULA
            // 
            this.PELICULA.FillWeight = 103.3629F;
            this.PELICULA.HeaderText = "PELICULA";
            this.PELICULA.Name = "PELICULA";
            this.PELICULA.ReadOnly = true;
            // 
            // CLIENTE
            // 
            this.CLIENTE.FillWeight = 103.3629F;
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            // 
            // FACTURA
            // 
            this.FACTURA.FillWeight = 103.3629F;
            this.FACTURA.HeaderText = "FACTURA";
            this.FACTURA.Name = "FACTURA";
            this.FACTURA.ReadOnly = true;
            // 
            // Nit
            // 
            this.Nit.FillWeight = 103.3629F;
            this.Nit.HeaderText = "NIT";
            this.Nit.Name = "Nit";
            this.Nit.ReadOnly = true;
            // 
            // BOLETOS
            // 
            this.BOLETOS.FillWeight = 103.3629F;
            this.BOLETOS.HeaderText = "BOLETOS";
            this.BOLETOS.Name = "BOLETOS";
            this.BOLETOS.ReadOnly = true;
            // 
            // PRECIO_BOLETO
            // 
            this.PRECIO_BOLETO.FillWeight = 103.3629F;
            this.PRECIO_BOLETO.HeaderText = "PRECIO BOLETO";
            this.PRECIO_BOLETO.Name = "PRECIO_BOLETO";
            this.PRECIO_BOLETO.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.FillWeight = 103.3629F;
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // FECHA
            // 
            this.FECHA.FillWeight = 103.3629F;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // inpBuscar
            // 
            this.inpBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inpBuscar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpBuscar.Location = new System.Drawing.Point(1074, 42);
            this.inpBuscar.Name = "inpBuscar";
            this.inpBuscar.PlaceholderText = "Buscar por ID....";
            this.inpBuscar.Size = new System.Drawing.Size(269, 31);
            this.inpBuscar.TabIndex = 3;
            this.inpBuscar.TextChanged += new System.EventHandler(this.inpBuscar_TextChanged);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1358, 704);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(750, 400);
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridVentas;
        private Button btnEliminar;
        private Button btnAgregar;
        private TextBox inpBuscar;
        private Label label2;
        private DataGridViewTextBoxColumn IDVENTA;
        private DataGridViewTextBoxColumn PELICULA;
        private DataGridViewTextBoxColumn CLIENTE;
        private DataGridViewTextBoxColumn FACTURA;
        private DataGridViewTextBoxColumn Nit;
        private DataGridViewTextBoxColumn BOLETOS;
        private DataGridViewTextBoxColumn PRECIO_BOLETO;
        private DataGridViewTextBoxColumn TOTAL;
        private DataGridViewTextBoxColumn FECHA;
        private Button btnVer;
    }
}