using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;
using TempoWeather.Core.Models;

namespace TempoWeather.Core
{
    public class NdfdClient
    {
        public dwml GetDwml(Stream stream)
        {
            var serializer = new XmlSerializer(typeof(dwml));
            var dwml = (dwml) serializer.Deserialize(stream);
            return dwml;
        }
    }
}
