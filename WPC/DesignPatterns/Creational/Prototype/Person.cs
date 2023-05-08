using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Prototype
{
    public class Person : ICloneable
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Address Address{ get; set; }

        public object Clone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Address = (Address)Address.Clone();

            return clone;
        }

        public object ShallowClone()
        {
            var clone = MemberwiseClone();

            return clone;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
