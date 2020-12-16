using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.Entities;
using Bicicletas.DataAccess;

namespace Bicicletas.BusinessLogic
{
    public class VentasBL
    {
        private static VentasBL _instance;

        public static VentasBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VentasBL();

                return _instance;
            }
        }

        public List<Venta> SelectAll()
        {
            return VentaDAL.Instance.SelectAll();
        }

        public bool Insert(Venta entity)
        {
            return VentaDAL.Instance.Insert(entity);
        }

        public bool Update(Venta entity)
        {
            return VentaDAL.Instance.Update(entity);
        }

        public bool Delete(int id)
        {
            return VentaDAL.Instance.Delete(id);
        }
    }
}
