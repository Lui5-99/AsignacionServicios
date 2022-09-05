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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
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

            List<Rol> ls = new CN_Rol().Listar();
            foreach (Rol item in ls)
            {
                cbRol.Items.Add(new OpcionCombo()
                {
                    valor = item.IdRol,
                    texto = item.Descripcion
                });
            }
            cbRol.DisplayMember = "texto";
            cbRol.ValueMember = "valor";
            cbRol.SelectedIndex = 0;

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

            List<Usuario> lsU = new CN_Usuario().Listar(0);
            foreach (Usuario item in lsU)
            {
                dgvDatos.Rows.Add(new object[]
                {
                    "",
                    item.IdUsuario,
                    item.User,
                    item.Nombre,
                    item.Correo,
                    item.Clave,
                    item.oRol.IdRol,
                    item.oRol.Descripcion,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo":"No Activo"
                });
            }
            txtUsuario.Select();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            Usuario oUsuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtId.Text),
                User = txtUsuario.Text,
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text,
                Clave = txtPwd.Text,
                oRol = new Rol()
                {
                    IdRol = Convert.ToInt32(((OpcionCombo)cbRol.SelectedItem).valor),
                    Descripcion = ((OpcionCombo)cbRol.SelectedItem).texto
                },
                Estado = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).valor) == 1 ? true : false
            };
            int IdUsuariogenerado = 0;
            bool respuesta = false;
            if (oUsuario.IdUsuario == 0)
            {
                if (txtPwd.Text != txtPwd2.Text)
                    MessageBox.Show("Las contraseñas no coinciden", "Mensaje", MessageBoxButtons.OK);
                else
                    IdUsuariogenerado = new CN_Usuario().Registrar(oUsuario, out Mensaje);
                if (IdUsuariogenerado != 0)
                {
                    dgvDatos.Rows.Add(new object[]
                    {
                        "",
                        IdUsuariogenerado.ToString(),
                        txtUsuario.Text,
                        txtNombre.Text,
                        txtCorreo.Text,
                        txtPwd.Text,
                        ((OpcionCombo)cbRol.SelectedItem).valor.ToString(),
                        ((OpcionCombo)cbRol.SelectedItem).texto.ToString(),
                        ((OpcionCombo)cbEstado.SelectedItem).valor.ToString(),
                        ((OpcionCombo)cbEstado.SelectedItem).texto.ToString()
                    });
                    MessageBox.Show("Usuario Agregado", "Mensaje", MessageBoxButtons.OK);
                    limpiar();
                }
                else
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK);
            }
            else
            {
                if (txtPwd.Text != txtPwd2.Text)
                    MessageBox.Show("Las contraseñas no coinciden", "Mensaje", MessageBoxButtons.OK);
                else
                    respuesta = new CN_Usuario().Editar(oUsuario, out Mensaje);
                if (respuesta)
                {
                    DataGridViewRow row = dgvDatos.Rows[Convert.ToInt32(lblIndice.Text)];
                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["Documento"].Value = txtUsuario.Text;
                    row.Cells["NombreCompleto"].Value = txtNombre.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Clave"].Value = txtPwd.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)cbRol.SelectedItem).valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cbRol.SelectedItem).texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cbEstado.SelectedItem).valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cbEstado.SelectedItem).texto.ToString();
                    MessageBox.Show("Usuario con el ID " + txtId.Text.ToString() + " actualizado", "Mensaje", MessageBoxButtons.OK);
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
            txtUsuario.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtPwd.Text = "";
            txtPwd2.Text = "";
            cbRol.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
            txtUsuario.Select();
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
                    txtUsuario.Text = dgvDatos.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombre.Text = dgvDatos.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvDatos.Rows[indice].Cells["Correo"].Value.ToString();
                    txtPwd.Text = dgvDatos.Rows[indice].Cells["Clave"].Value.ToString();
                    txtPwd2.Text = dgvDatos.Rows[indice].Cells["Clave"].Value.ToString();
                    foreach (OpcionCombo oc in cbRol.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dgvDatos.Rows[indice].Cells["IdRol"].Value.ToString()))
                        {
                            int indiceCombo = cbRol.Items.IndexOf(oc);
                            cbRol.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
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
                    "¿Desea eliminar el usuario?",
                    "Mensaje", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    Usuario oUsuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txtId.Text),
                    };
                    bool respuesta = new CN_Usuario().Eliminar(oUsuario, out Mensaje);
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
    }
}
