using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (inpUsuario.Text.Equals("admin") && inpPassword.Text.Equals("admin"))
            {
                MenuPrincipal.Logueado = true;
                MenuPrincipal.ShowMessage("Bienvenido al Sistema", "Bien", "info");
                this.DialogResult = DialogResult.OK;
            }
            else MenuPrincipal.ShowMessage("Usuario o contraseña incorrectos. Vuelva a intentarlo", "Bien", "info");
        }
    }
}
