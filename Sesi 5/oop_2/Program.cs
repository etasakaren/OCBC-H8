using System;

namespace oop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();
            Jet jet = new Jet();

            Console.WriteLine("What is the plane name?: ");
            plane.plane_kind = Console.ReadLine();
            Console.WriteLine("Where is the plane at now?: ");
            plane.height = int.Parse(Console.ReadLine());

            plane.fly();
            plane.hasTakenOff();

            Console.WriteLine("What is the jet name?: ");
            jet.plane_kind = Console.ReadLine();
            Console.WriteLine("What is the color of the jet?: ");
            jet.color = Console.ReadLine();
            Console.WriteLine("Where is the jet at now?: ");
            jet.height = int.Parse(Console.ReadLine());

            jet.flying();
        }
    }
}
