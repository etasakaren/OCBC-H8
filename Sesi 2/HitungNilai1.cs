using System;

namespace Sesi_2
{
    public class HitungNilai1
    {
        public static void Main(string[] args)
        {
            double num1, num2, num3;
            Console.WriteLine("===TOTAL AND AVERAGE===");
            Console.WriteLine("Masukkan angka 1: "); //25
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan angka 2: "); //38
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan angka 3: "); //72
            num3 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Total angka: {num1 + num2 + num3}");
            Console.WriteLine($"Rata-rata angka: {(num1 + num2 + num3) / 3}");

        }
    }
}