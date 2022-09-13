namespace AsignacionServicios
{
    partial class frmConfiguracion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbUusario = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuReportes = new System.Windows.Forms.CheckBox();
            this.menuAcercade = new System.Windows.Forms.CheckBox();
            this.menuConfiguracion = new System.Windows.Forms.CheckBox();
            this.menuClientes = new System.Windows.Forms.CheckBox();
            this.menuServicio = new System.Windows.Forms.CheckBox();
            this.menuUsuario = new System.Windows.Forms.CheckBox();
            this.btGuardarPermiso = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Descripción = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.btGuardarRol = new FontAwesome.Sharp.IconButton();
            this.txtIdRol = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 447);
            this.label1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Permisos";
            // 
            // cbUusario
            // 
            this.cbUusario.FormattingEnabled = true;
            this.cbUusario.Location = new System.Drawing.Point(28, 70);
            this.cbUusario.Margin = new System.Windows.Forms.Padding(2);
            this.cbUusario.Name = "cbUusario";
            this.cbUusario.Size = new System.Drawing.Size(222, 21);
            this.cbUusario.TabIndex = 44;
            this.cbUusario.SelectedIndexChanged += new System.EventHandler(this.cbUusario_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tipo usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.menuReportes);
            this.groupBox1.Controls.Add(this.menuAcercade);
            this.groupBox1.Controls.Add(this.menuConfiguracion);
            this.groupBox1.Controls.Add(this.menuClientes);
            this.groupBox1.Controls.Add(this.menuServicio);
            this.groupBox1.Controls.Add(this.menuUsuario);
            this.groupBox1.Location = new System.Drawing.Point(28, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 171);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos usuarios";
            // 
            // menuReportes
            // 
            this.menuReportes.AutoSize = true;
            this.menuReportes.Location = new System.Drawing.Point(7, 90);
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(69, 17);
            this.menuReportes.TabIndex = 9;
            this.menuReportes.Text = "Reportes";
            this.menuReportes.UseVisualStyleBackColor = true;
            // 
            // menuAcercade
            // 
            this.menuAcercade.AutoSize = true;
            this.menuAcercade.Location = new System.Drawing.Point(7, 136);
            this.menuAcercade.Name = "menuAcercade";
            this.menuAcercade.Size = new System.Drawing.Size(75, 17);
            this.menuAcercade.TabIndex = 8;
            this.menuAcercade.Text = "Acerca de";
            this.menuAcercade.UseVisualStyleBackColor = true;
            // 
            // menuConfiguracion
            // 
            this.menuConfiguracion.AutoSize = true;
            this.menuConfiguracion.Location = new System.Drawing.Point(7, 113);
            this.menuConfiguracion.Name = "menuConfiguracion";
            this.menuConfiguracion.Size = new System.Drawing.Size(91, 17);
            this.menuConfiguracion.TabIndex = 7;
            this.menuConfiguracion.Text = "Configuración";
            this.menuConfiguracion.UseVisualStyleBackColor = true;
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = true;
            this.menuClientes.Location = new System.Drawing.Point(7, 67);
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(63, 17);
            this.menuClientes.TabIndex = 4;
            this.menuClientes.Text = "Clientes";
            this.menuClientes.UseVisualStyleBackColor = true;
            // 
            // menuServicio
            // 
            this.menuServicio.AutoSize = true;
            this.menuServicio.Location = new System.Drawing.Point(7, 44);
            this.menuServicio.Name = "menuServicio";
            this.menuServicio.Size = new System.Drawing.Size(64, 17);
            this.menuServicio.TabIndex = 1;
            this.menuServicio.Text = "Servicio";
            this.menuServicio.UseVisualStyleBackColor = true;
            // 
            // menuUsuario
            // 
            this.menuUsuario.AutoSize = true;
            this.menuUsuario.Location = new System.Drawing.Point(7, 20);
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(62, 17);
            this.menuUsuario.TabIndex = 0;
            this.menuUsuario.Text = "Usuario";
            this.menuUsuario.UseVisualStyleBackColor = true;
            // 
            // btGuardarPermiso
            // 
            this.btGuardarPermiso.BackColor = System.Drawing.Color.Green;
            this.btGuardarPermiso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardarPermiso.ForeColor = System.Drawing.Color.White;
            this.btGuardarPermiso.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btGuardarPermiso.IconColor = System.Drawing.Color.White;
            this.btGuardarPermiso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btGuardarPermiso.IconSize = 20;
            this.btGuardarPermiso.Location = new System.Drawing.Point(29, 294);
            this.btGuardarPermiso.Margin = new System.Windows.Forms.Padding(2);
            this.btGuardarPermiso.Name = "btGuardarPermiso";
            this.btGuardarPermiso.Size = new System.Drawing.Size(221, 29);
            this.btGuardarPermiso.TabIndex = 46;
            this.btGuardarPermiso.Text = "Guardar";
            this.btGuardarPermiso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGuardarPermiso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btGuardarPermiso.UseVisualStyleBackColor = false;
            this.btGuardarPermiso.Click += new System.EventHandler(this.btGuardarPermiso_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(298, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 447);
            this.label2.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Roles";
            // 
            // Descripción
            // 
            this.Descripción.AutoSize = true;
            this.Descripción.BackColor = System.Drawing.Color.White;
            this.Descripción.Location = new System.Drawing.Point(304, 54);
            this.Descripción.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Descripción.Name = "Descripción";
            this.Descripción.Size = new System.Drawing.Size(65, 13);
            this.Descripción.TabIndex = 49;
            this.Descripción.Text = "Tipo usuario";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(301, 71);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(222, 20);
            this.txtRol.TabIndex = 50;
            // 
            // btGuardarRol
            // 
            this.btGuardarRol.BackColor = System.Drawing.Color.Green;
            this.btGuardarRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardarRol.ForeColor = System.Drawing.Color.White;
            this.btGuardarRol.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btGuardarRol.IconColor = System.Drawing.Color.White;
            this.btGuardarRol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btGuardarRol.IconSize = 20;
            this.btGuardarRol.Location = new System.Drawing.Point(301, 106);
            this.btGuardarRol.Margin = new System.Windows.Forms.Padding(2);
            this.btGuardarRol.Name = "btGuardarRol";
            this.btGuardarRol.Size = new System.Drawing.Size(221, 29);
            this.btGuardarRol.TabIndex = 51;
            this.btGuardarRol.Text = "Guardar";
            this.btGuardarRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGuardarRol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btGuardarRol.UseVisualStyleBackColor = false;
            this.btGuardarRol.Click += new System.EventHandler(this.btGuardarRol_Click);
            // 
            // txtIdRol
            // 
            this.txtIdRol.Location = new System.Drawing.Point(213, 23);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.Size = new System.Drawing.Size(37, 20);
            this.txtIdRol.TabIndex = 52;
            this.txtIdRol.Visible = false;
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 447);
            this.Controls.Add(this.txtIdRol);
            this.Controls.Add(this.btGuardarRol);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.Descripción);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btGuardarPermiso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbUusario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConfiguracion";
            this.Text = "frmConfiguracion";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbUusario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox menuClientes;
        private System.Windows.Forms.CheckBox menuServicio;
        private System.Windows.Forms.CheckBox menuUsuario;
        private System.Windows.Forms.CheckBox menuAcercade;
        private System.Windows.Forms.CheckBox menuConfiguracion;
        private FontAwesome.Sharp.IconButton btGuardarPermiso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Descripción;
        private System.Windows.Forms.TextBox txtRol;
        private FontAwesome.Sharp.IconButton btGuardarRol;
        private System.Windows.Forms.TextBox txtIdRol;
        private System.Windows.Forms.CheckBox menuReportes;
    }
}