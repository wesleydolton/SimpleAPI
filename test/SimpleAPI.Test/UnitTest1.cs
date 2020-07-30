using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;
using SimpleAPI;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController();
        WeatherForecast weatherForecast ;

    	[Fact]
        public void GetWeatherResults()
        {
            var returnValue = controller.Get();

            returnValue = null;
            
            Assert.NotNull(returnValue);

            //Assert.IsType(weatherForecast, returnValue.GetEnumerator());
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
