namespace firsttask
{
    public static class Calculator
    {
        public static double Circlearea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус не может быть меньше или равен 0");
            }

            return Math.PI * Math.Pow(radius, 2);
        }

        public static double TriangleArea(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Сторона треугольника не может быть меньше или равно 0");
            }
            else if ((Math.Pow(side1, 2) == Math.Pow(side2, 2) + Math.Pow(side3, 2))
                || (Math.Pow(side2, 2) == Math.Pow(side1, 2) + Math.Pow(side3, 2))
                || (Math.Pow(side3, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2)))
            {
                double arearighttrin = 0.5 * Math.Min(side1, side2) * Math.Min(side2, side3);
                return arearighttrin;
            }
            else
            {
                double semiperimeter = (side1 + side2 + side3) / 2;
                return Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
            }

        }
    }
}