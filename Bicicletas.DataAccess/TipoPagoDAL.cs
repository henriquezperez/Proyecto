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
    public class TipoPagoDAL:Conexion
    {
        private static TipoPagoDAL _instance;

        public static TipoPagoDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TipoPagoDAL();
                }

                return _instance;
            }

        }

        public List<TipoPago> SelectAll()
        {
            List<TipoPago> _listado = new List<TipoPago>();


            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TipoPagoSelectAll", conn))
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                TipoPago entity = new TipoPago();
                                entity.TarjetaId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.EfectivoId = dr.GetInt32(2);
                                entity.TarjetaId = dr.GetInt32(3);
                                _listado.Add(entity);
                            }
                        }
                    }
                }
            }

            return _listado;
        }


        public TipoPago SelectById(int id)
        {
            TipoPago result = null;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TarjetaSelectById", conn))
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
                                TipoPago entity = new TipoPago();
                                entity.TarjetaId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.EfectivoId = dr.GetInt32(2);
                                entity.TarjetaId = dr.GetInt32(3);
                            }
                        }
                    }
                }
            }

            return result;
        }



        public bool Insert(TipoPago entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TipoPagoInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@EfectivoId", entity.EfectivoId);
                    cmd.Parameters.AddWithValue("@TarjetaId", entity.TarjetaId);

                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }


        public bool Update(TipoPago entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TipoPagoUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@EfectivoId", entity.EfectivoId);
                    cmd.Parameters.AddWithValue("@TarjetaId", entity.TarjetaId);

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
                using (SqlCommand cmd = new SqlCommand("sp_TipoPagoDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoPagoId ", id);
                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

    }
}
