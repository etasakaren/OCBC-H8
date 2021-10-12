using System;

namespace Sesi_3
{
    public class Logika3
    {
        public static void Main(string[] args)
        {
            string username, password, choice;

            do
            {
                Console.WriteLine("===YOUR DATA===");
                Console.WriteLine("Input username: ");
                username = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Input the password: ");
                password = Console.ReadLine();
                Console.WriteLine();
                if (username == "ocbc" && password == "bootcamp")
                {
                    Console.WriteLine($"Hi, {username}.");
                }
                else
                {
                    Console.WriteLine("Sorry, we don't know you.");

                }
                Console.WriteLine("Do you want to reload the program? [Y/N]: ");
                choice = Console.ReadLine();
                Console.WriteLine();
            } while (choice == "Y");
        }
    }
}