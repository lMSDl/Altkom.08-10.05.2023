using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Flyweight
{
    public class Car
    {
        public Car(string owner, string number, string manufacturer, string model, string color)
        {
            Owner = owner;
            Number = number;
            Manufacturer = manufacturer;
            Model = model;
            Color = color;
        }

        public string Owner { get; set; }
        public string Number { get; set; }
        [JsonIgnore]
        public string Manufacturer { get => CarFlyweight.Manufacturer; private set => CarFlyweight.Manufacturer = value; }
        [JsonIgnore]
        public string Model { get => CarFlyweight.Model; private set => CarFlyweight.Model = value; }
        [JsonIgnore]
        public string Color { get => CarFlyweight.Color; private set => CarFlyweight.Color = value; }

        [JsonIgnore]
        public CarFlyweight CarFlyweight { get; set; } = new CarFlyweight();

        public override string ToString()
        {
            return CarFlyweight.ToString(this);
        }
    }
}
