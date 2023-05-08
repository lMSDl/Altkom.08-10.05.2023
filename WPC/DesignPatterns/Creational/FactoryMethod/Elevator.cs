using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.FactoryMethod
{
    internal class Elevator
    {

        private readonly Dictionary<string, IElevatorOperation> _operations = new Dictionary<string, IElevatorOperation>();

        public void Execute(string command, int floor)
        {
            Execute(CreateOperation(command), floor);
        }
        public void Execute(IElevatorOperation command, int floor)
        {
            command?.Operate(floor);
        }

        public IElevatorOperation CreateOperation(string operationName)
        {
            if(_operations.TryGetValue(operationName, out var result))
            {
                return result;
            }

            switch (nameof(Elevator) + operationName)
            {
                case nameof(ElevatorDown):
                    result = new ElevatorDown();
                    break;
                case nameof(ElevatorUp):
                    result = new ElevatorUp();
                    break;
                case nameof(ElevatorGoTo):
                    result = new ElevatorGoTo();
                    break;
            }

            _operations[operationName] = result;


            return result;

            /*switch (nameof(Elevator) + operationName)
            {
                case nameof(ElevatorDown):
                    return new ElevatorDown();
                case nameof(ElevatorUp):
                    return new ElevatorUp();
            }
            return null;*/
        }
    }
}
