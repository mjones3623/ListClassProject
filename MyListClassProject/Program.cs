using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> result;

            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();


            myList1.Add(1);
            myList1.Add(3);
            myList1.Add(5);

            myList2.Add(2);
            myList2.Add(1);
            myList2.Add(6);

            result = myList1 - myList2;

            Console.WriteLine(result.ToString());
            Console.ReadLine();

            



        }
    }
}
