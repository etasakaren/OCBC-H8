using System;

namespace Sesi_4{
    public class MenampilkanArray{
        public static void Main(string[] args){
            string[] examples = new string[4]{
                "Motherboard", "Processor", "Power Supply", "Video Card"
            };
            Console.WriteLine("Showing array: ");
            Console.WriteLine();
            foreach(string ex in examples){
                Console.WriteLine(ex);
            }
        }
    }
}