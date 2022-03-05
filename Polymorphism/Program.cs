using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();  
            Boat boat = new Boat();

            Vehicle [] vehicles = { car, bicycle, boat };

            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

        }
    }
}
