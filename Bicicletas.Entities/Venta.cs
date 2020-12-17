using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class Venta
    {
        public int VentaId { get; set; }

        public int BicicletaId { get; set; }

        /*
        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public int DUI { get; set; }
        */

        public int ClienteId { get; set; }

        public DateTime Fecha { get; set; }

        public int PagoId { get; set; }

        public int EstadoId { get; set; }

        /*
        public int GarantiaId { get; set; }

        public int Cantidad { get; set; }

        public decimal Subtotal { get; set; }
        */
        public decimal Total { get; set; }


        public Venta()
        {

        }

        public Venta(DateTime fechaId, int pagoId, int estadoId, int garantiaId, int cantidad, decimal subtotal, decimal total)
        {
            
            Fecha = fechaId;
            PagoId = pagoId;
            EstadoId = estadoId;
            Total = total;
            /*
            GarantiaId = garantiaId;
            Cantidad = cantidad;
            Subtotal = subtotal; */

        }

        public Venta(int bicicletaId, DateTime fechaId, int pagoId, int estadoId, decimal total)
        {
            BicicletaId = bicicletaId;
            
            Fecha = fechaId;
            PagoId = pagoId;
            EstadoId = estadoId;
            Total = total;
        }

    }
}
