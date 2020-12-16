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
    public class ColorDAL:Conexion
    {

        private static ColorDAL _instance;

        public static ColorDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ColorDAL();
                }
                return _instance;
            }


        }

        public List<Color> SelectAll()
        {
            List<Color> result = new List<Color>();

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_ColorSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            Color entity = null;
                            while (dr.Read())
                            {
                                entity = new Color()
                                {
                                    ColorId = dr.GetInt32(0),
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

        public bool Insert(Color entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_ColorInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ColorId", entity.ColorId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }

            }

            return result;
        }


        public bool Update(Color entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_ColorUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ColorId", entity.ColorId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);

                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }
        public Color SelectAllById(int id)
        {
            Color result = new Color();

            using (SqlConnection con = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_ColorSelectById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ColorId", id);
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr.HasRows)
                        {
                            result = new Color()
                            {
                                ColorId = dr.GetInt32(0),
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
                using (SqlCommand cmd = new SqlCommand("Sp_ColorDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ColorId", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

    }
}
