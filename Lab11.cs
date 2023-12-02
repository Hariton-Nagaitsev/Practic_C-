using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Distance
    {
        public int foot { get; set; }
        public double inches { get; set; }
        
        public override bool Equals(object p)
        {
            return true;
        }
        public override int GetHashCode()
        {
            return 0;
        }
        public static bool operator !=(Distance par1, Distance par2)
        {
            if (par1.foot == par2.foot)
                return true;
            return false;
        }
        public static bool operator ==(Distance par1, Distance par2)
        {
            if (par1.foot != par2.foot)
                return true;
            return false;
        }
        public static Distance operator +(Distance dis1, Distance dis2)
        {
            return new Distance { foot = dis1.foot + dis2.foot, inches = dis1.inches + dis2.inches };
        }
        public static Distance operator -(Distance dis1, Distance dis2)
        {
            return new Distance { foot = dis1.foot - dis2.foot, inches = dis1.inches - dis2.inches };
        }
        public override string ToString()
        {
            return String.Format("{0} - {1}", foot, inches);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Distance dis1 = new Distance();
            Distance dis2 = new Distance();
            Distance minus = new Distance();
            Distance plus = new Distance();

            Console.WriteLine("Enter feet №1"); dis1.foot = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter feet №2"); dis2.foot = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter inches №1"); dis1.inches = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter inches №2"); dis2.inches = double.Parse(Console.ReadLine());
            plus = dis1 + dis2;
            minus = dis1 - dis2;
            bool writ = dis1 == dis2;
            Console.WriteLine(writ);
            Console.WriteLine(plus);
            Console.WriteLine(minus);
        }
    }
}
