using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algorithm_Square
{
	public class Sqrt
  {
		public static void Square_root(double numb, out double nu)
		
		{
			double x = 1;
			double oldx = 0;
		  do
		  {
			  oldx = x;
        		x = (x + numb / x) / 2;
		  }
		  while(oldx != x);
		  nu = x;
		}
		
		public static void Output(double r)
		{
		  double check = r * r;
		  Console.WriteLine($"Square root = {r}, of a number {check}");
		}
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter numb: ");
			double numb = double.Parse(Console.ReadLine());
      			Square_root(numb, out double nu);
			Output(nu);
		}
	}
}
