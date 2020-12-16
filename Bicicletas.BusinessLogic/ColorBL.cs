using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.Entities;
using Bicicletas.DataAccess;

namespace Bicicletas.BusinessLogic
{
    public class ColorBL
    {
        private static ColorBL _instance;

        public static ColorBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ColorBL();

                return _instance;
            }
        }

        public List<Color> SelectAll()
        {
            return ColorDAL.Instance.SelectAll();
        }

        public bool Insert(Color entity)
        {
            return ColorDAL.Instance.Insert(entity);
        }

        public bool Update(Color entity)
        {
            return ColorDAL.Instance.Update(entity);
        }

        public bool Delete(int id)
        {
            return ColorDAL.Instance.Delete(id);
        }
    }
}
