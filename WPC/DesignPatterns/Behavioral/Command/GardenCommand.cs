using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Command
{
    public class GardenCommand : ICommand
    {
        private Garden _garden;
        private GardenActions _action;
        private string _plantName;

        public GardenCommand(Garden garden,  string plantName, GardenActions action)
        {
            _garden = garden;
            _action = action;
            _plantName = plantName;
        }

        public bool Execute()
        {
            switch (_action)
            {
                case GardenActions.Plant:
                    return _garden.Plant(_plantName);
                case GardenActions.Remove:
                    return _garden.Remove(_plantName);
            }
            return false;
        }

        public void Undo()
        {
            switch (_action)
            {
                case GardenActions.Plant:
                    _garden.Remove(_plantName);
                    break;
                case GardenActions.Remove:
                    _garden.Plant(_plantName);
                    break;
            }
        }
    }
}
