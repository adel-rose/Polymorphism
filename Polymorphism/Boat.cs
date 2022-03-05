using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Boat is moving!");
        }
    }
}
