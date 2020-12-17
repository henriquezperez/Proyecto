using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas.DataAccess
{
    public class DetalleVentaDAL
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
