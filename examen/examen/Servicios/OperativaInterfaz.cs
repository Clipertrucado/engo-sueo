using examen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.Servicios
{
    internal interface OperativaInterfaz
    {
        public void nuevoCliente(List<ClienteDto> listaCompleta);

        public void mostrarClientes(List<ClienteDto> listaCompleta);
    }
}
