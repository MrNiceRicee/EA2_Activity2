using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_Activity2._2
{
    class Hummingbird : Animal, IFlyable
    {
        public Hummingbird(String name)
        {
            Name = name;
            Type = "Hummingbird";
            Console.WriteLine("The " + Type + ", " + Name + ", is here! Humming like a Hummer!");
        }

        public void Ascend()
        {
            Console.WriteLine("Hummingbird is ascending the skies!");
        }

        public void Decend()
        {
            Console.WriteLine("Hummingbird is decending the skies!");
        }
        public override void Greet()
        {
            Console.WriteLine(Name + " the " + Type + " is greets you");
        }
    }
}
