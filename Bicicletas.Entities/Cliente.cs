using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class Cliente
    {
        public int DUI { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

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
