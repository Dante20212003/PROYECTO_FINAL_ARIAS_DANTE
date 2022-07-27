using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PROYECTO_FINAL_ARIAS_DANTE.Controladores;
using PROYECTO_FINAL_ARIAS_DANTE.Modelos;

namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas.Peliculas
{
    public partial class FormPeliculas : Form
    {
        public static PeliculasDAO ListaPeliculas = new PeliculasDAO();

        public FormPeliculas()
        {
            InitializeComponent();
        }

        private void FormPeliculas_Load(object sender, EventArgs e)
        {
            listarPeliculas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormularioPelicula fr = new FormularioPelicula();

            if (fr.ShowDialog() == DialogResult.OK) listarPeliculas();
          
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridPeliculas.RowCount > 0)
            {
                string codSelect = dataGridPeliculas.CurrentRow.Cells[0].Value.ToString();

                FormularioPelicula fr = new FormularioPelicula(codSelect);

                if (fr.ShowDialog() == DialogResult.OK) listarPeliculas();
            }
            else
            {
                MenuPrincipal.ShowMessage("Seleccione una pelicula para editar", "Alerta", "warn");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridPeliculas.RowCount > 0)
            {
                string codSelected = dataGridPeliculas.CurrentRow.Cells[0].Value.ToString();

                DialogResult dialogo = MessageBox.Show($"Esta seguro de eliminar la pelicula con CODIGO: {codSelected}?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogo == DialogResult.Yes)
                {
                    foreach (Pelicula item in ListaPeliculas.getPeliculas())
                    {
                        if (item.Codigo == codSelected)
                        {
                            ListaPeliculas.eliminar(item);
                            break;
                        }
                    }

                    ListaPeliculas.reloadTxt();
                    listarPeliculas();
                }
            }
            else
            {
                MenuPrincipal.ShowMessage("Seleccione un producto para editar", "Alerta", "warn");
            }
        }

        private void inpBuscar_TextChanged(object sender, EventArgs e)
        {
            var resultados = ListaPeliculas.getPeliculas().Where(pelicula => pelicula.Nombre.ToLower().Contains(inpBuscar.Text.ToLower()));


            dataGridPeliculas.Rows.Clear();

            foreach (Pelicula item in resultados)
            {
                dataGridPeliculas.Rows.Add(item.Codigo,
                                       item.Nombre,
                                       item.Genero,
                                       item.Clasificacion,
                                       item.Duracion + " min",
                                       item.Estreno,
                                       item.Director,
                                       item.Sinopsis,
                                       Image.FromFile(item.Imagen));
            }
        }

        void listarPeliculas()
        {
            dataGridPeliculas.Rows.Clear();

            foreach (Pelicula item in ListaPeliculas.getPeliculas())
            {
                dataGridPeliculas.Rows.Add(item.Codigo,
                                       item.Nombre,
                                       item.Genero,
                                       item.Clasificacion,
                                       item.Duracion + " min",
                                       item.Estreno,
                                       item.Director,
                                       item.Sinopsis,
                                       Image.FromFile(item.Imagen));
            }
        }
    }
}
