using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Builder
{
    public class ProductionBuilder : VehicleBuilderFacade
    {
        private Vehicle Vehicle { get; }
        public ProductionBuilder()
        {

        }
        public ProductionBuilder(Vehicle vehicle) : base(vehicle)
        {
        }
        public ProductionBuilder SetManufacturer(string value)
        {
            Vehicle.Manufacturer = value;
            return this;
        }
        public ProductionBuilder SetModel(string value)
        {
            Vehicle.Model = value;
            return this;
        }
        public ProductionBuilder SetProductionDate(DateTime value)
        {
            Vehicle.ProductionDate = value;
            return this;
        }
    }
}
