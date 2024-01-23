using Geometry;
using System;

namespace GeometryTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point();
            var p2 = new Point(5);
            var p3 = new Point(-1, 2);

            Console.WriteLine($"Point p1 {p1.X}, {p1.Y}");
            Console.WriteLine($"Point p2 {p2.X}, {p2.Y}");
            Console.WriteLine($"Point p3 {p3.X}, {p3.Y}");

            p3.Move(3, 6);
            Console.WriteLine($"Point p3 {p3.X}, {p3.Y}");

            var s1 = new Segment(p2, new Point(8, 8));

            Console.WriteLine(new Point(3,4).Distance());

            Console.WriteLine(new Segment(new Point(), new Point(3,4)).Length);

            var pc = new PolygonalChain(p1, p2);
            pc.AddMidpoint(p3);

            var pc1 = new PolygonalChain(new Point(1, 1), new Point(2, 2));
            pc1.AddMidpoint(new Point(1, 2));
            Console.WriteLine(pc1.Length);

            Console.WriteLine(p3.ToString());
            
        }
    }
}
