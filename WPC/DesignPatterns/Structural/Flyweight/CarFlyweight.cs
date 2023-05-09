using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Flyweight
{
    public class CarFlyweight
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public string ToString(Car car)
        {
            var builder = new StringBuilder();
            builder.AppendLine("Stan zewnętrzny:");
            builder.AppendLine(JsonConvert.SerializeObject(car));

            builder.AppendLine("Stan wewnętrzny:");
            builder.AppendLine(JsonConvert.SerializeObject(this));

            return builder.ToString();
        }
    }
}
