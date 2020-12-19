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
    public class VentaDAL : ConexionDAL
    {
        private static VentaDAL _instance;

        public static VentaDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new VentaDAL();
                }

                return _instance;
            }
        }

        public List<Venta> SelectAll()
        {
            List<Venta> _listado = new List<Venta>();


            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_VentaSelectAll", conn))
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                Venta entity = new Venta();
                                entity.VentaId = dr.GetInt32(0);
                                entity.BicicletaId = dr.GetInt32(1);
                                entity.ClienteId = dr.GetInt32(2);
                                entity.Fecha = dr.GetDateTime(3);
                                entity.PagoId = dr.GetInt32(4);
                                entity.EstadoId = dr.GetInt32(5);
                                entity.Total = dr.GetDecimal(6);

                                _listado.Add(entity);
                            }
                        }
                    }
                }
            }

            return _listado;
        }


        public Venta SelectById(int id)
        {
            Venta result = null;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_VentaSelectById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BicicletaId", id);
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                Venta entity = new Venta();
                                entity.VentaId = dr.GetInt32(0);
                                entity.BicicletaId = dr.GetInt32(1);
                                entity.ClienteId = dr.GetInt32(2);
                                entity.Fecha = dr.GetDateTime(3);
                                entity.PagoId = dr.GetInt32(4);
                                entity.EstadoId = dr.GetInt32(5);
                                entity.Total = dr.GetDecimal(6);
                            }
                        }
                    }
                }
            }

            return result;
        }



        public bool Insert(Venta entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_VentaInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VentaId", entity.VentaId);
                    cmd.Parameters.AddWithValue("@BicicletaId", entity.BicicletaId);
               
                    cmd.Parameters.AddWithValue("@ClienteId", entity.ClienteId);
                    cmd.Parameters.AddWithValue("@FechaId", entity.Fecha);
                    cmd.Parameters.AddWithValue("@PagoId", entity.PagoId);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);
               
                    cmd.Parameters.AddWithValue("@Total", entity.Total);

                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }


        public bool Update(Venta entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_VentaUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VentaId", entity.VentaId);
                    cmd.Parameters.AddWithValue("@BicicletaId", entity.BicicletaId);

                    cmd.Parameters.AddWithValue("@ClienteId", entity.ClienteId);
                    cmd.Parameters.AddWithValue("@FechaId", entity.Fecha);
                    cmd.Parameters.AddWithValue("@PagoId", entity.PagoId);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);

                    cmd.Parameters.AddWithValue("@Total", entity.Total);

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
                using (SqlCommand cmd = new SqlCommand("sp_VentaDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BicicletaId ", id);
                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

    }
}
