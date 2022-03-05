using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Bicycle : Vehicle
    {

        public override void Go()
        {
            Console.WriteLine("Bicycle is moving!");
        }
    }
}
