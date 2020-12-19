using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.Entities;
using Bicicletas.DataAccess;

namespace Bicicletas.BusinessLogic
{
    public class EstadoBL
    {
        private static EstadoBL _instance;

        public static EstadoBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EstadoBL();

                return _instance;
            }
        }

        public List<Estados> SelectAll()
        {
            return EstadosDAL.Instance.SelectAll();
        }

        public Estados SelectById(int id)
        {
            return EstadosDAL.Instance.SelectById(id);
        }

        public bool Insert(Estados entity)
        {
            return EstadosDAL.Instance.Insert(entity);
        }

        public bool Update(Estados entity)
        {
            return EstadosDAL.Instance.Update(entity);
        }

        public bool Delete(int id)
        {
            return EstadosDAL.Instance.Delete(id);
        }
    }
}
