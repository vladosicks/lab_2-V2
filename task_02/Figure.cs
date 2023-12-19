using System;

namespace Task_2
{
    public class Figure
    {
        private Point[] _points;

        public Figure(Point point1, Point point2, Point point3)
        {
            _points = new Point[3] { point1, point2, point3 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            _points = new Point[4] { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            _points = new Point[5] { point1, point2, point3, point4, point5 };
        }

        public double GetSideLength(Point a, Point b)
        {
            double sideLength = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
            return sideLength;
        }

        public void CalculatePerimeter()
        {
            double perimeter = 0;
            int numberOfPoints = _points.Length;

            for (int i = 0; i < numberOfPoints; i++)
            {
                int nextIndex = (i + 1) % numberOfPoints;
                perimeter += GetSideLength(_points[i], _points[nextIndex]);
            }

            Console.WriteLine("Периметр многокутника = " + perimeter);
        }
    }
}