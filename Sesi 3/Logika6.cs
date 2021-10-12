using System;

namespace Sesi_3
{
    public class Logika6
    {
        public static void Main(string[] args)
        {
            string name;
            int num = 10;
            Console.WriteLine("=====Welcome to Program=====");
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Welcome, {name}!");

            while (num < 20){
                Console.WriteLine($"Num = {num}");
                num++;
            }

        }
    }
}