using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final25_23333187D_58454323F_58451759L
{
    class Ingrediente
    {
        private static int contador = 1;
        private int id;
        private string nombre;
        private int precio;

        public Ingrediente(string anombre, int aprecio)
        {
            this.id = contador++;
            this.nombre = anombre;
            this.precio = aprecio;
        }
    }
}
