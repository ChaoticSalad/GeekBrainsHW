using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
//б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
//в)** Добавьте обработку ситуации отсутствия файла на диске.
//    Черников Олег
namespace hw4ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = StaticClass.FillArray("arrayElements.txt");
            Console.WriteLine($"Array: {StaticClass.PrintArr(myArray)}");
            Console.WriteLine($"Pairs with one number dividable by three: {StaticClass.FindPairsWithThree(myArray)}");

            Console.ReadKey();
        }
    }
}
