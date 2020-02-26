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





            //List<int> numbers = new List<int>();



            CustomList<int> numbers2 = new CustomList<int>();
            numbers2.Add(1);
            numbers2.Add(2);
            numbers2.Add(3);
            numbers2.Add(4);
            numbers2.Add(5);

            string ListAsNumbers = numbers2.ToString();
            
           // numbers2.ConvertToString(numbers2);

            //Console.WriteLine(numbers[8]);
            //Console.WriteLine(numbers.Count);

            //Console.WriteLine(numbers2[0]);

        }
    }
}
