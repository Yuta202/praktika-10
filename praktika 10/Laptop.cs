using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika_10
{
    internal class Laptop: Device
    {
        private int ram;
        private int battery;
        public int Ram
        {
            get { return ram; }
            set
            {
                if (value > 0 && value <= 64)
                { ram = value;}
                else
                {
                    Console.WriteLine("Ошибка.");
                }
            }
        }
        public int Battery
        {
            get { return battery; }
            set
            {
                if(value > 0 && value <=100)
                {  battery = value;}
                else
                {
                    Console.WriteLine("Ошибкаю");
                }
            }
        }
        public Laptop(string brand,int ram, int battery): base(brand)
        {
            this.ram = ram;
            this.battery = battery;
        }
        public void On()
        {
            Console.WriteLine($"Ноутбук {Brande}, ОЗУ {ram} гб, заряд {battery}%");
        }
    }
}
