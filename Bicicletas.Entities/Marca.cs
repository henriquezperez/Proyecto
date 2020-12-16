using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string Nombre { get; set; }

        public Marca()
        {

        }

        public Marca(string nombre)
        {
            Nombre = nombre;

        }

        public Marca(int marcaId, string nombre)
        {
            MarcaId = marcaId;
            Nombre = nombre;

        }
    }
}
