using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_04
{
    class Program
    {
        public static void Main()
        {
            Tringle.Input(); Tringle.Write(); 
            double perim = Tringle.Perimeter(); Tringle.Write1(perim);
            dynamic sqr = Tringle.Sqr(); Tringle.Write2(sqr);
        } 
    }

    class Tringle 
    {
        public static double a, b, c;

        public static Tringle Input()
        {
            Tringle input = new Tringle();

            Console.WriteLine("Enter a"); double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b"); double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c"); double c = double.Parse(Console.ReadLine());
            input.Sides(a, b, c);
            return input;

        }

        public static void Write() 
        {
            
            Console.WriteLine("Side A = {0}", a);
            Console.WriteLine("Side B = {0}", b);
            Console.WriteLine("Side C = {0}", c);
        }

        public static void Write1(double p)
        {

            Console.WriteLine("Perimetr = {0}", p);
            
        }
        public static void Write2(double s)
        {

            Console.WriteLine("Square = {0}", s);

        }
        public void Sides(double a1, double b1, double c1)
        {
            a = a1;
            b = b1;
            c = c1;
        }
        public static double Perimeter()
        {
            double p = a + b + c;
            return p;
        }

        private static (bool, double) Check()
        {
            bool ok;

            double pp;

            pp = 0.5 * (a + b + c);

            _ = (pp > a) && (pp > b) && (pp > c) ? ok = true : ok = false;

            return (ok, pp);
        }

        private static bool Check2()
        {
            bool ok;
            _ = a == b && b == c && c == a ? ok = true : ok = false;
            return ok;
        }

        public static dynamic Sqr()
        {
            dynamic square; string str = "Figure is not a triangle"; bool ok = Check2(); (bool, double) okk = Check();

            if (ok == false)
            {
                _ = okk.Item1 == true ? square = Math.Round(Math.Sqrt(okk.Item2 * (okk.Item2 - a) * (okk.Item2 - c) * (okk.Item2 - b)), 2) : square = str;
                
            }
            else 
            {
                square = Math.Round((Math.Pow((a), 2) * Math.Sqrt(3) / 4), 2);
            }
            return square;
        }
    }  
}
