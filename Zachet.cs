using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("Admin","00.00.0000", 0);
            Student student = new Student("Student","11.11.1111","faculty", 1);
            Teacher teacher = new Teacher("Teacher","22.22.2222","faculty","post", 2);
            Manager manager = new Manager("Manager","33.33.3333","faculty","post");
            List<object> person = new List<object> { admin, student,teacher,manager };
            foreach (object p in person) 
            {
                Console.WriteLine(p);
            }
            admin.Work();
            student.Work();
            teacher.Work();
            manager.Work();

            admin.PrintSelary();
            double per_hour = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            Admin admin1 = new Admin(per_hour);
            Console.WriteLine(admin1.Selary(month));
        }
    }
    interface IEmployee 
    {
        void Work();
    
    }
    abstract class Person : IEmployee
    {
        public string surname;
        public string date;
        public string faculty;
        public string post;
        public double per_hour { get; set; }

        public abstract void Work();
        public int[] days = new int[]{31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        public abstract double Selary(int months);
        public abstract void PrintSelary();
       
    }

    class Admin : Person
    {
        public int lab;

        public Admin(string surname, string date, int lab) 
        {
            this.surname = surname;
            this.date = date;
            this.lab = lab;
        
        }
        public Admin(double per_hour) => this.per_hour = per_hour;

        public override void Work()
        {
            Console.WriteLine("The admin is working");
        }
        public override void PrintSelary() 
        {
            Console.WriteLine("Enter the wage per hour, then the month number");
        }

        public override double Selary(int months) 
        {
            double selary = 0;
            for (int i = 0; i < days.Length; i++) 
            {
                if (i == months)
                {
                    int a = days[i];
                    selary = a * per_hour * 8;
                    return selary;
                }  
            }
            return selary;
            
        }
        public override string ToString()
        {
            return string.Format($"Name: {surname}, Date: {date}, Lab: {lab}");
        }

    }
    class Student : Person
    {
        public int group;

        public Student(string surname, string date, string faculty, int group) 
        {
            this.surname = surname;
            this.date = date;
            this.faculty = faculty;
            this.group = group;
        }
        public Student(double per_hour) => this.per_hour = per_hour;
        public override double Selary(int months)
        {
            double selary = 0;
            for (int i = 0; i < days.Length; i++)
            {
                if (i == months)
                {
                    int a = days[i];
                    selary = a * per_hour * 5;
                    return selary;
                }
            }
            return selary;

        }

        public override void Work()
        {
            Console.WriteLine("The student is learning");
        }
        public override void PrintSelary()
        {
            Console.WriteLine("Enter the wage per hour, then the month number");
        }
        public override string ToString()
        {
            return string.Format($"Name: {surname}, Date: {date}, Faculty: {faculty}, Group: {group}");
        }


    }
    class Teacher : Person
    {
        public int seniority;

        public Teacher( string surname, string date, string faculty, string post, int seniority) 
        {
            this.surname = surname;
            this.date = date;
            this.faculty = faculty;
            this.post = post;
            this.seniority = seniority;
        }

        public Teacher(double per_hour) => this.per_hour = per_hour;
        public override double Selary(int months)
        {
            double selary = 0;
            for (int i = 0; i < days.Length; i++)
            {
                if (i == months)
                {
                    int a = days[i];
                    selary = a * per_hour * 8;
                    return selary;
                }
            }
            return selary;
        }

        public override void Work()
        {
            Console.WriteLine("The teacher is working");
        }
        public override void PrintSelary()
        {
            Console.WriteLine("Enter the wage per hour, then the month number");
        }

        public override string ToString()
        {
            return string.Format($"Name: {surname}, Date: {date}, Faculty: {faculty}, Post: {post}, Seniority {seniority}");
        }
    }
    class Manager : Person
    {
        public Manager(string surname, string date, string faculty, string post) 
        {
            this.surname = surname;
            this.date = date;
            this.faculty = faculty;
            this.post = post;
        }

        public Manager(double per_hour) => this.per_hour = per_hour;
        public override double Selary(int months)
        {
            double selary = 0;
            for (int i = 0; i < days.Length; i++)
            {
                if (i == months)
                {
                    int a = days[i];
                    selary = a * per_hour * 8;
                    return selary;
                }
            }
            return selary;
        }
        public override void Work()
        {
            Console.WriteLine("The manager is working");
        }
        public override void PrintSelary()
        {
            Console.WriteLine("Enter the wage per hour, then the month number");
        }
        public override string ToString()
        {
            return string.Format($"Name: {surname}, Date: {date}, Faculty: {faculty}, Post: {post}");
        }
    }
}
