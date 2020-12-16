using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicletas.Entities;

namespace Bicicletas.DataAccess
{
    public class NinhoBiciDAL:Conexion
    {

        private static NinhoBiciDAL _instance;

        public static NinhoBiciDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NinhoBiciDAL();
                }

                return _instance;
            }


        }

        public List<NinhoBici> SelectAll()
        {
            List<NinhoBici> _listado = new List<NinhoBici>();

            
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_NinhoBiciSelectAll", conn))
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                NinhoBici entity = new NinhoBici();
                                entity.NinhoTipoId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                _listado.Add(entity);
                            }
                        }
                    }
                }
            }
            return _listado;
        }


        public NinhoBici SelectById(int id)
        {
            NinhoBici result = null;

                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_NinhoBiciSelectById", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MarcaId", id);
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    NinhoBici entity = new NinhoBici();
                                    entity.NinhoTipoId = dr.GetInt32(0);
                                    entity.Nombre = dr.GetString(1);
                                }
                            }
                        }
                    }
                }

            return result;
        }



        public bool Insert(NinhoBici entity)
        {
            bool result = false;

                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_NinhoBiciInsert", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);

                        conn.Open();

                        result = cmd.ExecuteNonQuery() > 0;
                    }
                }
            return result;
        }


        public bool Update(NinhoBici entity)
        {
            bool result = false;

                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_NinhoBiciUpdate", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NinhoTipoId", entity.NinhoTipoId);
                        cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);

                        conn.Open();

                        result = cmd.ExecuteNonQuery() > 0;
                    }
                }
            
            return result;
        }


        public bool Delete(int id)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_NinhoBiciDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NinhoTipoId", id);
                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

    }

   
}
