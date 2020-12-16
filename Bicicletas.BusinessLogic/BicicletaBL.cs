using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.Entities;
using Bicicletas.DataAccess;

namespace Bicicletas.BusinessLogic
{
    public class BicicletaBL
    {
        private static BicicletaBL _instance;

        public static BicicletaBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BicicletaBL();

                return _instance;
            }
        }

        public List<Bicicleta> SelectAll()
        {
            return BicicletaDAL.Instance.SelectAll();
        }

        public bool Insert(Bicicleta entity)
        {
            return BicicletaDAL.Instance.Insert(entity);
        }

        public bool Update(Bicicleta entity)
        {
            return BicicletaDAL.Instance.Update(entity);
        }

        public bool Delete(int id)
        {
            return BicicletaDAL.Instance.Delete(id);
        }
    }
}
