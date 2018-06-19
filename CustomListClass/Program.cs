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
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            //Act
            list.Remove(1);

            Console.WriteLine(list.Count);
            Console.ReadLine();



        }
    }
}
