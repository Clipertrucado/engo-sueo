using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuSeleccion()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("        MENU");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Dar de alta cliente");
            Console.WriteLine("2. Mostrar clientes");
            Console.WriteLine("3. Ordenar clientes");
            Console.WriteLine("0. cerrar");
            Console.WriteLine("----------------------");




            int selecion =  Convert.ToInt32(Console.ReadLine());
            return selecion;
        }
    }
}
