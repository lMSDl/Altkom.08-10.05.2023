using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Facade.I
{
    internal static class SerializeFacade
    {
        private static JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings()
        {
            DateFormatString = "yy-MM_d",
            DefaultValueHandling = DefaultValueHandling.Ignore,
            Formatting = Formatting.Indented,
        };

        public static string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, _jsonSerializerSettings);
        }

        public static T Deserialize<T>(string json) { return JsonConvert.DeserializeObject<T>(json, _jsonSerializerSettings); }
    }
}
