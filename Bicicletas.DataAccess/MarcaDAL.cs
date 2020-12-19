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
    public class MarcaDAL : ConexionDAL
    {
        private static MarcaDAL _instance;

        public static MarcaDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MarcaDAL();
                }

                return _instance;
            }



        }

        public List<Marca> SelectAll()
        {
            List<Marca> _listado = new List<Marca>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_MarcaSelectAll", conn))
                    {
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    Marca entity = new Marca();
                                    entity.MarcaId = dr.GetInt32(0);
                                    entity.NombreMarca = dr.GetString(1);
                                    _listado.Add(entity);
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                _listado = null;
            }


            return _listado;
        }


        public Marca SelectById(int id)
        {
            Marca result = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_MarcaSelectById", conn))
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
                                    Marca entity = new Marca();
                                    entity.MarcaId = dr.GetInt32(0);
                                    entity.NombreMarca = dr.GetString(1);
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                result = null;
            }

            return result;
        }



        public bool Insert(Marca entity)
        {
            bool result = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_MarcaInsert", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", entity.NombreMarca);

                        conn.Open();

                        result = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                result = false;
            }

            return result;
        }


        public bool Update(Marca entity)
        {
            bool result = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_MarcaUpdate", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MarcaId", entity.MarcaId);
                        cmd.Parameters.AddWithValue("@Nombre", entity.NombreMarca);

                        conn.Open();

                        result = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                result = false;
            }

            return result;
        }


        public bool Delete(int id)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_MarcaDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MarcaId", id);
                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
             return result;
        }
    }
}
