using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  public static int Euclid(int a, int b, out int nod)
	  {
	    while (a != b)
	    {
	      if (a > b)
	      {
	        a = a - b;
	      }
	      else
	      {
	        b = b - a;
	      }
	    }
	    nod = b;
	    return nod;
	  }
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter 1 number");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter 2 number");       
			int b = int.Parse(Console.ReadLine());
			
			Euclid(a,b, out int nod);
			Console.WriteLine($"Greatest common divisor = {nod}");
		}
	}
}
