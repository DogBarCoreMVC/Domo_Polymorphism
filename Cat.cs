using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domo_Polymorphism
{
    class Cat : Animal
    {
        public override void Goes()
        {
            Console.WriteLine("meow");
        }
    }
}
