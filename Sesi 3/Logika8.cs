using System;

namespace Sesi_3
{
    public class Logika8
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
            Console.WriteLine("Please enter a start number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter a limit number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Choose an operator? [*, +, -, /]: ");
            choice = Console.ReadLine();
            if (choice == "*")
            {
                for (int i = num1; i <= num2; i++)
                {
                    Console.Write(i + " ");
                    i *= i;
                }
            }
            else if (choice == "/")
            {
                for (int i = num1; i <= num2; i++)
                {
                    Console.Write(i + " ");
                    i /= i;
                }
            }
            else if (choice == "+")
            {
                for (int i = num1; i <= num2; i++)
                {
                    Console.Write(i + " ");
                    i += i;
                }
            }
            else if (choice == "-")
            {
                for (int i = num1; i <= num2; i++)
                {
                    Console.Write(i + " ");
                    i -= i;
                }
            }
        }
    }
}