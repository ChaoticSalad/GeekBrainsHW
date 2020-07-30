using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Предусмотреть методы сложения, вычитания, умножения и деления дробей.Написать программу, демонстрирующую все разработанные элементы класса.
//* Добавить свойства типа int для доступа к числителю и знаменателю;
//* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
//** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
//*** Добавить упрощение дробей.
//    Черников Олег
namespace hw3ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction myFrac1 = new Fraction(0, 1, 1);
            Fraction myFrac2 = new Fraction(0, 1, 1);

            myFrac1 = Fraction.UserEnter(myFrac1);
            myFrac2 = Fraction.UserEnter(myFrac2);
            Console.Write("+ to plus, - to minus, * to multiply and / to split ");
            Fraction.UserChoiceSwitch(myFrac1, myFrac2, Console.ReadLine());

            Fraction myFrac3 = new Fraction(0, 80, 250);
            myFrac3.DenomNum = 300;
            Console.WriteLine($"Dont mind me, Im just showing denominator {myFrac3.DenomNum}");
            double smth = myFrac3.FracToDecimal;
            Console.WriteLine($"Dont mind me either, I'm just showing decimal to frac: {smth:F2}");

            Console.ReadKey();

        }
    }
}
