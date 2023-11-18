using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Treyg05
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Введите периметр");
            double perimetr = double.Parse(Console.ReadLine());
            double side = perimetr / 3;
            double square = Math.Round(Math.Sqrt((perimetr * 0.5) * Math.Pow(((perimetr * 0.5) - side), (3))), 2);
            Console.WriteLine("Сторона\tПлощадь" +"\n"+ "{0}\t{1}", side, square);
            Console.Read();

        }
    }
}
