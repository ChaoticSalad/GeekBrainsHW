using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
//    Черников Олег

namespace hw2ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter 0 to stop");
            while (true)
            {
                Console.Write("Enter your number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 != 0 && num > 0)
                    sum += num;
                if (num == 0)
                    break;
            }
            Console.WriteLine("Summ of odd and positive numbers: " + sum);
            Console.ReadKey();
        }
    }
}
