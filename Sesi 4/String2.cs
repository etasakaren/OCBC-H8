using System;
using System.Globalization;

namespace Sesi_4
{
    public class String2
    {
        public static void Main(string[] args)
        {
            string str1 = "C# is my favorite.";
            string str2 = str1;
            string str3 = "C# is awesome.";

            Console.WriteLine("str1 is " + str1);
            Console.WriteLine("str1's length is " + str1.Length);
            Console.WriteLine("str1 lowercased is " + str1.ToLower(CultureInfo.CurrentCulture));
            Console.WriteLine("str1 uppercased is " + str1.ToUpper(CultureInfo.CurrentCulture));
            Console.WriteLine();
            Console.WriteLine("str1 shown in char by char: ");
            for (int i = 0; i < str1.Length; i++)
            {
                Console.Write(str1[i]);
            }
            string str1AndStr2 = str1 == str2 ? "str1 == str2" : "str1 != str2";
            string str1AndStr3 = str1 == str3 ? "str1 == str3" : "str1 != str3";
            Console.WriteLine();
            Console.WriteLine("str1 and str2 is " + str1AndStr2 + ", str1 and str3 is " + str1AndStr3);

            int equal = string.Compare(str1, str3, StringComparison.CurrentCulture);

            if (equal == 0)
            {
                Console.WriteLine("str1 and str3 have the same value.");
            }
            else if (equal < 0)
            {
                Console.WriteLine("str1 has lower value than str3.");
            }
            else
            {
                Console.WriteLine("str1 has bigger value than str3.");
            }

            str2 = "One Two Three One";
            Console.WriteLine();
            Console.WriteLine("First index of 'One' in str2 is " + str2.IndexOf("One", StringComparison.Ordinal));
            Console.WriteLine("Last index of 'One' str2 is " + str2.LastIndexOf("One", StringComparison.Ordinal));
        }
    }
}