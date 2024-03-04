using examen.Dtos;
using examen.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.Controladores
{
    internal class Program
    {
        public static void Main() { 
            string rutaFichero = "C:\\Users\\cliper\\source\\repos\\examen\\examen\\Ficheros\\fichero.txt";

            using (StreamWriter sw = new StreamWriter(rutaFichero)) 
            {
                sw.WriteLine("Se inicio la aplicacion" + DateTime.Now);
            }

            

            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperaticaImplementacion();
            List<ClienteDto> clientesDtos = new List<ClienteDto>();

            

            bool cerrar = true;

            while (cerrar)
            {
                int seleccion = mi.menuSeleccion();
                using (StreamWriter sw = new StreamWriter(rutaFichero, true))
                {
                    sw.WriteLine("Se mostro el menu" + DateTime.Now);
                }
                switch (seleccion)
                {
                    case 0:
                        cerrar = false;
                        
                        Console.WriteLine("0. cerrar");
                        break;

                    case 1:
                        Console.WriteLine("1. Dar de alta cliente");
                        oi.nuevoCliente(clientesDtos);
                        break;

                    case 2:
                        Console.WriteLine("2. Mostrar clientes");
                        oi.mostrarClientes(clientesDtos);
                        using (StreamWriter sw = new StreamWriter(rutaFichero, true))
                        {
                            sw.WriteLine("Se mostraron los clientes: " + DateTime.Now);
                        }
                        break; 

                    case 3:
                        using (StreamReader sr = new StreamReader(rutaFichero))
                        {
                            string contenido = sr.ReadToEnd();
                            Console.WriteLine("Contenido del archivo:\n" + contenido);
                        }
                        break;
                }
            }






            using (StreamWriter sw = new StreamWriter(rutaFichero, true))
            {
                sw.WriteLine("Se cerro la aplicacion" + DateTime.Now);
            }
        }
    }
}
