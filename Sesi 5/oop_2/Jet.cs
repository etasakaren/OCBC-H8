using System;

namespace oop_2
{
    public class Jet:Plane //inheritance
    {
        public string color;
        public void flying()
        {
            Console.WriteLine("Jet {0} which has {1} color is flying at {2} feet from the ground.", this.plane_kind, this.color, this.height);
        }
    }
}