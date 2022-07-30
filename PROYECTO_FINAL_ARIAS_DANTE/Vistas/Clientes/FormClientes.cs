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
using PROYECTO_FINAL_ARIAS_DANTE.Vistas.Ventas;
using PROYECTO_FINAL_ARIAS_DANTE.Modelos;
using System.Text.RegularExpressions;

namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas.Clientes
{
    public partial class FormClientes : Form
    {
        public static ClientesDAO ListaClientes = new ClientesDAO();
        bool isVenta;

        public FormClientes(bool isVenta = false)
        {
            this.isVenta = isVenta;
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            listarClientes();

            if (isVenta)
            {
                dataGridClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(doubleClickSelect);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormularioCliente fr = new FormularioCliente();

            if (fr.ShowDialog() == DialogResult.OK) listarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.RowCount > 0)
            {
                string ciSelect = dataGridClientes.CurrentRow.Cells[0].Value.ToString();

                FormularioCliente fr = new FormularioCliente(ciSelect);

                if (fr.ShowDialog() == DialogResult.OK) listarClientes();
            }
            else
            {
                MenuPrincipal.ShowMessage("Seleccione un libro para editar", "Alerta", "warn");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.RowCount > 0)
            {
                string ciSelected = dataGridClientes.CurrentRow.Cells[0].Value.ToString();

                DialogResult dialogo = MessageBox.Show($"Esta seguro de eliminar al cliente con CI: {ciSelected}?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogo == DialogResult.Yes)
                {
                    foreach (Cliente item in ListaClientes.getClientes())
                    {
                        if (item.Ci == ciSelected)
                        {
                            ListaClientes.eliminar(item);
                            break;
                        }
                    }

                    ListaClientes.reloadTxt();
                    listarClientes();
                }
            }
            else
            {
                MenuPrincipal.ShowMessage("Seleccione un producto para editar", "Alerta", "warn");
            }
        }

        private void inpBuscar_TextChanged(object sender, EventArgs e)
        {
            dynamic resultados;

            if (isInt(inpBuscar.Text))
            {
                 resultados = ListaClientes.getClientes().Where(cliente => cliente.Ci.Contains(inpBuscar.Text));
            }
            else
            {
                 resultados = ListaClientes.getClientes().Where(cliente => cliente.Nombre.ToLower().Contains(inpBuscar.Text.ToLower()));
            }

            dataGridClientes.Rows.Clear();

            foreach (Cliente item in resultados)
            {
                dataGridClientes.Rows.Add(item.Ci,
                                      item.Nombre,
                                      item.Edad,
                                      item.Telefono,
                                      item.Correo,
                                      item.Direccion,
                                      item.Sexo);
            }
        }

        private void doubleClickSelect(object sender, EventArgs e)
        {
            string nameClientSelect = dataGridClientes.CurrentRow.Cells[1].Value.ToString();

            FormularioVenta_v2.clienteSelect = nameClientSelect;
            this.DialogResult = DialogResult.OK;
        }

        bool isInt(string data)
        {
            Regex noInt = new Regex(@"\D");
            if (noInt.IsMatch(data))
            {
                return false;
            }

            return true;
        }

        void listarClientes()
        {
            dataGridClientes.Rows.Clear();

            foreach (Cliente item in ListaClientes.getClientes())
            {
                dataGridClientes.Rows.Add(item.Ci,
                                       item.Nombre,
                                       item.Edad,
                                       item.Telefono,
                                       item.Correo,
                                       item.Direccion,
                                       item.Sexo);
            }
        }

    }
}
