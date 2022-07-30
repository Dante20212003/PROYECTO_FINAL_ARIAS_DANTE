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
using PROYECTO_FINAL_ARIAS_DANTE.Modelos;

namespace PROYECTO_FINAL_ARIAS_DANTE.Vistas.Ventas
{
    public partial class FormVentas : Form
    {
        public static VentasDAO ListaVentas = new VentasDAO();
        Empresa DataEmpresa = MenuPrincipal.EmpresaData.getEmpresa();

        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            listarVentas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //FormularioVenta fr = new FormularioVenta();

            //if (fr.ShowDialog() == DialogResult.OK) listarVentas();

            FormularioVenta_v2 fr = new FormularioVenta_v2();

            if (fr.ShowDialog() == DialogResult.OK) listarVentas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridVentas.RowCount > 0)
            {
                string idSelected = dataGridVentas.CurrentRow.Cells[0].Value.ToString();

                DialogResult dialogo = MessageBox.Show($"Esta seguro de eliminar la venta con ID: {idSelected}?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogo == DialogResult.Yes)
                {
                    foreach (Venta item in ListaVentas.getVentas())
                    {
                        if (item.IdVenta.ToString() == idSelected)
                        {
                            ListaVentas.eliminar(item);
                            MenuPrincipal.ShowMessage("Eliminado exitosamente", "Bien", "info");
                            break;
                        }
                    }

                    ListaVentas.reloadTxt();
                    listarVentas();
                }
            }
            else
            {
                MenuPrincipal.ShowMessage("Seleccione una venta para eliminar", "Alerta", "warn");
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dataGridVentas.RowCount > 0)
            {
                string idSelect = dataGridVentas.CurrentRow.Cells[0].Value.ToString();

                FormularioVenta_v2 fr = new FormularioVenta_v2(idSelect);

                if (fr.ShowDialog() == DialogResult.OK) listarVentas();
            }
            else
            {
                MenuPrincipal.ShowMessage("Seleccione una venta para ver", "Alerta", "warn");
            }
        }

        private void inpBuscar_TextChanged(object sender, EventArgs e)
        {
            var resultados = ListaVentas.getVentas().Where(x => x.IdVenta.ToString().Contains(inpBuscar.Text.ToString()));

            dataGridVentas.Rows.Clear();

            foreach (Venta item in resultados)
            {
                dataGridVentas.Rows.Add(item.IdVenta,
                                        item.Pelicula,
                                        item.Cliente,
                                        item.Factura,
                                        item.Nit,
                                        item.Boletos,
                                        DataEmpresa.Moneda + " " + item.PrecioBoleto,
                                        DataEmpresa.Moneda + " " + item.Total,
                                        item.Fecha);
            }
        }

        void listarVentas()
        {
            dataGridVentas.Rows.Clear();

            foreach (Venta item in ListaVentas.getVentas())
            {
                dataGridVentas.Rows.Add(item.IdVenta,
                                       item.Pelicula,
                                       item.Cliente,
                                       item.Factura,
                                       item.Nit,
                                       item.Boletos,
                                       DataEmpresa.Moneda + " " + item.PrecioBoleto,
                                       DataEmpresa.Moneda + " " + item.Total,
                                       item.Fecha);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var resultados = ListaVentas.getVentas().Where(x => Convert.ToDateTime(x.Fecha).ToShortDateString().ToString().Contains(dateTimePicker1.Value.ToShortDateString().ToString()));

            dataGridVentas.Rows.Clear();

            foreach (Venta item in resultados)
            {
                dataGridVentas.Rows.Add(item.IdVenta,
                                        item.Pelicula,
                                        item.Cliente,
                                        item.Factura,
                                        item.Nit,
                                        item.Boletos,
                                        DataEmpresa.Moneda + " " + item.PrecioBoleto,
                                         DataEmpresa.Moneda + " " + item.Total,
                                        item.Fecha);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listarVentas();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
