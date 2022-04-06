using System;
using System.Collections.Generic;
using System.Text;

namespace Factories
{
    class Motorcycle: IVehicle
    {

        public string Color { get; set; }   

        public bool HasHandBreak { get; set; }

        public void Drive() 
        {
            Console.WriteLine("Driving a motorcycle");
        }



    }
}
