using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_Activity2._2
{
    class Program
    {
        static void Main(string[] args)
        {

/*            Animal an = new Animal();
            an.Talk();
            an.Greet();
            an.Sing();*/


            Dog Pochi = new Dog("Pochi");
            Pochi.Talk();
            Pochi.Greet();
            Pochi.Sing();
            Pochi.Fetch("Stick");
            Pochi.FeedMe();
            Pochi.TouchMe();

            Console.WriteLine();

            Robin robin = new Robin("Hood");
            robin.Talk();
            robin.Greet();
            robin.Sing();
            /*            robin.Fetch("String");
                        robin.FeedMe();
                        robin.TouchMe();*/

            Console.WriteLine();

            Wolf wolfie = new Wolf("Taun");
            wolfie.Greet();
            wolfie.Hunt(robin);
            wolfie.Sing();

            Console.WriteLine();

            Eagle eagle = new Eagle("E-Angles");
            eagle.Greet();
            eagle.Ascend();
            eagle.Hunt(wolfie);
            eagle.Decend();

            Console.WriteLine();

            Hummingbird hummie = new Hummingbird("Hummie");
            hummie.Greet();
            hummie.Ascend();
            hummie.Decend();


            Console.ReadLine();
        }
    }
}
