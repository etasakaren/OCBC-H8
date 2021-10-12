using System;
using System.Globalization;

namespace Sesi_4
{
    public class String3
    {
        public static void Main(string[] args)
        {
            string[] str = { "This", "is", "a", "test." };
            Console.WriteLine("Old string: ");
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();
            str[1] = "remains";
            str[3] = "test, too.";
            Console.WriteLine("New string: ");
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
        }
    }
}