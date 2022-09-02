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
            List<Cliente> ls = new List<Cliente>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdCliente, Codigo, RazonSocial, Correo, Telefono, Estado FROM CLIENTE");
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
            Mensaje = String.Empty;
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
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

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
        public List<Cliente> ListarComercial()
        {
            string CadenaComercial = @"Data Source=192.168.1.85\COMPAC;Initial Catalog=adEdgar;Persist Security Info=True;User ID=sa; password=contpaqi;";
            List<Cliente> ls = new List<Cliente>();
            using (SqlConnection oConexion = new SqlConnection(CadenaComercial))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT CCODIGOCLIENTE, CRAZONSOCIAL ");
                    query.AppendLine("FROM admClientes ");
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
                                });
                            }
                        }

                    }
                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    ls = new List<Cliente>();
                }
            }
            return ls;
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
                    SqlCommand cmd = new SqlCommand("delete from cliente where IdCliente = @Id");
                    cmd.Parameters.AddWithValue("@Id", oCliente.IdCliente);
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
