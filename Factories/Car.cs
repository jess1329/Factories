using System;
using System.Collections.Generic;
using System.Text;

namespace Factories
{
    class Car : IVehicle
    {
        public string Color { get; set; }

        public bool IsDriveable { get; set; }

        public void Drive()
        {
            Console.WriteLine("SOrry can't text I'm driving");
        }




    }
}
