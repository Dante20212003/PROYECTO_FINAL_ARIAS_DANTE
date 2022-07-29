using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PROYECTO_FINAL_ARIAS_DANTE.Modelos;
using PROYECTO_FINAL_ARIAS_DANTE.Controladores;

namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas
{
    public partial class ViewPelicula : Form
    {
        string cod;
        PeliculasDAO ListaPeliculas;

        public ViewPelicula(string cod, PeliculasDAO ListaPeliculas)
        {
            this.cod = cod;
            this.ListaPeliculas = ListaPeliculas;

            InitializeComponent();
        }

        private void ViewPelicula_Load(object sender, EventArgs e)
        {
            foreach (Pelicula item in ListaPeliculas.getPeliculas())
            {
                if (item.Codigo == cod)
                {
                    pictureBox1.Image = Image.FromFile(item.Imagen);
                    label1.Text = $"\nCodigo: {item.Codigo}\n\nNombre: {item.Nombre}\n\nGenero: {item.Genero}\n\nClasificacion: {item.Clasificacion}\n\nDuracion: {item.Duracion} min\n\nFecha Estreno: {item.Estreno}\n\nDirector: {item.Director}\n\nSinopsis: {item.Sinopsis}";

                    break;
                }
            }
        }
    }
}
