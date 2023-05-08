using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Builder
{
    internal class Client
    {
        public static void Execute()
        {
            var vehicle = new Vehicle(4, 5, 4, 500, 100);
            Console.WriteLine(vehicle);
        
        
            var vehicleBuilder = new VehicleBuilder();
            vehicleBuilder.SetWeels(4);
            vehicleBuilder.SetSeets(5);
            vehicleBuilder.SetDoors(4);
            vehicleBuilder.SetEngine(100);
            vehicleBuilder.SetTrunk(500);

            vehicle = vehicleBuilder.Build();
            Console.WriteLine(vehicle);
            
            var vehicle2 = vehicleBuilder.Build();
            vehicle2.Wheels = 10;

            Console.WriteLine(vehicle);


            vehicle = new VehicleBuilder()
                                        .SetWeels(4)
                                        .SetSeets(5)
                                        .SetDoors(4)
                                        .SetEngine(100)
                                        .SetTrunk(500)
                                        .Build();

            Console.WriteLine(vehicle);


            vehicle = new Vehicle() { Wheels = 4, Seats = 5, EnginePower = 100, Doors = 4, TrunkCapacity = 500 };
            Console.WriteLine(vehicle);

        }
    }
}
