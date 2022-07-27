using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PROYECTO_FINAL_ARIAS_DANTE.Vistas.Clientes;
using PROYECTO_FINAL_ARIAS_DANTE.Vistas.Peliculas;
using PROYECTO_FINAL_ARIAS_DANTE.Vistas.Ventas;

using PROYECTO_FINAL_ARIAS_DANTE.Controladores;
using PROYECTO_FINAL_ARIAS_DANTE.Modelos;

using System.Windows.Forms;

namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas
{
    public partial class MenuPrincipal : Form
    {
        public static PeliculasDAO ListaPeliculas = new PeliculasDAO();

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            listarPeliculas();

        }

        private void gestionarPeliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPeliculas formPeliculas = new FormPeliculas();

            formPeliculas.Show();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();

            formClientes.Show();
        }

        private void gestionarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();

            formVentas.Show();
        }

        void listarPeliculas()
        {
            flowLayout.Controls.Clear();

            foreach (Pelicula item in ListaPeliculas.getPeliculas())
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(item.Imagen);
                pictureBox.Location = new System.Drawing.Point(16, 13);
                pictureBox.Size = new System.Drawing.Size(300, 400);
                pictureBox.TabStop = false;

                Label label = new Label();
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(16, 420);
                label.Size = new System.Drawing.Size(38, 15);
                label.Text = $"Nombre: {item.Nombre}\nGenero: {item.Genero}\nDuracion: {item.Duracion} min\nFecha Estreno: {item.Estreno}";

                Button button = new Button();
                button.Location = new System.Drawing.Point(16, 490);
                button.Size = new System.Drawing.Size(290, 23);
                button.Text = "Ver Pelicula";
                button.UseVisualStyleBackColor = true;

                Panel panel = new Panel();
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);
                panel.Controls.Add(button);
                panel.Location = new System.Drawing.Point(3, 3);
                panel.Name = "panel1";
                panel.Size = new System.Drawing.Size(350, 550);

                flowLayout.Controls.Add(panel);
            }
        }

        public static void ShowMessage(string body, string title, string type)
        {
            if (type == "warn")
            {
                MessageBox.Show(body, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (type == "error")
            {
                MessageBox.Show(body, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (type == "info")
            {
                MessageBox.Show(body, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
