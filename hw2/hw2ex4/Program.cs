using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    //Реализовать метод проверки логина и пароля.
    //На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
    //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
    //С помощью цикла do while ограничить ввод пароля тремя попытками.
    //Черников Олег
namespace hw2ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "GeekBrains";
            string login = "root";
            int tries = 3;
            do
            {
                Console.Clear();
                Console.WriteLine("You have " + tries + " tries");
                Console.Write("Enter your login: ");
                string userLogin = Console.ReadLine();
                Console.Write("Enter your password: ");
                string userPassword = Console.ReadLine();
                if (userLogin == login && userPassword == password)
                {
                    Console.WriteLine("Access granted");
                    break;
                }
                tries--;
                if (tries == 0)
                    Console.WriteLine("You are out of tries\nAccess denied");
            } while (tries != 0);
            Console.ReadKey();
        }
    }
}
