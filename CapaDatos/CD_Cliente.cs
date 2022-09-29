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
    public class CD_Cliente
    {
        public List<Cliente> Listar()
        {
            string mensaje = string.Empty;
            List<Cliente> ls = new List<Cliente>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdCliente, Codigo, RazonSocial, Correo, Telefono, Estado FROM CLIENTE ORDER BY Codigo");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion)
                    {
                        CommandType = CommandType.Text,
                    };
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ls.Add(new Cliente()
                                {
                                    IdCliente = Convert.ToInt32(reader["IdCliente"]),
                                    Codigo = reader["Codigo"].ToString(),
                                    RazonSocial = reader["RazonSocial"].ToString(),
                                    Correo = reader["Correo"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Estado = Convert.ToBoolean(reader["Estado"]),
                                });
                            }
                        }

                    }
                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    ls = new List<Cliente>();
                }
            }
            return ls;
        }
        public int Registrar(Cliente oCliente, out string Mensaje)
        {
            //@Codigo varchar(50),
            //@RazonSocial varchar(50),
            //@Correo varchar(50),
            //@Telefono varchar(50),
            //@Estado bit,
            //@Resultado int output,
            //@Mensaje varchar(500) output
            int idClientegenerado = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCliente", oConexion);
                    cmd.Parameters.AddWithValue("Codigo", oCliente.Codigo);
                    cmd.Parameters.AddWithValue("RazonSocial", oCliente.RazonSocial);
                    cmd.Parameters.AddWithValue("Correo", oCliente.Correo);
                    cmd.Parameters.AddWithValue("Telefono", oCliente.Telefono);
                    cmd.Parameters.AddWithValue("Estado", oCliente.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    idClientegenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString() + "\n";

                    oConexion.Close();
                }
            }
            catch (Exception ex)
            {
                idClientegenerado = 0;
                Mensaje = ex.Message;
            }
            return idClientegenerado;
        }
        public List<Cliente> ListarComercial(string path)
        {
            string mensaje = string.Empty;
            string CadenaComercial = path;
            List<Cliente> ls = new List<Cliente>();
            using (SqlConnection oConexion = new SqlConnection(CadenaComercial))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT C.CCODIGOCLIENTE, C.CRAZONSOCIAL, ");
                    query.AppendLine("(SELECT CTELEFONO1 FROM admDomicilios WHERE CTIPOCATALOGO = 1 AND CIDCATALOGO = C.CIDCLIENTEPROVEEDOR) CTELEFONO1, ");
                    query.AppendLine("(SELECT CEMAIL FROM admDomicilios WHERE CTIPOCATALOGO = 1 AND CIDCATALOGO = C.CIDCLIENTEPROVEEDOR) CEMAIL");
                    query.AppendLine("FROM admClientes C ");
                    query.AppendLine("LEFT JOIN admDomicilios D ON C.CIDCLIENTEPROVEEDOR = D.CIDCATALOGO ");
                    query.AppendLine("WHERE C.CTIPOCLIENTE <> 3 GROUP BY C.CIDCLIENTEPROVEEDOR, C.CCODIGOCLIENTE, C.CRAZONSOCIAL ");
                    query.AppendLine("order by C.CCODIGOCLIENTE");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ls.Add(new Cliente()
                                {
                                    Codigo = reader["CCODIGOCLIENTE"].ToString(),
                                    RazonSocial = reader["CRAZONSOCIAL"].ToString(),
                                    Correo = reader["CEMAIL"].ToString(),
                                    Telefono = reader["CTELEFONO1"].ToString(),
                                });
                            }
                        }

                    }
                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    ls = new List<Cliente>();
                }
            }
            return ls;
        }
        public int CountClientesComercial()
        {
            string mensaje = string.Empty;
            string CadenaComercial = @"Data Source=192.168.1.85\COMPAC;Initial Catalog=adEdgar;Persist Security Info=True;User ID=sa; password=contpaqi;";
            int result = 0;
            using (SqlConnection oConexion = new SqlConnection(CadenaComercial))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT count(*) results ");
                    query.AppendLine("FROM admClientes WHERE CTIPOCLIENTE <> 3 ");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                result = Convert.ToInt32(reader["results"].ToString());
                            }
                        }

                    }
                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    result = 0;
                }
            }
            return result;
        }
        public bool Editar(Cliente oCliente, out string Mensaje)
        {
            //@IdCliente int,
            //@Codigo varchar(50),
            //@RazonSocial varchar(50),
            //@Correo varchar(50),
            //@Telefono varchar(50),
            //@Estado bit,
            //@Resultado bit output,
            //@Mensaje varchar(500) output
            bool respuesta = false;
            Mensaje = String.Empty;
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ModificarCliente", oConexion);
                    cmd.Parameters.AddWithValue("IdCliente", oCliente.IdCliente);
                    cmd.Parameters.AddWithValue("Codigo", oCliente.Codigo);
                    cmd.Parameters.AddWithValue("RazonSocial", oCliente.RazonSocial);
                    cmd.Parameters.AddWithValue("Correo", oCliente.Correo);
                    cmd.Parameters.AddWithValue("Telefono", oCliente.Telefono);
                    cmd.Parameters.AddWithValue("Estado", oCliente.Estado);
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
        public bool Eliminar(Cliente oCliente, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = String.Empty;
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("delete from cliente where IdCliente = @Id", oConexion);
                    cmd.Parameters.AddWithValue("@Id", oCliente.IdCliente);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
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
