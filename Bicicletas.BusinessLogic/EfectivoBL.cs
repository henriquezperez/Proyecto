using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.DataAccess;
using Bicicletas.Entities;

namespace Bicicletas.BusinessLogic
{
    public class EfectivoBL
    {
        private static EfectivoBL _instance;

        public static EfectivoBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EfectivoBL();

                return _instance;
            }
        }

        public List<Efectivo> SelectAll()
        {
            return EfectivoDAL.Instance.SelectAll();
        }

        public bool Insert(Efectivo entity)
        {
            return EfectivoDAL.Instance.Insert(entity);
        }

        public bool Update(Efectivo entity)
        {
            return EfectivoDAL.Instance.Update(entity);
        }

        public bool Delete(int id)
        {
            return EfectivoDAL.Instance.Delete(id);
        }
    }
}
