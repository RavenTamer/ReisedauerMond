using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisedauerMond
{
    internal class Mondreise
    {
        
        public Mondreise(double speedKmh) {
            SpeedKmh = speedKmh;
        }
        
        int distance = 384400;
        double speedKmh;

        public double SpeedKmh { get; set; }

        public double GetTravelDurationDays()
            {
                double days = GetTravelDurationHours() / 24;
                return days;
            }
        public double GetTravelDurationHours()
        {
            double hours = distance / SpeedKmh;
            return hours;
        }
    }
}
