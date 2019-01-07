using System;

namespace Structs.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class CoordRef
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CoordRef(int x,int y)
        {
            X = x;
            Y = y;
        }
    }

    struct CoordVal
    {
        public int X { get; set; }
        public int Y { get; set; }

        public CoordVal(int x,int y)
        {
            X = x;
            Y = y;
        }
    }

}
