using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Servicio
    {
        private CD_Servicio oCNServicio = new CD_Servicio();
        public int obtenerCorrelativo()
        {
            return oCNServicio.obtenerCorrelativo();
        }
        public bool Registrar(Servicio oServicio, DataTable detalleServicio, out string mensaje)
        {
            mensaje = string.Empty;
            if (oServicio.oCliente.RazonSocial == "")
                mensaje = "Ingresa un cliente \n";
            if (oServicio.oCliente.Codigo == "")
                mensaje = "Ingresa un cliente \n";
            if (oServicio.Descripcion == "")
                mensaje += "Ingresa una descripción \n";
            if(mensaje == string.Empty)
                return oCNServicio.Registrar(oServicio, detalleServicio, out mensaje);
            else
                return false;
        }
    }
}
