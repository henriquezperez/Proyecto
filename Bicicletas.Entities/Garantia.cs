using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class Garantia
    {
       public int GarantiaId { get; set; }

       public string Nombre { get; set; }

        public int TiempoGarantia { get; set; }

        public Garantia()
        {

        }

        public Garantia(string nombreGarantia, int tiempoGarantia)
        {
            Nombre = nombreGarantia;
            TiempoGarantia = tiempoGarantia;

        }
        public Garantia(int garantiaId, string nombreGarantia, int tiempoGarantia)
        {
            GarantiaId = garantiaId;
            Nombre = nombreGarantia;
            TiempoGarantia = tiempoGarantia;
        }
    }
}
