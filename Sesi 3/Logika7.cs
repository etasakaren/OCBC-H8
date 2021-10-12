using System;

namespace Sesi_3
{
    public class Logika7
    {
        public static void Main(string[] args)
        {
            string name, choice;
            int num;
            Console.WriteLine("=====Welcome to Program=====");
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Welcome, {name}!");
            Console.WriteLine();
            Console.WriteLine("Please enter a number: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Do you want to show odd or even numbers? [O/E]: ");
            choice = Console.ReadLine();
            if (choice == "O")
            {
                for (int i = 0; i <= num; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
            else if (choice == "E")
            {
                for (int i = 0; i <= num; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }
    }
}