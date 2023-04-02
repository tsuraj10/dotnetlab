using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            overloading cow=new overloading();
            cow.WhatIEat();
            cow.WhatIEat("grass");
            cow.WhatIEat("grass", "straw");
            Console.ReadKey();
        }
    }
}
