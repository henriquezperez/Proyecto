using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class DetalleVenta
    {
        public int  DellVeentaId { get; set; }

        public int VentaId { get; set; }

        public int BicicletaId { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public decimal Total { get; set; }

    }
}
