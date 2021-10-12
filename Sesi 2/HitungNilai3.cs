using System;

namespace Sesi_2
{
    public class HitungNilai3
    {
        public static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Masukkan nilai pertama: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan nilai kedua: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Hasil Perbandingan: ");
            Console.WriteLine($"num1 > num2 = {num1 > num2}");
            Console.WriteLine($"num1 >= num2 = {num1 >= num2}");
            Console.WriteLine($"num1 < num2 = {num1 < num2}");
            Console.WriteLine($"num1 <= num2 = {num1 <= num2}");
            Console.WriteLine($"num1 == num2 = {num1 == num2}");
            Console.WriteLine($"num1 != num2 = {num1 != num2}");
        }
    }
}