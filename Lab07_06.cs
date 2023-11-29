using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();

            object[] books = new object[] { book1, book2, book3 };


            book1.SetBook("book", "title", 233, 1900);
            book1.SetBook("book", "title", 325, 1800);
            book1.SetBook("book", "title", 100, 1700);


            book1.Show();

            Array.Sort(books);

            string bk = book1.Convert(book1);

            Console.WriteLine(bk);

            foreach (object b in books)
            {
                Book ini = (Book)b;
                string a = ini.Convert(ini);
                Console.WriteLine("Book year = {0}", a);
            }
            Console.Read();
        }
    }
    class Book : IComparable
    {
        private string athor;
        private string title;
        private int year;
        private int pages;


        public string Convert(object value)
        {

            return year.ToString();
        }

        int IComparable.CompareTo(object obj)
        {
            Book it = (Book)obj;
            if (this.year == it.year) return 0;
            else if (this.year > it.year) return 1;
            else return -1;
        }
        public void SetBook(string athor, string title, int pages, int year)
        {
            this.athor = athor;
            this.title = title;
            this.year = year;
            this.pages = pages;

        }
        public void Show()
        {
            Console.WriteLine($"Книга:Автор {athor}\nНазвание: {title}\nГод издания: {year}\nСтраниц: {pages}");

        }
    }
}
