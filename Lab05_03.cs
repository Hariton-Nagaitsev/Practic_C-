using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_03
{
    public class Program
    {
        static void Input(double[] array)                         // Ввод значений в массив
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("Enter value for [{0}] : ", i);
                array[i] = double.Parse(Console.ReadLine());
            }
        }
        static double Summ(double[] a)                         // Расчет суммы всех значений
        {
            double sum = a.Sum();
            return sum;

        }
        public static double PlusMinisSum(double[] array, out double plusSum, out double minusSum)  // Расчет суммы положительных и отрицательных значений
        {
            plusSum = 0;
            minusSum = 0;
            double r = 0;

            foreach (double i in array)
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
        static void SumSR(double a, double b)                                   // Расчет среднего значения
        {
            double res = a / b;
            Console.WriteLine(res);
        }
        static void Sumchet(double[] array)                                     // Расчет четных чисел
        {
            double res = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    res += array[i];
                }
            }
            Console.WriteLine(res);
        }
        static void SumNochet(double[] array)                                   // Расчет не четных чисел
        {
            double res = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    res += array[i];
                }
            }
            Console.WriteLine(res);
        }
        static void MinMax(double[] array)                      // Нахождение максимальных и минимальных значений и их индексов
        {
            double min = (array.Min());

            double index = Array.FindIndex(array, delegate (double i)
            {
                return i == min;
            });

            double max = (array.Max());

            double index2 = Array.FindIndex(array, delegate (double i)
            {
                return i == max;
            });

            Console.WriteLine("Min = {0}, Max = {1}, index Min = {2}, index Max = {3}", min, max, index, index2);
        }



        static void Output(double[] array)                             // Вывод значений массива
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter array length ");
            int cout = int.Parse(Console.ReadLine());              // Ввод размера массива
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
