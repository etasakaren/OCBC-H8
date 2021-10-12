using System;

namespace Sesi_2
{
    public class UsernameAritmatika
    {
        public static void Main(string[] args)
        {
            string username, password, gender, status;
            int age;
            double num1, num2, num3;

            Console.WriteLine("===YOUR DATA===");
            Console.WriteLine("Input username: ");
            username = Console.ReadLine();
            Console.WriteLine("Input your age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Input gender [F/M]: ");
            gender = Console.ReadLine();
            Console.WriteLine("Input marriage status [T/F]: ");
            status = Console.ReadLine();
            Console.WriteLine("Input the password: ");
            password = Console.ReadLine();

            Console.WriteLine();

            string genderFull = gender == "F" ? "Female" : "Male";
            string statusFull = status == "T" ? "True" : "False";
            if (username == "etasakaren" && age > 18 && password == "OCBC")
            {
                Console.WriteLine("===TOTAL AND AVERAGE===");
                Console.WriteLine("Input number 1: "); //25
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Input number 2: "); //38
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Input number 3: "); //72
                num3 = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("===OUTPUT===");
                Console.WriteLine($"Total angka: {num1 + num2 + num3} dan rata-rata angka: {(num1 + num2 + num3) / 3} \nUsername: {username} \nAge: {age} \nGender: {genderFull} \nStatus: {statusFull} \n");
            }
            else
            {
                Console.WriteLine("Sorry, try again.");

            }
        }
    }
}