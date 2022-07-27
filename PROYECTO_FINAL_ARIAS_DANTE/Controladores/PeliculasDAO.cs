using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PROYECTO_FINAL_ARIAS_DANTE.Modelos;
using PROYECTO_FINAL_ARIAS_DANTE.Vistas;

namespace PROYECTO_FINAL_ARIAS_DANTE.Controladores
{
    public class PeliculasDAO
    {
        private static List<Pelicula> ListaPeliculas = new List<Pelicula>();
        public static string rutaDbPeliculas = "E:\\Peliculas.txt";

        public PeliculasDAO()
        {
            cargarTxt();
        }

        public void agregar(Pelicula pelicula)
        {
            ListaPeliculas.Add(pelicula);
            agregarTxt(pelicula);

        }

        public void editar(Pelicula pelicula, Pelicula data)
        {
            ListaPeliculas[ListaPeliculas.IndexOf(pelicula)] = data;

            reloadTxt();
        }

        public void eliminar(Pelicula pelicula)
        {
            ListaPeliculas.Remove(pelicula);
        }

        public Pelicula getPeliculas(string ci)
        {
            return ListaPeliculas.FirstOrDefault(x => x.Codigo == ci);
        }

        public List<Pelicula> getPeliculas()
        {
            return ListaPeliculas;
        }

        void agregarTxt(Pelicula pelicula)
        {
            StreamWriter agregar = File.AppendText(rutaDbPeliculas);

            agregar.WriteLine($"{pelicula.Codigo}|{pelicula.Nombre}|{pelicula.Genero}|{pelicula.Clasificacion}|{pelicula.Duracion}|{pelicula.Estreno}|{pelicula.Director}|{pelicula.Sinopsis}|{pelicula.Imagen}");

            agregar.Close();
        }

        public void cargarTxt()
        {
            try
            {
                StreamReader archivo = new StreamReader(rutaDbPeliculas);
                string linea;
                string[] data;

                while ((linea = archivo.ReadLine()) != null)
                {
                    data = linea.Split('|');

                    Pelicula pelicula = new Pelicula();
                    pelicula.Codigo = data[0];
                    pelicula.Nombre = data[1];
                    pelicula.Genero = data[2];
                    pelicula.Clasificacion = data[3];
                    pelicula.Duracion = int.Parse(data[4]);
                    pelicula.Estreno = data[5];
                    pelicula.Director = data[6];
                    pelicula.Sinopsis = data[7];
                    pelicula.Imagen = data[8];

                    ListaPeliculas.Add(pelicula);
                }

                archivo.Close();
            }
            catch (Exception e)
            {
                MenuPrincipal.ShowMessage($"PROBLEMAS CON LA BASE DE DATOS.\n\n{e.Message}", "Error", "error");
            }
        }

        public void reloadTxt()
        {
            TextWriter archivo = new StreamWriter(rutaDbPeliculas);

            foreach (Pelicula item in ListaPeliculas)
            {
                archivo.WriteLine($"{item.Codigo}|{item.Nombre}|{item.Genero}|{item.Clasificacion}|{item.Duracion}|{item.Estreno}|{item.Director}|{item.Sinopsis}|{item.Imagen}");
            }

            archivo.Close();
        }
    }
}
