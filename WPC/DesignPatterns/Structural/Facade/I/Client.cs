using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Facade.I
{
    internal class Client
    {
        public static void Execute()
        {
            var person = new Person() { Name = "Ewa Ewowska", BirthDate = DateTime.Now };

            /*JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings()
            {
                DateFormatString = "yy-MM_d",
                DefaultValueHandling = DefaultValueHandling.Ignore,
                Formatting = Formatting.Indented,
            };

            var data = JsonConvert.SerializeObject(person, jsonSerializerSettings);*/

            var data = SerializeFacade.Serialize(person);

            Service(data);

        }

        public static void Service(string data) {
            Console.WriteLine(data);
        }
    }
}
