using System;

namespace Factories
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of vehicle do you want to make? Caro or Motorcycle????");
            string userInput = Console.ReadLine();

            VehicleFactory factory = new VehicleFactory();
            IVehicle myCar = factory.CreateVehicle(userInput);


            }

            Console.WriteLine("Lets make another vehicle");
            string userInput = Console.ReadLine();

            

            }
        }
}
