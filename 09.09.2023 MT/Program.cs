using System.Globalization;

namespace _09._09._2023_MT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Student student1 = new Student("Emma", "Watson", 25);
            //Student student2 = new Student("George", "Clooney", 52);
            //Student student3 = new Student("Uma", "Thurman", 36);
            #endregion

            #region Task2
            //Rectangle rectangle = new Rectangle(5, 4);
            //Console.WriteLine(rectangle.CalculatePerimeter());
            //Console.WriteLine(rectangle.CalculateArea());
            //Circle circle = new Circle(6.3);
            //Console.WriteLine(circle.CalculateArea());
            //Console.WriteLine(circle.CalculatePerimeter());
            //Triangle triangle = new Triangle(5,4,3);
            //Console.WriteLine(triangle.CalculateArea());
            //Console.WriteLine(triangle.CalculatePerimeter());
            //Square square = new Square(9);
            //Console.WriteLine(square.CalculateArea());
            //Console.WriteLine(square.CalculatePerimeter());
            #endregion

            #region Task3

            Calculate calculate = new Calculate();
            Console.WriteLine(calculate.Divide(100, 5, 2));
            Console.WriteLine(calculate.Multiple(3, 5, 4));
            #endregion
        }
    }
    class Student
    {
        public string Name { get; }
        public string Surname { get; }
        public byte Age { get; }
        private static int Counter = 0;
        public Student(string name, string surname, byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Counter++;
        }
        public static int Count()
        {
            return Counter;
        }

    }
    interface IFigure
    {
        double CalculateArea();

        double CalculatePerimeter();

    }
    class Rectangle : IFigure
    {
        private double width { get; }
        private double height { get; }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double CalculateArea()
        {
            return width * height;
        }
        public double CalculatePerimeter()
        {
            return 2 * (height + width);
        }

    }
    class Circle : IFigure
    {
        private double radius { get; }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public double CalculatePerimeter()
        {
            return Math.PI * radius * 2;
        }
    }
    class Triangle : IFigure
    {
        private double a { get; }
        private double b { get; }
        private double c { get; }
        //private double h { get; }

        public Triangle(double a, double b, double c)//double h)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            //this.h = h;
        }
        ////my method
        //public double CalculateArea()
        //{
        //    return 0.5 * b * h;
        //}

        public double CalculateArea()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public double CalculatePerimeter()
        {
            return a + b + c;
        }
        //// Teacher Method
        // double s = (a + b + c) / 2; return Math.Sqrt(s * (s - a) * (s - b) * (s - c))
    }
    class Square : IFigure
    {
        private double side { get; }


        public Square(double side)
        {
            this.side = side;

        }
        public double CalculateArea()
        {
            return side * side;
        }
        public double CalculatePerimeter()
        {
            return 4 * side;
        }
    }

    interface ISum
    {
        double Sum(params double[] numbers);
    }
    interface IMultiple
    {
        double Multiple(params double[] numbers);
      

    }
    interface IDifference
    {
        double Difference(params double[] numbers);

    }
    interface IDivide
    {
        double Divide(params double[] numbers);

    }
    class Calculate : ISum, IMultiple, IDifference, IDivide
    {
        public double Sum(params double[] numbers)
        {
            return numbers.Sum();

        }
        public double Multiple(params double[] numbers)
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine("Reqem yoxdur");

            }
            double result = 1.0;
            foreach (double num in numbers)
            {
                result *= num;
            }
            return result;

        }
       public double Difference(params double[] numbers)
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine("error");
            }
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }
       public double Divide(params double[] numbers)
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine("error");
            }
            double result = numbers[0];
            for (int i = 1; i< numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    Console.WriteLine("error");
                }

                result /= numbers[i];
            }
            return result;

        }
    }

}


