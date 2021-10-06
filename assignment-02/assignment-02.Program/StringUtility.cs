using System;
using System.Text;

namespace assignment_02.Program
{
    public static class StringUtility
    {
        public static string ReverseString(this string input)
        {
            char[] output = new char[input.Length];
            for (int outputIndex = 0, inputIndex = input.Length - 1; outputIndex < input.Length; outputIndex++, inputIndex--)
            {
                // check for surrogate pair

                if (input[inputIndex] >= 0xDC00 && input[inputIndex] <= 0xDFFF &&
                    inputIndex > 0 && input[inputIndex - 1] >= 0xD800 && input[inputIndex - 1] <= 0xDBFF)
                {
                    // preserve the order of the surrogate pair code units

                    output[outputIndex + 1] = input[inputIndex];
                    output[outputIndex] = input[inputIndex - 1];
                    outputIndex++;
                    inputIndex--;
                }
                else
                {
                    output[outputIndex] = input[inputIndex];
                }
            }
            return new string(output);
        }

        public static string UpperCaseString(this string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char c in input) {
                if((c >= 'a' && c <= 'z') || c == 'æ' || c == 'ø' || c == 'å')
                    sb.Append((char)(c - ('a' - 'A')));
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }

        public static string LowerCaseString(this string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if ((c >= 'A' && c <= 'Z') || c == 'Æ' || c == 'Ø' || c == 'Å')
                    sb.Append((char)(c + ('a' - 'A')));
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}