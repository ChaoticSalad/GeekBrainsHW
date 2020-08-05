using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = StaticClass.FillArray("arrayElements.txt");
            Console.WriteLine($"Array: {StaticClass.PrintArr(myArray)}");
            Console.WriteLine($"Pairs with one number dividable by three: {StaticClass.FindPairsWithThree(myArray)}");

            Console.ReadKey();
        }
    }
}
