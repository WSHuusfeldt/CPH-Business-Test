using System;

namespace assignment_01
{
    public class FahrenheitCelciusConverter
    {
        public double ConvertToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5/9;
        }

        public double ConvertToFahrenheit(double celcius)
        {
            return (celcius * 9/5) + 32;
        }
    }
}
