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
            List<int> numbers = new List<int>();
            CustomList<int> numbers2 = new CustomList<int>();

            Console.WriteLine(numbers[8]);
            Console.WriteLine(numbers.Count);

            Console.WriteLine(numbers2[0]);

        }
    }
}
