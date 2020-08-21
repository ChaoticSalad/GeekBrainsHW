using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
//    Требуется подсчитать сумму всех нечётных положительных чисел.
//    Сами числа и сумму вывести на экран, используя tryParse.
//    Черников Олег
namespace hw3ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            var goodNums = new List<int>();
            Console.WriteLine("Enter 0 to stop");
            while (true)
            {
                Console.Write("Enter your number: ");
                string userStuff = Console.ReadLine();
                bool success = Int32.TryParse(userStuff, out num);
                if (success)
                {
                    if (num % 2 != 0 && num > 0)
                    {
                        goodNums.Add(num);
                        sum += num;
                    }
                    if (num == 0)
                        break;
                }
                else
                    Console.WriteLine("Enter a NUMBER");
            }
            Console.Write("Summ of odd and positive numbers: " + sum + "\nPositive and odd numbers: ");
            foreach (int goodNum in goodNums)
                Console.Write(goodNum + " ");
            Console.ReadKey();
        }
    }
}
