using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_Activity2._2
{
    class Eagle : Animal, IFlyable, IPredator
    {
        //new Animal #2
        public Eagle(String name)
        {
            Name = name;
            Type = "Eagle";
            Console.WriteLine("The " + Type + ", " + Name + ", is here! It's not a plane!");
        }

        public override void Greet()
        {
            Console.WriteLine(Name + " the " + Type + " is greets you");
        }

        public void Ascend()
        {
            Console.WriteLine("Eagle is ascending the skies!");
        }

        public void Decend()
        {
            Console.WriteLine("Eagle is decending the skies!");
        }

        public void Eat()
        {
            Console.WriteLine("Eagle is eating something!");
        }

        public void Hunt(Animal animal)
        {
            Console.WriteLine(Name+" the "+Type+" is hunting "+animal.Name+" a "+ animal.Type+"!");
        }
    }
}
