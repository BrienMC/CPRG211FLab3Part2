using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG_211_F_Lab_3_Part_2
{
    public interface IAnimal
    {
        string? Name { get; set; }
        string? Colour { get; set; }
        int Height { get; set; }
        int Age { get; set; }

        public abstract void Eat();
        public string Cry();

    }

    public class Dog : IAnimal
    {
        public string? Name { get; set; }
        public string? Colour { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }
        
        public virtual string Cry()
        {
            return "Woof!";
        }

    }

    public class Cat : IAnimal
    {
        public string? Name { get; set; }
        public string? Colour { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }

        public virtual string Cry()
        {
            return "Meow!";
        }

    }
}
