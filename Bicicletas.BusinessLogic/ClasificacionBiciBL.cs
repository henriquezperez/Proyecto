using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.DataAccess;
using Bicicletas.Entities;

namespace Bicicletas.BusinessLogic
{
    public class ClasificacionBiciBL
    {
        private static ClasificacionBiciBL _instance;

        public static ClasificacionBiciBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClasificacionBiciBL();

                return _instance;
            }
        }

        public List<ClasificacionBici> SelectAll()
        {
            return ClasificacionBiciDAL.Instance.SelectAll();
        }

        public bool Insert(ClasificacionBici entity)
        {
            return ClasificacionBiciDAL.Instance.Insert(entity);
        }

        public bool Update(ClasificacionBici entity)
        {
            return ClasificacionBiciDAL.Instance.Update(entity);
        }

        public bool Delete(int id)
        {
            return ClasificacionBiciDAL.Instance.Delete(id);
        }
    }
}
