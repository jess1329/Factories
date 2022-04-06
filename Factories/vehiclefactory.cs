using System;
using System.Collections.Generic;
using System.Text;

namespace Factories
{
    class Vehiclefactory
    {
        public IVehicle CreateVehicle(string userInput) 
        {

            switch (userInput.ToLower())
            {
                case "car";
                    return new Car() { Color ="Blue", IsDriveable= true};
                    break;
                case "motorcycle":
                    return new Motorcycle();
                    break;
                default;
                    return new Car();


            }






        }




    }
}
