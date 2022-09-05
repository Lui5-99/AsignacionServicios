using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario oCD_Usuario = new CD_Usuario();
        public List<Usuario> Listar(int tipo)
        {
            return oCD_Usuario.Listar(tipo);
        }
        public int Registrar(Usuario oUsuario, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (oUsuario.User == string.Empty)
                Mensaje += "Es necesario el usuario\n";
            if (oUsuario.Nombre == string.Empty)
                Mensaje += "Es necesario el nombre del usuario\n";
            if (oUsuario.Clave == string.Empty)
                Mensaje += "Es necesaria una contraseña\n";
            if (Mensaje != string.Empty)
                return 0;
            else
                return oCD_Usuario.Registrar(oUsuario, out Mensaje);
        }
        public bool Editar(Usuario oUsuario, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (oUsuario.User == string.Empty)
                Mensaje += "Es necesario el usuario\n";
            if (oUsuario.Nombre == string.Empty)
                Mensaje += "Es necesario el nombre del usuario\n";
            if (oUsuario.Clave == string.Empty)
                Mensaje += "Es necesaria una contraseña\n";
            if (Mensaje != string.Empty)
                return false;
            else
                return oCD_Usuario.Editar(oUsuario, out Mensaje);
        }
        public bool Eliminar(Usuario oUsuario, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (oUsuario.User == string.Empty)
                Mensaje += "Es necesario el usuario\n";
            if (oUsuario.Nombre == string.Empty)
                Mensaje += "Es necesario el nombre del usuario\n";
            if (oUsuario.Clave == string.Empty)
                Mensaje += "Es necesaria una contraseña\n";
            if (Mensaje != string.Empty)
                return false;
            else
                return oCD_Usuario.Eliminar(oUsuario, out Mensaje);
        }
    }
}
