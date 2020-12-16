using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class RecargoTarjeta
    {
        public int TarjetaId { get; set; }

        public string Nombre { get; set; }

        public int PorcenGanancia { get; set; }

        public RecargoTarjeta()
        {

        }

        public RecargoTarjeta(string nombre, int porcGanancia)
        {
            Nombre = nombre;
            PorcenGanancia = porcGanancia;

        }

        public RecargoTarjeta(int tarjetaId ,string nombre, int porcGanancia)
        {
            TarjetaId = tarjetaId;
            Nombre = nombre;
            PorcenGanancia = porcGanancia;
        }
    }
}
