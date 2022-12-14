using AsignacionServicios.Modales;
using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
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

namespace AsignacionServicios
{
    public partial class frmMovimiento : Form
    {
        private Color Amarillo = Color.FromArgb(220, 247, 154);
        private Color Rojo = Color.FromArgb(247, 158, 139);
        private Color Verde = Color.FromArgb(143, 249, 131);
        public frmMovimiento()
        {
            InitializeComponent();
        }

        private void btLimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.BackColor = Color.White;
            txtCodigoServcio.Text = "";
            txtFecha.Text = "";
            txtUsuario.Text = "";
            txtAsignado.Text = "";
            txtCodigoCliente.Text = "";
            txtCliente.Text = "";
            txtBusqueda.Text = "";
            txtSolucion.Text = "";
            dgvDatos.Rows.Clear();
            txtBusqueda.Select();
        }

        private void btBusqueda_Click(object sender, EventArgs e)
        {
            using (var modal = new mdServicios())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtBusqueda.Text = modal._Servicio.CodigoServicio.ToString();
                }
                else
                {
                    txtBusqueda.BackColor = Color.MistyRose;
                    txtBusqueda.Text = "";
                }
            }
            Servicio oServ = new CN_Servicio().obtenerServicio(txtBusqueda.Text);
            if(oServ.IdServicio != 0)
            {
                txtBusqueda.BackColor = Verde;
                txtCodigoServcio.Text = oServ.CodigoServicio;
                txtFecha.Text = oServ.Fecha;
                txtUsuario.Text = oServ.oUsuario.Nombre;
                txtAsignado.Text = oServ.oAsignado.Nombre;
                txtCodigoCliente.Text = oServ.oCliente.Codigo;
                txtCliente.Text = oServ.oCliente.RazonSocial;
                txtSolucion.Text = "";
                dgvDatos.Rows.Clear();
                foreach (Movimiento dc in oServ.oDetalleServicio)
                {
                    dgvDatos.Rows.Add(new object[]
                    {
                        "",
                        dc.oUsuario.IdUsuario,
                        dc.oUsuario.User,
                        dc.oEstado.IdEstadoServicio,
                        dc.oEstado.Descripcion,
                        dc.FechaRegistro,
                        dc.Bitacora
                    });
                }
            }
            else
            {
                txtBusqueda.BackColor = Rojo;
                txtCodigoServcio.Text = "";
                txtFecha.Text = "";
                txtUsuario.Text = "";
                txtAsignado.Text = "";
                txtCodigoCliente.Text = "";
                txtCliente.Text = "";

                dgvDatos.Rows.Clear();
            }
            agregarColor();
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Servicio oServ = new CN_Servicio().obtenerServicio(txtBusqueda.Text);
                if (oServ.IdServicio != 0)
                {
                    txtBusqueda.BackColor = Verde;
                    txtCodigoServcio.Text = oServ.CodigoServicio;
                    txtFecha.Text = oServ.Fecha;
                    txtUsuario.Text = oServ.oUsuario.Nombre;
                    txtAsignado.Text = oServ.oAsignado.Nombre;
                    txtCodigoCliente.Text = oServ.oCliente.Codigo;
                    txtCliente.Text = oServ.oCliente.RazonSocial;
                    dgvDatos.Rows.Clear();
                    foreach (Movimiento dc in oServ.oDetalleServicio)
                    {
                        dgvDatos.Rows.Add(new object[]
                        {
                        "",
                        dc.oUsuario.IdUsuario,
                        dc.oUsuario.User,
                        dc.oEstado.IdEstadoServicio,
                        dc.oEstado.Descripcion,
                        dc.FechaRegistro,
                        dc.Bitacora
                        });
                    }
                }
                else
                {
                    txtBusqueda.BackColor = Rojo;
                    txtCodigoServcio.Text = "";
                    txtFecha.Text = "";
                    txtUsuario.Text = "";
                    txtAsignado.Text = "";
                    txtCodigoCliente.Text = "";
                    txtCliente.Text = "";
                    txtSolucion.Text = "";

                    dgvDatos.Rows.Clear();
                }
                agregarColor();
            }
         }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDatos.Columns[e.ColumnIndex].Name == "Vacio")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtSolucion.Text = dgvDatos.Rows[indice].Cells["Bitacora"].Value.ToString();
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
                var h = Properties.Resources.check.Height - 15;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new System.Drawing.Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
        private void agregarColor()
        {
            foreach(DataGridViewRow row in dgvDatos.Rows)
            {
                if (Convert.ToInt32(row.Cells["IdEstado"].Value.ToString()) == 1)
                    row.Cells["Estado"].Style.BackColor = Amarillo;
                if (Convert.ToInt32(row.Cells["IdEstado"].Value.ToString()) == 2)
                    row.Cells["Estado"].Style.BackColor = Verde;
                if (Convert.ToInt32(row.Cells["IdEstado"].Value.ToString()) == 3)
                    row.Cells["Estado"].Style.BackColor = Rojo;
            }
        }
    }
}
