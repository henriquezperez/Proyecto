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
    public class CategoriaDAL : ConexionDAL
    {
        private static CategoriaDAL _instance;

        public static CategoriaDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CategoriaDAL();
                }

                return _instance;
            }


        }

        public List<Categoria> SelectAll()
        {
            List<Categoria> _listado = new List<Categoria>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CategoriaSelectAll", conn))
                    {
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    Categoria entity = new Categoria();
                                    entity.CategoriaId = dr.GetInt32(0);
                                    entity.NombreCategoria = dr.GetString(1);
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


        public Categoria SelectById(int id)
        {
            Categoria result = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CategoriaSelectById", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CategoriaId", id);
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    Categoria entity = new Categoria();
                                    entity.CategoriaId = dr.GetInt32(0);
                                    entity.NombreCategoria = dr.GetString(1);
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



        public bool Insert(Categoria entity)
        {
            bool result = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CategoriaInsert", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", entity.NombreCategoria);

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


        public bool Update(Categoria entity)
        {
            bool result = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CategoriaUpdate", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CategoriaId", entity.CategoriaId);
                        cmd.Parameters.AddWithValue("@Nombre", entity.NombreCategoria);

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
            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CategoriaDelete", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CategoriaId", id);
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
    }
}
