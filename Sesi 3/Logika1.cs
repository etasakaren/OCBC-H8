using System;

namespace Sesi_3
{
    public class Logika1
    {
        public static void Main(string[] args)
        {
            string name, choice;
            int num1, num2;
            Console.WriteLine("=====Welcome to Program=====");
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Welcome, {name}!");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Please input any number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Please input another number: ");
                num2 = int.Parse(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine("First number is bigger than second number.");
                }
                else if (num1 < num2)
                {
                    Console.WriteLine("First number is smaller than second number.");
                }
                Console.WriteLine("Do you want to reload the program? [Y/N]: ");
                choice = Console.ReadLine();
                Console.WriteLine();
            } while (choice == "Y");
        }
    }
}