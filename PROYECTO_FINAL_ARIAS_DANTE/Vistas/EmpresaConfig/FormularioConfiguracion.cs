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

namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas.EmpresaConfig
{
    public partial class FormularioConfiguracion : Form
    {
        public FormularioConfiguracion()
        {
            InitializeComponent();
        }

        private void FormularioConfiguracion_Load_1(object sender, EventArgs e)
        {
            var data = MenuPrincipal.EmpresaData.getEmpresa();

            if (data.Nit != null) inpNit.Text = data.Nit;
            if (data.Nombre != null) inpNombre.Text = data.Nombre;
            if (data.Moneda != null) comboMoneda.SelectedItem = data.Moneda;
            if (data.Direccion != null) inpDireccion.Text = data.Direccion;
            if (data.Pais != null) inpPais.Text = data.Pais;
            if (data.Ciudad != null) inpCiudad.Text = data.Ciudad;
            if (data.Telefono != null) inpTelefono.Text = data.Telefono;
            if (data.Correo != null) inpCorreo.Text = data.Correo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (!validateNit()) check = false;
            if (!validateNombre()) check = false;
            if (!validateMoneda()) check = false;
            if (!validateDireccion()) check = false;
            if (!validatePais()) check = false;
            if (!validateCiudad()) check = false;
            if (!validateTelefono()) check = false;
            if (!validateCorreo()) check = false;


            if (check)
            {
                Empresa empresa = new Empresa();
                empresa.Nit = inpNit.Text;
                empresa.Nombre = inpNombre.Text;
                empresa.Moneda = comboMoneda.SelectedItem.ToString();
                empresa.Direccion = inpDireccion.Text;
                empresa.Pais = inpPais.Text;
                empresa.Ciudad = inpCiudad.Text;
                empresa.Telefono = inpTelefono.Text;
                empresa.Correo = inpCorreo.Text;

                MenuPrincipal.ShowMessage("Datos de empresa actualizados correctamente", "Bien", "info");

                MenuPrincipal.EmpresaData.agregar(empresa);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        private void inpNit_TextChanged(object sender, EventArgs e)
        {
            validateNit();
        }

        private void inpNombre_TextChanged(object sender, EventArgs e)
        {
            validateNombre();
        }

        private void comboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            validateMoneda();
        }

        private void inpDireccion_TextChanged(object sender, EventArgs e)
        {
            validateDireccion();
        }

        private void inpPais_TextChanged(object sender, EventArgs e)
        {
            validatePais();
        }

        private void inpNitudad_TextChanged(object sender, EventArgs e)
        {
            validateCiudad();
        }

        private void inpTelefono_TextChanged(object sender, EventArgs e)
        {
            validateTelefono();
        }

        private void inpCorreo_TextChanged(object sender, EventArgs e)
        {
            validateCorreo();
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

        bool validateNit()
        {
            if (inpNit.Text.Equals(""))
            {
                errorNit.Text = "Este campo es obligatorio";
                return false;
            }
            else errorNit.Text = "";

            if (!isInt(inpNit))
            {
                errorNit.Text = "Este campo debe ser numerico";
                return false;
            }
            else errorNit.Text = "";

            if (inpNit.Text.Length < 7)
            {
                errorNit.Text = "El Nit debe contener al menos 7 dígitos";
                return false;
            }
            else errorNit.Text = "";

            if (inpNit.Text.Length > 14)
            {
                errorNit.Text = "El Nit no puede contener mas de 14 dígitos";
                return false;
            }
            else errorNit.Text = "";

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

        bool validateMoneda()
        {
            if (comboMoneda.SelectedIndex < 0)
            {
                errorMoneda.Text = "Este campo es obligatorio";
                return false;
            }
            else errorMoneda.Text = "";

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

        bool validatePais()
        {
            if (inpPais.Text.Equals(""))
            {
                errorPais.Text = "Este campo es obligatorio";
                return false;
            }
            else errorPais.Text = "";

            return true;
        }

        bool validateCiudad()
        {
            if (inpCiudad.Text.Equals(""))
            {
                errorCiudad.Text = "Este campo es obligatorio";
                return false;
            }
            else errorCiudad.Text = "";

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

    }
}
