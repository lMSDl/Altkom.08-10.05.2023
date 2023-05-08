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


        }
    }
}
