using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//в) используя вывод со знаком $.
//    Черников Олег
namespace hw1
{
    class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.Write("Your name? ");
            string userName = Console.ReadLine();
            Console.Write("Your second name? ");
            string userSecondName = Console.ReadLine();
            Console.Write("Your age? ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your height? ");
            int userHeight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your weight? ");
            int userWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User name: " + userName + " User second name: " + userSecondName + " User age: " + userAge + " User height: " + userHeight + " User weight " + userWeight); //Склейка
            Console.WriteLine("User name: {0} User second name: {1} User age: {2} User height: {3} User weight: {4}", userName, userSecondName, userAge, userHeight, userWeight); //Форматирование
            Console.WriteLine($"User name: {userName} User second name: {userSecondName} User age: {userAge} User height {userHeight} User weight {userWeight}"); //$
            Pause();
        }
    }
}
