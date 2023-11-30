using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilderTask
{
    internal class CarManualBuilder : IBuilder
    {
        private Manual manual;
        public void reset()
        {
           manual= new Manual();
        }

        public void setEngine(float engine)
        {
            Console.WriteLine($"Add A Manual {engine} Engine instruction");
        }

        public void setGPS()
        {
            Console.WriteLine("Add A Manual GPS instruction");
        }

        public void setSeats(int number)
        {
            Console.WriteLine($"Add  Manual {number} Seats instruction");
        }

        public void setTripComputer()
        {
            Console.WriteLine("Add A Manual trip computer instruction");
        }
        public Manual getResult() { return manual; }
    }
}
