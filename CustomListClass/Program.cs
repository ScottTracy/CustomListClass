using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CustomList<int> list1 = new CustomList<int>() { 1, 2,};
            List<int> list2 = new List<int>() { 5, 6,};
            
            Console.WriteLine(list1.Count);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
