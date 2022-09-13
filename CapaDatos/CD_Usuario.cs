using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar(int tipo)
        {
            string mensaje = string.Empty;
            List<Usuario> ls = new List<Usuario>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT U.IdUsuario, U.UserName, U.NombreCompleto, U.Correo, U.Clave, U.Estado, ");
                    query.AppendLine("R.IdRol, R.Descripcion ");
                    query.AppendLine("FROM USUARIO U ");
                    query.AppendLine("INNER JOIN ROL R ON R.IdRol = U.IdRol ");
                    query.AppendLine(tipo == 1 ? "where u.IdRol IN (4,5) " : "");
                    query.AppendLine(tipo == 2 ? "where u.IdRol IN (1,3) " : "");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ls.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                User = reader["UserName"].ToString(),
                                Nombre = reader["NombreCompleto"].ToString(),
                                Correo = reader["Correo"].ToString(),
                                Clave = reader["Clave"].ToString(),
                                Estado = Convert.ToBoolean(reader["Estado"]),
                                oRol = new Rol()
                                {
                                    IdRol = Convert.ToInt32(reader["IdRol"]),
                                    Descripcion = reader["Descripcion"].ToString()
                                }
                            });
                        }
                    }
                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    ls = new List<Usuario>();
                }
            }
            return ls;
        }
        public int Registrar(Usuario oUsuario, out string Mensaje)
        {
            // @UserName varchar(50),
            // @NombreCompleto varchar(100),
            // @Correo varchar(100),
            // @Clave varchar(100),
            // @IdRol int,
            // @Estado bit,
            // @IdUsuarioResultado int output,
            // @Mensaje varchar(500) output
            int idusuariogenerado = 0;
            Mensaje = String.Empty;
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", oConexion);
                    cmd.Parameters.AddWithValue("UserName", oUsuario.User);
                    cmd.Parameters.AddWithValue("NombreCompleto", oUsuario.Nombre);
                    cmd.Parameters.AddWithValue("Correo", oUsuario.Correo);
                    cmd.Parameters.AddWithValue("Clave", oUsuario.Clave);
                    cmd.Parameters.AddWithValue("IdRol", oUsuario.oRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", oUsuario.Estado);
                    cmd.Parameters.Add("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    idusuariogenerado = Convert.ToInt32(cmd.Parameters["IdUsuarioResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                    oConexion.Close();
                }
            }
            catch (Exception ex)
            {
                idusuariogenerado = 0;
                Mensaje = ex.Message;
            }
            return idusuariogenerado;
        }

        public bool Editar(Usuario oUsuario, out string Mensaje)
        {
            // @IdUsuario int,
            // @UserName varchar(50),
            // @NombreCompleto varchar(100),
            // @Correo varchar(100),
            // @Clave varchar(100),
            // @IdRol int,
            // @Estado bit,
            // @Respuesta bit output,
            // @Mensaje varchar(500) output
            bool respuesta = false;
            Mensaje = String.Empty;
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", oConexion);
                    cmd.Parameters.AddWithValue("IdUsuario", oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("UserName", oUsuario.User);
                    cmd.Parameters.AddWithValue("NombreCompleto", oUsuario.Nombre);
                    cmd.Parameters.AddWithValue("Correo", oUsuario.Correo);
                    cmd.Parameters.AddWithValue("Clave", oUsuario.Clave);
                    cmd.Parameters.AddWithValue("IdRol", oUsuario.oRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", oUsuario.Estado);
                    cmd.Parameters.Add("respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
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

        public bool Eliminar(Usuario oUsuario, out string Mensaje)
        {
            // @IdUsuario int,
            // @Respuesta bit output,
            // @Mensaje varchar(500) output
            bool respuesta = false;
            Mensaje = String.Empty;
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", oConexion);
                    cmd.Parameters.AddWithValue("IdUsuario", oUsuario.IdUsuario);
                    cmd.Parameters.Add("respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
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
    }
}
