namespace AsignacionServicios
{
    partial class frmModServicios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtServicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricpcion = new System.Windows.Forms.RichTextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblIndice = new System.Windows.Forms.Label();
            this.btAdd = new FontAwesome.Sharp.IconButton();
            this.ckbFactura = new System.Windows.Forms.CheckBox();
            this.ckbHojaServicio = new System.Windows.Forms.CheckBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSolucion = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.btLimpiar = new FontAwesome.Sharp.IconButton();
            this.vacio = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUAsignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HojaServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bitacora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtServicio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDescricpcion);
            this.groupBox1.Controls.Add(this.dgvDatos);
            this.groupBox1.Controls.Add(this.lblIndice);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(300, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 423);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicio";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(509, 402);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 31;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Del";
            // 
            // dtServicio
            // 
            this.dtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtServicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtServicio.Location = new System.Drawing.Point(9, 46);
            this.dtServicio.Name = "dtServicio";
            this.dtServicio.Size = new System.Drawing.Size(118, 20);
            this.dtServicio.TabIndex = 30;
            this.dtServicio.ValueChanged += new System.EventHandler(this.dtServicio_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Descripción";
            // 
            // txtDescricpcion
            // 
            this.txtDescricpcion.Enabled = false;
            this.txtDescricpcion.Location = new System.Drawing.Point(5, 246);
            this.txtDescricpcion.Name = "txtDescricpcion";
            this.txtDescricpcion.Size = new System.Drawing.Size(601, 131);
            this.txtDescricpcion.TabIndex = 28;
            this.txtDescricpcion.Text = "";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vacio,
            this.IdServicio,
            this.CodigoServicio,
            this.Cliente,
            this.IdUsuario,
            this.Supervisor,
            this.IdUAsignado,
            this.Usuario,
            this.IdEstado,
            this.Estado,
            this.Fecha,
            this.Descripcion,
            this.Solucion,
            this.HojaServicio,
            this.Factura,
            this.Bitacora});
            this.dgvDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDatos.Location = new System.Drawing.Point(5, 71);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.Size = new System.Drawing.Size(602, 155);
            this.dgvDatos.TabIndex = 20;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            this.dgvDatos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDatos_CellPainting);
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(555, 403);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(16, 13);
            this.lblIndice.TabIndex = 27;
            this.lblIndice.Text = "-1";
            this.lblIndice.Visible = false;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Green;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btAdd.IconColor = System.Drawing.Color.White;
            this.btAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAdd.IconSize = 21;
            this.btAdd.Location = new System.Drawing.Point(15, 359);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(228, 30);
            this.btAdd.TabIndex = 28;
            this.btAdd.Text = "Guardar";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // ckbFactura
            // 
            this.ckbFactura.AutoSize = true;
            this.ckbFactura.BackColor = System.Drawing.Color.White;
            this.ckbFactura.Enabled = false;
            this.ckbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFactura.Location = new System.Drawing.Point(15, 133);
            this.ckbFactura.Name = "ckbFactura";
            this.ckbFactura.Size = new System.Drawing.Size(62, 17);
            this.ckbFactura.TabIndex = 26;
            this.ckbFactura.Text = "Factura";
            this.ckbFactura.UseVisualStyleBackColor = false;
            // 
            // ckbHojaServicio
            // 
            this.ckbHojaServicio.AutoSize = true;
            this.ckbHojaServicio.BackColor = System.Drawing.Color.White;
            this.ckbHojaServicio.Enabled = false;
            this.ckbHojaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHojaServicio.Location = new System.Drawing.Point(15, 110);
            this.ckbHojaServicio.Name = "ckbHojaServicio";
            this.ckbHojaServicio.Size = new System.Drawing.Size(104, 17);
            this.ckbHojaServicio.TabIndex = 25;
            this.ckbHojaServicio.Text = "Hoja de Servicio";
            this.ckbHojaServicio.UseVisualStyleBackColor = false;
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(15, 83);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(145, 21);
            this.cbEstado.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Solución";
            // 
            // txtSolucion
            // 
            this.txtSolucion.Location = new System.Drawing.Point(15, 174);
            this.txtSolucion.Name = "txtSolucion";
            this.txtSolucion.Size = new System.Drawing.Size(228, 158);
            this.txtSolucion.TabIndex = 21;
            this.txtSolucion.Text = "";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 447);
            this.label2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Usuario";
            // 
            // cbUsuario
            // 
            this.cbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(15, 39);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(145, 21);
            this.cbUsuario.TabIndex = 28;
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.Color.Teal;
            this.btLimpiar.FlatAppearance.BorderSize = 0;
            this.btLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpiar.ForeColor = System.Drawing.Color.White;
            this.btLimpiar.IconChar = FontAwesome.Sharp.IconChar.BroomBall;
            this.btLimpiar.IconColor = System.Drawing.Color.White;
            this.btLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btLimpiar.IconSize = 21;
            this.btLimpiar.Location = new System.Drawing.Point(15, 398);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(228, 30);
            this.btLimpiar.TabIndex = 29;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLimpiar.UseVisualStyleBackColor = false;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // vacio
            // 
            this.vacio.HeaderText = "";
            this.vacio.MinimumWidth = 6;
            this.vacio.Name = "vacio";
            this.vacio.ReadOnly = true;
            this.vacio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vacio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vacio.Width = 30;
            // 
            // IdServicio
            // 
            this.IdServicio.HeaderText = "IdServicio";
            this.IdServicio.Name = "IdServicio";
            this.IdServicio.ReadOnly = true;
            this.IdServicio.Visible = false;
            // 
            // CodigoServicio
            // 
            this.CodigoServicio.HeaderText = "Codigo Servicio";
            this.CodigoServicio.Name = "CodigoServicio";
            this.CodigoServicio.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 200;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            // 
            // Supervisor
            // 
            this.Supervisor.HeaderText = "Supervisor";
            this.Supervisor.Name = "Supervisor";
            this.Supervisor.ReadOnly = true;
            this.Supervisor.Width = 150;
            // 
            // IdUAsignado
            // 
            this.IdUAsignado.HeaderText = "IdUAsignado";
            this.IdUAsignado.Name = "IdUAsignado";
            this.IdUAsignado.ReadOnly = true;
            this.IdUAsignado.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 150;
            // 
            // IdEstado
            // 
            this.IdEstado.HeaderText = "IdEstado";
            this.IdEstado.Name = "IdEstado";
            this.IdEstado.ReadOnly = true;
            this.IdEstado.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Visible = false;
            // 
            // Solucion
            // 
            this.Solucion.HeaderText = "Solucion";
            this.Solucion.Name = "Solucion";
            this.Solucion.ReadOnly = true;
            this.Solucion.Visible = false;
            // 
            // HojaServicio
            // 
            this.HojaServicio.HeaderText = "HojaServicio";
            this.HojaServicio.Name = "HojaServicio";
            this.HojaServicio.ReadOnly = true;
            this.HojaServicio.Visible = false;
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            this.Factura.Visible = false;
            // 
            // Bitacora
            // 
            this.Bitacora.HeaderText = "Ultimo movimiento";
            this.Bitacora.Name = "Bitacora";
            this.Bitacora.ReadOnly = true;
            this.Bitacora.Width = 250;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(458, 403);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(13, 13);
            this.lblCodigo.TabIndex = 32;
            this.lblCodigo.Text = "0";
            this.lblCodigo.Visible = false;
            // 
            // frmModServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 447);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.txtSolucion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckbFactura);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.ckbHojaServicio);
            this.Controls.Add(this.label2);
            this.Name = "frmModServicios";
            this.Text = "frmModServicios";
            this.Load += new System.EventHandler(this.frmModServicios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtSolucion;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbFactura;
        private System.Windows.Forms.CheckBox ckbHojaServicio;
        private System.Windows.Forms.Label lblIndice;
        private FontAwesome.Sharp.IconButton btAdd;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtServicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDescricpcion;
        private System.Windows.Forms.Label lblId;
        private FontAwesome.Sharp.IconButton btLimpiar;
        private System.Windows.Forms.DataGridViewButtonColumn vacio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUAsignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn HojaServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bitacora;
        private System.Windows.Forms.Label lblCodigo;
    }
}