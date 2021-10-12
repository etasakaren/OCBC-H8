using System;

namespace Sesi_2
{
    public class String
    {
        public static void Main(string[] args)
        {
            string nama, alamat;
            int umur;

            Console.WriteLine("===PROGRAM PENDAFTARAN PENDUDUK===");
            Console.WriteLine("Masukkan nama: ");
            nama = Console.ReadLine();
            Console.WriteLine("Masukkan alamat: ");
            alamat = Console.ReadLine();
            Console.WriteLine("Masukkan umur: ");
            umur = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Terima kasih, berikut data anda: ");
            Console.WriteLine($"Nama: {nama}");
            Console.WriteLine($"Alamat: {alamat}");
            Console.WriteLine($"Umur: {umur} tahun");

            Console.WriteLine();
            Console.WriteLine("Data sudah tersimpan!");

        }
    }
}