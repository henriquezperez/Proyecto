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
    public class TarjetaDAL:Conexion
    {
        private static TarjetaDAL _instance;

        public static TarjetaDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TarjetaDAL();
                }

                return _instance;
            }
        }

        public List<Tarjeta> SelectAll()
        {
            List<Tarjeta> _listado = new List<Tarjeta>();


            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TarjetaSelectAll", conn))
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                Tarjeta entity = new Tarjeta();
                                entity.TarjetaId = dr.GetInt32(0);
                                entity.Pago = dr.GetDecimal(1);
                                entity.PorcenRecargo = dr.GetInt32(2);
                                _listado.Add(entity);
                            }
                        }
                    }
                }
            }

            return _listado;
        }


        public Tarjeta SelectById(int id)
        {
            Tarjeta result = null;

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
                                Tarjeta entity = new Tarjeta();
                                entity.TarjetaId = dr.GetInt32(0);
                                entity.Pago = dr.GetDecimal(1);
                                entity.PorcenRecargo = dr.GetInt32(2);
                            }
                        }
                    }
                }
            }

            return result;
        }



        public bool Insert(Tarjeta entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TarjetaInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Pago", entity.Pago);
                    cmd.Parameters.AddWithValue("@PorcenRegargo", entity.PorcenRecargo);

                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }


        public bool Update(Tarjeta entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TarjetaUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Pago", entity.Pago);
                    cmd.Parameters.AddWithValue("@PorcenRegargo", entity.PorcenRecargo);

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
                using (SqlCommand cmd = new SqlCommand("sp_TarjetaDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TarjetaId ", id);
                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
