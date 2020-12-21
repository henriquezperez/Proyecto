using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class ClasificacionBici
    {
        public int ClasificacionBiciId { get; set; }

        public string NombreClasificacion { get; set; }

        public int TamanhoId { get; set; }

        public ClasificacionBici ()
        {


        }
        public ClasificacionBici(string nombre, int tamanho)
        {
            NombreClasificacion = nombre;


        }
        public ClasificacionBici(int clasificacion, string nombre, int tamanho)
        {
            ClasificacionBiciId = clasificacion;
            NombreClasificacion = nombre;
            TamanhoId = tamanho;
        }



    }
}
