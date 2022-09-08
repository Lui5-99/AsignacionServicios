using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Servicio
    {
        public int obtenerCorrelativo()
        {
            int idCorrelativo = 0;
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from Servicio");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    idCorrelativo = Convert.ToInt32(cmd.ExecuteScalar());

                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    idCorrelativo = 0;
                }
            }
            return idCorrelativo;
        }
        public bool Registrar(Servicio oServicio, DataTable detalleMovimiento, out string mensaje)
        {
            //@IdUsuario int,
            //@IdUAsignado int,
            //@CodigoServicio varchar (50),
            //@RazonSocial varchar(50),
            //@IdEstadoServicio int,
            //@Factura bit,
            //@HojaServicio bit,
            //@Descripcion varchar(500),
            //@DetalleMovimiento[EMovimiento] ReadOnly,
            //@Resultado bit output,
            //@Mensaje varchar(500) output
            mensaje = string.Empty;
            bool resultado = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarServicio", oConexion);
                    cmd.Parameters.AddWithValue("IdUsuario", oServicio.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("IdUAsignado", oServicio.oAsignado.IdUsuario);
                    cmd.Parameters.AddWithValue("CodigoServicio", oServicio.CodigoServicio);
                    cmd.Parameters.AddWithValue("RazonSocial", oServicio.oCliente.RazonSocial);
                    cmd.Parameters.AddWithValue("IdEstadoServicio", oServicio.oEstado.IdEstadoServicio);
                    cmd.Parameters.AddWithValue("Factura", oServicio.Factura);
                    cmd.Parameters.AddWithValue("HojaServicio", oServicio.HojaServicio);
                    cmd.Parameters.AddWithValue("Descripcion", oServicio.Descripcion);
                    cmd.Parameters.AddWithValue("DetalleMovimiento", detalleMovimiento);

                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oConexion.Open();
                    cmd.ExecuteNonQuery();


                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    resultado = false;
                }
            }
            return resultado;
        }
        public List<Servicio> Listar(string fecha)
        {
            string _fecha = fecha + " 00:00:00";
            string _fecha2 = fecha + " 23:59:59";
            List<Servicio> ls = new List<Servicio>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT S.IdServicio, S.CodigoServicio, S.IdUsuario, U.NombreCompleto Supervisor,  ");
                    query.AppendLine("S.IdUAsignado, U1.NombreCompleto Usuario, S.RazonSocial, ");
                    query.AppendLine("S.IdEstadoServicio, ES.Descripcion Estado, S.FechaRegistro,  ");
                    query.AppendLine("S.Descripcion, S.Solucion, S.HojaServicio, S.Factura ");
                    query.AppendLine("FROM SERVICIO S ");
                    query.AppendLine("INNER JOIN USUARIO U ON S.IdUsuario = U.IdUsuario ");
                    query.AppendLine("INNER JOIN USUARIO U1 ON S.IdUAsignado = U1.IdUsuario ");
                    query.AppendLine("INNER JOIN ESTADOSERVICIO ES ON S.IdEstadoServicio = ES.IdEstadoServicio ");
                    query.AppendLine("WHERE s.FechaRegistro Between CAST('" + _fecha + "' AS datetime) and ");
                    query.AppendLine("CAST('" + _fecha2 + "' AS datetime) ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ls.Add(new Servicio()
                            {
                                IdServicio = Convert.ToInt32(reader["IdServicio"].ToString()),
                                CodigoServicio = reader["CodigoServicio"].ToString(),
                                oUsuario = new Usuario()
                                {
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"].ToString()),
                                    Nombre = reader["Supervisor"].ToString(),
                                },
                                oAsignado = new Usuario()
                                {
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"].ToString()),
                                    Nombre = reader["Usuario"].ToString(),
                                },
                                oCliente = new Cliente()
                                {
                                    RazonSocial = reader["RazonSocial"].ToString(),
                                },
                                oEstado = new EstadoServicio()
                                {
                                    IdEstadoServicio = Convert.ToInt32(reader["IdEstadoServicio"].ToString()),
                                    Descripcion = reader["Estado"].ToString(),
                                },
                                Fecha = reader["FechaRegistro"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Solucion = reader["Solucion"].ToString(),
                                HojaServicio = Convert.ToBoolean(reader["HojaServicio"].ToString()),
                                Factura = Convert.ToBoolean(reader["Factura"].ToString()),
                            });
                        }
                    }
                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    ls = new List<Servicio>();
                }
            }
            return ls;
        }
        public bool Editar(Servicio oServicio, out string Mensaje)
        {
            //@IdServicio int,
            //@IdUAsignado int,
            //@IdEstadoServicio int,
            //@Descripcion varchar(50),
            //@Solucion varchar(50),
            //@Resultado bit output,
            //@Mensaje varchar(500) output
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ModificarServicio", oConexion);
                    cmd.Parameters.AddWithValue("IdServicio", oServicio.IdServicio);
                    cmd.Parameters.AddWithValue("IdUAsignado", oServicio.oAsignado.IdUsuario);
                    cmd.Parameters.AddWithValue("IdEstadoServicio", oServicio.oEstado.IdEstadoServicio);
                    cmd.Parameters.AddWithValue("Descripcion", oServicio.Descripcion);
                    cmd.Parameters.AddWithValue("Solucion", oServicio.Solucion);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                    oConexion.Close();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }
        public Servicio obtenerServicio(string numero)
        {
            Servicio oServicio = new Servicio();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select S.IdServicio, S.CodigoServicio, U.IdUsuario, U.NombreCompleto,  ");
                    query.AppendLine("U2.IdUsuario IdUAsignado, U2.NombreCompleto Asignado, CONVERT(CHAR(10),S.FechaRegistro,103) FechaRegistro, ");
                    query.AppendLine("C.Codigo, C.RazonSocial ");
                    query.AppendLine("from SERVICIO S ");
                    query.AppendLine("INNER JOIN USUARIO U ON S.IdUsuario = U.IdUsuario ");
                    query.AppendLine("INNER JOIN USUARIO U2 ON S.IdUAsignado = U2.IdUsuario ");
                    query.AppendLine("INNER JOIN CLIENTE C ON C.RazonSocial = S.RazonSocial ");
                    query.AppendLine("WHERE S.CodigoServicio = @CodigoServicio");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("CodigoServicio", numero);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            oServicio = new Servicio()
                            {
                                IdServicio = Convert.ToInt32(reader["IdServicio"].ToString()),
                                CodigoServicio = reader["CodigoServicio"].ToString(),
                                oUsuario = new Usuario()
                                {
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"].ToString()),
                                    Nombre = reader["NombreCompleto"].ToString(),
                                },
                                oAsignado = new Usuario()
                                {
                                    IdUsuario = Convert.ToInt32(reader["IdUAsignado"].ToString()),
                                    Nombre = reader["Asignado"].ToString(),
                                },
                                Fecha = reader["FechaRegistro"].ToString(),
                                oCliente = new Cliente()
                                {
                                    Codigo = reader["Codigo"].ToString(),
                                    RazonSocial = reader["RazonSocial"].ToString(),
                                }
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    oServicio = new Servicio();
                }
            }
            return oServicio;
        }
        public List<Movimiento> obtenerDetalle(int id)
        {
            List<Movimiento> ls = new List<Movimiento>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select M.IdMovimiento, U.IdUsuario, U.Documento,   ");
                    query.AppendLine("ES.IdEstadoServicio, ES.Descripcion, M.Bitacora ,M.FechaRegistro ");
                    query.AppendLine("from MOVIMIENTO M  ");
                    query.AppendLine("INNER JOIN USUARIO U ON M.IdUsuario = U.IdUsuario  ");
                    query.AppendLine("INNER JOIN ESTADOSERVICIO ES ON M.IdEstadoServicio = ES.IdEstadoServicio ");
                    query.AppendLine("WHERE M.IdServicio = @Id ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("Id", id);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ls.Add(new Movimiento()
                            {
                                IdMovimiento = Convert.ToInt32(reader["IdMovimiento"].ToString()),
                                oUsuario = new Usuario()
                                {
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"].ToString()),
                                    User = reader["Documento"].ToString()
                                },
                                oEstado = new EstadoServicio()
                                {
                                    IdEstadoServicio = Convert.ToInt32(reader["IdEstadoServicio"].ToString()),
                                    Descripcion = reader["Descripcion"].ToString(),
                                },
                                Bitacora = reader["Bitacora"].ToString(),
                                FechaRegistro = reader["FechaRegistro"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    ls = new List<Movimiento>();
                }
            }
            return ls;
        }
    }
}
