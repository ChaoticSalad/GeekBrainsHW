using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов, 
//содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) ** с использованием регулярных выражений.
//    Черников Олег
namespace hw5ex1
{
    class Program
    {
        static void Main(string[] args)
        {
        //    bool flag = false;
        //    bool flag1 = true;
            string login = String.Empty;
            Regex logReg = new Regex("^[a-zA-Z][a-zA-Z0-9]{1,9}$");
            do
            {
                Console.WriteLine("Enter your login: ");
                login = Console.ReadLine();
                Console.Clear();

                //for (int i = 0; i < login.Length; i++)
                //{
                //    char c = login[i];
                //    if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
                //        flag = true;
                //}

                //if (Char.IsDigit(login[0]) || login.Length < 2 || login.Length > 10 || !flag)
                //{
                //    flag1 = false;
                //    Console.WriteLine("Login is incorrect");
                //}
                //else
                //    flag1 = true;

                if (!logReg.IsMatch(login))
                    Console.WriteLine("Login is incorrect");
            }
            while (!logReg.IsMatch(login));
            Console.WriteLine("Login is correct");
            Console.WriteLine(login);
            Console.ReadKey();
        }
    }
}
