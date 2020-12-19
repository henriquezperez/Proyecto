using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bicicletas.DataAccess
{
    public class DetalleVentaDAL : ConexionDAL
    {
        private static DetalleVentaDAL _instance;

        public static DetalleVentaDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DetalleVentaDAL();
                }

                return _instance;
            }


        }
    }
}
