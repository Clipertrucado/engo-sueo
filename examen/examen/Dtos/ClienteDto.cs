using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.Dtos
{
    internal class ClienteDto
    {
        int idCliente;
        string nombreCliente = "aaaaa";
        string apellidoCliente = "aaaaa";
        DateTime feNaCliente;
        int anyosClienete = 99999;
        int mesesCliente = 99999;
        int diasCliente = 99999;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public DateTime FeNaCliente { get => feNaCliente; set => feNaCliente = value; }
        public int AnyosClienete { get => anyosClienete; set => anyosClienete = value; }
        public int MesesCliente { get => mesesCliente; set => mesesCliente = value; }
        public int DiasCliente { get => diasCliente; set => diasCliente = value; }

        public ClienteDto(int idCliente, string nombreCliente, string apellidoCliente, DateTime feNaCliente, int anyosClienete, int mesesCliente, int diasCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.feNaCliente = feNaCliente;
            this.anyosClienete = anyosClienete;
            this.mesesCliente = mesesCliente;
            this.diasCliente = diasCliente;
        }

        public ClienteDto()
        {
        }

        override
        public String ToString(){

            return "id: " + idCliente + " Nombbre: " + nombreCliente + " Apellido: " + apellidoCliente + " Fecha nacimiento: " + feNaCliente.ToString() + " Años: " + anyosClienete + " Meses: " + mesesCliente + " Dias: " + diasCliente;
        }
    }
}
