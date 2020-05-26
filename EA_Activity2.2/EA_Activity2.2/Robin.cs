using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_Activity2._2
{
    class Robin : Animal, IFlyable
    {
        public Robin(String name)
        {
            Name = name;
            Type = "Robin";
            Console.WriteLine("The " + Type + ", " + Name + ", is here! It's Robin's hood");
        }

        public void Ascend()
        {
            Console.WriteLine("Robin is ascending the skies.");
        }

        public void Decend()
        {
            Console.WriteLine("Robin is decending the skies.");
        }

        public override void Talk()
        {
            Console.WriteLine(Name + " the " + Type + " is talking to you");
        }

        public override void Greet()
        {
            Console.WriteLine(Name + " the " + Type + " is greets you");
        }
        public override void Sing()
        {
            Console.WriteLine("Chirp Chirp");
        }
    }
}
