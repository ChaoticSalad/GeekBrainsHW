using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
//а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
//    Использовать массив(или список) делегатов, в котором хранятся различные функции.
//б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.
//    Пусть она возвращает минимум через параметр(с использованием модификатора out). 
//    Черников Олег
namespace hw6ex2
{
    public delegate double Fun(double x);
    class Program
    {
        public static double MyFunOne(double x)
        {
            return Math.Pow(x, 2) - 50 * x + 10;
        }

        public static double MyFunSin(double x)
        {
            return Math.Sin(x);
        }

        public static double MyFunCos(double x)
        {
            return Math.Cos(x);
        }

        public static double MyFunPow(double x)
        {
            return Math.Pow(x, 2);
        }
        
        public static double MyFunSqrt(double x)
        {
            return Math.Sqrt(x);
        }

        public static void SaveFunc(string fileName, Fun F, double min, double max, double step)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = min;
            while (x <= max)
            {
                bw.Write(F(x));
                x += step;
            }
            bw.Close();
            fs.Close();
        }
        public static double [] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double[] arrFunEl = new double [fs.Length / sizeof(double)];
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                arrFunEl[i] = bw.ReadDouble();
                if (arrFunEl[i] < min) min = arrFunEl[i];
            }
            bw.Close();
            fs.Close();
            return arrFunEl;
        }

        public static int UserChooseFun()
        {
            int choice;
            do
            {
                Console.WriteLine("Choose function: \n1)f(x) = x^2 - 50x + 10 \n2)f(x) = Sin(x) \n3)f(x) = Cos(x) \n4)f(x) = x^2 \n5)f(x) = Sqrt(x)");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    choice = 0;
                }
            } while (choice < 1 || choice > 5);
            return choice;
        }

        public static void UserChooseMinMax(out double min, out double max)
        {
            do
            {
                try
                {
                    Console.Write("Choose minimal of function: ");
                    min = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Choose maximum of function: ");
                    max = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    min = 1;
                    max = 0;
                }
            } while (min > max);
        }

        static void Main(string[] args)
        {
            List<Fun> functions = new List<Fun>();
            functions.Add(new Fun(MyFunOne));
            functions.Add(new Fun(MyFunSin));
            functions.Add(new Fun(MyFunCos));
            functions.Add(new Fun(MyFunPow));
            functions.Add(new Fun(MyFunSqrt));

            int userChoice = UserChooseFun();

            double userMinimal = 0;
            double userMaximum = 0;
            UserChooseMinMax(out userMinimal, out userMaximum);
            
            SaveFunc("data.bin", functions[userChoice-1], userMinimal, userMaximum, 0.5);

            double minUserFun = Double.MaxValue;
            double[] funElArr = Load("data.bin", out minUserFun);
            Console.WriteLine("f(x) elements: ");
            for (int i = 0; i < funElArr.Length; i++)
            {
                Console.Write($"{funElArr[i]} ");
            }
            Console.WriteLine($"\nMinimal of choosed function: {minUserFun}");
            Console.ReadKey();
        }
    }
}
