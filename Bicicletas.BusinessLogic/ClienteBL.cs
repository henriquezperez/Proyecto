using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.DataAccess;
using Bicicletas.Entities;

namespace Bicicletas.BusinessLogic
{
    public class ClienteBL
    {
        private static ClienteBL _instance;

        public static ClienteBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClienteBL();

                return _instance;
            }
        }

        public List<Cliente> SelectAll()
        {
            return ClienteDAL.Instance.SelectAll();
        }

        public bool Insert(Cliente entity)
        {
            return ClienteDAL.Instance.Insert(entity);
        }

        public bool Update(Cliente entity)
        {
            return ClienteDAL.Instance.Update(entity);
        }

        public bool Delete(int id)
        {
            return ClienteDAL.Instance.Delete(id);
        }
    }
}
