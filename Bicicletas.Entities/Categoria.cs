using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string NombreCategoria { get; set; }

        public int ClasificacionBiciId { get; set; }


        public Categoria()
        {

        }

        public Categoria(string nombreCategoria, int clasificacionId)
        {
            NombreCategoria = nombreCategoria;
            ClasificacionBiciId = clasificacionId;
        }
      
        public Categoria(int categoriaId, string nombreCategoria, int clasificacionId)
        {
            CategoriaId = categoriaId;
            NombreCategoria = nombreCategoria;
            ClasificacionBiciId = clasificacionId;
        }
    }
}
