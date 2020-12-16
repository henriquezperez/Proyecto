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

        public string Nombre { get; set; }

        public Estados()
        {

        }

        public Estados(string nombreEst)
        {
            Nombre = nombreEst;
        }

        public Estados(int estadoId, string nombreEst)
        {
            EstadoId = estadoId;
            Nombre = nombreEst;
        }
    }
}
