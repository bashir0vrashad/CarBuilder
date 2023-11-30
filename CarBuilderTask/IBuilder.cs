using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilderTask
{
    internal interface IBuilder
    {
        void reset();
        void setSeats(int number);
        void setEngine(float engine);
        void setTripComputer();
        void setGPS();
    }
}
