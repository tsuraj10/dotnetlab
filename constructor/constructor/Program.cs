using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Program
    {
        public delegate void WhatIeat();
        public delegate void WhatIeats(string food);
        static void Main(string[] args)
        {
            Animal cow= new Animal();
            Animal dog = new Animal("dog");
            
            WhatIeat eat = new WhatIeat(cow.WhatIeat);
            WhatIeats eats= new WhatIeats(dog.WhatIeat);
            eat();
            eats("bone");
            //cow.WhatIeat();
            //dog.WhatIeat("bone");
            Console.ReadKey();
        }
    }
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("CommonAnimal Cow");
        }
        public void WhatIeat()
        {
            Console.WriteLine("I eat grass");
        }
        public Animal(string name)
        {
            Console.WriteLine("This is " + name);
        }
        public void WhatIeat(string food)
        {
            Console.WriteLine("I eat "+food);
        }
        /*~Animal()
        {
            
        }*/
    }
}
