using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Windows;
using AsignacionServicios.Modales;

namespace AsignacionServicios
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;
        private static int IdRolActual = 0;
        public Inicio(Usuario oUsuario)
        {
            InitializeComponent();
            usuarioActual = oUsuario;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuarioActual.Nombre;
            IdRolActual = usuarioActual.oRol.IdRol;
            List<Permiso> ls = new CN_Permiso().Listar(usuarioActual.IdUsuario);
            foreach(IconMenuItem iconMenu in menu.Items)
            {
                bool encontrado = ls.Any(
                    m => m.NombreMenu == iconMenu.Name && m.Estado == true
                    );
                if (!encontrado)
                    iconMenu.Visible = false;
            }
            switch (IdRolActual)
            {
                case 1:
                    subMenuVer.Visible = true;
                    break;
                case 2:
                    subMenuAgregar.Visible = false;
                    break;
                case 3:
                    subMenuAgregar.Text = "Nuevo";
                    break;
                case 4:
                    subMenuAgregar.Text = "Ver";
                    break;
                case 5:
                    subMenuAgregar.Visible = false;
                    break;
                case 6:
                    subMenuAgregar.Visible = false;
                    break;
            }
        }
        private void AbrirFormulario(IconMenuItem menu, Form frm)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            menuActivo = menu;
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.BackColor = Color.SteelBlue;
            contenedor.Controls.Add(frm);
            frm.Show();
        }

        private void menuUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios(usuarioActual));
        }

        private void menuConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmConfiguracion());
        }

        private void menuServicio_Click(object sender, EventArgs e)
        {
            
        }

        private void subMenuAgregar_Click(object sender, EventArgs e)
        {
            if(subMenuAgregar.Text == "Nuevo")
            {
                AbrirFormulario((IconMenuItem)sender, new frmServicios(usuarioActual));
            }
            else if (subMenuAgregar.Text == "Ver")
            {
                AbrirFormulario((IconMenuItem)sender, new frmModServicios(usuarioActual));
            }
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void SubMenuDetalles_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmMovimiento());
        }

        private void menuAcercade_Click(object sender, EventArgs e)
        {
            var modal = new mdAcercade();
            var result = modal.ShowDialog();
        }

        private void subMenuVer_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmModServicios(usuarioActual));
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReporte());
        }
    }
}
