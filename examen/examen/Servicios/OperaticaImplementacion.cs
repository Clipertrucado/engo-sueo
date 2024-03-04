using examen.Dtos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace examen.Servicios
{
    internal class OperaticaImplementacion : OperativaInterfaz
    {
        public void nuevoCliente(List<ClienteDto> listaCompleta)
        {
            listaCompleta.Add(crearCliente(listaCompleta));


        }

        private ClienteDto crearCliente(List<ClienteDto> listaCompleta)
        {
            ClienteDto cliente = new ClienteDto();

            Console.WriteLine("Nombre del cliente");
            cliente.NombreCliente = Console.ReadLine();

            Console.WriteLine("Apellido del cliente");
            cliente.ApellidoCliente = Console.ReadLine();

            
            Console.WriteLine("Fecha de nacimiento del cliente");
            CultureInfo cultura = new CultureInfo("es-SP");

            DateTimeFormatInfo infoFormatoCulturaEspecifica = CultureInfo.GetCultureInfo("es-SP").DateTimeFormat;
            Type tipo = infoFormatoCulturaEspecifica.GetType();
            PropertyInfo[] propiedadesFormatos = tipo.GetProperties();
            DateTime fecha = DateTime.Today;
            foreach (var propiedad in propiedadesFormatos)
            {
                // Is this a format pattern-related property?
                if (propiedad.Name.Contains("Pattern"))
                {
                    string formato = propiedad.GetValue(infoFormatoCulturaEspecifica, null).ToString();
                    Console.WriteLine(propiedad.Name + ": " + formato + " " +
                                      fecha.ToString(formato));
                }
            }
            DateTime fechaNaci = Convert.ToDateTime(Console.ReadLine(), cultura);//20/04/2004
            cliente.FeNaCliente = fechaNaci;

            int[] edad = new int[3];

            edad = calcularEdad(fecha);

            cliente.DiasCliente = edad[0];

            cliente.MesesCliente = edad[1];

            cliente.AnyosClienete = edad[2];

            cliente.IdCliente = calcularId(listaCompleta);
            Console.WriteLine(cliente.ToString());
            

            return cliente;
        }

        private int[] calcularEdad(DateTime fecha)
        {
            int[] edad = new int[3];
            TimeSpan diferencia = DateTime.Now - fecha;

            double todoEnDias = diferencia.TotalDays;
            int soloDias = Convert.ToInt32(todoEnDias);

            int dias = soloDias % 30;

            int restoEnMeses = Convert.ToInt32(soloDias / 30);

            int meses = Convert.ToInt32(restoEnMeses % 12);

            int anyos = restoEnMeses / 12;

            edad[0] = dias;
            edad[1] = meses;
            edad[2] = anyos;

           
            return edad;
        }

        private int calcularId(List<ClienteDto> listaCompleta) {

            int id = 0;

            for (int i = 0; i < 100; i++) {
                foreach (var cliente in listaCompleta) {

                    if (i == cliente.IdCliente) {

                    }
                    else { 
                        id = i;
                        i = 100;
                        break;
                    }
                
                }
            
            }

            Console.WriteLine("el id seleccionado es:" + id);
            return id; 
        }

        public void mostrarClientes(List<ClienteDto> listaCompleta)
        {
            foreach (ClienteDto cliente in listaCompleta) {
                Console.WriteLine(cliente.ToString());
            }
        }
    }
}
