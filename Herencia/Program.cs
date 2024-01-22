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
            Persona p2 = new Persona();


            p1.Nombre = "Abril";
            p2.Nombre = "Martin";

            Developer d1 = new Developer();

            d1.Nombre = "Jon";

            Console.WriteLine(p1.Greet());

            Console.WriteLine(d1.Greet());

            Console.WriteLine("Testing commits");
            Console.WriteLine("Testing again");

            List<Persona> listaPersonas = new List<Persona>();

            listaPersonas.Add(p1);
            listaPersonas.Add(d1);
            listaPersonas.Add(p2);

            //Console.WriteLine($"The list of person is: {listaPersonas.Count}");
            //Console.WriteLine($"The name of the first people on the list is: {listaPersonas[0].Nombre}");

            foreach (Persona item in listaPersonas)
            {
                Console.WriteLine(item.Nombre);
            }

            Console.ReadKey();
        }
    }
}
