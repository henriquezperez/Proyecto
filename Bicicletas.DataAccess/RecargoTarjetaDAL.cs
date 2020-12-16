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
    public class RecargoTarjetaDAL:Conexion
    {
        private static RecargoTarjetaDAL _instance;

        public static RecargoTarjetaDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RecargoTarjetaDAL();
                }

                return _instance;
            }
        }

        public List<RecargoTarjeta> SelectAll()
        {
            List<RecargoTarjeta> _listado = new List<RecargoTarjeta>();


            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_RecargoTarjetaSelectAll", conn))
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                RecargoTarjeta entity = new RecargoTarjeta();
                                entity.TarjetaId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.PorcenGanancia = dr.GetInt32(2);
                                _listado.Add(entity);
                            }
                        }
                    }
                }
            }
            return _listado;
        }


        public RecargoTarjeta SelectById(int id)
        {
            RecargoTarjeta result = null;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_RecargoTarjetaSelectById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TarjetaId", id);
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                RecargoTarjeta entity = new RecargoTarjeta();
                                entity.TarjetaId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.PorcenGanancia = dr.GetInt32(2);
                            }
                        }
                    }
                }
            }

            return result;
        }



        public bool Insert(RecargoTarjeta entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_RecargoTarjetaInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@PorcentajeGanancia", entity.PorcenGanancia);

                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public bool Update(RecargoTarjeta entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_RecargoTarjetaUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TarjetaId",entity.TarjetaId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@PorcentajeGanancia", entity.PorcenGanancia);

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
                using (SqlCommand cmd = new SqlCommand("sp_NinhoBiciDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TarjetaId", id);
                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


    }
}
