using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class NinhoBici
    {
        public int NinhoTipoId { get; set; }

        public string Nombre { get; set; }

        public NinhoBici()
        {

        }

        public NinhoBici(string nombre)
        {
            Nombre = nombre;
        }

        public NinhoBici(int tipoId, string nombre)
        {
            NinhoTipoId = tipoId;

            Nombre = nombre;
        }

    }
}
