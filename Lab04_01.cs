using System;


namespace Utils
{

    class Utils
    {
      public static int Greater(int a, int b)
      {
        if (a > b)
        return a;
        else
        return b;
      }
    }
    public class Test
    {
      public static void Main( )
    {
        int x; // Input value 1
        int y; // Input value 2
        int greater; // Result from Greater()
          // Get input numbers
        Console.WriteLine("Enter first number:");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        y = int.Parse(Console.ReadLine());
        
          // Test the Greater( ) method
        greater = Utils.Greater(x,y);
        Console.WriteLine("The greater value is " + greater);
      }
    }
}
