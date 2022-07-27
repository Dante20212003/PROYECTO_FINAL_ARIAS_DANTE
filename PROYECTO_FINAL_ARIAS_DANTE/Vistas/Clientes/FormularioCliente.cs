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

namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas.Clientes
{
    public partial class FormularioCliente : Form
    {
        string ci;
        Cliente cliente_edit;

        public FormularioCliente(string ci_ = "")
        {
            ci = ci_;
            InitializeComponent();
        }

        private void FormularioCliente_Load(object sender, EventArgs e)
        {
            if (ci.Length > 0)
            {
                this.Text = "Actualizar Cliente";
                btnSave.Text = "ACTUALIZAR";
                int width, heigth;
                width = btnSave.Size.Width;
                heigth = btnSave.Size.Height;
                btnSave.Size = new Size(width + 20, heigth);
                titleForm.Hide();
                titleFormUpdate.Show();

                foreach (Cliente item in FormClientes.ListaClientes.getClientes())
                {
                    if (item.Ci == ci)
                    {
                        inpCi.Text = item.Ci;
                        inpNombre.Text = item.Nombre;
                        inpEdad.Text = item.Edad.ToString();
                        inpTelefono.Text = item.Telefono;
                        inpCorreo.Text = item.Correo;
                        inpDireccion.Text = item.Direccion;

                        if (item.Sexo == "Hombre") radioHombre.Checked = true;
                        else radioMujer.Checked = true;

                        cliente_edit = item;
                        break;
                    }
                }
            }
        }

        private void inpCi_TextChanged(object sender, EventArgs e)
        {
            validateCi();
        }

        private void inpNombre_TextChanged(object sender, EventArgs e)
        {
            validateNombre();
        }

        private void inpEdad_TextChanged(object sender, EventArgs e)
        {
            validateEdad();
        }

        private void inpTelefono_TextChanged(object sender, EventArgs e)
        {
            validateTelefono();
        }

        private void inpCorreo_TextChanged(object sender, EventArgs e)
        {
            validateCorreo();
        }

        private void inpDireccion_TextChanged(object sender, EventArgs e)
        {
            validateDireccion();
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

        bool validateCi()
        {
            if (inpCi.Text.Equals(""))
            {
                errorCi.Text = "Este campo es obligatorio";
                return false;
            }
            else errorCi.Text = "";

            if (!isInt(inpCi))
            {
                errorCi.Text = "Este campo debe ser numerico";
                return false;
            }
            else errorCi.Text = "";

            if (inpCi.Text.Length < 7)
            {
                errorCi.Text = "El CI debe contener al menos 7 dígitos";
                return false;
            }
            else errorCi.Text = "";

            if (inpCi.Text.Length > 10)
            {
                errorCi.Text = "El CI no puede contener mas de 10 dígitos";
                return false;
            }
            else errorCi.Text = "";

            if (validateExistsCi(inpCi.Text))
            {
                errorCi.Text = "El CI ya se encuentra registrado";
            }
            else errorCi.Text = "";

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

        bool validateEdad()
        {
            if (inpEdad.Text.Equals(""))
            {
                errorEdad.Text = "Este campo es obligatorio";
                return false;
            }
            else errorEdad.Text = "";

            if (!isInt(inpEdad))
            {
                errorEdad.Text = "Este campo debe ser numerico";
                return false;
            }
            else errorEdad.Text = "";

            return true;
        }

        bool validateTelefono()
        {
            if (inpTelefono.Text.Equals(""))
            {
                errorTelefono.Text = "Este campo es obligatorio";
                return false;
            }
            else errorTelefono.Text = "";

            if (!isInt(inpTelefono))
            {
                errorTelefono.Text = "Este campo debe ser numerico";
                return false;
            }
            else errorTelefono.Text = "";

            if (inpTelefono.Text.Length < 7)
            {
                errorTelefono.Text = "El Teléfono debe contener al menos 7 dígitos";
                return false;
            }
            else errorTelefono.Text = "";

            if (inpTelefono.Text.Length > 10)
            {
                errorTelefono.Text = "El Teléfono no puede contener mas de 10 dígitos";
                return false;
            }
            else errorTelefono.Text = "";

            return true;
        }

        bool validateCorreo()
        {
            if (inpCorreo.Text.Equals(""))
            {
                errorCorreo.Text = "Este campo es obligatorio";
                return false;
            }
            else errorCorreo.Text = "";

            return true;
        }

        bool validateDireccion()
        {
            if (inpDireccion.Text.Equals(""))
            {
                errorDireccion.Text = "Este campo es obligatorio";
                return false;
            }
            else errorDireccion.Text = "";

            return true;
        }

        bool validateExistsCi(string ci_)
        {
            foreach (Cliente item in FormClientes.ListaClientes.getClientes())
            {
                if (item.Ci == ci_ && ci_ != ci)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (!validateCi()) check = false;
            if (!validateNombre()) check = false;
            if (!validateEdad()) check = false;
            if (!validateTelefono()) check = false;
            if (!validateCorreo()) check = false;
            if (!validateDireccion()) check = false;


            if (check)
            {
                string message = "";

                Cliente cliente = new Cliente();
                cliente.Ci = inpCi.Text;
                cliente.Nombre = inpNombre.Text;
                cliente.Edad = int.Parse(inpEdad.Text);
                cliente.Telefono = inpTelefono.Text;
                cliente.Correo = inpCorreo.Text;
                cliente.Direccion = inpDireccion.Text;

                if (radioHombre.Checked) cliente.Sexo = "Hombre";
                else cliente.Sexo = "Mujer";

                if (ci.Length > 0)
                {
                    FormClientes.ListaClientes.editar(cliente_edit, cliente);
                    message = $"Cliente con CI: {cliente.Ci} actualizado con éxito";
                }
                else
                {
                    FormClientes.ListaClientes.agregar(cliente);
                    message = $"Cliente con CI: {cliente.Ci} agregado con éxito";
                }

                MenuPrincipal.ShowMessage(message, "Bien", "info");

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }
    }
}
