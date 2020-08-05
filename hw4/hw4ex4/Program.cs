using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hw4ex4
{
    struct Account
    {
        private static string[] arr;
        public static string[] ReadFromFile(string fileName)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName);
                int arrLen = Convert.ToInt32(sr.ReadLine());
                arr = new string[arrLen];

                for (int i = 0; i < arr.Length; i++)
                {
                    try
                    {
                        arr[i] = sr.ReadLine();
                    }
                    catch(Exception exc)
                    {
                        Console.WriteLine(exc.Message);
                    }
                }

                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return arr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArr = Account.ReadFromFile("logPass.txt");
            int tries = 3;
            bool flag = false;
            do
            {
                Console.Clear();
                Console.WriteLine("You have " + tries + " tries");
                Console.Write("Enter your login: ");
                string userLogPas = Console.ReadLine();
                Console.Write("Enter your password: ");
                userLogPas += ":" + Console.ReadLine();
                for (int i = 0; i < myArr.Length; i++)
                {
                    if (userLogPas == myArr[i])
                    {
                        Console.WriteLine("Access granted");
                        flag = true;
                        break;
                    }

                }
                tries--;
                if (tries == 0)
                    Console.WriteLine("You are out of tries\nAccess denied");
            } while (tries != 0 && !flag);
            Console.ReadKey();
        }
    }
}
