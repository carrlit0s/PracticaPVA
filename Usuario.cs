using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final25_23333187D_58454323F_58451759L
{
    class Usuario
    {
        private static int contador = 1;
        private int id;
        private string nombre;
        private string contraseña;
        private string rol; // "Cliente" o "Admin"

        public Usuario(string anombre, string acontraseña, string arol)
        {
            this.id = contador++;
            this.nombre = anombre;
            this.contraseña = acontraseña;
            this.rol = arol;
        }
    }
}
