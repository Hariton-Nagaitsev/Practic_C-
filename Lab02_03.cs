using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public struct Distance
    {
        public int foot;
        public double inches;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Distance pointA, pointB, distance;

            Console.WriteLine("Enter the number of feet: ");
            pointA.foot = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of inches: ");
            pointA.inches = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of feet: ");
            pointB.foot = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of inches: ");
            pointB.inches = double.Parse(Console.ReadLine());
            

            distance.inches = pointA.inches + pointB.inches;
            distance.foot = (int)0;
            
            while (distance.inches >= 12.0) 
            {
                distance.inches -= 12.0;
                distance.foot++;
            }
            distance.foot += pointA.foot + pointB.foot;
            Console.WriteLine(distance.foot + "-" + distance.inches);

        }
    }
}
