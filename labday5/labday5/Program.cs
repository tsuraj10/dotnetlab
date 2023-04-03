using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labday5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Indexer indexers = new Indexer();
            indexers[0] = "Suraj";
            indexers[1] = "Santosh";
            indexers[2] = "Nishant";
            indexers[3] = "Sagar";
            indexers[4] = "Suman";
            for(int counter=0;counter<5;counter++)
            {
                Console.WriteLine(indexers[counter]);
            }
            Console.ReadKey();
        }
    }
}
