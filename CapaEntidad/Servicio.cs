using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public Usuario oUsuario { get; set; }        
        public Usuario oAsignado { get; set; }
        public string CodigoServicio { get; set; }
        public Cliente oCliente { get; set; }  
        public EstadoServicio oEstado { get; set; }
        public bool Factura { get; set; }
        public bool HojaServicio { get; set; }
        public string Descripcion { get; set; }
        public string Solucion { get; set; }
        public List<Movimiento> oDetalleServicio { get; set; }
        public string Fecha { get; set; }
        public string Bitacora { get; set; }
    }
}
