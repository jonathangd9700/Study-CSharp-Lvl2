using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Animal
    {
        public virtual string Eat()
        {
            return "Eating...";
        }

        public virtual string ToComunicate() 
        {
            return "Making a strange noise...";
        }

    }
}
