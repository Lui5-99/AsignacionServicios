using AsignacionServicios.Modales;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionServicios
{
    public partial class frmModServicios : Form
    {
        private Usuario _Usuario;
        public frmModServicios(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }
    }
}
