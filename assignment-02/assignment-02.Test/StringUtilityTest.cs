using System;
using System.Collections.Generic;
using assignment_02.Program;
using Xunit;

namespace assignment_02.Test
{
    public class StringUtilityTest
    {
        public static IEnumerable<object[]> ReverseStringData()
        {
            yield return new object[] { "", "" };
            yield return new object[] { "aBc", "cBa" };
            yield return new object[] { "efTg", "gTfe" };
            yield return new object[] { "gjc", "cjg" };
            yield return new object[] { "y1f3", "3f1y" };
            yield return new object[] { "th🐨🐨", "🐨🐨ht" };
            yield return new object[] { "5t\n5", "5\nt5" };
            yield return new object[] { "🐨🌵", "🌵🐨" };
        }

        public static IEnumerable<object[]> UppercaseStringData()
        {
            yield return new object[] { "", "" };
            yield return new object[] { "aBc", "ABC" };
            yield return new object[] { "gtk", "GTK" };
            yield return new object[] { "13r", "13R" };
            yield return new object[] { "æøå!", "ÆØÅ!" };
            yield return new object[] { "🐨🌵", "🐨🌵" };
        }

        public static IEnumerable<object[]> LowercaseStringData()
        {
            yield return new object[] { "", "" };
            yield return new object[] { "ABC", "abc" };
            yield return new object[] { "Gtk", "gtk" };
            yield return new object[] { "13R", "13r" };
            yield return new object[] { "ÆØÅ!", "æøå!" };
            yield return new object[] { "🐨🌵", "🐨🌵" };
        }

        [Theory]
        [MemberData(nameof(ReverseStringData))]
        public void ReverseStringMethodTest(string input, string expected)
        {
            string result = input.ReverseString();
            
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(UppercaseStringData))]
        public void UppercaseStringMethodTest(string input, string expected)
        {
            string result = input.UpperCaseString();

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(LowercaseStringData))]
        public void LowercaseStringMethodTest(string input, string expected)
        {
            string result = input.LowerCaseString();

            Assert.Equal(expected, result);
        }
    }
}
