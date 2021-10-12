using System;

namespace Sesi_4
{
    public class Length
    {
        public static void Main(string[] args)
        {
            int[] listNum = new int[10];
            Console.WriteLine("Jumlah angka: " + listNum.Length);
            Console.WriteLine();
            Console.WriteLine("List angka tersebut: ");
            for (int i = 0; i < listNum.Length; i++)
            {
                listNum[i] = i * i;
                Console.Write(listNum[i] + " ");
            }
        }
    }
}