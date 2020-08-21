using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
//в) Добавить диалог с использованием switch демонстрирующий работу класса.
//    Черников Олег
namespace hm3ex1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(1, 1);
            Complex complex2 = new Complex(2, 2);

            Console.Write("+ for plus, - for minus or * for multiply: ");
            Complex.PrintSwitch(complex1, complex2, Console.ReadLine()); //Вызов диалогового окна switch

            Console.ReadKey();
        }

    }
}
