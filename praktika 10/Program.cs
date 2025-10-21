using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // книга           
            Book book = new Book("Война и мир", 1200);
            book.Read();
            Book book1 = new Book("1984");
            book1.Read();
            Book book2 = new Book();
            book2.Read();
            // Employe
            Employe emp = new Employe("Иван", 90000);
            emp.Work();
            Employe emp1 = new Employe("Петя");
            emp1.Work();
            // устройство
            Laptop lp = new Laptop("Macbook", 64, 84);
            lp.Poweron();
            lp.On();
            // Point
            Point x = new Point(5.5, 9.105);
            x.Show();
            Point y = new Point(5.15);
            y.Show();
            Point z = new Point();
            z.Show();
            // животные
            Cat cat = new Cat("Барсик", 9);
            cat.Speak();
            cat.Meow();
            Cat cat1 = new Cat("Дымок", 9);
            cat1.Speak();
            cat1.Meow();
        }
    }
}
