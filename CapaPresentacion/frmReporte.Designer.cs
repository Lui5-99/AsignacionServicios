namespace AsignacionServicios
{
    partial class frmReporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btBuscar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.IdServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUAsignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioEncargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bitacora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HojaServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnexportar = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btUser = new FontAwesome.Sharp.IconButton();
            this.btAsignado = new FontAwesome.Sharp.IconButton();
            this.btCliente = new FontAwesome.Sharp.IconButton();
            this.lblIdUsuaurio = new System.Windows.Forms.Label();
            this.lblIdUAsignado = new System.Windows.Forms.Label();
            this.btLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 9);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(996, 109);
            this.label10.TabIndex = 57;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Reporte Bítacora";
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "dd/MM/yyyy";
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(106, 53);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(97, 20);
            this.dtFecha.TabIndex = 207;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 208;
            this.label4.Text = "Fecha:";
            // 
            // btBuscar
            // 
            this.btBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btBuscar.IconColor = System.Drawing.Color.Black;
            this.btBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btBuscar.IconSize = 17;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btBuscar.Location = new System.Drawing.Point(775, 89);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(78, 21);
            this.btBuscar.TabIndex = 215;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 213;
            this.label5.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 132);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(996, 306);
            this.label1.TabIndex = 216;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdServicio,
            this.CodigoServicio,
            this.IdUsuario,
            this.Usuario,
            this.IdUAsignado,
            this.UsuarioEncargado,
            this.Cliente,
            this.IdEstado,
            this.Estado,
            this.Fecha,
            this.Descripcion,
            this.Bitacora,
            this.HojaServicio,
            this.Factura});
            this.dgvDatos.Location = new System.Drawing.Point(23, 194);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.Size = new System.Drawing.Size(969, 219);
            this.dgvDatos.TabIndex = 217;
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
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // IdUAsignado
            // 
            this.IdUAsignado.HeaderText = "IdUAsignado";
            this.IdUAsignado.Name = "IdUAsignado";
            this.IdUAsignado.ReadOnly = true;
            this.IdUAsignado.Visible = false;
            // 
            // UsuarioEncargado
            // 
            this.UsuarioEncargado.HeaderText = "Usuario Encargado";
            this.UsuarioEncargado.Name = "UsuarioEncargado";
            this.UsuarioEncargado.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
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
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Bitacora
            // 
            this.Bitacora.HeaderText = "Bitacora";
            this.Bitacora.Name = "Bitacora";
            this.Bitacora.ReadOnly = true;
            // 
            // HojaServicio
            // 
            this.HojaServicio.HeaderText = "Hoja de servicio";
            this.HojaServicio.Name = "HojaServicio";
            this.HojaServicio.ReadOnly = true;
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            // 
            // btnexportar
            // 
            this.btnexportar.BackColor = System.Drawing.SystemColors.Control;
            this.btnexportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexportar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnexportar.IconColor = System.Drawing.Color.LimeGreen;
            this.btnexportar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnexportar.IconSize = 17;
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexportar.Location = new System.Drawing.Point(23, 157);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(118, 21);
            this.btnexportar.TabIndex = 223;
            this.btnexportar.Text = "Descargar Excel";
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportar.UseVisualStyleBackColor = false;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.White;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 16;
            this.btnbuscar.Location = new System.Drawing.Point(898, 151);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(42, 23);
            this.btnbuscar.TabIndex = 221;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.White;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.FlatAppearance.BorderSize = 0;
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 18;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(946, 151);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(42, 23);
            this.btnlimpiarbuscador.TabIndex = 222;
            this.btnlimpiarbuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(740, 154);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(152, 20);
            this.txtBusqueda.TabIndex = 220;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Location = new System.Drawing.Point(618, 154);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(116, 21);
            this.cbBusqueda.TabIndex = 219;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(551, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 218;
            this.label11.Text = "Buscar por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 224;
            this.label3.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(275, 53);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(159, 20);
            this.txtUsuario.TabIndex = 225;
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(275, 88);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(159, 20);
            this.txtEncargado.TabIndex = 227;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 226;
            this.label6.Text = "Encargado";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(565, 53);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(327, 20);
            this.txtCliente.TabIndex = 228;
            // 
            // btUser
            // 
            this.btUser.BackColor = System.Drawing.Color.White;
            this.btUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btUser.FlatAppearance.BorderSize = 0;
            this.btUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUser.ForeColor = System.Drawing.Color.Black;
            this.btUser.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btUser.IconColor = System.Drawing.Color.Black;
            this.btUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btUser.IconSize = 16;
            this.btUser.Location = new System.Drawing.Point(440, 53);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(42, 23);
            this.btUser.TabIndex = 229;
            this.btUser.UseVisualStyleBackColor = false;
            this.btUser.Click += new System.EventHandler(this.btUser_Click);
            // 
            // btAsignado
            // 
            this.btAsignado.BackColor = System.Drawing.Color.White;
            this.btAsignado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAsignado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btAsignado.FlatAppearance.BorderSize = 0;
            this.btAsignado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAsignado.ForeColor = System.Drawing.Color.Black;
            this.btAsignado.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btAsignado.IconColor = System.Drawing.Color.Black;
            this.btAsignado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAsignado.IconSize = 16;
            this.btAsignado.Location = new System.Drawing.Point(440, 88);
            this.btAsignado.Name = "btAsignado";
            this.btAsignado.Size = new System.Drawing.Size(42, 23);
            this.btAsignado.TabIndex = 230;
            this.btAsignado.UseVisualStyleBackColor = false;
            this.btAsignado.Click += new System.EventHandler(this.btAsignado_Click);
            // 
            // btCliente
            // 
            this.btCliente.BackColor = System.Drawing.Color.White;
            this.btCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btCliente.FlatAppearance.BorderSize = 0;
            this.btCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCliente.ForeColor = System.Drawing.Color.Black;
            this.btCliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btCliente.IconColor = System.Drawing.Color.Black;
            this.btCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCliente.IconSize = 16;
            this.btCliente.Location = new System.Drawing.Point(898, 53);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(42, 23);
            this.btCliente.TabIndex = 231;
            this.btCliente.UseVisualStyleBackColor = false;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // lblIdUsuaurio
            // 
            this.lblIdUsuaurio.AutoSize = true;
            this.lblIdUsuaurio.BackColor = System.Drawing.Color.White;
            this.lblIdUsuaurio.Location = new System.Drawing.Point(275, 34);
            this.lblIdUsuaurio.Name = "lblIdUsuaurio";
            this.lblIdUsuaurio.Size = new System.Drawing.Size(13, 13);
            this.lblIdUsuaurio.TabIndex = 232;
            this.lblIdUsuaurio.Text = "0";
            this.lblIdUsuaurio.Visible = false;
            // 
            // lblIdUAsignado
            // 
            this.lblIdUAsignado.AutoSize = true;
            this.lblIdUAsignado.BackColor = System.Drawing.Color.White;
            this.lblIdUAsignado.Location = new System.Drawing.Point(378, 34);
            this.lblIdUAsignado.Name = "lblIdUAsignado";
            this.lblIdUAsignado.Size = new System.Drawing.Size(13, 13);
            this.lblIdUAsignado.TabIndex = 233;
            this.lblIdUAsignado.Text = "0";
            this.lblIdUAsignado.Visible = false;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btLimpiar.IconColor = System.Drawing.Color.Black;
            this.btLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btLimpiar.IconSize = 17;
            this.btLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btLimpiar.Location = new System.Drawing.Point(862, 89);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(78, 21);
            this.btLimpiar.TabIndex = 234;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 447);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.lblIdUAsignado);
            this.Controls.Add(this.lblIdUsuaurio);
            this.Controls.Add(this.btCliente);
            this.Controls.Add(this.btAsignado);
            this.Controls.Add(this.btUser);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtEncargado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cbBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Name = "frmReporte";
            this.Text = "frmReporteCompras";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private FontAwesome.Sharp.IconButton btnexportar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cbBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCliente;
        private FontAwesome.Sharp.IconButton btUser;
        private FontAwesome.Sharp.IconButton btAsignado;
        private FontAwesome.Sharp.IconButton btCliente;
        private System.Windows.Forms.Label lblIdUsuaurio;
        private System.Windows.Forms.Label lblIdUAsignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUAsignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioEncargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn HojaServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private FontAwesome.Sharp.IconButton btLimpiar;
    }
}