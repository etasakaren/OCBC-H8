using System;

namespace oop_2
{
    public class Plane
    {
        public string plane_kind;
        private int _height; //encapsulation
        public int height
        {
            get { return _height; }
            set { _height = value; }
        }

        public void fly()
        {
            Console.WriteLine("Plane {0} is taking off.", this.plane_kind);
        }

        public void hasTakenOff()
        {
            Console.WriteLine("Plane {0} is flying at {1} feet from the ground.", this.plane_kind, this.height);
        }
    }
}