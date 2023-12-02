using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To calculate the perimeter and area of the figure, enter:\nfor a triangle T/t\nfor a square S/s\nfor a circle C/c");
            
            string enter = Console.ReadLine();

            if (enter == "T" || enter == "t")
            {
                Console.WriteLine("Enter the sides of the triangle");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                Triangle tring = new Triangle(a, b, c);
                tring.Area();
                tring.Show();
            }
            else if (enter == "S" || enter == "s")
            {
                Console.WriteLine("Enter the side of the square");
                double a = double.Parse(Console.ReadLine());
                Square squa = new Square(a);
                squa.Area();
                squa.Show();
            }
            else 
            {
                Console.WriteLine("Enter the radius of the circle");
                double a = double.Parse(Console.ReadLine());
                Circle circle = new Circle(a);
                circle.Area();
                circle.Show();

            }
        }
    }
    class Shape
    {
        public double side { get; set; }

    }
    internal interface Spin
    {
        void Spin();
    }
    class Triangle : Shape, Spin
    {
        private double sideA { get; set; }
        private double sideB { get; set; }
        private double sideC { get; set; }
    
    
        public Triangle(double sideA, double sideB, double sideC) 
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
    
        public double Perimetr() 
        {
            double per = sideA + sideB + sideC;
            return per;
        
        }
    
        private (bool, double) Check()
        {
            bool ok;
            double pper = Perimetr();
            pper = 0.5 * (sideA + sideB + sideC);
    
            _ = (pper > sideA) && (pper > sideB) && (pper > sideC) ? ok = true : ok = false;
    
            return (ok, pper);
        }
    
        private bool Check2()
        {
            bool ok;
            _ = sideA == sideB && sideB == sideC && sideC == sideA ? ok = true : ok = false;
            return ok;
        }
    
        public double Area() 
        {
            double area;
            bool ok = Check2();
            (bool, double) okk = Check();
    
            if (ok == false)
            {
                _ = okk.Item1 == true ? area = Math.Round(Math.Sqrt(okk.Item2 * (okk.Item2 - sideA) * (okk.Item2 - sideC) * (okk.Item2 - sideB)), 2) : area = 0;
            }
            else 
            {
                area = Math.Round((Math.Pow((sideA), 2) * Math.Sqrt(3) / 4), 2);
            }
            return area; 
        }
    
        public void Spin() 
        {
            Console.WriteLine("The triangle shape has turned");
        
        }
    
        public void Show()
        {
            Console.WriteLine("Side Triangle:\nSide A = {0}\nSide B = {1}\nSide C = {2}", sideA, sideB, sideC);
            if (Area() == 0)
            {
                Console.WriteLine("is not a triangle");
    
            }
            else 
            {
                Console.WriteLine("Square = {0}\nPerimeter = {1}", Area(), Perimetr());
            }
        }
    }
    class Square : Shape, Spin
    {
        
    
        public Square(double side) 
        {
            this.side = side;
        }
    
        public double Perimetr()
        {
            double per = side * 4;
            return per;
    
        }
        public double Area()
        {
            double S = Math.Round(Math.Pow((side), 2), 2);
            return S;
    
        }
    
        public void Spin()
        {
            Console.WriteLine("The figure square has turned");
    
        }
    
        public void Show() 
        {
            Console.WriteLine("Side Square:\nSide = {0}", side);
            Console.WriteLine("Square = {0}\nPerimetr = {1}", Area(), Perimetr());
        
        }
    }
    class Circle : Shape
    {
         public Circle(double rad) 
         {
             this.side = rad;
         }
    
         public double Perimetr()
         {
             double per = 2 * 3.14 * side;
             return per;
         }
    
         public double Area() 
         {
             double S = Math.Round(3.14 * Math.Pow((side), 2), 2);
             return S;
         
         }
    
         public void Show() 
         {
             Console.WriteLine("Radius Circle:\nRadius = {0}", side);
             Console.WriteLine("Square = {0}\nPerimetr = {1}", Area(), Perimetr());
         }
    
    }
}




