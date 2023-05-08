using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.FactoryMethod
{
    public class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();

            var action = "Down";
            var floor = 3;


            elevator.Execute("Up", 5);

            IElevatorOperation elevatorOperation = elevator.CreateOperation(action);

            if (elevatorOperation != null)
            {
                elevator.Execute(elevatorOperation, floor);
            }

            elevator.Execute("GoTo", 5);
        }
    }
}
