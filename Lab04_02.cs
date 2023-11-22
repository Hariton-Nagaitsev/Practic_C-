using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Utils
{

    public class Utils
    
  {
    public static void Swap(ref int a, ref int b)
    {
      int temp = a;
      a = b;
      b = temp;
    }
  }
    public class Test
  {
    public static void Main( )
    {
      //As before…
      // Test the Swap method
      int x; // Input value 1
      int y; // Input value 2
      
      x = int.Parse(Console.ReadLine());
      y = int.Parse(Console.ReadLine());
      Console.WriteLine("Before swap: " + x + "," + y);
      Utils.Swap(ref x, ref y);
      Console.WriteLine("After swap: " + x + "," + y); 
    }
  }
}
