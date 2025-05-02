namespace Final25_23333187D_58454323F_58451759L
{
    partial class RegistroForm
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
            this.lblsubtitulo = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblIniciarSesión = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtnombreusuario = new System.Windows.Forms.TextBox();
            this.lblnombreusuario = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsubtitulo
            // 
            this.lblsubtitulo.AutoSize = true;
            this.lblsubtitulo.Location = new System.Drawing.Point(189, 83);
            this.lblsubtitulo.Name = "lblsubtitulo";
            this.lblsubtitulo.Size = new System.Drawing.Size(308, 25);
            this.lblsubtitulo.TabIndex = 3;
            this.lblsubtitulo.Text = "Los burritos más top de Murcia";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Mongolian Baiti", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(225, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(228, 56);
            this.lbltitulo.TabIndex = 2;
            this.lbltitulo.Text = "Burritops";
            // 
            // lblIniciarSesión
            // 
            this.lblIniciarSesión.AutoSize = true;
            this.lblIniciarSesión.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesión.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblIniciarSesión.Location = new System.Drawing.Point(27, 154);
            this.lblIniciarSesión.Name = "lblIniciarSesión";
            this.lblIniciarSesión.Size = new System.Drawing.Size(141, 25);
            this.lblIniciarSesión.TabIndex = 4;
            this.lblIniciarSesión.Text = "Iniciar Sesión";
            this.lblIniciarSesión.Click += new System.EventHandler(this.lblIniciarSesión_Click);
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Location = new System.Drawing.Point(254, 436);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(123, 25);
            this.lblcontraseña.TabIndex = 10;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(254, 475);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(189, 31);
            this.txtcontraseña.TabIndex = 9;
            this.txtcontraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontraseña_KeyPress);
            // 
            // txtnombreusuario
            // 
            this.txtnombreusuario.Location = new System.Drawing.Point(254, 267);
            this.txtnombreusuario.Name = "txtnombreusuario";
            this.txtnombreusuario.Size = new System.Drawing.Size(189, 31);
            this.txtnombreusuario.TabIndex = 8;
            this.txtnombreusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombreusuario_KeyPress);
            // 
            // lblnombreusuario
            // 
            this.lblnombreusuario.AutoSize = true;
            this.lblnombreusuario.Location = new System.Drawing.Point(249, 223);
            this.lblnombreusuario.Name = "lblnombreusuario";
            this.lblnombreusuario.Size = new System.Drawing.Size(194, 25);
            this.lblnombreusuario.TabIndex = 7;
            this.lblnombreusuario.Text = "Nombre de usuario";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(254, 336);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(184, 25);
            this.lblnombre.TabIndex = 12;
            this.lblnombre.Text = "Nombre Completo";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(254, 373);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(189, 31);
            this.txtnombre.TabIndex = 11;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(497, 552);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(141, 43);
            this.btnRegistrarse.TabIndex = 13;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 632);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtnombreusuario);
            this.Controls.Add(this.lblnombreusuario);
            this.Controls.Add(this.lblIniciarSesión);
            this.Controls.Add(this.lblsubtitulo);
            this.Controls.Add(this.lbltitulo);
            this.Name = "RegistroForm";
            this.Text = "RegistroForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsubtitulo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblIniciarSesión;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtnombreusuario;
        private System.Windows.Forms.Label lblnombreusuario;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnRegistrarse;
    }
}