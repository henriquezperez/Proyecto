using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class DetalleVenta
    {
        public int  DellVentaId { get; set; }

        public int VentaId { get; set; }

        public int BicicletaId { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public decimal Total { get; set; }


        public DetalleVenta ()
        {

        }

        public DetalleVenta(int ventaId, int bicicletaId, int cantidad, decimal precio, decimal total)
        {
            VentaId = ventaId;
            BicicletaId = bicicletaId;
            Cantidad = cantidad;
            Precio = precio;
            Total = total;

        }
        public DetalleVenta(int detalleVentaId, int ventaId, int bicicletaId, int cantidad, decimal precio, decimal total)
        {
            DellVentaId = detalleVentaId;
            VentaId = ventaId;
            BicicletaId = bicicletaId;
            Cantidad = cantidad;
            Precio = precio;
            Total = total;

        }
    }
}
