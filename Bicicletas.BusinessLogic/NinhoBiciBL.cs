using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.Entities;
using Bicicletas.DataAccess;

namespace Bicicletas.BusinessLogic
{
    public class NinhoBiciBL
    {
        private static NinhoBiciBL _instance;

        public static NinhoBiciBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NinhoBiciBL();

                return _instance;
            }
        }

        public List<NinhoBici> SelectAll()
        {
            return NinhoBiciDAL.Instance.SelectAll();
        }

        public bool Insert(NinhoBici entity)
        {
            return NinhoBiciDAL.Instance.Insert(entity);
        }

        public bool Update(NinhoBici entity)
        {
            return NinhoBiciDAL.Instance.Update(entity);
        }

        public bool Delete(int id)
        {
            return NinhoBiciDAL.Instance.Delete(id);
        }
    }
}
