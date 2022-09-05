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
            List<Usuario> ls = new CN_Usuario().Listar(1);
            foreach(Usuario item in ls)
            {
                cbUsuario.Items.Add(new OpcionCombo()
                {
                    valor = item.IdUsuario,
                    texto = item.Nombre
                });
            }
            cbUsuario.DisplayMember = "texto";
            cbUsuario.ValueMember = "valor";
            cbUsuario.SelectedIndex = 0;
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Servicio oServ = new Servicio()
            {
                oUsuario = new Usuario()
                {
                    IdUsuario = _Usuario.IdUsuario
                },
                oAsignado = new Usuario()
                {
                    IdUsuario = Convert.ToInt32(((OpcionCombo)cbUsuario.SelectedItem).valor)
                },
                oCliente = new Cliente()
                {
                    Codigo = txtCodigo.Text,
                    RazonSocial = txtRazon.Text
                },
                oEstado = new EstadoServicio()
                {
                    IdEstadoServicio = 1
                },
                Factura = cbFactura.Checked,
                HojaServicio = cbHojaServicio.Checked,
                Descripcion = txtDescricpcion.Text
            };
            DataTable dt = new DataTable();
            dt.Columns.Add("IdUsuario", typeof(int));
            dt.Rows.Add(Convert.ToInt32(((OpcionCombo)cbUsuario.SelectedItem).valor));
            bool respuesta = new CN_Servicio().Registrar(oServ, dt, out mensaje);
            if(respuesta)
                MessageBox.Show("Servicio generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                Cliente oCliente = new CN_Cliente().Listar().Where(p => p.Codigo == txtCodigo.Text && p.Estado == true).FirstOrDefault();
                if (oCliente != null)
                {
                    txtCodigo.BackColor = Color.Honeydew;
                    txtRazon.Text = oCliente.RazonSocial.ToString();
                }
                else
                {
                    txtCodigo.BackColor = Color.MistyRose;
                    txtCodigo.Text = "";
                    txtRazon.Text = "";
                    txtCodigo.Select();
                }
            }
        }
    }
}
