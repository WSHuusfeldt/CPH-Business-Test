using System;
using Xunit;

namespace assignment_01.Tests
{
    public class RomanNumeralConverterTest
    {
        [Fact]
        public void Test1()
        {
            RomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string result = romanNumeralConverter.Convert(10);

            Assert.Equal("X", result);
        }

        [Fact]
        public void Test2()
        {
            RomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string result = romanNumeralConverter.Convert(3);

            Assert.Equal("III", result);
        }

        [Fact]
        public void Test3()
        {
            RomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string result = romanNumeralConverter.Convert(45);

            Assert.Equal("XLV", result);
        }

        [Fact]
        public void Test4()
        {
            RomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string result = romanNumeralConverter.Convert(11984);

            Assert.Equal("MMMMMMMMMMMCMLXXXIV", result);
        }
    }
}
