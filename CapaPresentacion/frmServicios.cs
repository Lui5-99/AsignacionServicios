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
    public partial class frmServicios : Form
    {
        private Usuario _Usuario;
        public frmServicios(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {
            List<Usuario> ls = new CN_Usuario().Listar();
            foreach(Usuario item in ls)
            {
                cbUsuario.Items.Add(new OpcionCombo()
                {
                    valor = item.IdUsuario,
                    texto = item.Nombre
                });
            }
        }

        private void btBuscarClientes_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtCodigo.Text = modal._Cliente.Codigo.ToString();
                    txtCodigo.BackColor = Color.Honeydew;
                    txtRazon.Text = modal._Cliente.RazonSocial.ToString();
                }
                else
                {
                    txtCodigo.BackColor = Color.MistyRose;
                    txtRazon.Select();
                }
            }
        }
    }
}
