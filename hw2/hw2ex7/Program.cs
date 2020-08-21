using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.
//    Черников Олег
namespace hw2ex7
{
    class Program
    {
        public static int sum = 0;
        public static void RecursiveEnum(int first, int second)
        {
            if (first <= second)
            {
                Console.WriteLine(first);
                first++;
                RecursiveEnum(first, second);
            }
        }
        public static int RecursiveSum(int first, int second)
        {
            if (first <= second)
            {
                sum += first;
                first++;
                RecursiveSum(first, second);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int userFirstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int userSecondNum = Convert.ToInt32(Console.ReadLine());
            if (userFirstNum <= userSecondNum)
            {
                RecursiveEnum(userFirstNum, userSecondNum);
                Console.WriteLine(RecursiveSum(userFirstNum, userSecondNum));
            }
            else
            {
                RecursiveEnum(userSecondNum, userFirstNum);
                Console.WriteLine(RecursiveSum(userSecondNum, userFirstNum));
            }
            Console.ReadKey();
        }
    }
}
