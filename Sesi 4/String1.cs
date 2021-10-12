using System;

namespace Sesi_4
{
    public class String1
    {
        public static void Main(string[] args)
        {
            char[] charray = { '1', ' ', 'H', 'e', 'l', 'l', '0', '.' };
            string str1 = new string(charray);
            string str2 = "Hello there.";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            for (int i = 0; i < charray.Length; i++)
            {
                Console.Write(charray[i]);
            }
        }
    }
}