using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilderTask
{
    internal class CarBuilder : IBuilder
    {
        private Car car;
        public void reset()
        {
          car = new Car();
        }

        public void setEngine(float engine)
        {
            Console.WriteLine($"Add A Car {engine} Engine instruction");
        }

        public void setGPS()
        {
            Console.WriteLine("Add A Car GPS instruction");
        }

        public void setSeats(int number)
        {
            Console.WriteLine($"Add  Car {number} Seats instruction");
        }

        public void setTripComputer()
        {
            Console.WriteLine("Add A Car trip computer instruction");
        }
        public Car getResult() { return car; }
    }
}
