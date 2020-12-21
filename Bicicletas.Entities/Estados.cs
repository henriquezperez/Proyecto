using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class Estados
    {
        public int EstadoId { get; set; }

        public string NombreEstado { get; set; }

        public Estados()
        {

        }

        public Estados(string nombreEst)
        {
            NombreEstado = nombreEst;
        }

        public Estados(int estadoId, string nombreEst)
        {
            EstadoId = estadoId;
            NombreEstado = nombreEst;
        }
    }
}
