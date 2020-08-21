using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Написать метод подсчета количества цифр числа.
//    Черников Олег
namespace hw2ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num < 0)
                num *= -1;
            int sum = ((num.ToString()).Replace(".","")).Length; //remove all dots from a number
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
