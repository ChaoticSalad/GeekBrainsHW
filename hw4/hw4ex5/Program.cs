using LibHw4Ex5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//* а) Реализовать библиотеку с классом для работы с двумерным массивом.Реализовать конструктор, заполняющий массив случайными числами.Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out).
//** б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
// ** в) Обработать возможные исключительные ситуации при работе с файлами.
//    Черников Олег
namespace hw4ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            LibEx5 myArr = new LibEx5(10, 10, 100, 10);
            Console.WriteLine(myArr.Print());

            Console.WriteLine($"Sum of the elements in the array: {myArr.SumOfArr()}");

            int min = 50;
            Console.WriteLine($"Sum of the elements in the array higher than {min}: {myArr.SumOfArrMod(min)}");

            Console.WriteLine($"Maximum element of the array: {myArr.Max}"); 
            
            int x = 0;
            int y = 0;
            myArr.MaxElIndex(out x, out y);
            Console.WriteLine($"Index of the maximum element: {x} {y} ");

            Console.WriteLine($"Minimum element of the array: {myArr.Min}");

            myArr.SaveToFile("textInArr.txt");
            Console.WriteLine("Array successfully saved to file textInArr.txt");

            LibEx5 txtArr = new LibEx5(10, 10, "arrayList.txt");
            Console.WriteLine("Array from txt file: ");
            Console.WriteLine(txtArr.Print());

            Console.ReadKey();
        }
    }
}
