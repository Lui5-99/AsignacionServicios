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
using CapaEntidad;
using CapaNegocio;
using AsignacionServicios;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = new CN_Usuario().Listar().Where(
                u => u.User == txtUser.Text && u.Clave == txtPwd.Text).FirstOrDefault();
            if(oUsuario != null)
            {
                Inicio oInicio = new Inicio(oUsuario);
                oInicio.Show();
                this.Hide();
                oInicio.FormClosing += frm_FormClosing;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña invalida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtUser.Text = "";
            txtPwd.Text = "";
            txtUser.Select();
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUser.Select();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPwd.Select();
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btIngresar_Click(sender, e);
            }
        }
    }
}
