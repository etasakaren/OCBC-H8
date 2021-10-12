using System;

namespace Sesi_2
{
    public class Foxi
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Aeta!");
            Console.WriteLine("Selamat Datang di Bootcamp OCBC!");
            Console.WriteLine("Tahap 1 saya akan belajar C#");

            Console.WriteLine();
            string nama = "Foxi";
            int jumlah1 = 10, jumlah2 = 7, jumlah3 = 13; 
            double harga1 = 10000, harga2 = 5000, harga3 = 20000; 
            Console.WriteLine($"Nama customer: {nama}");
            Console.WriteLine($"Barang 1 berjumlah {jumlah1} dengan harga {harga1} yang harus dibayar sebesar {jumlah1*harga1}");
            Console.WriteLine($"Barang 2 berjumlah {jumlah2} dengan harga {harga2} yang harus dibayar sebesar {jumlah2*harga2}"); 
            Console.WriteLine($"Barang 3 berjumlah {jumlah3} dengan harga {harga3} yang harus dibayar sebesar {jumlah3*harga3}");     

            Console.WriteLine($"Jumlah semua barang: {jumlah1+jumlah2+jumlah3}");
            Console.WriteLine($"Total harga semua barang: {harga1+harga2+harga3}");                              
        }
    }
}