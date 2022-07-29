using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PROYECTO_FINAL_ARIAS_DANTE.Modelos;
using PROYECTO_FINAL_ARIAS_DANTE.Vistas;

namespace PROYECTO_FINAL_ARIAS_DANTE.Controladores
{
    public class EmpresaDAO
    {
        private static Empresa Empresa = new Empresa();
        public static string rutaDBEmpresa = MenuPrincipal.rutaDBEmpresa;

        public EmpresaDAO()
        {
            cargarTxt();
        }

        public void agregar(Empresa empresa)
        {
            Empresa.Nit = empresa.Nit;
            Empresa.Nombre = empresa.Nombre;
            Empresa.Moneda = empresa.Moneda;
            Empresa.Direccion = empresa.Direccion;
            Empresa.Pais = empresa.Pais;
            Empresa.Ciudad = empresa.Ciudad;
            Empresa.Telefono = empresa.Telefono;
            Empresa.Correo = empresa.Correo;

            agregarTxt(empresa);
        }

        public void editar(Empresa empresa, Empresa data)
        {
            //Empresa[Empresa.IndexOf(empresa)] = data;

            reloadTxt();
        }

        public void eliminar(Empresa empresa)
        {
            //Empresa.Remove(empresa);
        }

        public Empresa getEmpresa()
        {
            return Empresa;
        }

        void agregarTxt(Empresa empresa)
        {
            //StreamWriter agregar = File.AppendText(rutaDBEmpresa);

            TextWriter agregar = new StreamWriter(rutaDBEmpresa);

            agregar.WriteLine($"{empresa.Nit}|{empresa.Nombre}|{empresa.Moneda}|{empresa.Direccion}|{empresa.Pais}|{empresa.Ciudad}|{empresa.Telefono}|{empresa.Correo}");

            agregar.Close();
        }

        public void cargarTxt()
        {
            try
            {
                StreamReader archivo = new StreamReader(rutaDBEmpresa);
                string linea;
                string[] data;

                if ((linea = archivo.ReadLine()) != null)
                {
                    data = linea.Split('|');

                    Empresa.Nit = data[0];
                    Empresa.Nombre = data[1];
                    Empresa.Moneda = data[2];
                    Empresa.Direccion = data[3];
                    Empresa.Pais = data[4];
                    Empresa.Ciudad = data[5];
                    Empresa.Telefono = data[6];
                    Empresa.Correo = data[7];
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
            TextWriter archivo = new StreamWriter(rutaDBEmpresa);

            //foreach (Empresa empresa in Empresa)
            //{
            //    archivo.WriteLine($"{empresa.Nit}|{empresa.Nombre}|{empresa.Moneda}|{empresa.Direccion}|{empresa.Pais}|{empresa.Ciudad}|{empresa.Telefono}|{empresa.Correo}");
            //}

            archivo.Close();
        }
    }
}
