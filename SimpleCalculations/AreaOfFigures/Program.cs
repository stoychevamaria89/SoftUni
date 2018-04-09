using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string square = "square";
            string circle = "circle";
            string rectangle = "rectangle";
            string triangle = "triangle";
            var input = Console.ReadLine();
            if (input == square)
            {
                var a = double.Parse(Console.ReadLine());
                var areaSquare = a * a;
                Console.WriteLine(Math.Round(areaSquare, 3));
            }
            else if (input == circle)
            {
                var r = double.Parse(Console.ReadLine());
                var areaCircle = r * r * Math.PI;
                Console.WriteLine(Math.Round(areaCircle, 3));
            }
            else if (input == rectangle)
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var areaRectangle = a * b;
                Console.WriteLine(Math.Round(areaRectangle, 3));
            }
            else if (input == triangle)
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                var areaTriangle = a * h / 2;
                Console.WriteLine(Math.Round(areaTriangle, 3));
            }
        }
    }
}
