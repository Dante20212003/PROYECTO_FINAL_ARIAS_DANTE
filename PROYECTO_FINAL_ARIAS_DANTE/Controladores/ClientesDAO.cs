using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PROYECTO_FINAL_ARIAS_DANTE.Modelos;
using PROYECTO_FINAL_ARIAS_DANTE.Vistas;

namespace PROYECTO_FINAL_ARIAS_DANTE.Controladores
{
    public class ClientesDAO
    {
        private static List<Cliente> ListaClientes = new List<Cliente>();
        public static string rutaDBClientes = "E:\\Clientes.txt";

        public ClientesDAO()
        {
            ListaClientes.Clear();
            cargarTxt();
        }

        public void agregar(Cliente cliente)
        {
            ListaClientes.Add(cliente);
            agregarTxt(cliente);
        }

        public void editar(Cliente cliente, Cliente data)
        {
            ListaClientes[ListaClientes.IndexOf(cliente)] = data;

            reloadTxt();
        }

        public void eliminar(Cliente cliente)
        {
            ListaClientes.Remove(cliente);
        }

        public Cliente getCliente(string name)
        {
            return ListaClientes.FirstOrDefault(x => x.Nombre == name);
        }

        public List<Cliente> getClientes()
        {
            return ListaClientes;
        }

        void agregarTxt(Cliente cliente)
        {
            StreamWriter agregar = File.AppendText(rutaDBClientes);

            agregar.WriteLine($"{cliente.Ci}|{cliente.Nombre}|{cliente.Edad}|{cliente.Telefono}|{cliente.Correo}|{cliente.Direccion}|{cliente.Sexo}");

            agregar.Close();
        }

        public void cargarTxt()
        {
            try
            {
                StreamReader archivo = new StreamReader(rutaDBClientes);
                string linea;
                string[] data;

                while ((linea = archivo.ReadLine()) != null)
                {
                    data = linea.Split('|');

                    Cliente cliente = new Cliente();
                    cliente.Ci = data[0];
                    cliente.Nombre = data[1];
                    cliente.Edad = int.Parse(data[2]);
                    cliente.Telefono = data[3];
                    cliente.Correo = data[4];
                    cliente.Direccion = data[5];
                    cliente.Sexo = data[6];

                    ListaClientes.Add(cliente);
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
            TextWriter archivo = new StreamWriter(rutaDBClientes);

            foreach (Cliente item in ListaClientes)
            {
                archivo.WriteLine($"{item.Ci}|{item.Nombre}|{item.Edad}|{item.Telefono}|{item.Correo}|{item.Direccion}|{item.Sexo}");
            }

            archivo.Close();
        }
    }
}
