using AsignacionServicios.Modales;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
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
    public partial class frmReporte : Form
    {
        private Color Amarillo = Color.FromArgb(220, 247, 154);
        private Color Rojo = Color.FromArgb(247, 158, 139);
        private Color Verde = Color.FromArgb(143, 249, 131);
        public frmReporte()
        {
            InitializeComponent();
        }

        private void btUser_Click(object sender, EventArgs e)
        {
            using (var modal = new mdUsuario(2))
            {
                var result = modal.ShowDialog();
                if(result == DialogResult.OK)
                {
                    txtUsuario.Text = modal._Usuario.Nombre;
                    txtUsuario.BackColor = Verde;
                    lblIdUsuaurio.Text = modal._Usuario.IdUsuario.ToString();
                }
                else
                {
                    txtUsuario.Text = "";
                    txtUsuario.BackColor = Rojo;
                    lblIdUsuaurio.Text = "0";
                }
            }
        }

        private void btAsignado_Click(object sender, EventArgs e)
        {
            using (var modal = new mdUsuario(1))
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtEncargado.Text = modal._Usuario.Nombre;
                    txtEncargado.BackColor = Verde;
                    lblIdUAsignado.Text = modal._Usuario.IdUsuario.ToString();
                }
                else
                {
                    txtEncargado.Text = "";
                    txtEncargado.BackColor = Rojo;
                    lblIdUAsignado.Text = "0";
                }
            }
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtCliente.Text = modal._Cliente.RazonSocial;
                    txtCliente.BackColor = Verde;
                }
                else
                {
                    txtCliente.Text = "";
                    txtCliente.BackColor = Rojo;
                }
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            /*if (!(txtUsuario.Text == string.Empty || txtEncargado.Text == string.Empty || txtCliente.Text == string.Empty))
            {*/
                dgvDatos.Rows.Clear();
                string fecha = dtFecha.Value.ToString("yyyyMMdd");
                Servicio oServ = new Servicio()
                {
                    oUsuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(lblIdUsuaurio.Text)
                    },
                    oAsignado = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(lblIdUAsignado.Text)
                    },
                    oCliente = new Cliente()
                    {
                        RazonSocial = txtCliente.Text
                    },
                };
                List<Servicio> ls = new CN_Servicio().ListarBitacora(fecha, 1, oServ);
                foreach (Servicio item in ls)
                {
                    dgvDatos.Rows.Add(new object[]
                    {
                       item.IdServicio,
                       item.CodigoServicio,
                       item.oUsuario.IdUsuario,
                       item.oUsuario.Nombre,
                       item.oAsignado.IdUsuario,
                       item.oAsignado.Nombre,
                       item.oCliente.RazonSocial,
                       item.oEstado.IdEstadoServicio,
                       item.oEstado.Descripcion,
                       item.Fecha,
                       item.Descripcion,
                       item.Bitacora,
                       item.HojaServicio == true ? "Si" : "No",
                       item.Factura == true ? "Si" : "No"
                    });
                }
           /* }
            else
            {
                MessageBox.Show("Algún campo está vacío", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            limpiar();
            Servicio oServ = null;
            string fecha = DateTime.Now.ToString("yyyyMMdd");
            List<Servicio> ls = new CN_Servicio().ListarBitacora(fecha, 0, oServ);
            foreach (Servicio item in ls)
            {
                dgvDatos.Rows.Add(new object[]
                {
                   item.IdServicio,
                   item.CodigoServicio,
                   item.oUsuario.IdUsuario,
                   item.oUsuario.Nombre,
                   item.oAsignado.IdUsuario,
                   item.oAsignado.Nombre,
                   item.oCliente.RazonSocial,
                   item.oEstado.IdEstadoServicio,
                   item.oEstado.Descripcion,
                   item.Fecha,
                   item.Descripcion,
                   item.Bitacora,
                   item.HojaServicio == true ? "Si" : "No",
                   item.Factura == true ? "Si" : "No"
                });
            }
            foreach (DataGridViewColumn column in dgvDatos.Columns)
            {
                if (column.Visible)
                {
                    cbBusqueda.Items.Add(new OpcionCombo()
                    {
                        valor = column.Name,
                        texto = column.HeaderText,
                    });
                }
            }
            cbBusqueda.DisplayMember = "texto";
            cbBusqueda.ValueMember = "valor";
            cbBusqueda.SelectedIndex = 0;
        }
        private void limpiar()
        {
            dgvDatos.Rows.Clear();
            txtBusqueda.Text = "";
            txtUsuario.Text = "";
            txtUsuario.BackColor = Color.White;
            txtEncargado.Text = "";
            txtEncargado.BackColor = Color.White;
            txtCliente.Text = "";
            txtCliente.BackColor = Color.White;
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            Servicio oServ = null;
            string fecha = DateTime.Now.ToString("yyyyMMdd");
            List<Servicio> ls = new CN_Servicio().ListarBitacora(fecha, 0, oServ);
            foreach (Servicio item in ls)
            {
                dgvDatos.Rows.Add(new object[]
                {
                   item.IdServicio,
                   item.CodigoServicio,
                   item.oUsuario.IdUsuario,
                   item.oUsuario.Nombre,
                   item.oAsignado.IdUsuario,
                   item.oAsignado.Nombre,
                   item.oCliente.RazonSocial,
                   item.oEstado.IdEstadoServicio,
                   item.oEstado.Descripcion,
                   item.Fecha,
                   item.Descripcion,
                   item.Bitacora,
                   item.HojaServicio == true ? "Si" : "No",
                   item.Factura == true ? "Si" : "No"
                });
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count < 1)
                MessageBox.Show("No hay datos por exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn column in dgvDatos.Columns)
                {
                    if (column.HeaderText != "" && column.Visible)
                    {
                        dt.Columns.Add(column.HeaderText, typeof(string));
                    }
                }
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new object[]
                        {
                            row.Cells[1].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString() == "true" ? "Si" : "No",
                            row.Cells[13].Value.ToString() == "true" ? "Si" : "No",

                        });
                    }
                }
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteBitacora_{0}.xlsx", DateTime.Now.ToString("yyyyMMddHHmm"));
                saveFile.Filter = "Excel Files| *.xlsx; *.xlsm; *.xlsb; *.xls; *‌​.xml";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var sheet = wb.Worksheets.Add(dt, "Bitacora");
                        sheet.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Excel generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar excel\n" + ex.Message.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
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
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.ToString().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
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

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            cbBusqueda.SelectedIndex = 0;
        }
    }
}
