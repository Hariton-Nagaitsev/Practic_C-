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
          int num = int.Parse(Console.ReadLine());
          int summ = 0;
          int mult = 1;
          int d;
          
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
