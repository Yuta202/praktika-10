using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika_10
{
    internal class Cat: Animal
    {
        private int lives;
        public int Lives
        {
            get { return lives; }
            set
            {
                if(value>=1&&value<=9)
                {
                    lives = value;
                }
                else
                {
                    Console.WriteLine("Кол-во жизней не может быть меньше 0.");
                }
            }
        }
        public Cat(string name,int lives) : base(name)
        { this.lives = lives; }
        public Cat(string name): base(name)
        {

        }
       
        public void Meow()
        {
            int minus = lives - 1;
            if (minus < 0)
            {
                Console.WriteLine("Ошибка. Кол-во жизней не может быть меньше 0.");
            }
            
            Console.WriteLine($"{Name} мяукнул, осталось жизней: {minus}");
        }
    }
}
