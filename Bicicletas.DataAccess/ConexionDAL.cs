using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Bicicletas.DataAccess
{
    public class ConexionDAL
    {
        protected string _cadena =
       ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
    }
}
