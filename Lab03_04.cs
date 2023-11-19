using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count_attempt = 3; // число попыток
            int shot = 1; // число выстрелов
            int win_count = 0; // число выйгранных очков
            int status_count = count_attempt;

            while (count_attempt > 0) 
            {
                try
                {
                    Console.WriteLine("Выполните {0} выстрел", shot);
                    Console.WriteLine("Введите значение x: ");
                    double x = double.Parse(Console.ReadLine()); // первая длина катета треугольника
                    Console.WriteLine("Введите значение y: ");
                    double y = double.Parse(Console.ReadLine()); // вторая длина катета треугольника

                    double c = Math.Sqrt((Math.Pow(Math.Abs(x), 2)) + (Math.Pow(Math.Abs(y), 2))); // расчет длины гипотенузы

                    if (c <= 1)
                    {
                        win_count += 10;
                        count_attempt--;
                        Console.WriteLine("Вы выйграли 10 очков");
                        if (count_attempt == 1)
                        {
                            Console.WriteLine("У вас осталось {0} попытка", count_attempt);
                        }
                        else if (count_attempt >= 2 && count_attempt <= 4) 
                        {
                            Console.WriteLine("У вас осталось {0} попытки", count_attempt);
                        }
                        else
                        {
                            Console.WriteLine("У вас осталось {0} попыток", count_attempt);
                        }
                    }
                    else if (c > 1 && c <= 2)
                    {
                        win_count += 5;
                        count_attempt--;
                        Console.WriteLine("Вы выйграли 5 очков");
                        if (count_attempt == 1)
                        {
                            Console.WriteLine("У вас осталось {0} попытка", count_attempt);
                        }
                        else if (count_attempt >= 2 && count_attempt <= 4)
                        {
                            Console.WriteLine("У вас осталось {0} попытки", count_attempt);
                        }
                        else
                        {
                            Console.WriteLine("У вас осталось {0} попыток", count_attempt);
                        }
                    }
                    else if (c > 2 && c <= 3)
                    {
                        win_count += 1;
                        count_attempt--;
                        Console.WriteLine("Вы выйграли 1 очко");
                        if (count_attempt == 1)
                        {
                            Console.WriteLine("У вас осталось {0} попытка", count_attempt);
                        }
                        else if (count_attempt >= 2 && count_attempt <= 4)
                        {
                            Console.WriteLine("У вас осталось {0} попытки", count_attempt);
                        }
                        else
                        {
                            Console.WriteLine("У вас осталось {0} попыток", count_attempt);
                        }
                    }
                    else 
                    {
                        win_count += 0;
                        count_attempt--;
                        Console.WriteLine("Вы промахнулись");
                        if (count_attempt == 1)
                        {
                            Console.WriteLine("У вас осталось {0} попытка", count_attempt);
                        }
                        else if (count_attempt >= 2 && count_attempt <= 4)
                        {
                            Console.WriteLine("У вас осталось {0} попытки", count_attempt);
                        }
                        else
                        {
                            Console.WriteLine("У вас осталось {0} попыток", count_attempt);
                        }
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Error", e.Message);
                    count_attempt++;
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
                shot += 1;
            }
            Console.WriteLine("Ваш выигрыш составил: {0} очков из {1} попыток!", win_count, status_count);
            Console.WriteLine("Игра окончена!");
        }
    }
}
