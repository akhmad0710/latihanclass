using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanmemberclass
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek taxi

            taxi taxi = new taxi();

            //pengesetan nilai properties

            taxi.drivername = "jono";
            taxi.onduty = true;
            taxi.numpassenger = 10;

            //pemanggil method
            taxi.TaxiInfo();
            taxi.PickupPassenger();
            taxi.DropOffPassanger();

            Console.ReadKey();

        }
    }
}
