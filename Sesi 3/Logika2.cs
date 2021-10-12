using System;

namespace Sesi_3
{
    public class Logika2
    {
        public static void Main(string[] args)
        {
            string name, choice;
            int score;
            Console.WriteLine("=====Welcome to Program=====");
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Welcome, {name}!");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Please input your score: ");
                score = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (score <= 60)
                {
                    Console.WriteLine("Improve your score.");
                }
                else if (score <= 80)
                {
                    Console.WriteLine("Congrats, you have a great score.");
                }
                else
                {
                    Console.WriteLine("Congrats, you have the perfect score.");
                }
                Console.WriteLine("Do you want to reload the program? [Y/N]: ");
                choice = Console.ReadLine();
                Console.WriteLine();
            } while (choice == "Y");
        }
    }
}