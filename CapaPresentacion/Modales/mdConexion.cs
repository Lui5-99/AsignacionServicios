using AsignacionServicios.Utilidades;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionServicios.Modales
{
    public partial class mdConexion : Form
    {
        public Parametro _param { get; set; }
        public mdConexion()
        {
            InitializeComponent();
        }

        private void mdConexion_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"Parametros.txt"))
            {
                string[] datos = cSeguridad.read(@"Parametros.txt");
                txtServidor.Text = cSeguridad.Decrypt(datos[0]);
                txtInstancia.Text = cSeguridad.Decrypt(datos[1]);
                txtBD.Text = cSeguridad.Decrypt(datos[2]);
                txtUser.Text = cSeguridad.Decrypt(datos[3]);
                txtPass.Text = cSeguridad.Decrypt(datos[4]);
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            List<string> datos = new List<string>();
            datos.Add(txtServidor.Text.Trim());
            datos.Add(txtInstancia.Text.Trim());
            datos.Add(txtBD.Text.Trim());
            datos.Add(txtUser.Text.Trim());
            datos.Add(label6.Text.Trim());
            cSeguridad.GuardarTxt(datos, @"Parametros.txt");
            _param = new Parametro()
            {
                Servidor = txtServidor.Text.Trim(),
                Instancia = txtInstancia.Text.Trim(),
                BaseDatos = txtBD.Text.Trim(),
                Usuario = txtUser.Text.Trim(),
                Clave = label6.Text.Trim()
            };
            path = @"Data Source=" + _param.Servidor + @"\" + _param.Instancia + ";Initial Catalog=" + _param.BaseDatos + ";" +
                        "Persist Security Info=True;User ID=" + _param.Usuario + "; password=" + _param.Clave + ";";
            List<Cliente> cliente = new CN_Cliente().ListarComercial(path);
            if (!(cliente.Count >= 0 || cliente == null))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                MessageBox.Show("Error en la conexión", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            cSeguridad.GuardarTxtVacio(@"Parametros.txt");
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtServidor.Text = "";
            txtInstancia.Text = "";
            txtBD.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
        }
    }
}
