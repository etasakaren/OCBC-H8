using System;

namespace Sesi_4
{
    public class Array
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[5];
            string[] names = new string[] { "John", "Johnny", "Jojon", "Joe" };
            object[] objects = { 11, "Hallo", DateTime.Now, 'c', true };

            foreach (object obj in objects)
            {
                Console.Write(obj + " ");
            }
        }
    }
}