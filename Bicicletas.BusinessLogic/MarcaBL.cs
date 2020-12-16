using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.DataAccess;
using Bicicletas.Entities;

namespace Bicicletas.BusinessLogic
{
    public class MarcaBL
    {
        private static MarcaBL _instance;

        public static MarcaBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MarcaBL();

                return _instance;
            }
        }

        public List<Marca> SelectAll()
        {
            return MarcaDAL.Instance.SelectAll();
        }

        public bool Insert(Marca entity)
        {
            return MarcaDAL.Instance.Insert(entity);
        }

        public bool Update(Marca entity)
        {
            return MarcaDAL.Instance.Update(entity);
        }

        public bool Delete(int id)
        {
            return MarcaDAL.Instance.Delete(id);
        }
    }
}
