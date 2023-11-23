using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter value a");
			double a = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter value b");
			double b = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter value c");
			double c = double.Parse(Console.ReadLine());
			
			double input;
			
			if (a != 0)
			{
			  
			input = Sqr(a, b, c, out double x1, out double x2);
			
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
		
		public static double Sqr(double a, double b, double c, out double x1, out double x2)
		{
		  
		    
		    double d = Math.Pow((b),2) - 4 * a * c;
		  
		    if (d > 0)
		    {
		       x1 = (-b + Math.Sqrt(d)) / 2 * a;
		       x2 = (-b - Math.Sqrt(d)) / 2 * a;
		    }
		    else
		    {
		        x1 = 0;
		        x2 = 0;
		    }

		  }
		}
}
