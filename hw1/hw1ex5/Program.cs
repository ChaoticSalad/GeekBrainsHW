using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) * Сделать задание, только вывод организовать в центре экрана.
// в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
//     Черников Олег
namespace hw1ex5
{
    class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }
        static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your second name: ");
            string userSecondName = Console.ReadLine();
            Console.Write("Enter your city: ");
            string userCity = Console.ReadLine();
            string ms = $"Hello {userName} {userSecondName} from {userCity}";
            Print(ms, (Console.WindowWidth - ms.Length) / 2, Console.WindowHeight / 2);
            Pause();
        }
    }
}
