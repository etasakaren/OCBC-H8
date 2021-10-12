using System;

namespace Sesi_3
{
    public class Logika4
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

                if (score >= 85)
                {
                    Console.WriteLine("Congrats, you have an awesome score.");
                }
                else if (score >= 65)
                {
                    Console.WriteLine("Congrats, you have a great score.");
                }
                else if (score >= 45)
                {
                    Console.WriteLine("Congrats, you have a bad score.");
                }
                else if (score <= 25)
                {
                    Console.WriteLine("Congrats, you have the worst score.");
                }
                Console.WriteLine("Do you want to reload the program? [Y/N]: ");
                choice = Console.ReadLine();
                Console.WriteLine();
            } while (choice == "Y");
        }
    }
}