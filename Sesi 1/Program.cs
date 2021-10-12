using System;

namespace Sesi_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fName, lName, address;
            int age, birthY;

            Console.WriteLine("Input your first name: ");
            fName = Console.ReadLine();

            Console.WriteLine("Input your last name: ");
            lName = Console.ReadLine();

            Console.WriteLine("Input your address: ");
            address = Console.ReadLine();

            Console.WriteLine("Input your birth year (YYYY): ");
            birthY = int.Parse(Console.ReadLine());
            age = DateTime.Now.Year - birthY;

            Console.Write("Hello, " + fName + " " + lName + " who lives in " + address + ". Your age now is " + age + ". You were born in " + birthY + ".");
        }
    }
}
