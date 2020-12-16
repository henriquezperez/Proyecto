using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.Entities;
using Bicicletas.DataAccess;

namespace Bicicletas.BusinessLogic
{
    public class TamanhoBiciBL
    {
        private static TamanhoBiciBL _instance;

        public static TamanhoBiciBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TamanhoBiciBL();

                return _instance;
            }
        }

        public List<TamanhoBici> SelectAll()
        {
            return TamahoBiciDAL.Instance.SelectAll();
        }

        public bool Insert(TamanhoBici entity)
        {
            return TamahoBiciDAL.Instance.Insert(entity);
        }

        public bool Update(TamanhoBici entity)
        {
            return TamahoBiciDAL.Instance.Update(entity);
        }

        public bool Delete(int id)
        {
            return TamahoBiciDAL.Instance.Delete(id);
        }
    }
}
