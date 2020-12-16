using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class TiempoGarantia
    {
        public int GarantiaId { get; set; }

        public string Nombre { get; set; }

        public int TiempoMeses { get; set; }
        
        public TiempoGarantia()
        {

        }

        public TiempoGarantia(string nombre, int tiempoMes)
        {
            Nombre = nombre;

            TiempoMeses = tiempoMes;
        }

        public TiempoGarantia(int garantiaId, string nombre, int tiempoMes)
        {
            GarantiaId = garantiaId;

            Nombre = nombre;

            TiempoMeses = tiempoMes;

        }

    }
}
