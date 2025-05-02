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
    public partial class RegistroForm: Form
    {
        public static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=BurritoDB;Integrated Security=True";
        List<Usuario> usuarios = new List<Usuario>();
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void lblIniciarSesión_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoggin loginForm = new FormLoggin();
            loginForm.Show();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtnombreusuario.Text.Trim();
            string contraseña = txtcontraseña.Text.Trim();
            //creamos un usuario con los datos introducidos y lo añadimos a la lista de usuarios
            Usuario usuario = new Usuario(nombreUsuario, contraseña, "Cliente");
            usuarios.Add(usuario);

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            // Aquí deberías agregar la lógica para guardar el nuevo usuario en la base de datos

            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();

            string query = "INSERT INTO Usuarios (NombreUsuario, Contraseña, Rol) VALUES (@nombreUsuario, @contraseña, 'Cliente')";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            comando.ExecuteNonQuery();
            conexion.Close();
            // Mostrar un mensaje de éxito
            MessageBox.Show("Usuario registrado correctamente.");

            //redirigir al formulario de inicio de sesión
            this.Hide();
            FormLoggin loginForm = new FormLoggin();
            loginForm.Show();
        }

        // Eventos para manejar el evento KeyPress
        private void txtnombreusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                txtnombre.Focus();
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtcontraseña.Focus();
            }
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnRegistrarse.PerformClick();
            }
        }
    }
}
