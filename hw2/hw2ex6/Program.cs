using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//* Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
//    «Хорошим» называется число, которое делится на сумму своих цифр.
//    Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
//    Черников Олег
namespace hw2ex6
{
    class Program
    {
        public static int count = 0;
        public static int GoodNum(int number)
        {
            int sum = 0;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                string numToTest = number.ToString();
                char numEl = numToTest[i];
                sum += Convert.ToInt32(Char.GetNumericValue(numEl));
            }
            if (number % sum == 0)
            {
                count++;
                return number;
            }
            else
                return 0;
        }
        static void Main(string[] args)
        {
            DateTime begin = DateTime.Now;
            int firstNum = 1;
            int secondNum = 1000000000;
            int goodNum;
            for (int i = firstNum; i < secondNum; i++)
            {
                goodNum = GoodNum(i);
                if (goodNum != 0)
                    Console.WriteLine(goodNum);
            }
            Console.WriteLine($"There's {count} of good numbers\nTime = {DateTime.Now - begin}");
            Console.ReadKey();
        }
    }
}
