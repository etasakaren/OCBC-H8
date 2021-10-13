using System;

namespace oop_1
{
    class Program{
        public static void Main(string[] args){
            Laptop lap = new Laptop();

            Console.WriteLine("What is your laptop brand?: ");
            lap.brand= Console.ReadLine();
            Console.WriteLine("How much is your ram?: ");
            lap.ram = int.Parse(Console.ReadLine());
            Console.WriteLine("How much is your memory?: ");
            lap.memory = int.Parse(Console.ReadLine());

            lap.Chatting();
            lap.Ram();
            lap.Memory();
        }
    }
}
