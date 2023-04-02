using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] names = new string[5];
                names[0] = "suraj";
                names[1] = "nishant";
                names[2] = "santosh";
                names[3] = "raj";
                names[4] = "suman";
                names[5] = "srijan";
                foreach (string item in names)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
