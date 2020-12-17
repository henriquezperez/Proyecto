using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class Color
    {
        public int ColorId { get; set; }
        public string NombreColor { get; set; }

        public Color()
        {

        }

        public Color(string nombre)
        {
            NombreColor = nombre;

        }

        public Color(int colorId, string nombre)
        {
            ColorId = colorId;

            NombreColor = nombre;

        }
    }
}
