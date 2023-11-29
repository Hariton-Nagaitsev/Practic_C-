using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Customer
    {
        public string Name { get; set; }
        public double Balance { get; private set; }

        public Customer(string name, double balance = 100)
        {
            Name = name;
            Balance = balance;
        }

        public Customer() { }

        public override string ToString()
        {
            return string.Format("Клиент: {0} имеет баланс: {1}", Name, Balance);
        }
        
        public void RecordPayment(double amountPaid)
        {
            if (amountPaid > 0)
                Balance += amountPaid;
        }

        Tarif tar = new Tarif();
        public void RecordCall(char callType, double minutes)
        {
            if (callType == 'Г')
            {
                Console.WriteLine("У вас есть возможность изменить тариф на: ##После10МинутВ2РазаДешевле##\nНажмите 1\nЛибо " +
                    "остаться на: ##Повременный##\nНажмите 0 ");
                int tarif = int.Parse(Console.ReadLine());

                if (tarif == 1)
                {
                    Balance -= tar.Tar2(minutes);
                }
                else
                {
                    Balance -= tar.Tar1(minutes);
                }

            }
            else
                if (callType == 'М') 
            {
                Console.WriteLine("У вас есть возможность изменить тариф на: ##ПлатиМеньшеДо5Минут##\nНажмите 2\nЛибо " +
                    "остаться на: ##Повременный##\nНажмите 0 ");
                int tarif = int.Parse(Console.ReadLine());

                if (tarif == 2)
                {
                    Balance -= tar.Tar3(minutes);
                }
                else 
                {
                    Balance -= tar.Tar1(minutes);
                }

            }      
        }
    }

    class Tarif
    {
        
        public double Tar1(double min)
        {
            min = min * 5;

            return min;
        }

        public double Tar2(double min)
        {
            if (min > 10)
            {
                min = min * 2.5;
                return min;
            }
            else
            {
                min = min * 5;

                return min;
            }
        }

        public double Tar3(double min)
        {
            if (min < 5)
            {
                min = min * 2.5;
                return min;
            }
            else
            {
                min = min * 10;
                return min;
            }

        }

    }

    class Customer1
    {
        static void Main(string[] args)
        {
            Customer Ivan = new Customer("Иван Петров", 500);
            Customer Elena = new Customer("Елена Иванова");

            Ivan.RecordCall('Г', 6.1);
            Elena.RecordCall('М', 20.1);

            Console.WriteLine(Ivan);
            Console.WriteLine(Elena);

        }
    }
}

