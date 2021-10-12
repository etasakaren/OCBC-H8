using System;

namespace Sesi_2
{
    public class HitungNilai4
    {
        public static void Main(string[] args)
        {
            string password;
            int age;

            Console.WriteLine("Input your age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the password: ");
            password = Console.ReadLine();

            string qualified = age > 18 && password == "OCBC" ? "Welcome to the OCBC Club!!!" : "Sorry, try again.";
            Console.WriteLine(qualified);
        }
    }
}