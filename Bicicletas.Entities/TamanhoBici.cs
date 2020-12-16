using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.Entities
{
    public class TamanhoBici
    {
        public int TamanhoId { get; set; }
        public string NombreTamanho { get; set; }

        public TamanhoBici()
        {

        }
        public TamanhoBici(string nombreTamanho)
        {
            NombreTamanho = nombreTamanho;
        }
        public TamanhoBici(int tamanhoId, string nombreTamanho)
        {
            TamanhoId = tamanhoId;
            NombreTamanho = nombreTamanho;
        }
    }
}
