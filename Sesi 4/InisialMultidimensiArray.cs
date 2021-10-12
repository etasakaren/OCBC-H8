using System;

namespace Sesi_4
{
    public class InisialMultidimensiArray
    {
        public static void Main(string[] args)
        {
            int[,] tabel = { { 1, 1 }, { 2, 4 }, { 3, 9 }, { 4, 16 }, { 5, 25 }, { 6, 36 }, { 7, 49 }, { 8, 64 }, { 9, 81 }, { 10, 100 } };

            for (int baris = 0; baris < 10; baris++)
            {
                for (int kolom = 0; kolom < 2; kolom++)
                {
                    Console.Write(tabel[baris, kolom] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}