using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //logicalop();
            //bitwiseop();
            shiftingleft();
            Console.ReadKey();
        }
        static void logicalop()
        {
            Console.WriteLine("Enter your college:");
            string college=Console.ReadLine();
            Console.WriteLine("Enter program:");
            string prog=Console.ReadLine();
            if (college.ToLower() == "bmc" &&  prog.ToLower() =="csit")
            {
                Console.WriteLine("Welcome to Lab");
            }
            else
            {
                Console.WriteLine("You are not authorised.");
            }

        }
        static void bitwiseop()
        {
            int a = 2;
            int b = 3;
            Console.WriteLine(a | b);
        }

        static void shiftingleft()
        {
            int a = 0b10100;
            string shiftleft= Convert.ToString(a<<3,2);
            Console.WriteLine("shiftleft " + shiftleft);
            string shiftright = Convert.ToString(a >> 3,2);
            Console.WriteLine("shiftright " + shiftright);
        }
    }
}
