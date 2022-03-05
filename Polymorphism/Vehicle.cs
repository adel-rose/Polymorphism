using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
     class Vehicle
    {

        public virtual void Go() 
        {
            Console.WriteLine("Vehicle is moving!");
        }
        
    }
}
