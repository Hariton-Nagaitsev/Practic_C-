using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_03
{
    public class Program
    {
        static void Input(double[] ints)
        {
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                Console.Write("Enter value for [{0}] : ", i);
                ints[i] = double.Parse(Console.ReadLine());
            }
        }
        static double Summ(double[] a)
        {
            double sum = a.Sum();
            return sum;

        }
        public static double PlusMinisSum(double[] ints, out double plusSum, out double minusSum)
        {
            plusSum = 0;
            minusSum = 0;
            double r = 0;

            foreach (double i in ints)
            {
                if (i < 0)
                {
                    minusSum += i;
                }
                else
                {
                    plusSum += i;
                }
            }
            return r;
        }
        static void SumSR(double a, double b)
        {
            double res = a / b;
            Console.WriteLine(res);
        }
        static void Sumchet(double[] ints)
        {
            double res = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 == 0)
                {
                    res += ints[i];
                }
            }
            Console.WriteLine(res);
        }
        static void SumNochet(double[] ints)
        {
            double res = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 != 0)
                {
                    res += ints[i];
                }
            }
            Console.WriteLine(res);
        }
        static void MinMax(double[] ints)
        {
            double min = (ints.Min());

            double index = Array.FindIndex(ints, delegate (double i)
            {
                return i == min;
            });

            double max = (ints.Max());

            double index2 = Array.FindIndex(ints, delegate (double i)
            {
                return i == max;
            });

            Console.WriteLine("Min = {0}, Max = {1}, index Min = {2}, index Max = {3}", min, max, index, index2);
        }
        static void Output(double[] ints)
        {
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                Console.Write("{0} ", ints[i]);
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter array length ");
            int cout = int.Parse(Console.ReadLine());
            double[] a = new double[cout];
            Input(a);
            Output(a);
            Summ(a);
            double su = Summ(a);
            Console.WriteLine(su);
            SumSR(su, cout);
            Sumchet(a);
            SumNochet(a);
            MinMax(a);
            PlusMinisSum(a, out double plusSum, out double minusSum);
            Console.WriteLine("{0},{1}", plusSum, minusSum);
        }
    }
}
