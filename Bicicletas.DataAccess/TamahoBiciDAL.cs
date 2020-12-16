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
    public class TamahoBiciDAL:Conexion
    {
        private static TamahoBiciDAL _instance;

        public static TamahoBiciDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TamahoBiciDAL();
                }

                return _instance;
            }


        }


        public List<TamanhoBici> SelectAll()
        {
            List<TamanhoBici> _listado = new List<TamanhoBici>();


            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TamanhoBiciSelectAll", conn))
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                TamanhoBici entity = new TamanhoBici();
                                entity.TamanhoId = dr.GetInt32(0);
                                entity.NombreTamanho = dr.GetString(1);
                                _listado.Add(entity);
                            }
                        }
                    }
                }
            }

            return _listado;
        }


        public TamanhoBici SelectById(int id)
        {
            TamanhoBici result = null;

                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_TamanhoBiciSelectById", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TamanhoId", id);
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    TamanhoBici entity = new TamanhoBici();
                                    entity.TamanhoId = dr.GetInt32(0);
                                    entity.NombreTamanho = dr.GetString(1);
                                }
                            }
                        }
                    }
                }

            return result;
        }



        public bool Insert(TamanhoBici entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TamanhoBiciInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreTamanho", entity.NombreTamanho);

                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }


        public bool Update(TamanhoBici entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TamanhoBiciUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TamanhoId ", entity.TamanhoId);
                    cmd.Parameters.AddWithValue("@NombreTamanho", entity.NombreTamanho);

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
                using (SqlCommand cmd = new SqlCommand("sp_TamanhoBiciDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TamanhoId ", id);
                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

    }
}
