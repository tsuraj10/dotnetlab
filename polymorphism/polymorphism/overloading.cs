using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class overloading
    {
            public void WhatIEat()
            {
                Console.WriteLine("Cow eat grass");
            }
            public void  WhatIEat(string food)
            {
                Console.WriteLine("Cow eat "+ food);
            }
            public void WhatIEat(string food1, string food2)
            {
                Console.WriteLine("Cow eat " + food1 +" and "+ food2);
            }
    }
}
