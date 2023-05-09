using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Builder
{
    public class VehicleBuilderFacade : BaseBuilder
    {
        public VehicleBuilderFacade()
        {
        }

        public VehicleBuilderFacade(Vehicle vehicle) : base(vehicle)
        {
        }
        public VehicleBuilder Parts => new VehicleBuilder(Vehicle);
        public ProductionBuilder Metadata => new ProductionBuilder(Vehicle);
    }
}
