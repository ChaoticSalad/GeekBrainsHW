using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
//б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
//    Черников Олег
namespace hw1ex3
{
    class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }
        public static void WriteDistance(int xOne, int yOne, int xTwo, int yTwo)
        {
            Console.WriteLine("Distance between x1, y1 and x2, y2 is {0:F2}", (Math.Sqrt(Math.Pow(xTwo - xOne, 2) + Math.Pow(yTwo - yOne, 2))));
        }
        static void Main(string[] args)
        {
            Console.Write("Enter x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            WriteDistance(x1,y1,x2,y2);
            Pause();
        }
    }
}
