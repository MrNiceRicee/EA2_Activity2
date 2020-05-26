using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_Activity2._2
{
    class Wolf: Animal,IPredator
    {
        // new animal #1

        public Wolf(String name)
        {
            Name = name;
            Type = "Wolf";
            Console.WriteLine("The "+Type+ ", "+Name+", is here! The lone wolf");
        }


        public void Eat()
        {
            Console.WriteLine("Wolf is eating");
        }

        public void Hunt(Animal animal)
        {
            Console.WriteLine(Name + " the " + Type + " is hunting " + animal.Name + " a " + animal.Type + "!");
        }

        public override void Sing()
        {
            Console.WriteLine("Wolf is singing");
        }

        public override void Greet()
        {
            Console.WriteLine(Name+" the "+Type+" is greets you");
        }
    }
}
