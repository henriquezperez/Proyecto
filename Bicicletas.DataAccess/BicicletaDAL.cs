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
    public class BicicletaDAL : Conexion
    {
        private static BicicletaDAL _instance;

        public static BicicletaDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BicicletaDAL();
                }

                return _instance;
            }
        }

        public List<Bicicleta> SelectAll()
        {
            List<Bicicleta> result = new List<Bicicleta>();

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_BicicletaSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            Bicicleta entity = null;
                            while (dr.Read())
                            {
                                entity = new Bicicleta()
                                {
                                    BicicletaId = dr.GetInt32(0),
                                    ThamanhoId = dr.GetInt32(1),
                                    CategoriaId = dr.GetInt32(2),
                                    MarcaId = dr.GetInt32(3),
                                    GarantiaId = dr.GetInt32(4),
                                    ColorId = dr.GetInt32(5),
                                    Precio = dr.GetDecimal(6),
                                   
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public bool Insert(Bicicleta entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_BicicletaInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ThamanhoId", entity.ThamanhoId);
                    cmd.Parameters.AddWithValue("@CategoriaId", entity.CategoriaId);
                    cmd.Parameters.AddWithValue("@MarcaId", entity.MarcaId);
                    cmd.Parameters.AddWithValue("@GarantiaId", entity.GarantiaId);
                    cmd.Parameters.AddWithValue("@ColorId", entity.ColorId);
                    cmd.Parameters.AddWithValue("@Precio", entity.Precio);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }

            }

            return result;
        }


        public bool Update(Bicicleta entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_BicicletaUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BicicletaId", entity.BicicletaId);
                    cmd.Parameters.AddWithValue("@TamanhoId", entity.ThamanhoId);
                    cmd.Parameters.AddWithValue("@CategoriaId", entity.CategoriaId);
                    cmd.Parameters.AddWithValue("@MarcaId", entity.MarcaId);
                    cmd.Parameters.AddWithValue("@GarantiaId", entity.GarantiaId);
                    cmd.Parameters.AddWithValue("@ColorId", entity.ColorId);
                    cmd.Parameters.AddWithValue("@Precio", entity.Precio);
                  
                    conn.Open();

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }
        public Bicicleta SelectAllById(int id)
        {
            Bicicleta result = new Bicicleta();

            using (SqlConnection con = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_BicicletaSelectById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DoctorId", id);
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr.HasRows)
                        {
                            result = new Bicicleta()
                            {
                                BicicletaId = dr.GetInt32(0),
                                ThamanhoId = dr.GetInt32(1),
                                CategoriaId = dr.GetInt32(2),
                                MarcaId = dr.GetInt32(3),
                                GarantiaId = dr.GetInt32(4),
                                ColorId = dr.GetInt32(5),
                                Precio = dr.GetDecimal(6),
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
                using (SqlCommand cmd = new SqlCommand("Sp_BicicletaDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BicicletaId", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

    }
}
