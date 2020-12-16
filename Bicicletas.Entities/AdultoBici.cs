using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class AdultoBici
    {
        public int AdulTipoId { get; set; }

        public string Nombre { get; set; }

        public AdultoBici()
        {

        }

        public AdultoBici(string nombre)
        {
            Nombre = nombre;
        }

        public AdultoBici(int tipoId, string nombre)
        {
            AdulTipoId = tipoId;
            Nombre = nombre;
        }
    }
}
