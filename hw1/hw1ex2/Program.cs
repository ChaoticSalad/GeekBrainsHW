using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.
//    Черников Олег
namespace hw1ex2
{
    class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your height: ");
            double userHeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your weight: ");
            double userWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your body index is {Math.Round(userWeight / Math.Pow(userHeight, 2), 4)}"); //m/(h*h)
            Pause();
        }
    }
}
