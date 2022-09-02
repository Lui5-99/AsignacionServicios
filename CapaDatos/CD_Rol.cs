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
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            List<Rol> ls = new List<Rol>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdRol, Descripcion FROM Rol ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ls.Add(new Rol()
                            {
                                IdRol = Convert.ToInt32(reader["IdRol"].ToString()),
                                Descripcion = reader["Descripcion"].ToString()
                            });
                        }
                    }
                    oConexion.Close();
                }
                catch (Exception ex)
                {

                }
            }
            return ls;
        }
        public int Registrar(Rol oRol, out string Mensaje)
        {
            // @Descripcion varchar(50),
            int result = 0;
            Mensaje = String.Empty;
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("INSERT INTO ROL (DESCRIPCION) VALUES (@Descripcion) ");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("Descripcion", oRol.Descripcion);
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
        public int IdRol()
        {
            int IdRol = 0;
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT TOP 1 IdRol FROM Rol Order By IdRol DESC");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            IdRol = Convert.ToInt32(reader["IdRol"].ToString());
                        }
                    }
                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    IdRol = 0;
                }
            }
            return IdRol;
        }
    }
}
