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
        public static string rutaDBClientes = MenuPrincipal.rutaDBClientes;

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

        public void rellenar()
        {
            Cliente cliente = new Cliente();
            cliente.Ci = "12755611";
            cliente.Nombre = "Dante Arias Tarifa";
            cliente.Edad = 19;
            cliente.Telefono = "68681507";
            cliente.Correo = "dantearias@gmail.com";
            cliente.Direccion = "Barrio Juan Pablo II";
            cliente.Sexo = "Hombre";
            agregar(cliente);

            Cliente cliente2 = new Cliente();
            cliente2.Ci = "4130521";
            cliente2.Nombre = "Mariela Farnfan";
            cliente2.Edad = 22;
            cliente2.Telefono = "68686060";
            cliente2.Correo = "mari.Eli@gmail.com";
            cliente2.Direccion = "Barrio El Prado";
            cliente2.Sexo = "Mujer";
            agregar(cliente2);

            Cliente cliente3 = new Cliente();
            cliente3.Ci = "88349309";
            cliente3.Nombre = "Daniel Mancilla";
            cliente3.Edad = 34;
            cliente3.Telefono = "73449940";
            cliente3.Correo = "danyManci@gmail.com";
            cliente3.Direccion = "Barrio Chino";
            cliente3.Sexo = "Hombre";
            agregar(cliente3);

            Cliente cliente4 = new Cliente();
            cliente4.Ci = "41284929";
            cliente4.Nombre = "Esteban Quito";
            cliente4.Edad = 19;
            cliente4.Telefono = "73491240";
            cliente4.Correo = "esteban_quito@gmail.com";
            cliente4.Direccion = "Barrio La Victorioa";
            cliente4.Sexo = "Hombre";
            agregar(cliente4);

            Cliente cliente5 = new Cliente();
            cliente5.Ci = "883491202";
            cliente5.Nombre = "Belen Betancur Benitez";
            cliente5.Edad = 14;
            cliente5.Telefono = "69313969";
            cliente5.Correo = "belencita_beni_betan@gmail.com";
            cliente5.Direccion = "Barrio La Nueva";
            cliente5.Sexo = "Mujer";
            agregar(cliente5);

            Cliente cliente6 = new Cliente();
            cliente6.Ci = "99359924";
            cliente6.Nombre = "Matias Mendoza Gutierrez";
            cliente6.Edad = 16;
            cliente6.Telefono = "69248412";
            cliente6.Correo = "maticito@gmail.com";
            cliente6.Direccion = "Barrio El Carmen";
            cliente6.Sexo = "Hombre";
            agregar(cliente6);

            Cliente cliente7 = new Cliente();
            cliente7.Ci = "459249012";
            cliente7.Nombre = "Nicolas Estrada Tarifa";
            cliente7.Edad = 20;
            cliente7.Telefono = "67429412";
            cliente7.Correo = "nico_3str-da@gmail.com";
            cliente7.Direccion = "Barrio Aeropuerto";
            cliente7.Sexo = "Hombre";
            agregar(cliente7);

            Cliente cliente8 = new Cliente();
            cliente8.Ci = "88421420";
            cliente8.Nombre = "Alicia Villanueva";
            cliente8.Edad = 21;
            cliente8.Telefono = "73454040";
            cliente8.Correo = "alicita@gmail.com";
            cliente8.Direccion = "Barrio El Campesino";
            cliente8.Sexo = "Mujer";
            agregar(cliente8);
        }
    }
}
