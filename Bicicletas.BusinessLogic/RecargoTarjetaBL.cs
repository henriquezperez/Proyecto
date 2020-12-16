using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.DataAccess;
using Bicicletas.Entities;

namespace Bicicletas.BusinessLogic
{
    public class RecargoTarjetaBL
    {
        private static RecargoTarjetaBL _instance;

        public static RecargoTarjetaBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RecargoTarjetaBL();

                return _instance;
            }
        }

        public List<RecargoTarjeta> SelectAll()
        {
            return RecargoTarjetaDAL.Instance.SelectAll();
        }

        public bool Insert(RecargoTarjeta entity)
        {
            return RecargoTarjetaDAL.Instance.Insert(entity);
        }

        public bool Update(RecargoTarjeta entity)
        {
            return RecargoTarjetaDAL.Instance.Update(entity);
        }

        public bool Delete(int id)
        {
            return RecargoTarjetaDAL.Instance.Delete(id);
        }
    }
}
