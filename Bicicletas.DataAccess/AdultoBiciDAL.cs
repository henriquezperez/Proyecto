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
    public class AdultoBiciDAL : Conexion
    {
        private static AdultoBiciDAL _instance;

        public static AdultoBiciDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AdultoBiciDAL();
                }

                return _instance;
            }

        }

        public List<AdultoBici> SelectAll()
        {
            List<AdultoBici> result = new List<AdultoBici>();

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_AdultoBiciSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            AdultoBici entity = null;
                            while (dr.Read())
                            {
                                entity = new AdultoBici()
                                {
                                    AdulTipoId = dr.GetInt32(0),
                                    Nombre = dr.GetString(1),
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public bool Insert(AdultoBici entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_AdultoBiciInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AdulTipoId", entity.AdulTipoId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);                  

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }

            }

            return result;
        }


        public bool Update(AdultoBici entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_AdultoBiciUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AdulTipoId", entity.AdulTipoId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);

                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }
        public AdultoBici SelectAllById(int id)
        {
            AdultoBici result = new AdultoBici();

            using (SqlConnection con = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_AdultoBiciSelectById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DoctorId", id);
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr.HasRows)
                        {
                            result = new AdultoBici()
                            {
                                AdulTipoId = dr.GetInt32(0),
                                Nombre = dr.GetString(1),
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
                using (SqlCommand cmd = new SqlCommand("Sp_AdultoBiciDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AdulTipoId", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

    }
}
