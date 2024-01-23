using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Perro:AnimalDomestico
    {

        public override string Eat()
        {
            return "Eating meat";
        }

        public override string ToComunicate()
        {
            return "To bark";
        }
    }
}
