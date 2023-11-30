using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilderTask
{
    internal class Director
    {
        public void makeSUV(IBuilder builder) 
        {
            builder.reset();
            Console.WriteLine();
            builder.setSeats(4);
            Console.WriteLine();
            builder.setEngine(2.0f);
            Console.WriteLine();
            builder.setTripComputer();
            Console.WriteLine();
            builder.setGPS();
        }
        public void makeSportsCar(IBuilder builder) 
        { 
            builder.reset();
            Console.WriteLine();
            builder.setSeats(2);
            Console.WriteLine();
            builder.setEngine(4.4f);
            Console.WriteLine();
            builder.setTripComputer();
            Console.WriteLine();
            builder.setGPS();
        }
    }
}
