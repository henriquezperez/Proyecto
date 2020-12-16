using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class Fecha
    {
        public string FechaId { get; set; }


        public Fecha()
        {

        }

        public Fecha(string fecha)
        {
            FechaId = fecha;
        }
    }
}
