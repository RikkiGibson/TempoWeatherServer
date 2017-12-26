using System;
using System.IO;
using System.Xml.Serialization;
using TempoWeather.Core;
using TempoWeather.Core.Models;
using Xunit;

namespace TempoWeather.Test
{
    public class NdfdParsingTests
    {
        [Fact]
        public void Test1()
        {
            var fileStream = File.Open("Resources/NDFDSample.xml", FileMode.Open);
            var client = new NdfdClient();
            var dwml = client.GetDwml(fileStream);
            Assert.NotNull(dwml);
        }
    }
}
