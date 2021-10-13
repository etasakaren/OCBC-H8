using System;

namespace oop_2_3_4
{
    public class Overloading //same method name but different param name
    {
        public string name;
        public double mobilenum;
        public void print(string name)
        {
            this.name = name;
            Console.WriteLine("Your name is {0}.", this.name);
        }

        public void print(double mobilenum)
        {
            this.mobilenum = mobilenum;
            Console.WriteLine("{0}'s phone number is {1}.", this.name, this.mobilenum);
        }
    }
}