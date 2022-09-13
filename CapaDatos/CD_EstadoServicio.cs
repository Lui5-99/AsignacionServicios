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
    public class CD_EstadoServicio
    {
        
        public List<EstadoServicio> Listar()
        {
            string mensaje = string.Empty;
            List<EstadoServicio> ls = new List<EstadoServicio>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdEstadoServicio, descripcion from EstadoServicio  ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion)
                    {
                        CommandType = CommandType.Text
                    };
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ls.Add(new EstadoServicio()
                            {
                                IdEstadoServicio = Convert.ToInt32(reader["IdEstadoServicio"].ToString()),
                                Descripcion = reader["Descripcion"].ToString()
                            });
                        }
                    }
                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    ls = new List<EstadoServicio>();
                }
            }
            return ls;
        }
    }
}
