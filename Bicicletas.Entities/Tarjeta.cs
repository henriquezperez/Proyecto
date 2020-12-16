using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class Tarjeta
    {
        public int TarjetaId { get; set; }

        public decimal Pago { get; set; }

        public int PorcenRecargo { get; set; }

        public Tarjeta()
        {

        }

        public Tarjeta(decimal pago, int porcRecargo)
        {
            Pago = pago;
            PorcenRecargo = porcRecargo;

        }

        public Tarjeta(int tarjetaId,decimal pago, int porcRecargo)
        {
            TarjetaId = tarjetaId;
            Pago = pago;
            PorcenRecargo = porcRecargo;
        }
    }

}
