using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.DataAccess;
using Bicicletas.Entities;

namespace Bicicletas.BusinessLogic
{
    public class TarjetaBL
    {
        private static TarjetaBL _instance;

        public static TarjetaBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TarjetaBL();

                return _instance;
            }
        }

        public List<Tarjeta> SelectAll()
        {
            return TarjetaDAL.Instance.SelectAll();
        }

        public bool Insert(Tarjeta entity)
        {
            return TarjetaDAL.Instance.Insert(entity);
        }

        public bool Update(Tarjeta entity)
        {
            return TarjetaDAL.Instance.Update(entity);
        }

        public bool Delete(int id)
        {
            return TarjetaDAL.Instance.Delete(id);
        }
    }
}
