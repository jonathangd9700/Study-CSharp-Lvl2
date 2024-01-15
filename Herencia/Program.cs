using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();

            p1.Nombre = "Abril";

            Developer d1 = new Developer();

            d1.Nombre = "Jon";

            Console.WriteLine(p1.Greet());

            Console.WriteLine(d1.Greet());

            Console.ReadKey();
        }
    }
}
