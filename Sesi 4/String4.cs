using System;
using System.Globalization;

namespace Sesi_4
{
    public class String4
    {
        public static void Main(string[] args)
        {
            string str = "I like the clean code.";
            Console.WriteLine("Before substring: " + str);
            Console.WriteLine("After substring: " + str.Substring(3, 7));
        }
    }
}