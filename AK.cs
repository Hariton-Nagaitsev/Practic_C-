using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab04_05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter value a"); double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value b"); double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value c"); double c = double.Parse(Console.ReadLine());

            if (a != 0)
            {
                (double, double, double) result = Sqr(a, b, c);
                double flag = result.Item1, x1 = result.Item2, x2 = result.Item3;
                
                if (x1 == 0 && x2 == 0)
                {
                    Console.WriteLine("no roots");
                }
                else if (x1 == x2)
                {
                    Console.WriteLine($"roots = {x1}");
                }
                else
                {
                    Console.WriteLine($"roots = {x1} and {x2}");
                }
            }
            else
            {
                Console.WriteLine("Equation is not square");
            }
        }
        public static (double, double, double) Sqr(double a, double b, double c)
        {
            double flag = 0, x1, x2;
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d >= 0)
            {
                x1 = Math.Round(((-b + Math.Sqrt(d)) / (2 * a)), 2); x2 = Math.Round(((-b - Math.Sqrt(d)) / (2 * a)), 2);
            }
            else
            {
                x1 = 0;
                x2 = 0;
            }
            return (flag, x1, x2);
        }
    }
}
