using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Structs.Lab
{
    class Program
    {

        static void Main(string[] args)
        {
            var s = Stopwatch.StartNew();
            new MyTest().TestClass();
            s.Stop();
            Console.WriteLine($" Class  => {s.ElapsedMilliseconds,5:N0} ms");

            var s1 = Stopwatch.StartNew();
            new MyTest().TestStruct();
            s1.Stop();
            Console.WriteLine($" Struct => {s1.ElapsedMilliseconds,5:N0} ms");

            Console.WriteLine($"\n Struct is {s.ElapsedMilliseconds / s1.ElapsedMilliseconds }x faster!");
            Console.WriteLine();

        }

        public class MyTest
        {
            private static int numberOfIterations = 25000;
            private static int numberOfRequests = 100000;


            public void TestClass()
            {
                for (int r = 0; r < numberOfRequests; r++)
                {
                    var list = new CoordRef[numberOfIterations];
                    for (int i = 0; i < numberOfIterations; i++)
                    {
                        list[i] = new CoordRef(i, i);
                    }
                }
            }

            public void TestStruct()
            {
                for (int r = 0; r < numberOfRequests; r++)
                {
                    var list = new CoordVal[numberOfIterations];
                    for (int i = 0; i < numberOfIterations; i++)
                    {
                        list[i] = new CoordVal(i, i);
                    }
                }
            }
        }
    }



    class CoordRef
    {
        public int X;
        public int Y;
        public CoordRef(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    struct CoordVal
    {
        public int X;
        public int Y;

        public CoordVal(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

}
