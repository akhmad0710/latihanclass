using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanmemberclass
{
    class taxi
    {
        //properties
        public string drivername { get; set; }
        public bool onduty { get; set; }
        public float numpassenger { get; set; }


        public void TaxiInfo()
        {
            Console.WriteLine("drivername = {0}", drivername );
            Console.WriteLine("onduty = {0}", onduty);
            Console.WriteLine("numpassenger = {0}", numpassenger);
        }

        public void PickupPassenger()
        {
            Console.WriteLine("jono sedang menjemput penumpang");
        }

        public void DropOffPassanger()
        {
            Console.WriteLine("jonoselesai mengantar penumpang");
        }

 

    }
}
