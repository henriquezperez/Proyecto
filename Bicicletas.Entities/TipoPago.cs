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

        public int EfectivoId { get; set; }

        public int TarjetaId { get; set; }

        public TipoPago()
        {

        }

        public TipoPago(string nombre)
        {
            Nombre = nombre;
        }

        public TipoPago(int pagoId, string nombre)
        {
            PagoId = pagoId;
            Nombre = nombre;

        }
    }
}
