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
public abstract class Bird
{
    public void WhatIEat()
    {
        Console.WriteLine("I eat grass");
    }
    public abstract void WhatIEat(string food);
}
public class Crow: Bird
{
    public override void WhatIEat(string food)
    {
         Console.WriteLine("I eat "+ food);
    }
    public void WhatIEat(string food1,string food2)
    {
        Console.WriteLine("I eat " + food1 +" and " + food2);
    }
}