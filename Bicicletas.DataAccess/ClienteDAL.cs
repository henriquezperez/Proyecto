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
    public class ClienteDAL : Conexion
    {
        private static ClienteDAL _instance;

        public static ClienteDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ClienteDAL();
                }

                return _instance;
            }

        }

        public List<Cliente> SelectAll()
        {
            List<Cliente> result = new List<Cliente>();

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ClientesSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            Cliente entity = null;
                            while (dr.Read())
                            {
                                entity = new Cliente()
                                {
                                    DUI = dr.GetInt32(0),
                                    Nombres = dr.GetString(1),
                                    Apellidos = dr.GetString(2),
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public bool Insert(Cliente entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ClientesInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DUI", entity.DUI);
                    cmd.Parameters.AddWithValue("@Nombres", entity.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", entity.Apellidos);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }

            }

            return result;
        }


        public bool Update(Cliente entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ClienteUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DUI", entity.DUI);
                    cmd.Parameters.AddWithValue("@Nombres", entity.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", entity.Apellidos);

                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }
        public Cliente SelectAllById(int id)
        {
            Cliente result = new Cliente();

            using (SqlConnection con = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_ClienteSelectById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClienteId", id);
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr.HasRows)
                        {
                            result = new Cliente()
                            {
                               
                            };

                        }
                    }
                }

            }
            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;

            using (SqlConnection con = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_ClienteDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClienteId", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

    }
}
