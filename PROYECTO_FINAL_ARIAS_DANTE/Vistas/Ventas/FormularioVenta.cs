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
using System.Drawing.Printing;

using PROYECTO_FINAL_ARIAS_DANTE.Controladores;
using PROYECTO_FINAL_ARIAS_DANTE.Modelos;
using PROYECTO_FINAL_ARIAS_DANTE.Vistas.Clientes;
using PROYECTO_FINAL_ARIAS_DANTE.Vistas.Peliculas;

namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas.Ventas
{
    public partial class FormularioVenta : Form
    {
        string id;

        public static PeliculasDAO ListaPeliculas = new PeliculasDAO();
        public static ClientesDAO ListaClientes = new ClientesDAO();

        public FormularioVenta(string id_ = "")
        {
            id = id_;
            InitializeComponent();
        }

        private void FormularioVenta_Load(object sender, EventArgs e)
        {
            listarPeliculas();
            listarClientes();

            if (id.Length > 0)
            {
                btnGenerarVenta.Hide();
                titleFormUpdate.Hide();

                btnAddCliente.Enabled = false;
                btnAddPelicula.Enabled = false;

                btnImprimir.Show();

                foreach (Venta item in FormVentas.ListaVentas.getVentas())
                {
                    if (item.IdVenta.ToString() == id)
                    {
                        titleVer.Text = $"VENTA N° {item.IdVenta}";
                        titleVer.Show();

                        comboPeliculas.SelectedItem = item.Pelicula;
                        comboPeliculas.Enabled = false;

                        comboClientes.SelectedItem = item.Cliente;
                        comboClientes.Enabled = false;

                        if (item.Factura == "SI")
                        {
                            radioFacturaSi.Checked = true;
                            radioFacturaSi.Enabled = false;
                            radioFacturaNo.Enabled = false;

                            inpNit.Text = item.Nit;
                            inpNit.Enabled = false;
                        }
                        else radioFacturaSi.Checked = false;

                        inpPrecio.Text = item.PrecioBoleto.ToString();
                        inpPrecio.Enabled = false;

                        inpNumeroBoletos.Value = item.Boletos;
                        inpNumeroBoletos.Enabled = false;

                        inpTotal.Text = "Bs." + item.Total.ToString();
                        inpTotal.Enabled = false;

                        datePicker.Value = Convert.ToDateTime(item.Fecha);

                        break;
                    }
                }
            }
        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (!validatePelicula()) check = false;
            if (!validateCliente()) check = false;
            if (!validateNit()) check = false;
            if (!validatePrecio()) check = false;

            if (check)
            {
                string message = "";

                Venta venta = new Venta();

                if (FormVentas.ListaVentas.getFinalIdVenta() < 0) venta.IdVenta = 1;
                else venta.IdVenta = FormVentas.ListaVentas.getFinalIdVenta() + 1;

                venta.Pelicula = comboPeliculas.SelectedItem.ToString();
                venta.Cliente = comboClientes.SelectedItem.ToString();

                if (radioFacturaSi.Checked)
                {
                    venta.Factura = "SI";
                    venta.Nit = inpNit.Text;
                }
                else
                {
                    venta.Factura = "NO";
                    venta.Nit = "";
                }

                venta.Boletos = int.Parse(inpNumeroBoletos.Text);
                venta.PrecioBoleto = double.Parse(inpPrecio.Text);
                venta.Total = int.Parse(inpNumeroBoletos.Text) * double.Parse(inpPrecio.Text);
                venta.Fecha = datePicker.Value.ToString();

                FormVentas.ListaVentas.agregar(venta);
                message = $"Venta con ID: {venta.IdVenta} agregado con éxito";

                MenuPrincipal.ShowMessage(message, "Bien", "info");

                this.DialogResult = DialogResult.OK;

                print();
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            print();
        }

        private void btnAddPelicula_Click(object sender, EventArgs e)
        {
            FormularioPelicula fr = new FormularioPelicula();

            if (fr.ShowDialog() == DialogResult.OK) listarPeliculas();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            FormularioCliente fr = new FormularioCliente();

            if (fr.ShowDialog() == DialogResult.OK) listarClientes();
        }

        private void comboPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            validatePelicula();
        }

        private void comboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            validateCliente();
        }

        private void radioFacturaSi_CheckedChanged(object sender, EventArgs e)
        {
            validateRadio();
        }

        private void radioFacturaNo_CheckedChanged(object sender, EventArgs e)
        {
            validateRadio();
        }

        private void inpNit_TextChanged(object sender, EventArgs e)
        {
            validateNit();
        }

        private void inpPrecio_TextChanged(object sender, EventArgs e)
        {
            validatePrecio();
        }

        private void inpNumeroBoletos_ValueChanged(object sender, EventArgs e)
        {
            validatePrecio();
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

        bool validatePelicula()
        {
            if (comboPeliculas.SelectedIndex < 0)
            {
                errorPelicula.Text = "Este campo es obligatorio";
                return false;
            }
            else errorPelicula.Text = "";

            return true;
        }

        bool validateCliente()
        {
            if (comboClientes.SelectedIndex < 0)
            {
                errorCliente.Text = "Este campo es obligatorio";
                return false;
            }
            else errorCliente.Text = "";

            return true;
        }

        bool validateRadio()
        {
            if (radioFacturaSi.Checked)
            {
                inpNit.Enabled = true;
                return false;
            }
            else inpNit.Enabled = false;

            return true;
        }

        bool validateNit()
        {

            if (radioFacturaSi.Checked)
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
                    errorNit.Text = "El NIT debe contener al menos 7 dígitos";
                    return false;
                }
                else errorNit.Text = "";

                if (inpNit.Text.Length > 14)
                {
                    errorNit.Text = "El CI no puede contener mas de 14 dígitos";
                    return false;
                }
                else errorNit.Text = "";
            }

            return true;
        }

        bool validatePrecio()
        {
            if (inpPrecio.Text.Equals(""))
            {
                errorPrecio.Text = "Este campo es obligatorio";
                return false;
            }
            else errorPrecio.Text = "";

            if (!isInt(inpPrecio))
            {
                errorPrecio.Text = "Este campo debe ser numerico";
                return false;
            }
            else errorPrecio.Text = "";

            inpTotal.Text = "Bs. " + (int.Parse(inpPrecio.Text) * int.Parse(inpNumeroBoletos.Value.ToString())).ToString();

            return true;
        }

        void listarPeliculas()
        {
            comboPeliculas.Items.Clear();

            foreach (Pelicula item in ListaPeliculas.getPeliculas())
            {
                comboPeliculas.Items.Add(item.Nombre);
            }
        }

        void listarClientes()
        {
            comboClientes.Items.Clear();

            foreach (Cliente item in ListaClientes.getClientes())
            {
                comboClientes.Items.Add(item.Nombre);
            }
        }

        void print()
        {
            printPreviewDialog1.Size = new Size(1000, 1000);

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Pelicula pelicula = ListaPeliculas.getPelicula(comboPeliculas.SelectedItem.ToString());
            Cliente cliente = ListaClientes.getCliente(comboClientes.SelectedItem.ToString());

            e.Graphics.DrawString("GRACIAS POR SU COMPRA", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(250, 40));


            e.Graphics.DrawString($"Fecha:   {datePicker.Value}", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, 90 + 60));

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(100, 120 + 60));

            e.Graphics.DrawString("DETALLES PELICULA", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(350, 140 + 60));

            e.Graphics.DrawString($"Pelicula:   {comboPeliculas.SelectedItem.ToString()}", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, 170 + 60));

            e.Graphics.DrawString($"Genero:     {pelicula.Genero}", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, 200 + 60));

            e.Graphics.DrawString($"Duracion:   {pelicula.Duracion} min", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, 230 + 60));

            e.Graphics.DrawString($"Sinopsis:   {pelicula.Sinopsis}", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, 260 + 60));

            e.Graphics.DrawString($"Estreno:    {pelicula.Estreno}", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, 290 + 60));



            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(100, 310 + 60));

            e.Graphics.DrawString("DETALLES CLIENTE", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(350, 340 + 60));

            e.Graphics.DrawString($"Nombre:   {cliente.Nombre}", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, 370 + 60));

            e.Graphics.DrawString($"Edad:     {cliente.Edad}", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, 400 + 60));

            e.Graphics.DrawString($"Telefono:   {cliente.Telefono} min", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, 430 + 60));

            e.Graphics.DrawString($"Correo:   {cliente.Correo}", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, 460 + 60));


            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(100, 500 + 60));

            e.Graphics.DrawString("DETALLES COMPRA", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(350, 530 + 60));


            e.Graphics.DrawString($"N° Factura: {FormVentas.ListaVentas.getFinalIdVenta()}", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(100, 560 + 60));


            e.Graphics.DrawString($"Nit:   {inpNit.Text}", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, 590 + 60));

            e.Graphics.DrawString($"Numero de Boletos:   {inpNumeroBoletos.Text}", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, 620 + 60));

            e.Graphics.DrawString($"Total:  Bs. {inpTotal.Text}", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, 650 + 60));


        }


    }
}
