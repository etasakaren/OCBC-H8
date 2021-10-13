using System;

namespace oop_1 //concept
{
    public class Laptop{
            public string brand;
            public int ram;
            public int memory;

            public void Chatting(){
                Console.WriteLine("\n{0} is chatting.", this.brand);
            }
            public void Ram(){
                Console.WriteLine("\n{0} has {1} GB size of RAM.", this.brand, this.ram);
            }
            public void Memory(){
                Console.WriteLine("\n{0} has {1} GB size of memory.", this.brand, this.memory);
            }
        }
}
