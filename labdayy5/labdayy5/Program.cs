using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labdayy5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Indexer indexers = new Indexer();
            indexers[0] = "Suraj";
            indexers[1] = "Santosh";
            indexers[2] = "Nishant";
            indexers[3] = "Sagar";
            indexers[4] = "Suman";
            for (int counter = 0; counter < 5; counter++)
            {
                Console.WriteLine(indexers[counter]);
            }*/
            /*ArrayList mylist=new ArrayList();
            mylist.Add("BMC");
            mylist.Add(5891);
            foreach(var item in mylist)
            {
                Console.WriteLine(item);
            }*/
            /*Hashtable mylist = new Hashtable();
            mylist.Add("College","BMC");
            mylist.Add("mobile",5891);
            mylist.Add("ismarried", false);
            foreach (var item in mylist.Keys)
            {
                Console.WriteLine("Key is "+item + " and value is "+ mylist[item]);
            }*/
            /*List<int> rollno=new List<int>();
            rollno.Add(1);
            rollno.Add(2);
            rollno.Add(3);
            rollno.Add(4);
            rollno.Add(5);
            rollno.Add(6);
            foreach (var item in rollno)
            {
                Console.WriteLine("Roll Num is " + item);
            }*/
            FileStream file = new FileStream("suraj.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //file.WriteByte((byte) 10);
            Console.Write(file.ReadByte()+" ");
            file.Close();
            Console.ReadKey();
            
        }
    }
}
