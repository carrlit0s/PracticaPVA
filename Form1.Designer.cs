namespace Final25_23333187D_58454323F_58451759L
{
    partial class FormLoggin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblsubtitulo = new System.Windows.Forms.Label();
            this.lblRegistrarse = new System.Windows.Forms.Label();
            this.lblnombreusuario = new System.Windows.Forms.Label();
            this.txtnombreusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Mongolian Baiti", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(196, 23);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(228, 56);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Burritops";
            // 
            // lblsubtitulo
            // 
            this.lblsubtitulo.AutoSize = true;
            this.lblsubtitulo.Location = new System.Drawing.Point(160, 97);
            this.lblsubtitulo.Name = "lblsubtitulo";
            this.lblsubtitulo.Size = new System.Drawing.Size(308, 25);
            this.lblsubtitulo.TabIndex = 1;
            this.lblsubtitulo.Text = "Los burritos más top de Murcia";
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRegistrarse.Location = new System.Drawing.Point(30, 153);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(122, 25);
            this.lblRegistrarse.TabIndex = 2;
            this.lblRegistrarse.Text = "Registrarse";
            this.lblRegistrarse.Click += new System.EventHandler(this.lblRegistrarse_Click);
            // 
            // lblnombreusuario
            // 
            this.lblnombreusuario.AutoSize = true;
            this.lblnombreusuario.Location = new System.Drawing.Point(201, 235);
            this.lblnombreusuario.Name = "lblnombreusuario";
            this.lblnombreusuario.Size = new System.Drawing.Size(194, 25);
            this.lblnombreusuario.TabIndex = 3;
            this.lblnombreusuario.Text = "Nombre de usuario";
            // 
            // txtnombreusuario
            // 
            this.txtnombreusuario.Location = new System.Drawing.Point(206, 279);
            this.txtnombreusuario.Name = "txtnombreusuario";
            this.txtnombreusuario.Size = new System.Drawing.Size(189, 31);
            this.txtnombreusuario.TabIndex = 4;
            this.txtnombreusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombreusuario_KeyPress);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(206, 411);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(189, 31);
            this.txtcontraseña.TabIndex = 5;
            this.txtcontraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontraseña_KeyPress);
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Location = new System.Drawing.Point(206, 353);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(123, 25);
            this.lblcontraseña.TabIndex = 6;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(468, 475);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 40);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormLoggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 538);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtnombreusuario);
            this.Controls.Add(this.lblnombreusuario);
            this.Controls.Add(this.lblRegistrarse);
            this.Controls.Add(this.lblsubtitulo);
            this.Controls.Add(this.lbltitulo);
            this.Name = "FormLoggin";
            this.Text = "Loggin";
            this.Load += new System.EventHandler(this.FormLoggin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblsubtitulo;
        private System.Windows.Forms.Label lblRegistrarse;
        private System.Windows.Forms.Label lblnombreusuario;
        private System.Windows.Forms.TextBox txtnombreusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Button btnLogin;
    }
}

