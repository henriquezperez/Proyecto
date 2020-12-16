using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class Venta
    {
        public int BicicletaId { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public int DUI { get; set; }

        public string FechaId { get; set; }

        public int PagoId { get; set; }

        public int EstadoId { get; set; }

        public int GarantiaId { get; set; }

        public int Cantidad { get; set; }

        public decimal Subtotal { get; set; }

        public decimal Total { get; set; }


        public Venta()
        {

        }

        public Venta(string nombres, string apellidos, int dui, string fechaId, int pagoId, int estadoId, int garantiaId, int cantidad, decimal subtotal, decimal total)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            DUI = dui;
            FechaId = fechaId;
            PagoId = pagoId;
            EstadoId = estadoId;
            GarantiaId = garantiaId;
            Cantidad = cantidad;
            Subtotal = subtotal;
            Total = total;

        }

        public Venta(int bicicletaId ,string nombres, string apellidos, int dui, string fechaId, int pagoId, int estadoId, int garantiaId, int cantidad, decimal subtotal, decimal total)
        {
            BicicletaId = bicicletaId;
            Nombres = nombres;
            Apellidos = apellidos;
            DUI = dui;
            FechaId = fechaId;
            PagoId = pagoId;
            EstadoId = estadoId;
            GarantiaId = garantiaId;
            Cantidad = cantidad;
            Subtotal = subtotal;
            Total = total;
        }

    }
}
