using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_04
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the side length A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the side length B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the side length C");
            double c = double.Parse(Console.ReadLine());
            dynamic reply;
            _ = a == b && b == c && c == a ? reply = Operation.Sqr1(a) : reply = Operation.Sqr(a, b, c);
            Console.WriteLine(reply);

        }
    }
    public class Operation 
    {
        public static dynamic Sqr(double a, double b, double c)
        {
            dynamic square;
            bool okk;
            double pp;
            pp = 0.5 * (a + b + c);
            okk = Check(a, b, c);
            string str = "Figure is not a triangle";
            _ = okk == true ? square = Math.Round(Math.Sqrt(pp * (pp - a) * (pp - c) * (pp - b)), 2) : square = str;
            return square;
        }

         private static bool Check(double a, double b, double c) 
        {
            bool ok;
            double pp;
            pp = 0.5 * (a + b + c);
            _ = (pp > a) && (pp > b) && (pp > c) ? ok = true : ok = false;
            return ok;
        }
        public static dynamic Sqr1(double a)
        {
            dynamic square;
            square = Math.Round((Math.Pow((a),2) * Math.Sqrt(3) / 4), 2);
            return square;
        }
    }
}
