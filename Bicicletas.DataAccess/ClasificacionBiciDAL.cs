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
    public class ClasificacionBiciDAL : ConexionDAL
    {
        private static ClasificacionBiciDAL _instance;

        public static ClasificacionBiciDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ClasificacionBiciDAL();
                }

                return _instance;
            }


        }

        //PARA ESTADOS
        public List<ClasificacionBici> SelectAll()
        {
            List<ClasificacionBici> _listado = new List<ClasificacionBici>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ClasificacionSelectAll", conn))
                    {
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    ClasificacionBici entity = new ClasificacionBici();
                                    entity.ClasificacionBiciId = dr.GetInt32(0);
                                    entity.NombreClasificacion = dr.GetString(1);
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


        public ClasificacionBici SelectById(int id)
        {
            ClasificacionBici result = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ClasificacionSelectById", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ClasificacionBiciId", id);
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    ClasificacionBici entity = new ClasificacionBici();
                                    entity.ClasificacionBiciId = dr.GetInt32(0);
                                    entity.NombreClasificacion = dr.GetString(1);
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



        public bool Insert(ClasificacionBici entity)
        {
            bool result = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ClasificacionInsert", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreClasificacion", entity.NombreClasificacion);

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


        public bool Update(ClasificacionBici entity)
        {
            bool result = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ClasificacionUpdate", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ClasificacionBiciId", entity.ClasificacionBiciId);
                        cmd.Parameters.AddWithValue("@NombreClasificacion", entity.NombreClasificacion);

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
                    using (SqlCommand cmd = new SqlCommand("sp_ClasificacionDelete", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ClasificacionBiciId", id);
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
