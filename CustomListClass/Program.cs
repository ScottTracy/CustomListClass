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
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 5, 6, };
            CustomList<int> result = new CustomList<int>();
            //Act
            result = list1 + list2;
            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}
