using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Test
    {
        static void Main()
        {
            int f; // Factorial result
            bool ok; // Factorial success or failure
            Console.WriteLine("Number for factorial:");
            int x = int.Parse(Console.ReadLine());
            // Test the factorial function
            ok = Utils.Factorial(x, out f);
            // Output factorial results
            if (ok)
                Console.WriteLine("Factorial(" + x + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");
        }
    }
    public class Utils
        {
            // Calculate factorial
            // and return the result as an out parameter
            public static bool Factorial(int n, out int answer)
            {
                int k; // Loop counter
                int f; // Working value
                bool ok = true; // True if okay, false if not
                                // Check the input value
                if (n < 0)
                ok = false;
                // Calculate the factorial value as the
                // product of all of the numbers from 2 to n
                try
                {
                    checked
                    {
                        f = 1;
                        for (k = 2; k <= n; ++k)
                        {
                            f = f * k;
                        }
                    }
                }
                catch (Exception)
                {
                    f = 0;
                    ok = false;
                }
                answer = f;
                return ok;
            }
        }

}
