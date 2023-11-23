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
			
			dynamic input = Sqr(a,b,c, out double x1, out double x2);
			
			
			
		}
		
		
		public static dynamic Sqr(double a, double b, double c, out double x1, out double x2)
		{

		  
		  if (a != 0)
		  {

		  double d = Math.Pow((d),2) - 4 * a * c;
		  
		    if (d > 0)
		    {
		      x1 = -b + Math.Sqr(d)) / 2 * a;
		      x2 = -b - Math.Sqr(d)) / 2 * a;
		    }
		    else
		    {
		      
		    }
		  }
		  else
		  {
		     return "Equation is not square";
		  }
		  
		  
		}
		
	}
}
