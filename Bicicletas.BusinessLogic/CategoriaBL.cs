using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.DataAccess;
using Bicicletas.Entities;

namespace Bicicletas.BusinessLogic
{
    public class CategoriaBL
    {
        private static CategoriaBL _instance;

        public static CategoriaBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CategoriaBL();

                return _instance;
            }
        }

        public List<Categoria> SelectAll()
        {
            return CategoriaDAL.Instance.SelectAll();
        }

        public bool Insert(Categoria entity)
        {
            return CategoriaDAL.Instance.Insert(entity);
        }

        public bool Update(Categoria entity)
        {
            return CategoriaDAL.Instance.Update(entity);
        }

        public bool Delete(int id)
        {
            return CategoriaDAL.Instance.Delete(id);
        }
    }
}
