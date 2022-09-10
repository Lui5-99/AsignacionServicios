namespace AsignacionServicios
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.menuServicio = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuAgregar = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuVer = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuDetalles = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuConfiguracion = new FontAwesome.Sharp.IconMenuItem();
            this.menuAcercade = new FontAwesome.Sharp.IconMenuItem();
            this.lblSistema = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuario,
            this.menuServicio,
            this.menuClientes,
            this.menuConfiguracion,
            this.menuAcercade});
            this.menu.Location = new System.Drawing.Point(0, 48);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1019, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuUsuario
            // 
            this.menuUsuario.AutoSize = false;
            this.menuUsuario.BackColor = System.Drawing.Color.White;
            this.menuUsuario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menuUsuario.IconColor = System.Drawing.Color.Black;
            this.menuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuario.IconSize = 50;
            this.menuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(122, 69);
            this.menuUsuario.Text = "Usuarios";
            this.menuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuario.Click += new System.EventHandler(this.menuUsuario_Click);
            // 
            // menuServicio
            // 
            this.menuServicio.AutoSize = false;
            this.menuServicio.BackColor = System.Drawing.Color.White;
            this.menuServicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuAgregar,
            this.subMenuVer,
            this.SubMenuDetalles});
            this.menuServicio.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.menuServicio.IconColor = System.Drawing.Color.Black;
            this.menuServicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuServicio.IconSize = 50;
            this.menuServicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuServicio.Name = "menuServicio";
            this.menuServicio.Size = new System.Drawing.Size(122, 69);
            this.menuServicio.Text = "Servicios";
            this.menuServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuServicio.Click += new System.EventHandler(this.menuServicio_Click);
            // 
            // subMenuAgregar
            // 
            this.subMenuAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuAgregar.IconColor = System.Drawing.Color.Black;
            this.subMenuAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuAgregar.Name = "subMenuAgregar";
            this.subMenuAgregar.Size = new System.Drawing.Size(115, 22);
            this.subMenuAgregar.Text = "Nuevo";
            this.subMenuAgregar.Click += new System.EventHandler(this.subMenuAgregar_Click);
            // 
            // subMenuVer
            // 
            this.subMenuVer.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuVer.IconColor = System.Drawing.Color.Black;
            this.subMenuVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuVer.Name = "subMenuVer";
            this.subMenuVer.Size = new System.Drawing.Size(115, 22);
            this.subMenuVer.Text = "Ver";
            this.subMenuVer.Visible = false;
            this.subMenuVer.Click += new System.EventHandler(this.subMenuVer_Click);
            // 
            // SubMenuDetalles
            // 
            this.SubMenuDetalles.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuDetalles.IconColor = System.Drawing.Color.Black;
            this.SubMenuDetalles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuDetalles.Name = "SubMenuDetalles";
            this.SubMenuDetalles.Size = new System.Drawing.Size(115, 22);
            this.SubMenuDetalles.Text = "Detalles";
            this.SubMenuDetalles.Click += new System.EventHandler(this.SubMenuDetalles_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = false;
            this.menuClientes.BackColor = System.Drawing.Color.White;
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 50;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(122, 69);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuConfiguracion
            // 
            this.menuConfiguracion.AutoSize = false;
            this.menuConfiguracion.BackColor = System.Drawing.Color.White;
            this.menuConfiguracion.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.menuConfiguracion.IconColor = System.Drawing.Color.Black;
            this.menuConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuConfiguracion.IconSize = 50;
            this.menuConfiguracion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuConfiguracion.Name = "menuConfiguracion";
            this.menuConfiguracion.Size = new System.Drawing.Size(122, 69);
            this.menuConfiguracion.Text = "Configuración";
            this.menuConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuConfiguracion.Click += new System.EventHandler(this.menuConfiguracion_Click);
            // 
            // menuAcercade
            // 
            this.menuAcercade.AutoSize = false;
            this.menuAcercade.BackColor = System.Drawing.Color.White;
            this.menuAcercade.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.menuAcercade.IconColor = System.Drawing.Color.Black;
            this.menuAcercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAcercade.IconSize = 50;
            this.menuAcercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAcercade.Name = "menuAcercade";
            this.menuAcercade.Size = new System.Drawing.Size(122, 69);
            this.menuAcercade.Text = "Acerca de";
            this.menuAcercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuAcercade.Click += new System.EventHandler(this.menuAcercade_Click);
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.BackColor = System.Drawing.Color.SteelBlue;
            this.lblSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Location = new System.Drawing.Point(12, 9);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(298, 31);
            this.lblSistema.TabIndex = 2;
            this.lblSistema.Text = "Asignación de servicios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(831, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(890, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 15);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1019, 48);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 121);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1019, 492);
            this.contenedor.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 613);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem menuUsuario;
        private FontAwesome.Sharp.IconMenuItem menuServicio;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuConfiguracion;
        private FontAwesome.Sharp.IconMenuItem menuAcercade;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem subMenuAgregar;
        private FontAwesome.Sharp.IconMenuItem SubMenuDetalles;
        private FontAwesome.Sharp.IconMenuItem subMenuVer;
    }
}