using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika_10
{
    internal class Employe
    {
        private string name;
        private double salary;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                if(value> 0&& value <1000000)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Ошибка.");
                }
            }
        }
        public Employe(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public Employe(string name):this(name, 80000)
        { this.name = name; }
        public void Work()
        {
            Console.WriteLine($"{name} работает, получает {salary}.");
        }
    }
}
