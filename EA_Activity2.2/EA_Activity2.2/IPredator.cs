using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_Activity2._2
{
    interface IPredator
    {
        //new interface #2
        void Hunt(Animal animal);
        void Eat();
    }
}
