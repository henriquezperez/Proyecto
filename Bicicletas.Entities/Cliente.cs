using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public int DUI { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string Correo { get; set; }



        /*
         *  ClienteId int identity (1,1) not null primary key,
	 Nombres varchar (67) not null,
	 Apellidos varchar (67) not null,
	 Dui varchar (10) not null,
	 Telefono char (10) not null,
	 Direccion varchar (60) not null,
	 Correo varchar (60) not null
         */

        public Cliente()
        {

        }

        public Cliente(string nombres, string apellidos)
        {
            Nombres = nombres;
            Apellidos = apellidos;

        }
        public Cliente(int dui, string nombres, string apellidos)
        {
            DUI = dui;
            Nombres = nombres;
            Apellidos = apellidos;

        }
    }
}
