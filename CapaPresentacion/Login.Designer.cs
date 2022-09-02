namespace CapaPresentacion
{
    partial class Login
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
            this.lblSistema = new System.Windows.Forms.Label();
            this.picDefault = new FontAwesome.Sharp.IconPictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btIngresar = new FontAwesome.Sharp.IconButton();
            this.btCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.picDefault)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 271);
            this.label1.TabIndex = 0;
            // 
            // lblSistema
            // 
            this.lblSistema.BackColor = System.Drawing.Color.SlateGray;
            this.lblSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Location = new System.Drawing.Point(12, 231);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(324, 31);
            this.lblSistema.TabIndex = 3;
            this.lblSistema.Text = "Asignación Servicios";
            this.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picDefault
            // 
            this.picDefault.BackColor = System.Drawing.Color.SlateGray;
            this.picDefault.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.picDefault.IconColor = System.Drawing.Color.White;
            this.picDefault.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picDefault.IconSize = 117;
            this.picDefault.Location = new System.Drawing.Point(109, 86);
            this.picDefault.Name = "picDefault";
            this.picDefault.Size = new System.Drawing.Size(129, 117);
            this.picDefault.TabIndex = 4;
            this.picDefault.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(382, 72);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(267, 20);
            this.txtUser.TabIndex = 5;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(382, 148);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(267, 20);
            this.txtPwd.TabIndex = 6;
            this.txtPwd.UseSystemPasswordChar = true;
            this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña";
            // 
            // btIngresar
            // 
            this.btIngresar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIngresar.ForeColor = System.Drawing.Color.White;
            this.btIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btIngresar.IconColor = System.Drawing.Color.White;
            this.btIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btIngresar.IconSize = 21;
            this.btIngresar.Location = new System.Drawing.Point(382, 202);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(130, 30);
            this.btIngresar.TabIndex = 9;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btIngresar.UseVisualStyleBackColor = false;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btCancelar.IconColor = System.Drawing.Color.White;
            this.btCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCancelar.IconSize = 21;
            this.btCancelar.Location = new System.Drawing.Point(519, 202);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(130, 30);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 271);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.picDefault);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDefault)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSistema;
        private FontAwesome.Sharp.IconPictureBox picDefault;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btIngresar;
        private FontAwesome.Sharp.IconButton btCancelar;
    }
}