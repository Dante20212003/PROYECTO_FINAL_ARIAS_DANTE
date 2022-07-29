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
        public static string rutaDbPeliculas = MenuPrincipal.rutaDBPeliculas;

        public PeliculasDAO()
        {
            ListaPeliculas.Clear();
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

        public Pelicula getPelicula(string nombre)
        {
            return ListaPeliculas.FirstOrDefault(x => x.Nombre == nombre);
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

        public void rellenar()
        {
            string ruta_base = AppDomain.CurrentDomain.BaseDirectory + "img\\";

            Pelicula pelicula = new Pelicula();
            pelicula.Codigo = "599294";
            pelicula.Nombre = "The Batman";
            pelicula.Genero = "Accion, Thriller";
            pelicula.Clasificacion = "12+";
            pelicula.Duracion = 175;
            pelicula.Estreno = "16/07/2022";
            pelicula.Director = "Warner Bros., DC Entertainment, 6th & Idaho Productions";
            pelicula.Sinopsis = "Después de dos años acechando por las calles de la ciudad como Batman (Robert Pattinson), e infundiendo miedo en las mentes perversas de los criminales, Bruce Wayne está sumido en las profundidades de las sombras de Gotham City. Este vigilante solitario cuenta con pocos aliados de confianza y eso le ha llevado a convertirse en la única encarnación de la venganza entre sus conciudadanos. Cuando un asesino apunta a la élite de Gotham con una serie de maquinaciones sádicas, un rastro de pistas crípticas lleva a Batman a realizar una investigación en el inframundo.";
            pelicula.Imagen = $"{ruta_base}batman.jpg";
            agregar(pelicula);

            Pelicula pelicula2 = new Pelicula();
            pelicula2.Codigo = "499281";
            pelicula2.Nombre = "Space Jam";
            pelicula2.Genero = "Animacion, Infantil, Comedia";
            pelicula2.Clasificacion = "Todo Publico";
            pelicula2.Duracion = 120;
            pelicula2.Estreno = "12/07/2021";
            pelicula2.Director = "Warner Bros, Spring Hill Productions";
            pelicula2.Sinopsis = "La superestrella de la NBA, LeBron James, se une a Bugs Bunny y al resto de los Looney Tunes en esta esperada secuela.";
            pelicula2.Imagen = $"{ruta_base}space.jpg";
            agregar(pelicula2);

            Pelicula pelicula3 = new Pelicula();
            pelicula3.Codigo = "839912";
            pelicula3.Nombre = "Scream";
            pelicula3.Genero = "Terror, Thriller, Intriga";
            pelicula3.Clasificacion = "15+";
            pelicula3.Duracion = 112;
            pelicula3.Estreno = "06/02/2021";
            pelicula3.Director = "Spyglass Media Group";
            pelicula3.Sinopsis = "Veinticinco años después de que una serie de brutales asesinatos conmocionara al tranquilo pueblo de Woodsboro, un nuevo asesino se ha puesto la máscara de Ghostface y comienza a perseguir a un grupo de adolescentes para resucitar los secretos del mortífero pasado del pueblo.";
            pelicula3.Imagen = $"{ruta_base}scream.jpg";
            agregar(pelicula3);

            Pelicula pelicula4 = new Pelicula();
            pelicula4.Codigo = "7388124";
            pelicula4.Nombre = "Bohemian Rapsody";
            pelicula4.Genero = "Drama, Biográfico, Música, Años 70, Años 80";
            pelicula4.Clasificacion = "15+";
            pelicula4.Duracion = 134;
            pelicula4.Estreno = "12/01/2018";
            pelicula4.Director = "Coproducción Reino Unido-Estados Unidos, 20th Century Fox";
            pelicula4.Sinopsis = "'Bohemian Rhapsody' es una celebración del grupo Queen, de su música y de su singular cantante Freddie Mercury, que desafió estereotipos para convertirse en uno de los showmans más queridos del mundo. El film plasma el meteórico ascenso de la banda al olimpo de la música a través de sus icónicas canciones y su revolucionario sonido, su crisis cuando el estilo de vida de Mercury estuvo fuera de control, y su triunfal reunión en la víspera del Live Aid, en la que Mercury, mientras sufría una enfermedad que amenazaba su vida, lidera a la banda en uno de los conciertos de rock más grandes de la historia. Refleja asimismo cómo se cimentó el legado de una banda que siempre se pareció más a una familia, y que continúa inspirando soñadores y amantes de la música hasta nuestros días.";
            pelicula4.Imagen = $"{ruta_base}queen.jpg";
            agregar(pelicula4);

            Pelicula pelicula5 = new Pelicula();
            pelicula5.Codigo = "524424";
            pelicula5.Nombre = "Peaky Blinders";
            pelicula5.Genero = "Serie de TV. Drama. Thriller";
            pelicula5.Clasificacion = "15+";
            pelicula5.Duracion = 60;
            pelicula5.Estreno = "24/10/2022";
            pelicula5.Director = "BBC, Caryn Mandabach Productions";
            pelicula5.Sinopsis = "Serie de TV (2013-2022). 6 temporadas. 36 episodios. Una familia de gánsters asentada en Birmingham tras la Primera Guerra Mundial (1914-1918), dirige un local de apuestas hípicas. Las actividades del ambicioso jefe de la banda llaman la atención del Inspector jefe Chester Campbell, un detective de la Real Policía Irlandesa que es enviado desde Belfast para limpiar la ciudad y acabar con la banda.";
            pelicula5.Imagen = $"{ruta_base}peanky.jpg";
            agregar(pelicula5);

            Pelicula pelicula6 = new Pelicula();
            pelicula6.Codigo = "953882";
            pelicula6.Nombre = "Mia Wallace";
            pelicula6.Genero = "Crimen, Suspenso";
            pelicula6.Clasificacion = "18+";
            pelicula6.Duracion = 120;
            pelicula6.Estreno = "12/09/2012";
            pelicula6.Director = "Quentin Tarantino Roger Avary";
            pelicula6.Sinopsis = "Mia Wallace es un personaje ficticio interpretado por Uma Thurman en la película de Quentin Tarantino de 1994 Pulp Fiction. Fue el papel revelación de Thurman y le valió una nominación al Premio de la Academia a la Mejor Actriz de Reparto. El personaje se convirtió en un icono cultural.Mia fue el personaje destacado del material promocional de la película, apareciendo en una cama con un cigarrillo en la mano.";
            pelicula6.Imagen = $"{ruta_base}MiaWallace.jpg";
            agregar(pelicula6);

            Pelicula pelicula7 = new Pelicula();
            pelicula7.Codigo = "388412";
            pelicula7.Nombre = "Jurasic World";
            pelicula7.Genero = "Ciencia ficción. Acción. Fantástico. Aventuras";
            pelicula7.Clasificacion = "Todo Publico";
            pelicula7.Duracion = 146;
            pelicula7.Estreno = "15/12/2022";
            pelicula7.Director = "Amblin Entertainment, Universal Pictures";
            pelicula7.Sinopsis = "Cuatro años después de la destrucción de Isla Nublar, los dinosaurios ahora conviven -y cazan- con los seres humanos en todo el mundo. Este frágil equilibrio remodelará el futuro y determinará, de una vez por todas, si los seres humanos seguirán en la cúspide de los depredadores en un planeta que comparten con los animales más temibles de la creación.";
            pelicula7.Imagen = $"{ruta_base}jurassic.jpg";
            agregar(pelicula7);

            Pelicula pelicula8 = new Pelicula();
            pelicula8.Codigo = "4124494";
            pelicula8.Nombre = "Jaws";
            pelicula8.Genero = "Terror, Drama";
            pelicula8.Clasificacion = "15+";
            pelicula8.Duracion = 114;
            pelicula8.Estreno = "09/02/2000";
            pelicula8.Director = "";
            pelicula8.Sinopsis = "En la costa de un pequeño pueblo del Este de los Estados Unidos, un enorme tiburón ataca a varias personas. Por temor a los nefastos efectos que este hecho podría tener sobre el negocio turístico, el alcalde se niega a cerrar las playas y a difundir la noticia. Pero un nuevo ataque del tiburón termina con la vida de un bañista. Cuando el terror se apodera de todos, un veterano cazador de tiburones, un oceanógrafo y el jefe de la policía local se unen para intentar capturar al escualo.";
            pelicula8.Imagen = $"{ruta_base}jaws.jpg";
            agregar(pelicula8);

            Pelicula pelicula9 = new Pelicula();
            pelicula9.Codigo = "123884";
            pelicula9.Nombre = "Harry Potter";
            pelicula9.Genero = "Fantástico, Aventuras, Drama";
            pelicula9.Clasificacion = "12+";
            pelicula9.Duracion = 112;
            pelicula9.Estreno = "20/05/2011";
            pelicula9.Director = "Warner Bros";
            pelicula9.Sinopsis = "El final ha llegado. Harry, Hermione y Ron tendrán que recuperar la espada de Gryffindor para encontrar y destruir los últimos horrocruxes. Mientras tanto, Lord Voldemort está a punto de apoderarse por completo de Hogwarts y de conseguir su objetivo: matar a Harry Potter. La única esperanza de Harry es encontrar los horrocruxes antes de que Voldemort lo encuentre a él. Buscando pistas, descubre una antigua y olvidada historia: la leyenda de las reliquias de la muerte, que podría dar al malvado Lord el poder definitivo. Pero el futuro de Harry está escrito desde que nació e incluye una misión para la que se ha estado preparando desde que llegó a Hogwarts: la batalla final contra Voldemort.";
            pelicula9.Imagen = $"{ruta_base}harry2.jpg";
            agregar(pelicula9);

            Pelicula pelicula10 = new Pelicula();
            pelicula10.Codigo = "420001";
            pelicula10.Nombre = "Batman Vs Superman";
            pelicula10.Genero = "Fantástico, Aventuras, Drama";
            pelicula10.Clasificacion = "12+";
            pelicula10.Duracion = 154;
            pelicula10.Estreno = "15/10/2016";
            pelicula10.Director = "Warner Bros, DC Entertainment";
            pelicula10.Sinopsis = "Ante el temor de las acciones que pueda llevar a cabo Superman, el vigilante de Gotham City aparece para poner a raya al superhéroe de Metrópolis, mientras que la opinión pública debate cuál es realmente el héroe que necesitan. El hombre de acero y Batman se sumergen en una contienda territorial, pero las cosas se complican cuando una nueva y peligrosa amenaza surge rápidamente, poniendo en jaque la existencia de la humanidad.";
            pelicula10.Imagen = $"{ruta_base}batvsup.jpg";
            agregar(pelicula10);

            Pelicula pelicula11 = new Pelicula();
            pelicula11.Codigo = "582894";
            pelicula11.Nombre = "Cazafantasmas";
            pelicula11.Genero = "Fantástico. Comedia";
            pelicula11.Clasificacion = "Todo Publico";
            pelicula11.Duracion = 124;
            pelicula11.Estreno = "22/03/2021";
            pelicula11.Director = "Sony Pictures Entertainment(SPE)";
            pelicula11.Sinopsis = "Una madre soltera y sus dos hijos llegan a una pequeña ciudad, descubriendo su conexión con los cazafantasmas originales y el legado secreto que dejó su abuelo tras de sí. Secuela directa de \"Cazafantasmas 2\".";
            pelicula11.Imagen = $"{ruta_base}cazafantasmas.jpg";
            agregar(pelicula11);
        }
    }
}
