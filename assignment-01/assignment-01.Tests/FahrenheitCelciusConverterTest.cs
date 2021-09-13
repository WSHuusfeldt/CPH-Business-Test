using System;
using Xunit;

namespace assignment_01.Tests
{
    public class FahrenheitCelciusConverterTest
    {
        [Fact]
        public void Test1()
        {
            FahrenheitCelciusConverter fahrenheitCelcius = new FahrenheitCelciusConverter();
            double result = fahrenheitCelcius.ConvertToCelcius(100);

            Assert.Equal(37.77777777777778, result);
        }

        [Fact]
        public void Test2()
        {
            FahrenheitCelciusConverter fahrenheitCelcius = new FahrenheitCelciusConverter();
            double result = fahrenheitCelcius.ConvertToFahrenheit(20);

            Assert.Equal(68, result);
        }
    }
}
