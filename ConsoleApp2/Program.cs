using System;
using firsttask;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности:");
            double circleRadius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите первую сторону трегольника:");
            double triangleSide1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону трегольника:");
            double triangleSide2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третью сторону трегольника:");
            double triangleSide3 = Convert.ToDouble(Console.ReadLine());

            double circleArea = Calculator.Circlearea(circleRadius);
            double triangleArea = Calculator.TriangleArea(triangleSide1, triangleSide2, triangleSide3);

            Console.WriteLine($"Площадь круга: {circleArea}");
            Console.WriteLine($"Площадь треугольника: {triangleArea}");
        }
    }
}