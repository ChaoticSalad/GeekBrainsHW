using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.
//    Черников Олег
namespace hw1ex4
{
    class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your first element: ");
            string firstEl = Console.ReadLine();
            Console.Write("Enter your second element: ");
            string secondEl = Console.ReadLine();
            //string swapEl = firstEl; //a)
            //firstEl = secondEl;
            //secondEl = swapEl;
            firstEl += secondEl; //б)
            secondEl = firstEl.Substring(0, firstEl.Length - secondEl.Length);
            firstEl = firstEl.Remove(0, secondEl.Length);
            Console.WriteLine($"First: {firstEl}, second: {secondEl}");
            Pause();

        }
    }
}
