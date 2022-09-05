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
            //@IdCliente int,
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
                    cmd.Parameters.AddWithValue("IdCliente", oServicio.oCliente.IdCliente);
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
    }
}
