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
using PROYECTO_FINAL_ARIAS_DANTE.Vistas.EmpresaConfig;

using PROYECTO_FINAL_ARIAS_DANTE.Controladores;
using PROYECTO_FINAL_ARIAS_DANTE.Modelos;

using System.Windows.Forms;

namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas
{
    public partial class MenuPrincipal : Form
    {
        public static PeliculasDAO ListaPeliculas;
        public static EmpresaDAO EmpresaData;

        public static string rutaDBPeliculas = "";
        public static string rutaDBClientes = "";
        public static string rutaDBVentas = "";
        public static string rutaDBEmpresa = "";

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            comprobarBasesDeDatos();
            listarPeliculas();

            titleEmpresa.Text = $"Cinepolis {EmpresaData.getEmpresa().Nombre}";

            toolTip1.SetToolTip(btnRecargar, "Recarga los datos");

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

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConfiguracion formConfiguracion = new FormularioConfiguracion();

            if (formConfiguracion.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            listarPeliculas();
            titleEmpresa.Text = $"Cinepolis {EmpresaData.getEmpresa().Nombre}";
        }

        public void listarPeliculas()
        {
            flowLayout.Controls.Clear();

            foreach (Pelicula item in ListaPeliculas.getPeliculas())
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(item.Imagen);
                pictureBox.Location = new System.Drawing.Point(16, 13);
                pictureBox.Size = new System.Drawing.Size(300, 400);
                pictureBox.TabStop = false;
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

                Label label = new Label();
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(16, 420);
                label.Size = new System.Drawing.Size(38, 15);
                label.Text = $"Nombre: {item.Nombre}\nGenero: {item.Genero}\nDuracion: {item.Duracion} min\nFecha Estreno: {item.Estreno}";

                Button button = new Button();
                button.Location = new System.Drawing.Point(16, 490);
                button.Size = new System.Drawing.Size(295, 50);
                button.Font = new Font(button.Font.Name, 14f, FontStyle.Bold);
                button.Text = "Ver Pelicula";
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = Color.White ;
                button.BackColor = Color.SteelBlue;
                button.Cursor = Cursors.Hand;
                button.UseVisualStyleBackColor = true;
                button.Click += new System.EventHandler(button_Click);
                button.Name = $"btnPelicula,{item.Codigo}";

                Panel panel = new Panel();
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);
                panel.Controls.Add(button);
                panel.Location = new System.Drawing.Point(3, 3);
                panel.Name = "panel1";
                panel.BackColor = Color.LightBlue;
                panel.Size = new System.Drawing.Size(350, 550);

                flowLayout.Controls.Add(panel);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            string cod = button.Name.Substring(button.Name.LastIndexOf(',') + 1);

            ViewPelicula viewPelicula = new ViewPelicula(cod, ListaPeliculas);
            viewPelicula.ShowDialog();
        }

        void comprobarBasesDeDatos()
        {
            try
            {
                bool check = true;
                bool checkEmpresa = true;

                string ruta_base = AppDomain.CurrentDomain.BaseDirectory + "basededatos";

                string path_clientes = Path.Combine(ruta_base, "Clientes.txt");
                string path_peliculas = Path.Combine(ruta_base, "Peliculas.txt");
                string path_ventas = Path.Combine(ruta_base, "Ventas.txt");
                string path_Empresa = Path.Combine(ruta_base, "Empresa.txt");

                if (!File.Exists(path_clientes))
                {
                    using (File.Create(path_clientes)) ;
                    rutaDBClientes = path_clientes;

                    ClientesDAO clientesDao = new ClientesDAO();
                    clientesDao.rellenar();

                    check = false;
                }
                else rutaDBClientes = path_clientes;

                if (!File.Exists(path_peliculas))
                {
                    using (File.Create(path_peliculas)) ;
                    rutaDBPeliculas = path_peliculas;

                    ListaPeliculas = new PeliculasDAO();
                    ListaPeliculas.rellenar();
                    check = false;
                }
                else
                {
                    rutaDBPeliculas = path_peliculas;
                    ListaPeliculas = new PeliculasDAO();
                }

                if (!File.Exists(path_ventas))
                {
                    using (File.Create(path_ventas)) ;

                    rutaDBVentas = path_ventas;

                    check = false;
                }
                else rutaDBVentas = path_ventas;

                if (!File.Exists(path_Empresa))
                {
                    using (File.Create(path_Empresa)) ;
                    rutaDBEmpresa = path_Empresa;

                    check = false;
                    checkEmpresa = false;
                }
                else
                {
                    rutaDBEmpresa = path_Empresa;
                }

                EmpresaData = new EmpresaDAO();

                var Data = EmpresaData.getEmpresa();

                if (Data.Nit == null || Data.Nombre == null || Data.Moneda == null || Data.Direccion == null || Data.Pais == null || Data.Ciudad == null || Data.Telefono == null || Data.Correo == null)
                {
                    checkEmpresa = false;
                }
                else
                {
                    if (Data.Nit.Equals("") || Data.Nombre.Equals("") || Data.Moneda.Equals("") || Data.Direccion.Equals("") || Data.Pais.Equals("") || Data.Ciudad.Equals("") || Data.Telefono.Equals("") || Data.Correo.Equals(""))
                    {
                        checkEmpresa = false;
                    }
                }

                if (!check)
                {
                    ShowMessage($"No se detecto una base de datos.\n\nPor lo que se creara una base de datos en la siguiente ruta:\n\n{ruta_base}\\", "Alerta", "info");
                }

                if (!checkEmpresa)
                {
                    ShowMessage("Por favor configure los datos de la empresa antes de continuar", "Alerta", "info");

                    bool comprobeEmpresa = false;

                    FormularioConfiguracion formularioConfiguracion = new FormularioConfiguracion();

                    do
                    {
                        if (formularioConfiguracion.ShowDialog() == DialogResult.OK)
                        {
                            comprobeEmpresa = true;
                        }
                        else
                        {
                            comprobeEmpresa = false;

                            DialogResult dialogo = MessageBox.Show("No puedes continuar sin configurar la empresa\n\nDeseas volver a intentarlo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (dialogo == DialogResult.No)
                            {
                                this.Close();
                            }
                            //  ShowMessage("No puedes continuar sin configurar la empresa", "Alerta", "warn");
                        }
                    } while (!comprobeEmpresa);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR GRAVE " + ex.Message);
                this.Close();
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
