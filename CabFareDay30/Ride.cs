using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabFareDay30
{
    public class Ride
    {
        public double Distance { get; set; }
        public double Time { get; set; }
        public double Fare { get; set; }

        public Ride(double distance, double time)
        {
            Distance = distance;
            Time = time;
            Fare = (distance * 10) + (time * 1);

            if (Fare < 5)
            {
                Fare = 5;
            }
        }
    }
}
