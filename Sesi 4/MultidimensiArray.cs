using System;

namespace Sesi_4
{
    public class MultidimensiArray
    {
        public static void Main(string[] args)
        {
            int[,] tabel = new int[3, 4];

            for (int baris = 0; baris < 3; baris++)
            {
                for (int kolom = 0; kolom < 4; kolom++)
                {
                    tabel[baris, kolom] = (baris * 4) + kolom + 1;
                    Console.Write(tabel[baris, kolom] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}