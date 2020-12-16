using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class Bicicleta
    {
        public int BicicletaId { get; set; }

        public int ThamanhoId { get; set; }

        public int CategoriaId { get; set; }

        public int MarcaId { get; set; }

        public int GarantiaId { get; set; }

        public int ColorId { get; set; }

        public decimal Precio { get; set; }


        public Bicicleta()
        {

        }

        public Bicicleta(int tamanhoId, int categoriaId, int marcaId, int garantiaId, int colorId, decimal precio)
        {
            ThamanhoId = tamanhoId;
            CategoriaId = categoriaId;
            MarcaId = marcaId;
            GarantiaId = garantiaId;
            ColorId = colorId;
            Precio = precio;

        }

        public Bicicleta(int bicicletaId ,int tamanhoId, int categoriaId, int marcaId, int garantiaId, int colorId, decimal precio)
        {
            BicicletaId = bicicletaId;
            ThamanhoId = tamanhoId;
            CategoriaId = categoriaId;
            MarcaId = marcaId;
            GarantiaId = garantiaId;
            ColorId = colorId;
            Precio = precio;

        }
    }
}
