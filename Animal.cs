using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domo_Polymorphism
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual void Goes()
        {
            Console.WriteLine("Animal Goes");
        }
    }
}
