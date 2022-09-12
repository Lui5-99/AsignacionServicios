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

namespace AsignacionServicios.Modales
{
    public partial class mdUsuario : Form
    {
        public Usuario _Usuario { get; set; }
        private int _tipo = 0;
        public mdUsuario(int tipo)
        {
            InitializeComponent();
            _tipo = tipo;
        }

        private void btBusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBusqueda.SelectedItem).valor.ToString();
            if (dgvDatos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.ToString().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void mdUsuario_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvDatos.Columns)
            {
                if (column.Visible)
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

            List<Usuario> ls = new CN_Usuario().Listar(_tipo == 1 ? 1 : 2);
            foreach (Usuario item in ls)
            {
                dgvDatos.Rows.Add(new object[]
                {
                    item.IdUsuario,
                    item.User,
                    item.Nombre
                });
            }
        }

        private void dgvDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;
            if(iRow >= 0 && iCol >= 0)
            {
                _Usuario = new Usuario()
                {
                    IdUsuario = Convert.ToInt32(dgvDatos.Rows[iRow].Cells["Id"].Value.ToString()),
                    User = dgvDatos.Rows[iRow].Cells["Usuario"].Value.ToString(),
                    Nombre = dgvDatos.Rows[iRow].Cells["Nombre"].Value.ToString(),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBusqueda.SelectedItem).valor.ToString();
            if(dgvDatos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.ToString().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btLimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            cbBusqueda.SelectedIndex = 0;
        }
    }
}
