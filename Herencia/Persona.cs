using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Persona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Edad { get; set; }

        public int EyeColor { get; set; }

        public string Greet() 
        {
            return $"Hola mi nombre es {Nombre}";
        }
    }
}
