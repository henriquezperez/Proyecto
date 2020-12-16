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

        public string Nombre { get; set; }

        public int NinhoTipoId { get; set; }

        public int AdulTipoId { get; set; }

        public Categoria()
        {

        }

        public Categoria(string nombreCategoria, int ninhoId)
        {
            Nombre = nombreCategoria;

            NinhoTipoId = ninhoId;
        }
        /*
        public Categoria(string nombreCategoria, int adultId)
        {
            NombreCategoria = nombreCategori;
            AdulTipoId = adultId;
        }
        */
        public Categoria(int categoriaId, string nombreCategoria)
        {
            CategoriaId = categoriaId;
            Nombre = nombreCategoria;
        }
    }
}
