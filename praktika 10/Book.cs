using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika_10
{
    internal class Book
    {
        private string title;
        private int pages;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value > 0 && value < 5001)
                {
                    pages = value;
                }
                else
                {
                    Console.WriteLine("Ошибка. Число страниц должно входить в определенный диапазон");
                }
            }
        }
        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;
        }
        public Book(string title): this(title, 1)
        {

        }
        public Book():this ("Без названия", 1)
        {

        }
        public void Read()
        {
            Console.WriteLine($"Читаю книгу:{title}, в ней {pages} страниц.");
        }
    }
}
