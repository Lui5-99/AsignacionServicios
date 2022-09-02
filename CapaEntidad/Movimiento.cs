using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Movimiento
    {
        public int IdMovimiento { get; set; }
        public Servicio oServicio { get; set; }
        public Usuario oUsuario { get; set; }
        public string FechaRegistro { get; set; }
    }
}
