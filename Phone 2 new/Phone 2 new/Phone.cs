using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_2_new
{
    internal class Phone
    { }
        namespace phone2
    {
        public class Phone
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public double ScreenSize { get; set; }
            public int RAM { get; set; }
            public int Storage { get; set; }
            public string Color { get; set; }
            public decimal Price { get; set; }
            public int BatteryCapacity { get; set; }
            public string OperatingSystem { get; set; }

            public double PricePerGB()
            {
                return Storage > 0 ? (double)Price / Storage : 0;
            }
        }
    }
}
