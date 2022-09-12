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

        private void frmModServicios_Load(object sender, EventArgs e)
        {
            dtServicio.Value = DateTime.Now;
            /*string fecha = dtServicio.Value.ToString("yyyyMMdd");
            List<Servicio> ls = new CN_Servicio().Listar(fecha);
            foreach (Servicio item in ls)
            {
                dgvDatos.Rows.Add(new object[]
                {
                   "",
                   item.IdServicio,
                   item.oCliente.RazonSocial,
                   item.oUsuario.IdUsuario,
                   item.oUsuario.Nombre,
                   item.oAsignado.IdUsuario,
                   item.oAsignado.Nombre,
                   item.oEstado.IdEstadoServicio,
                   item.oEstado.Descripcion,
                   item.Fecha,
                   item.Descripcion,
                   item.Solucion,
                   item.HojaServicio,
                   item.Factura
                });
            }*/
            List<Usuario> lsU = new CN_Usuario().Listar(1);
            foreach (Usuario item in lsU)
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

            List<EstadoServicio> lsE = new CN_EstadoServicio().Listar();
            foreach (EstadoServicio item in lsE)
            {
                cbEstado.Items.Add(new OpcionCombo()
                {
                    valor = item.IdEstadoServicio,
                    texto = item.Descripcion
                });
            }
            cbEstado.DisplayMember = "texto";
            cbEstado.ValueMember = "valor";
            cbEstado.SelectedIndex = 0;
            foreach (OpcionCombo oc in cbUsuario.Items)
            {
                if (Convert.ToInt32(oc.valor) == _Usuario.IdUsuario)
                {
                    int indiceCombo = cbUsuario.Items.IndexOf(oc);
                    cbUsuario.SelectedIndex = indiceCombo;
                    break;
                }
            }
            cbUsuario.Enabled = false;

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDatos.Columns[e.ColumnIndex].Name == "vacio")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    lblIndice.Text = indice.ToString();
                    lblId.Text = dgvDatos.Rows[indice].Cells["IdServicio"].Value.ToString();
                    txtDescricpcion.Text = dgvDatos.Rows[indice].Cells["Descripcion"].Value.ToString();
                    txtSolucion.Text = dgvDatos.Rows[indice].Cells["Solucion"].Value.ToString();
                    lblCodigo.Text = dgvDatos.Rows[indice].Cells["CodigoServicio"].Value.ToString();
                    foreach (OpcionCombo oc in cbUsuario.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dgvDatos.Rows[indice].Cells["IdUsuario"].Value.ToString()))
                        {
                            int indiceCombo = cbUsuario.Items.IndexOf(oc);
                            cbUsuario.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                    foreach (OpcionCombo oc in cbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dgvDatos.Rows[indice].Cells["IdEstado"].Value.ToString()))
                        {
                            int indiceCombo = cbEstado.Items.IndexOf(oc);
                            cbEstado.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                    ckbHojaServicio.Checked = Convert.ToBoolean(dgvDatos.Rows[indice].Cells["HojaServicio"].Value.ToString());
                    ckbFactura.Checked = Convert.ToBoolean(dgvDatos.Rows[indice].Cells["Factura"].Value.ToString());

                    /*foreach (OpcionCombo oc in cbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == 2)
                        {
                            int indiceCombo = cbEstado.Items.IndexOf(oc);
                            cbEstado.SelectedIndex = indiceCombo;
                            cbEstado.Enabled = false;
                            break;
                        }
                    }*/
                }
            }
        }

        private void dgvDatos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check.Width - 10;
                var h = Properties.Resources.check.Height - 10;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dtServicio_ValueChanged(object sender, EventArgs e)
        {
            refresh();
        }
        private void limpiar()
        {
            ckbFactura.Checked = false;
            ckbHojaServicio.Checked = false;
            txtSolucion.Text = "";
            txtDescricpcion.Text = "";
            lblId.Text = "0";
            lblIndice.Text = "-1";
            lblCodigo.Text = "0";
            //
        }
        private void btLimpiar_Click(object sender, EventArgs e)
        {
            dtServicio.Value = DateTime.Now;
            cbEstado.SelectedIndex = 0;
            cbUsuario.SelectedIndex = 0;
            limpiar();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            Servicio oServicio = new Servicio()
            {
                IdServicio = Convert.ToInt32(lblId.Text),
                oAsignado = new Usuario()
                {
                    //IdUsuario = Convert.ToInt32(((OpcionCombo)cbUsuario.SelectedItem).valor),
                    //Nombre = ((OpcionCombo)cbUsuario.SelectedItem).texto
                    IdUsuario = _Usuario.IdUsuario,
                    Nombre = _Usuario.Nombre
                },
                oEstado = new EstadoServicio()
                {
                    IdEstadoServicio = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).valor),
                    Descripcion = ((OpcionCombo)cbEstado.SelectedItem).texto
                },
                Descripcion = txtDescricpcion.Text,
                Solucion = txtSolucion.Text
            };
            DataTable dt = new DataTable();
            dt.Columns.Add("IdUsuario");
            dt.Columns.Add("IdEstadoServicio");
            dt.Columns.Add("Bitacora");
            dt.Rows.Add(oServicio.oAsignado.IdUsuario, oServicio.oEstado.IdEstadoServicio, txtSolucion.Text);
            if(oServicio.IdServicio != 0)
            {
                bool respuesta = new CN_Servicio().Editar(oServicio, out Mensaje);
                if (respuesta)
                {
                    DataGridViewRow row = dgvDatos.Rows[Convert.ToInt32(lblIndice.Text)];
                    row.Cells["IdServicio"].Value = lblId.Text;
                    row.Cells["IdUAsignado"].Value = ((OpcionCombo)cbUsuario.SelectedItem).valor.ToString();
                    row.Cells["Usuario"].Value = ((OpcionCombo)cbUsuario.SelectedItem).texto.ToString();
                    row.Cells["IdEstado"].Value = ((OpcionCombo)cbEstado.SelectedItem).valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cbEstado.SelectedItem).texto.ToString();
                    row.Cells["Fecha"].Value = DateTime.Now;
                    row.Cells["Solucion"].Value = txtSolucion.Text;
                    MessageBox.Show("Servicio con el código " + lblCodigo.Text.ToString() + " actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK);
            }
        }
        private void refresh()
        {
            dgvDatos.Rows.Clear();
            string fecha = dtServicio.Value.ToString("yyyyMMdd");
            List<Servicio> ls = new CN_Servicio().Listar(fecha);
            foreach (Servicio item in ls)
            {
                dgvDatos.Rows.Add(new object[]
                {
                   "",
                   item.IdServicio,
                   item.CodigoServicio,
                   item.oCliente.RazonSocial,
                   item.oUsuario.IdUsuario,
                   item.oUsuario.Nombre,
                   item.oAsignado.IdUsuario,
                   item.oAsignado.Nombre,
                   item.oEstado.IdEstadoServicio,
                   item.oEstado.Descripcion,
                   item.Fecha,
                   item.Descripcion,
                   item.Solucion,
                   item.HojaServicio,
                   item.Factura,
                   item.Bitacora
                });
            }
            limpiar();
        }

    }
}
