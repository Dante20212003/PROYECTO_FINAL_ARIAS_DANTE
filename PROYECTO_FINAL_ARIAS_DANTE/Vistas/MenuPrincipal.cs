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

using System.Windows.Forms;

namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();

            formClientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPeliculas formClientes = new FormPeliculas();

            formClientes.Show();
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
