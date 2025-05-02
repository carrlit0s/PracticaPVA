using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final25_23333187D_58454323F_58451759L
{
    class Burrito
    {
        private static int contador = 1;
        private int id;
        private string nombre;
        private string tamaño;
        private int precio;
        private List<Ingrediente> ingredientes = new List<Ingrediente>();

        public Burrito(string anombre, string atamaño, int aprecio)
        {
            this.id = contador++;
            this.nombre = anombre;
            this.tamaño = atamaño;
            this.precio = aprecio;
        }
    }
}
