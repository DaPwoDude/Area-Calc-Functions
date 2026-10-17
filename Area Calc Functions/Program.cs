namespace Area_Calc_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again == true)
            {
                Console.WriteLine("===============");
                Console.WriteLine("AREA CALCULATOR");
                Console.WriteLine("===============");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Trapezoid");
                Console.WriteLine("5. Parallelogram");
                Console.WriteLine("6. Square");
                Console.WriteLine("7. Elipse");
                Console.WriteLine("8. Exit");
                Console.WriteLine();
                Console.WriteLine("Pick a number from 1 to 8");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    double area = CircleCalc();
                    Console.WriteLine("Area of circle is " + area);
                }
                else if (num == 2)
                {
                    double area = RecCalc();
                    Console.WriteLine("Area of rectangle is " + area);
                }
                else if (num == 3)
                {
                    double area = TriCalc();
                    Console.WriteLine("Area of triangle is " + area);
                }
                else if (num == 4)
                {
                    double area = TrapezoidCalc();
                    Console.WriteLine("Area of trapezoid is " + area);
                }
                else if (num == 5)
                {
                    double area = RecCalc();
                    Console.WriteLine("Area of parallelogram is " + area);
                }
                else if (num == 6)
                {
                    double area = SquareCalc();
                    Console.WriteLine("Area of square is " + area);
                }
                else if (num == 7)
                {
                    double area = ElipseCalc();
                    Console.WriteLine("Area of elipse is " + area);
                }
                else if (num == 8)
                {
                    again = false;
                }
            }
        }

        static double CircleCalc()
        {
            Console.WriteLine("Enter radius");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = radius * radius * 3.14;
            return area;
        }
        static double RecCalc()
        {
            Console.WriteLine("Enter width");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height");
            double height = Convert.ToDouble(Console.ReadLine());
            double area = width * height;
            return area;
        }
        static double TriCalc()
        {
            Console.WriteLine("Enter base");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height");
            double height = Convert.ToDouble(Console.ReadLine());
            double area = 0.5 * width * height;
            return area;
        }
        static double TrapezoidCalc()
        {
            Console.WriteLine("Enter parallel side length");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter other parallel side length");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height");
            double height = Convert.ToDouble(Console.ReadLine());
            double area = ((a + b) / 2) * height;
            return area;
        }
        static double SquareCalc()
        {
            Console.WriteLine("Enter side length");
            double width = Convert.ToDouble(Console.ReadLine());
            double area = width * width;
            return area;
        }
        static double ElipseCalc()
        {
            Console.WriteLine("Enter longest radius");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter shortest radius");
            double b = Convert.ToDouble(Console.ReadLine());
            double area = a * b * 3.14;
            return area;
        }
    }
}
