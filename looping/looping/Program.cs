using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //swicase();
            Person suraj= new Person();
            suraj.HairColor = "black";
            suraj.NumberOfEye = 2;
            Console.WriteLine("hair color is " + suraj.HairColor + " and has " + suraj.NumberOfEye + " eye");
            Console.ReadKey();
        }
        static void swicase() 
        {
            Console.WriteLine("Enter the number: ");
            int num=Convert.ToInt32(Console.ReadLine());
            switch (num) 
            {
                case 0:
                    Console.WriteLine("This is case 1");
                    break;  
                case 1:
                    Console.WriteLine("This is case 2");
                    break;
                default: 
                    Console.WriteLine("this is default case");
                    break;
            }
        }
        static void foreas()
        {
            string[] arrays = { "suraj", "thapa" };
            foreach (string elements in arrays) 
            {
                Console.WriteLine(elements);
            }
        }
    }
}
