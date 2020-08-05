using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryMyArray;
//а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера 
//    и заполняющий массив числами от начального значения с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, 
//    метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),  
//    метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
//б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
//е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
//    Черников Олег
namespace hw4ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            LibMyArray a = new LibMyArray(10, 0, 10);
            Console.WriteLine($"Array: {LibMyArray.ToString(a)}");
            Console.WriteLine($"Max element: {a.Max}");
            Console.WriteLine($"Min element: {a.Min}");
            Console.WriteLine($"Count of positive numbers: {a.CountPositiv}");
            Console.WriteLine($"Summ of the elements: {a.Summ}");

            LibMyArray inverseArray = LibMyArray.Inverse(a);
            Console.WriteLine($"Changed signs of the array: {LibMyArray.ToString(inverseArray)}");

            int multiplyer = 2;
            a = LibMyArray.Multi(a, multiplyer);
            Console.WriteLine($"Multiplied all elements of the array by {multiplyer}: {LibMyArray.ToString(a)}");

            Console.WriteLine($"There is {LibMyArray.MaxCount(a)} max numbers in the array");

            Console.WriteLine(LibMyArray.FrequencyElArr(a));

            Console.ReadKey();
        }
    }
}
