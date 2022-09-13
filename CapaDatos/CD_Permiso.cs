using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int IdUsuario)
        {
            string mensaje = string.Empty;
            List<Permiso> ls = new List<Permiso>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT P.IdRol, P.NombreMenu, P.Estado FROM PERMISO P ");
                    query.AppendLine("INNER JOIN ROL R ON R.IdRol = P.IdRol ");
                    query.AppendLine("INNER JOIN USUARIO U ON U.IdRol = R.IdRol");
                    query.AppendLine("WHERE U.IdUsuario = @IdUsuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ls.Add(new Permiso()
                            {
                                oRol = new Rol()
                                {
                                    IdRol = Convert.ToInt32(reader["IdRol"].ToString())
                                },
                                NombreMenu = reader["NombreMenu"].ToString(),
                                Estado = Convert.ToBoolean(reader["Estado"].ToString())
                            });
                        }
                    }
                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    ls = new List<Permiso>();
                }
            }
            return ls;
        }
        public List<Permiso> ListarPermisos(int IdRol)
        {
            string mensaje = string.Empty;
            List<Permiso> ls = new List<Permiso>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT P.IdRol, P.NombreMenu, p.Estado FROM PERMISO P ");
                    query.AppendLine("INNER JOIN ROL R ON R.IdRol = P.IdRol ");
                    query.AppendLine("WHERE r.IdRol = @IdRol");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("IdRol", IdRol);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ls.Add(new Permiso()
                            {
                                oRol = new Rol()
                                {
                                    IdRol = Convert.ToInt32(reader["IdRol"].ToString())
                                },
                                NombreMenu = reader["NombreMenu"].ToString(),
                                Estado = Convert.ToBoolean(reader["Estado"].ToString())
                            });
                        }
                    }
                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    ls = new List<Permiso>();
                }
            }
            return ls;
        }
        public int Registrar(Permiso oPermiso, out string Mensaje)
        {
            // @Descripcion varchar(50),
            int result = 0;
            Mensaje = String.Empty;
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("insert into PERMISO(IdRol,NombreMenu, Estado) values ");
                    query.AppendLine("(@IdRol, @NombreMenu, @Estado) ");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("IdRol", oPermiso.oRol.IdRol);
                    cmd.Parameters.AddWithValue("NombreMenu", oPermiso.NombreMenu);
                    cmd.Parameters.AddWithValue("Estado", oPermiso.Estado);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    result = cmd.ExecuteNonQuery();
                    oConexion.Close();
                }
            }
            catch (Exception ex)
            {
                result = 0;
                Mensaje = ex.Message;
            }
            return result;
        }
        public int Editar(Permiso oPermiso, out string Mensaje)
        {
            int result = 0;
            Mensaje = String.Empty;
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update PERMISO SET Estado = @Estado ");
                    query.AppendLine("Where IdRol = @IdRol AND NombreMenu = @NombreMenu ");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("IdRol", oPermiso.oRol.IdRol);
                    cmd.Parameters.AddWithValue("NombreMenu", oPermiso.NombreMenu);
                    cmd.Parameters.AddWithValue("Estado", oPermiso.Estado);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    result = cmd.ExecuteNonQuery();
                    oConexion.Close();
                }
            }
            catch (Exception ex)
            {
                result = 0;
                Mensaje = ex.Message;
            }
            return result;
        }
        public List<Permiso> ListarMenus()
        {
            string mensaje = string.Empty;
            List<Permiso> ls = new List<Permiso>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select DISTINCT NombreMenu from PERMISO ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ls.Add(new Permiso()
                            {
                                NombreMenu = reader["NombreMenu"].ToString()
                            });
                        }
                    }
                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    ls = new List<Permiso>();
                }
            }
            return ls;
        }
    }
}
