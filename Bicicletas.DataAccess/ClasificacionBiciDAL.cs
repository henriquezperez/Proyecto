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
    public class ClasificacionBiciDAL : ConexionDAL
    {
        private static ClasificacionBiciDAL _instance;

        public static ClasificacionBiciDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ClasificacionBiciDAL();
                }

                return _instance;
            }


        }
    }
}
