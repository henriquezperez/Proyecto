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
        public string NombreMarca { get; set; }

        public Marca()
        {

        }

        public Marca(string nombre)
        {
            NombreMarca = nombre;

        }

        public Marca(int marcaId, string nombre)
        {
            MarcaId = marcaId;
            NombreMarca = nombre;

        }
    }
}
