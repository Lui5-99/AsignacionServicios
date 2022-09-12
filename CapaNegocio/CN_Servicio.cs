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
        public List<Servicio> Listar(string fecha)
        {
            return oCNServicio.Listar(fecha);
        }
        public List<Servicio> ListarBitacora(string fecha, int tipo, Servicio oServ)
        {
            return oCNServicio.ListarBitacora(fecha, tipo, oServ);
        }
        public bool Editar(Servicio oServicio, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (oServicio.Solucion == string.Empty)
                Mensaje += "Es necesario una solución\n";
            if (Mensaje != string.Empty)
                return false;
            else
                return oCNServicio.Editar(oServicio, out Mensaje);
        }
        public Servicio obtenerServicio(string numero)
        {
            Servicio oServicio = oCNServicio.obtenerServicio(numero);
            if (oServicio.IdServicio != 0)
            {
                List<Movimiento> ls = oCNServicio.obtenerDetalle(oServicio.IdServicio);
                oServicio.oDetalleServicio = ls;
            }
            return oServicio;
        }
    }
}
