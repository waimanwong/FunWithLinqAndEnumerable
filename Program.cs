using System;
using System.Linq;
using System.Collections.Generic;

namespace FunWithLinqAndEnumerable
{
    class Program
    {
        static IEnumerable<Point> InitPoints()
        {
            return Enumerable.Range(start:1, count: 10).Select(x => new Point(x,0));
        }

        static void Main(string[] args)
        {
            var points = InitPoints().ToArray();

            foreach(var point in points)
            {
                Console.WriteLine(point);
            }

            Console.WriteLine("Move up all points");

            foreach(var point in points)
            {
                point.MoveUp();
            }

            foreach(var point in points)
            {
                Console.WriteLine(point);
            }

            Console.WriteLine("Press return to exit.");
            Console.ReadLine();
        }
    }
}
