using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PROYECTO_FINAL_ARIAS_DANTE.Controladores;
using PROYECTO_FINAL_ARIAS_DANTE.Modelos;
using PROYECTO_FINAL_ARIAS_DANTE.Vistas;

namespace PROYECTO_FINAL_ARIAS_DANTE.Controladores
{
    public class VentasDAO
    {
        private static List<Venta> ListaVentas = new List<Venta>();
        public static string rutaDbVentas = "E:\\Ventas.txt";

        public VentasDAO()
        {
            ListaVentas.Clear();
            cargarTxt();
        }

        public void agregar(Venta venta)
        {
            ListaVentas.Add(venta);
            agregarTxt(venta);

        }

        public void editar(Venta venta, Venta data)
        {
            ListaVentas[ListaVentas.IndexOf(venta)] = data;

            reloadTxt();
        }

        public void eliminar(Venta venta)
        {
            ListaVentas.Remove(venta);
        }

        public Venta getVenta(string ci)
        {
            return ListaVentas.FirstOrDefault(x => x.IdVenta.ToString() == ci);
        }

        public int getFinalIdVenta()
        {
            if (ListaVentas.Count > 0)
            {
                return ListaVentas[ListaVentas.Count - 1].IdVenta;
            }

            return -1;
        }

        public List<Venta> getVentas()
        {
            return ListaVentas;
        }

        void agregarTxt(Venta venta)
        {
            StreamWriter agregar = File.AppendText(rutaDbVentas);

            agregar.WriteLine($"{venta.IdVenta}|{venta.Pelicula}|{venta.Cliente}|{venta.Factura}|{venta.Nit}|{venta.Boletos}|{venta.PrecioBoleto}|{venta.Total}|{venta.Fecha}");

            agregar.Close();
        }

        public void cargarTxt()
        {
            try
            {
                StreamReader archivo = new StreamReader(rutaDbVentas);
                string linea;
                string[] data;

                while ((linea = archivo.ReadLine()) != null)
                {
                    data = linea.Split('|');

                    Venta venta = new Venta();

                    venta.IdVenta = int.Parse(data[0]);
                    venta.Pelicula = data[1];
                    venta.Cliente = data[2];
                    venta.Factura = data[3];
                    venta.Nit = data[4];
                    venta.Boletos = int.Parse(data[5]);
                    venta.PrecioBoleto = double.Parse(data[6]);
                    venta.Total = double.Parse(data[7]);
                    venta.Fecha = data[8];

                    ListaVentas.Add(venta);
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
            TextWriter archivo = new StreamWriter(rutaDbVentas);

            foreach (Venta venta in ListaVentas)
            {
                archivo.WriteLine($"{venta.IdVenta}|{venta.Pelicula}|{venta.Cliente}|{venta.Factura}|{venta.Nit}|{venta.Boletos}|{venta.PrecioBoleto}|{venta.Total}|{venta.Fecha}");
            }

            archivo.Close();
        }
    }
}
