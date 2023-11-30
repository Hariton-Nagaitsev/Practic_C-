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
        public static void Main(string[] args)
        {
            Tringle input = new Tringle();
            input.Input();
            input.Write();
            double perim = input.Perimeter(); input.Write1(perim);
            dynamic sqr = input.Sqr(); input.Write2(sqr);

        }
    }

    class Tringle
    {
        private double a, b, c;

        public Tringle(double a, double b, double C) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        
        }
        public Tringle(){}
        
        public double Input()
        {
            Console.WriteLine("Enter a"); double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b"); double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c"); double c = double.Parse(Console.ReadLine());
          
            Tringle input = new Tringle(a,b,c);
          
            return input;
                    
        }
        

        public void Write()
        {

            Console.WriteLine("Side A = {0}", a);
            Console.WriteLine("Side B = {0}", b);
            Console.WriteLine("Side C = {0}", c);
        }

        public void Write1(double p)
        {

            Console.WriteLine("Perimetr = {0}", p);

        }
        public void Write2(dynamic s)
        {
            Console.WriteLine("Square = {0}", s);
        }

        public double Perimeter()
        {
            double p = this.a + b + c;
            return p;
        }

        private (bool, double) Check()
        {
            bool ok;

            double pp;

            pp = 0.5 * (a + b + c);

            _ = (pp > a) && (pp > b) && (pp > c) ? ok = true : ok = false;

            return (ok, pp);
        }

        private bool Check2()
        {
            bool ok;
            _ = a == b && b == c && c == a ? ok = true : ok = false;
            return ok;
        }

        public dynamic Sqr()
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
