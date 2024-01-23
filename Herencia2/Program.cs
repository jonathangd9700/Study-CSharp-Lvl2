using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro a1 = new Perro();
            a1.Nombre = "Moro";
            Gato g1 = new Gato();
            g1.Nombre = "Michi";
            Console.WriteLine(a1.ToString());
            Console.WriteLine(a1.Eat());
            Console.WriteLine(g1.ToString());
            Console.WriteLine(g1.Eat());

            List<Animal> animals = new List<Animal>();

            animals.Add(a1);
            animals.Add(g1);
            animals.Add(new Gato());
            animals.Add(new Perro());
            
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Eat());
                Console.Write(animal.ToComunicate());
            }

            Console.ReadKey();
        }
    }
}
