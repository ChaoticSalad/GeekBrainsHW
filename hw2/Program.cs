using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
//Написать метод, возвращающий минимальное из трёх чисел.
//    Черников Олег

namespace hw2
{
    class Program
    {
        public static int MaxTrio (int first, int second, int third)
        {
            if (first > second && first > third) 
                return first;
            else if (second > first && second > third) 
                return second;
            else 
                return third;

        }
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maximum out of three is " + MaxTrio(num1, num2, num3));
            Console.ReadKey();
        }
    }
}
