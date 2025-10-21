using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika_10
{
    internal class Device
    {
        private string brand;
        public string Brande
        {
            get {  return brand; }
            set { brand = value; }
        }
        public Device(string brand)
        {
            this.brand = brand;
        }
        public void Poweron()
        {
            Console.WriteLine($"{brand} включен.");
        }
    }
}
