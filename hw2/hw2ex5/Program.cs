using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
//б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
//    Черников Олег
namespace hw2ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double normalBodyIndex = 0.0022;
            Console.Write("Enter your height: ");
            int userHeight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your weight: ");
            int userWeight = Convert.ToInt32(Console.ReadLine());
            double userBodyIndex = Convert.ToDouble(userWeight / Math.Pow(userHeight, 2));
            if (userBodyIndex > normalBodyIndex + 0.0003) //normalBMI = 0.0018 ~ 0.0025
            {
                Console.WriteLine($"Too fat, lose {userWeight - (normalBodyIndex * Math.Pow(userHeight, 2))} kg"); //mUser - (normalBMI * userHeight^2) = mDifference
            }
            else if (userBodyIndex < normalBodyIndex - 0.0004)
            {
                Console.WriteLine($"Too skinny, gain {(normalBodyIndex * Math.Pow(userHeight, 2)) - userWeight} kg"); //(normalBMI * userHeight^2) - mUser = mDifference
            }
            else
                Console.WriteLine("You are good");

            Console.ReadKey();
        }
    }
}
