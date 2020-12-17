using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class TipoPago
    {
        public int PagoId { set; get; }

        public string Nombre { get; set; }

        public decimal EfectivoCant { get; set; }


        public TipoPago()
        {

        }

        public TipoPago(string nombre)
        {
            Nombre = nombre;
        }

        public TipoPago(int pagoId, string nombre, decimal efectivoCant)
        {
            PagoId = pagoId;
            Nombre = nombre;
            EfectivoCant = efectivoCant;

        }
    }
}
