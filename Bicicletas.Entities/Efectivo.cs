using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class Efectivo
    {
        public int EfectivoId { get; set; }

        public string Nombre { get; set; }

        public decimal Pago { get; set; }

        public Efectivo()
        {

        }

        public Efectivo(string nombre, decimal pago)
        {
            Nombre = nombre;
            Pago = pago;

        }

        public Efectivo(int efectivoId,string nombre, decimal pago)
        {
            EfectivoId = efectivoId;
            Nombre = nombre;
            Pago = pago;

        }

    }
}
