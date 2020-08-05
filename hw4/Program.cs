using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
//Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.
//Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
//В данной задаче под парой подразумевается два подряд идущих элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
//    Черников Олег
namespace hw4ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[20];
            int min = -10_000;
            int max = 10_000;
            int sum = 0;
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(min, max);
                Console.Write(myArray[i] + " ");

            }

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (myArray[i] % 3 == 0 && myArray[i + 1] % 3 != 0)
                    sum++;
                else if (myArray[i] % 3 != 0 && myArray[i + 1] % 3 == 0)
                    sum++;
            }

            Console.WriteLine("\n" + sum);
            Console.ReadKey();
        }
    }
}
