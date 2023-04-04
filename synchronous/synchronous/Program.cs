using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace synchronous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            function2();
            function1();
            
            Console.ReadKey();
        }
        public static void function1()
        {
            for(int counter=0;counter<=50;counter++)
            {
                Console.WriteLine("I am from function1");
            }
        }
        public static async void function2()
        {
            await Task.Run(() =>
            {
                for (int counter = 0; counter <=50; counter++)
                {
                    Console.WriteLine("I am from function2");
                }
            });
        }
    }
}
