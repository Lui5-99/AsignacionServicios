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
    public partial class mdServicios : Form
    {
        public Servicio _Servicio{ get; set; }
        public mdServicios()
        {
            InitializeComponent();
        }

        private void dtServicio_ValueChanged(object sender, EventArgs e)
        {
            dgvDatos.Rows.Clear();
            string fecha = dtServicio.Value.ToString("yyyyMMdd");
            List<Servicio> ls = new CN_Servicio().Listar(fecha);
            foreach (Servicio item in ls)
            {
                dgvDatos.Rows.Add(new object[]
                {
                   item.IdServicio,
                   item.CodigoServicio,
                   item.oCliente.RazonSocial,
                   item.Descripcion
                });
            }
        }

        private void mdServicios_Load(object sender, EventArgs e)
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
            dgvDatos.Rows.Clear();
            string fecha = DateTime.Now.ToString("yyyyMMdd");
            List<Servicio> ls = new CN_Servicio().Listar(fecha);
            foreach (Servicio item in ls)
            {
                dgvDatos.Rows.Add(new object[]
                {
                   item.IdServicio,
                   item.CodigoServicio,
                   item.oCliente.RazonSocial,
                   item.Descripcion
                });
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
            cbBusqueda.SelectedIndex = 0;
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;
            if (iRow >= 0 && iCol >= 0)
            {
                _Servicio = new Servicio()
                {
                    IdServicio = Convert.ToInt32(dgvDatos.Rows[iRow].Cells["Id"].Value.ToString()),
                    CodigoServicio = dgvDatos.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    oCliente = new Cliente()
                    {
                       RazonSocial = dgvDatos.Rows[iRow].Cells["Nombre"].Value.ToString()
                    }  

                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
