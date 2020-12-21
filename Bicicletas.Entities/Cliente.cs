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

        public string DUI { get; set; }

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

        public Cliente(string nombres, string apellidos, string telefono, string direccion, string correo)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Telefono = telefono;
            Direccion = direccion;
            Correo = correo;

        }
        public Cliente(string dui, string nombres, string apellidos, string telefono, string direccion, string correo)
        {
            DUI = dui;
            Nombres = nombres;
            Apellidos = apellidos;
            Telefono = telefono;
            Direccion = direccion;
            Correo = correo;

        }
    }
}
