using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
//    Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
//    Черников Олег
namespace hw6ex1
{
    public delegate double Fun(double x);
    public delegate double FunTwo(double a, double x);

    class Program
    {
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        
        public static void TableTwo(FunTwo F, double x, double a, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double MyFunc(double x)
        {
            return x * x * x;
        }

        public static double MyFuncTwo(double a, double x)
        {
            return a * Math.Pow(x, 2);
        }

        public static double MyFuncTwoSin(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static void Main()
        {
            Console.WriteLine("Таблица функции MyFunc:");
            Table(new Fun(MyFunc), -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            Table(MyFunc, -2, 2);
            Console.WriteLine("Таблица функции Sin:");
            Table(Math.Sin, -2, 2);
            Console.WriteLine("Таблица функции x^2:");
            Table(delegate (double x) { return x * x; }, 0, 3);

            Console.WriteLine("Таблица функции a*x^2: ");
            TableTwo(new FunTwo(MyFuncTwo), -2, 3, 2);

            Console.WriteLine("Таблица функции a*Sin(x): ");
            TableTwo(new FunTwo(MyFuncTwoSin), -2, 3, 2);


            Console.ReadKey();
        }
    }

}
