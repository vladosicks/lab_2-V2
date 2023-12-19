using System;
using System.Text;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Point point1 = new Point(0, 0, "A");
            Point point2 = new Point(3, 0, "B");
            Point point3 = new Point(0, 4, "C");

            Figure triangle = new Figure(point1, point2, point3);
            triangle.CalculatePerimeter();
        }
    }
}