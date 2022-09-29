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
using AsignacionServicios.Utilidades;
using System.IO;

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
            Usuario oUsuario = new CN_Usuario().Listar(0).Where(
                u => u.User == txtUser.Text && u.Clave == cSeguridad.Encrypt(txtPwd.Text)).FirstOrDefault();
            if(oUsuario != null)
            {
                if (ckbRecordar.Checked)
                {
                    List<string> datos = new List<string>();
                    datos.Add(txtUser.Text.Trim());
                    datos.Add(txtPwd.Text.Trim());
                    cSeguridad.GuardarTxt(datos, @"Creedenciales.txt");
                }
                else
                    cSeguridad.GuardarTxtVacio(@"Creedenciales.txt");
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
            if (File.Exists(@"creedenciales.txt"))
            {
                string[] lineas = cSeguridad.read(@"creedenciales.txt");
                ckbRecordar.Checked = lineas[0] == string.Empty ? false : true;
                txtPwd.Text = lineas[1] == string.Empty ? string.Empty : cSeguridad.Decrypt(lineas[1]);
                txtUser.Text = lineas[0] == string.Empty ? string.Empty : cSeguridad.Decrypt(lineas[0]);
            }
            else
            {
                ckbRecordar.Checked = false;
            }
            txtUser.Select();
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"creedenciales.txt"))
            {
                string[] lineas = cSeguridad.read(@"creedenciales.txt");
                ckbRecordar.Checked = lineas[0] == string.Empty ? false : true;
                txtPwd.Text = lineas[1] == string.Empty ? string.Empty : cSeguridad.Decrypt(lineas[1]);
                txtUser.Text = lineas[0] == string.Empty ? string.Empty : cSeguridad.Decrypt(lineas[0]);
            }
            else
            {
                ckbRecordar.Checked = false;
            }
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
