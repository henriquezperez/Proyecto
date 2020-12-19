using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.Entities;

namespace Bicicletas.DataAccess
{
    public class GarantiaDAL : ConexionDAL
    {

        private static GarantiaDAL _instance;

        public static GarantiaDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GarantiaDAL();
                }

                return _instance;
            }


        }
    }
}
