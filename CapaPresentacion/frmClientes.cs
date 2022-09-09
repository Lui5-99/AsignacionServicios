using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using CapaEntidad;

namespace AsignacionServicios
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            cbEstado.Items.Add(new OpcionCombo()
            {
                valor = 1,
                texto = "Activo"
            });
            cbEstado.Items.Add(new OpcionCombo()
            {
                valor = 0,
                texto = "No activo"
            });
            cbEstado.DisplayMember = "texto";
            cbEstado.ValueMember = "valor";
            cbEstado.SelectedIndex = 0;
            foreach (DataGridViewColumn column in dgvDatos.Columns)
            {
                if (column.Visible && column.Name != "vacio")
                {
                    cbBusqueda.Items.Add(new OpcionCombo()
                    {
                        valor = column.Name,
                        texto = column.HeaderText
                    });
                }
            }
            cbBusqueda.DisplayMember = "texto";
            cbBusqueda.ValueMember = "valor";
            cbBusqueda.SelectedIndex = 0;

            List<Cliente> lsC = new CN_Cliente().Listar();
            foreach (Cliente item in lsC)
            {
                dgvDatos.Rows.Add(new object[]
                {
                    "",
                    item.IdCliente,
                    item.Codigo,
                    item.RazonSocial,
                    item.Correo,
                    item.Telefono,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo":"No Activo"
                });
            }
            txtCliente.Select();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            Cliente oCliente = new Cliente()
            {
                IdCliente = Convert.ToInt32(txtId.Text),
                Codigo = txtCliente.Text,
                RazonSocial = txtNombre.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).valor) == 1 ? true : false
            };
            int IdClientegenerado = 0;
            bool respuesta = false;
            if (oCliente.IdCliente == 0)
            {
                IdClientegenerado = new CN_Cliente().Registrar(oCliente, out Mensaje);
                txtId.Text = IdClientegenerado.ToString();
                if (IdClientegenerado != 0)
                {
                    dgvDatos.Rows.Add(new object[]
                    {
                        "",
                        txtId.Text,
                        txtCliente.Text,
                        txtNombre.Text,
                        txtCorreo.Text,
                        txtTelefono.Text,
                        ((OpcionCombo)cbEstado.SelectedItem).valor.ToString(),
                        ((OpcionCombo)cbEstado.SelectedItem).texto.ToString()
                    });
                    MessageBox.Show("Cliente Agregado", "Mensaje", MessageBoxButtons.OK);
                    limpiar();
                }
                else
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK);
            }
            else
            {
                respuesta = new CN_Cliente().Editar(oCliente, out Mensaje);
                if (respuesta)
                {
                    DataGridViewRow row = dgvDatos.Rows[Convert.ToInt32(lblIndice.Text)];
                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["Documento"].Value = txtCliente.Text;
                    row.Cells["NombreCompleto"].Value = txtNombre.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Telefono"].Value = txtTelefono.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cbEstado.SelectedItem).valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cbEstado.SelectedItem).texto.ToString();
                    MessageBox.Show("Cliente con el ID " + txtId.Text.ToString() + " actualizado", "Mensaje", MessageBoxButtons.OK);
                    limpiar();
                }
                else
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK);
            }
        }
        private void limpiar()
        {
            lblIndice.Text = "-1";
            txtId.Text = "0";
            txtCliente.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            cbEstado.SelectedIndex = 0;
            txtCliente.Select();
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

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDatos.Columns[e.ColumnIndex].Name == "vacio")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    lblIndice.Text = indice.ToString();
                    txtId.Text = dgvDatos.Rows[indice].Cells["Id"].Value.ToString();
                    txtCliente.Text = dgvDatos.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombre.Text = dgvDatos.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvDatos.Rows[indice].Cells["Correo"].Value.ToString();
                    txtTelefono.Text = dgvDatos.Rows[indice].Cells["Telefono"].Value.ToString();
                    foreach (OpcionCombo oc in cbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dgvDatos.Rows[indice].Cells["EstadoValor"].Value.ToString()))
                        {
                            int indiceCombo = cbEstado.Items.IndexOf(oc);
                            cbEstado.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                }
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show(
                    "¿Desea eliminar el Cliente?",
                    "Mensaje", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    Cliente oCliente = new Cliente()
                    {
                        IdCliente = Convert.ToInt32(txtId.Text),
                    };
                    bool respuesta = new CN_Cliente().Eliminar(oCliente, out Mensaje);
                    if (respuesta)
                    {
                        dgvDatos.Rows.RemoveAt(Convert.ToInt32(lblIndice.Text));
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK);
                    }

                }
            }
        }

        private void btBusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBusqueda.SelectedItem).valor.ToString();
            if (dgvDatos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBusqueda.SelectedItem).valor.ToString();
            if (dgvDatos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btLimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
        }

        private void btSinc_Click(object sender, EventArgs e)
        {
            int errores = 0;
            string mensaje = string.Empty;
            string error = string.Empty;
            int result = 0;
            List<Cliente> ls = new CN_Cliente().ListarComercial();
            foreach(Cliente item in ls)
            {
                Cliente _auxCliente = new Cliente()
                {
                    Codigo = item.Codigo,
                    RazonSocial = item.RazonSocial,
                    Correo = "",
                    Telefono = "",
                    Estado = true,
                };
                result = new CN_Cliente().Registrar(_auxCliente, out mensaje);
                if(result == 0)
                {
                    errores++;
                    error += mensaje;
                }
            }
            if(errores == 0)
            {
                MessageBox.Show("Todos los clientes sincronizados con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var dialog = MessageBox.Show("¿Copiar el error?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialog == DialogResult.Yes)
                    Clipboard.SetText(error);
            }
            load();
        }
    }
}
