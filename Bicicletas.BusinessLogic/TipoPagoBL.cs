using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.DataAccess;
using Bicicletas.Entities;

namespace Bicicletas.BusinessLogic
{
    public class TipoPagoBL
    {
        private static TipoPagoBL _instance;

        public static TipoPagoBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TipoPagoBL();

                return _instance;
            }
        }

        public List<TipoPago> SelectAll()
        {
            return TipoPagoDAL.Instance.SelectAll();
        }

        public bool Insert(TipoPago entity)
        {
            return TipoPagoDAL.Instance.Insert(entity);
        }

        public bool Update(TipoPago entity)
        {
            return TipoPagoDAL.Instance.Update(entity);
        }

        public bool Delete(int id)
        {
            return TipoPagoDAL.Instance.Delete(id);
        }
    }
}
