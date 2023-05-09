using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Flyweight
{
    public class FlyweightFactory
    {
        private readonly Dictionary<string, CarFlyweight> _flyweights;
        public FlyweightFactory(params CarFlyweight[] flyweights)
        {
            _flyweights = flyweights.ToDictionary(x => Key(x));
        }
        private string Key(CarFlyweight carFlyweight)
        {
            var values = carFlyweight.GetType().GetProperties()
                .Where(x => x.CanRead)
                .Where(x => x.CanWrite)
                .OrderBy(x => x.Name)
                .Select(x => x.GetValue(carFlyweight).ToString());

            return string.Join("_", values);
        }

        public CarFlyweight GetCarFlyweight(CarFlyweight carFlyweight)
        {
            var key = Key(carFlyweight);
            if (_flyweights.TryGetValue(key, out var result))
            {
                Console.WriteLine($"Zwracamy wartość z cache ({key})");
                return result;
            }

            Console.WriteLine($"Stan nie istanieje w cache, zapisujemy ({key})");
            _flyweights[key] = carFlyweight;
            return carFlyweight;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder($"W cache znajduje się {_flyweights.Count()} stanów\n");
            foreach (var item in _flyweights)
            {
                stringBuilder.AppendLine(item.Key);
            }
            return stringBuilder.ToString();
        }
    }
}
