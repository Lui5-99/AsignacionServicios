using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private CD_Permiso oCD_Permiso = new CD_Permiso();
        public List<Permiso> Listar(int IdUsuario)
        {
            return oCD_Permiso.Listar(IdUsuario);
        }
        public List<Permiso> ListarPermisos(int IdRol)
        {
            return oCD_Permiso.ListarPermisos(IdRol);
        }
        public List<Permiso> ListarMenus()
        {
            return oCD_Permiso.ListarMenus();
        }
        public int Registrar(Permiso oPermiso, out string mensaje)
        {
            return oCD_Permiso.Registrar(oPermiso, out mensaje);
        }
        public int Editar(Permiso oPermiso, out string mensaje)
        {
            return oCD_Permiso.Editar(oPermiso, out mensaje);
        }
    }
}
