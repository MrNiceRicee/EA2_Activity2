using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_Activity2._2
{
    class Dog : Animal, IDomesticated
    {
        
        public Dog(String name)
        {
            Name = name;
            Type = "Dog";
            Console.WriteLine("The " + Type + ", " + Name + ", is here! Good doggo!");
        }

        public override void Greet()
        {
            Console.WriteLine(Name + " the " + Type + " is greets you");
        }
        public new void Talk()
        {
            Console.WriteLine("Bark bark bark");
        }

        public override void Sing()
        {
            Console.WriteLine("Hooowl!");
        }

        public void Fetch(string Thing)
        {
            Console.WriteLine("Oh boy! Here is your "+ Thing + ". Let's do it again!");
        }

        public void TouchMe()
        {
            Console.WriteLine("Please scratch behind my ears.");
        }

        public void FeedMe()
        {
            Console.WriteLine("It's food time! The very best time of day!");
        }
    }
}
