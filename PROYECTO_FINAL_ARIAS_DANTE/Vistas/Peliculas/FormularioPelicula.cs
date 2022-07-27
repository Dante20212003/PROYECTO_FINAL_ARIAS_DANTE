using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using PROYECTO_FINAL_ARIAS_DANTE.Modelos;

namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas.Peliculas
{
    public partial class FormularioPelicula : Form
    {
        string cod;
        Pelicula pelicula_edit;

        public FormularioPelicula(string cod_ = "")
        {
            cod = cod_;
            InitializeComponent();
        }

        private void FormularioPelicula_Load(object sender, EventArgs e)
        {
            comboClasificacion.Items.Add("Todo Publico");
            comboClasificacion.Items.Add("12+");
            comboClasificacion.Items.Add("15+");
            comboClasificacion.Items.Add("18+");

            if (cod.Length > 0)
            {
                this.Text = "Actualizar Pelicula";
                btnSave.Text = "ACTUALIZAR";

                int width, heigth;
                width = btnSave.Size.Width;
                heigth = btnSave.Size.Height;
                btnSave.Size = new Size(width + 20, heigth);

                titleForm.Hide();
                titleFormUpdate.Show();

                foreach (Pelicula item in FormPeliculas.ListaPeliculas.getPeliculas())
                {
                    if (item.Codigo == cod)
                    {

                        inpCodigo.Text = item.Codigo;
                        inpNombre.Text = item.Nombre;
                        inpGenero.Text = item.Genero;
                        comboClasificacion.SelectedItem = item.Clasificacion;
                        inpDuracion.Text = item.Duracion.ToString();
                        datePicker.Value = Convert.ToDateTime(item.Estreno);
                        inpDirector.Text = item.Director;
                        inpSinopsis.Text = item.Sinopsis;
                        imageBox.Image = Image.FromFile(item.Imagen);
                        imageBox.ImageLocation = item.Imagen;

                        pelicula_edit = item;
                        break;
                    }
                }
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";

            MessageBox.Show("Se recomienda utilizar imagenes de 350x500");

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageBox.ImageLocation = ofd.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (!validateCod()) check = false;
            if (!validateNombre()) check = false;
            if (!validateGenero()) check = false;
            if (!validateClasificacion()) check = false;
            if (!validateDuracion()) check = false;
            if (!validateEstreno()) check = false;
            if (!validateDirector()) check = false;
            if (!validateSinopsis()) check = false;

            if (check)
            {
                string path = $"{AppDomain.CurrentDomain.BaseDirectory}img", message = "", nameImage;

                if (!Directory.Exists(path))
                {
                    MessageBox.Show("NO EXISTE");
                    Directory.CreateDirectory(path);
                }

                Pelicula pelicula = new Pelicula();
                pelicula.Codigo = inpCodigo.Text;
                pelicula.Nombre = inpNombre.Text;
                pelicula.Genero = inpGenero.Text;
                pelicula.Clasificacion = comboClasificacion.SelectedItem.ToString();
                pelicula.Duracion = int.Parse(inpDuracion.Text);
                pelicula.Estreno = datePicker.Value.ToShortDateString();
                pelicula.Director = inpDirector.Text;
                pelicula.Sinopsis = inpSinopsis.Text;

                if (imageBox.Image != null)
                {
                    if (pelicula_edit != null)
                    {
                        if (imageBox.ImageLocation.ToString() != pelicula_edit.Imagen.ToString())
                        {
                            saveAndCopyImage(path, pelicula);
                        }
                        else
                        {
                            pelicula.Imagen = pelicula_edit.Imagen;
                        }
                    }
                    else
                    {
                        saveAndCopyImage(path, pelicula);
                    }
                }
                else
                {
                    nameImage = "default.jpg";
                    pelicula.Imagen = $"{path}\\{nameImage}";

                }

                if (cod.Length > 0)
                {
                    FormPeliculas.ListaPeliculas.editar(pelicula_edit, pelicula);
                    message = $"Pelicula con CODIGO: {pelicula.Codigo} actualizado con éxito";
                }
                else
                {
                    FormPeliculas.ListaPeliculas.agregar(pelicula);
                    message = $"Pelicula con CODIGO: {pelicula.Codigo} agregado con éxito";
                }

                MenuPrincipal.ShowMessage(message, "Bien", "info");

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        void saveAndCopyImage(string path, Pelicula pelicula)
        {
            string nameImage = imageBox.ImageLocation.Substring(imageBox.ImageLocation.LastIndexOf('\\') + 1);
            pelicula.Imagen = $"{path}\\{nameImage}";

            try
            {
                File.Copy(imageBox.ImageLocation, $"{path}\\{nameImage}", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inpCodigo_TextChanged(object sender, EventArgs e)
        {
            validateCod();
        }

        private void inpNombre_TextChanged(object sender, EventArgs e)
        {
            validateNombre();
        }

        private void inpGenero_TextChanged(object sender, EventArgs e)
        {
            validateGenero();
        }

        private void comboClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            validateClasificacion();
        }

        private void inpDuracion_TextChanged(object sender, EventArgs e)
        {
            validateDuracion();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            validateEstreno();
        }

        private void inpDirector_TextChanged(object sender, EventArgs e)
        {
            validateDirector();
        }

        private void inpSinopsis_TextChanged(object sender, EventArgs e)
        {
            validateSinopsis();
        }

        bool isInt(TextBox textbox)
        {
            Regex noInt = new Regex(@"\D");
            if (noInt.IsMatch(textbox.Text))
            {
                return false;
            }

            return true;
        }

        bool validateCod()
        {
            if (inpCodigo.Text.Equals(""))
            {
                errorCodigo.Text = "Este campo es obligatorio";
                return false;
            }
            else errorCodigo.Text = "";

            if (validateExistsCod(inpCodigo.Text))
            {
                errorCodigo.Text = "El Codigo ya se encuentra registrado";
            }
            else errorCodigo.Text = "";

            return true;
        }

        bool validateNombre()
        {
            if (inpNombre.Text.Equals(""))
            {
                errorNombre.Text = "Este campo es obligatorio";
                return false;
            }
            else errorNombre.Text = "";

            return true;
        }

        bool validateGenero()
        {
            if (inpGenero.Text.Equals(""))
            {
                errorGenero.Text = "Este campo es obligatorio";
                return false;
            }
            else errorGenero.Text = "";

            return true;
        }

        bool validateClasificacion()
        {
            if (comboClasificacion.SelectedItem.Equals(""))
            {
                errorClasificacion.Text = "Este campo es obligatorio";
                return false;
            }
            else errorClasificacion.Text = "";

            return true;
        }

        bool validateDuracion()
        {
            if (inpDuracion.Text.Equals(""))
            {
                errorDuracion.Text = "Este campo es obligatorio";
                return false;
            }
            else errorDuracion.Text = "";

            if (!isInt(inpDuracion))
            {
                errorDuracion.Text = "La duracion debe ser numerica";
                return false;
            }
            else errorDuracion.Text = "";

            return true;
        }

        bool validateEstreno()
        {
            if (datePicker.Value.ToString().Length < 1)
            {
                errorEstreno.Text = "Este campo es obligatorio";
                return false;
            }
            else errorEstreno.Text = "";

            return true;
        }

        bool validateDirector()
        {
            if (inpDirector.Text.Equals(""))
            {
                errorDirector.Text = "Este campo es obligatorio";
                return false;
            }
            else errorDirector.Text = "";

            return true;
        }

        bool validateSinopsis()
        {
            if (inpSinopsis.Text.Equals(""))
            {
                errorSinopsis.Text = "Este campo es obligatorio";
                return false;
            }
            else errorSinopsis.Text = "";

            return true;
        }

        bool validateExistsCod(string cod_)
        {
            foreach (Pelicula item in FormPeliculas.ListaPeliculas.getPeliculas())
            {
                if (item.Codigo == cod_ && cod_ != cod)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
