using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.Entities;
using Bicicletas.DataAccess;

namespace Bicicletas.BusinessLogic
{
    public class AdultoBiciBL
    {
        private static AdultoBiciBL _instance;

        public static AdultoBiciBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdultoBiciBL();

                return _instance;
            }
        }

        public List<AdultoBici> SelectAll()
        {
            return AdultoBiciDAL.Instance.SelectAll();
        }

        public bool Insert(AdultoBici entity)
        {
            return AdultoBiciDAL.Instance.Insert(entity);
        }

        public bool Update(AdultoBici entity)
        {
            return AdultoBiciDAL.Instance.Update(entity);
        }

        public bool Delete(int id)
        {
            return AdultoBiciDAL.Instance.Delete(id);
        }
    }
}
