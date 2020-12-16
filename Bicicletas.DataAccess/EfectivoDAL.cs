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
    public class EfectivoDAL:Conexion
    {
        private static EfectivoDAL _instance;

        public static EfectivoDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EfectivoDAL();
                }

                return _instance;
            }


        }
        public List<Efectivo> SelectAll()
        {
            List<Efectivo> result = new List<Efectivo>();

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_EfectivoSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            Efectivo entity = null;
                            while (dr.Read())
                            {
                                entity = new Efectivo()
                                {
                                    EfectivoId = dr.GetInt32(0),
                                    Nombre = dr.GetString(1),
                                    Pago = dr.GetDecimal(2),
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public bool Insert(Efectivo entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_EfectivoInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EfectivoId", entity.EfectivoId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Pago", entity.Pago);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }

            }

            return result;
        }


        public bool Update(Efectivo entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_EfectivoUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EfectivoId", entity.EfectivoId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Pago", entity.Pago);

                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }
        public Efectivo SelectAllById(int id)
        {
            Efectivo result = new Efectivo();

            using (SqlConnection con = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_EfectivoSelectById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EfectivoId", id);
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr.HasRows)
                        {
                            result = new Efectivo()
                            {
                                EfectivoId = dr.GetInt32(0),
                                Nombre = dr.GetString(1),
                                Pago = dr.GetDecimal(2),
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
                using (SqlCommand cmd = new SqlCommand("Sp_EfectivoDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EfectivoId", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

    }
}
