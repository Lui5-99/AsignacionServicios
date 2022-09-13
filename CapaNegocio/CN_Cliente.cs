using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente oCD_Cliente = new CD_Cliente();
        public List<Cliente> Listar()
        {
            return oCD_Cliente.Listar();
        }
        public List<Cliente> ListarComercial()
        {
            return oCD_Cliente.ListarComercial();
        }
        public int Registrar(Cliente oCliente, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (oCliente.Codigo == string.Empty)
                Mensaje += "Es necesario el Cliente\n";
            if (oCliente.RazonSocial == string.Empty)
                Mensaje += "Es necesario el nombre del Cliente\n";
            if (Mensaje != string.Empty)
                return 0;
            else
                return oCD_Cliente.Registrar(oCliente, out Mensaje);
        }
        public bool Editar(Cliente oCliente, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (oCliente.Codigo == string.Empty)
                Mensaje += "Es necesario el Cliente\n";
            if (oCliente.RazonSocial == string.Empty)
                Mensaje += "Es necesario el nombre del Cliente\n";
            if (Mensaje != string.Empty)
                return false;
            else
                return oCD_Cliente.Editar(oCliente, out Mensaje);
        }
        public bool Eliminar(Cliente oCliente, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (oCliente.Codigo == string.Empty)
                Mensaje += "Es necesario el Cliente\n";
            if (oCliente.RazonSocial == string.Empty)
                Mensaje += "Es necesario el nombre del Cliente\n";
            if (Mensaje != string.Empty)
                return false;
            else
                return oCD_Cliente.Eliminar(oCliente, out Mensaje);
        }
        public int CountClientesComercial()
        {
           return oCD_Cliente.CountClientesComercial();
        }
    }
}
