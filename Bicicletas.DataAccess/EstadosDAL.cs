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
    public class EstadosDAL:Conexion
    {
        private static EstadosDAL _instance;

        public static EstadosDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EstadosDAL();
                }

                return _instance;
            }
        }

        //PARA ESTADOS
        public List<Estados> SelectAll()
        {
            List<Estados> _listado = new List<Estados>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_EstadosSelectAll", conn))
                    {
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    Estados entity = new Estados();
                                    entity.EstadoId = dr.GetInt32(0);
                                    entity.Nombre = dr.GetString(1);
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


        public Estados SelectById(int id)
        {
            Estados result = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_EstadosSelectById", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EstadoId", id);
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    Estados entity = new Estados();
                                    entity.EstadoId = dr.GetInt32(0);
                                    entity.Nombre = dr.GetString(1);
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



        public bool Insert(Estados entity)
        {
            bool result = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_EstadosInsert", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);

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


        public bool Update(Estados entity)
        {
            bool result = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_EstadosUpdate", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);
                        cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);

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
                    using (SqlCommand cmd = new SqlCommand("sp_EstadosDelete", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EstadoId", id);
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
