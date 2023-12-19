using System;
using System.Text;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double side1;
            double side2;
            while (true)
            {
                Console.WriteLine("Введіть 1 сторону: ");
                if (Double.TryParse(Console.ReadLine(), out side1))
                {
                    break;
                }
                Console.WriteLine("Будь ласка, введіть число!");
            }

            while (true)
            {
                Console.WriteLine("Введіть 2 сторону: ");
                if (Double.TryParse(Console.ReadLine(), out side2))
                {
                    break;
                }
                Console.WriteLine("Будь ласка, введіть число!");
            }

            Rectangle rectangle = new Rectangle(side1,side2);
            Console.WriteLine("Площа= " + rectangle.Area);
            Console.WriteLine("Периметр= " + rectangle.Perimeter);
            
            
        }
    }
}