using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Sum
{
	/// Контрольное задание - Вычислить сумму цифр числа. Обосновать выбор типа цикла
    class Program
    {
        static void Main()
        {
          long num = long.Parse(Console.ReadLine());
          long summ = 0;
          long mult = 1;
          long d;
          
          while (num > 0)
          {
            d = num % 10;
	    summ = summ + d;
	    num = num / 10;
          }
	Console.WriteLine(summ);
        }
    }
}
