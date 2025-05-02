using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final25_23333187D_58454323F_58451759L
{
    public partial class FormLoggin: Form
    {
        //arreglar conexión con la base de datos
        public static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=BurritoDB;Integrated Security=True";
        public FormLoggin()
        {
            InitializeComponent();
        }

        private void FormLoggin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtnombreusuario.Text.Trim();
            string contraseña = txtcontraseña.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Usuarios WHERE NombreUsuario = @user AND Contraseña = @pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", usuario);
                cmd.Parameters.AddWithValue("@pass", contraseña);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string rol = reader["Rol"].ToString();

                    MessageBox.Show($"Bienvenido {usuario} - Rol: {rol}");
/*
                    if (rol == "admin")
                        new AdminForm().Show();
                    else
                        new ClienteForm().Show();
*/
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario no registrado. Por favor, regístrate primero.");
                    this.Hide();
                    new RegistroForm().Show(); // Lanza formulario de registro
                }
            }
        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroForm registroForm = new RegistroForm();
            registroForm.Show();
        }

        //Eventos Keypress
        private void txtnombreusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                txtcontraseña.Focus();
            }
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
