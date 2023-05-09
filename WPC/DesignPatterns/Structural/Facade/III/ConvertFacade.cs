using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Facade.III
{
    internal class ConvertFacade : IXmlConverter, IJsonConverter, IByteArrayConverter
    {
        private IXmlConverter xmlConverter;
        private IJsonConverter jsonConverter;
        private IByteArrayConverter byteArrayConverter;

        public ConvertFacade(IXmlConverter xmlConverter, IJsonConverter jsonConverter, IByteArrayConverter byteArrayConverter)
        {
            this.xmlConverter = xmlConverter;
            this.jsonConverter = jsonConverter;
            this.byteArrayConverter = byteArrayConverter;
        }

        public byte[] ToByteArray(object obj)
        {
            return byteArrayConverter.ToByteArray(obj);
        }

        public string ToJson(object obj)
        {
            return jsonConverter.ToJson(obj);
        }

        public string ToXml(object obj)
        {
            return xmlConverter.ToXml(obj);
        }
    }
}
