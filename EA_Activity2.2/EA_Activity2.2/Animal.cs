using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_Activity2._2
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public virtual void Greet()
        {
            Console.WriteLine("Animal says hello!");
        }
        public virtual void Talk()
        {
            Console.WriteLine("Animal talking");
        }

        public virtual void Sing()
        {
            Console.WriteLine("Animal song");
        }
        
    }
}
