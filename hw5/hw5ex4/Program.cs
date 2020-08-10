using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
// * Задача ЕГЭ.
// На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
//    В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100,
//    каждая из следующих N строк имеет следующий формат:
//<Фамилия> <Имя> <оценки>,
//    где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, 
//    <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. <Фамилия> и<Имя>, 
//    а также<Имя> и<оценки> разделены одним пробелом. Пример входной строки:
//Иванов Петр 4 5 3
//    Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
//    Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
//        Черников Олег

namespace hw5ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students: ");
            string[] students = new string[Convert.ToInt32(Console.ReadLine())];
            double[] grades = new double[students.Length];
            double firstWorst = double.MaxValue;
            double secondWorst = double.MaxValue;
            double thirdWorst = double.MaxValue;
            string studFirstWorst = String.Empty;
            string studSecndWorst = String.Empty;
            string studThirdWorst = String.Empty;

            Regex regStud = new Regex("^[A-Z][a-z]{1,19}( [A-Z])[a-z]{1,14}( [1-5]){3}$");

            for (int i = 0; i < students.Length; i++)
            {
                do
                {
                    Console.WriteLine("Enter student family name, name and his grades: ");
                    students[i] = Console.ReadLine();
                    //Console.Clear();
                    if (!regStud.IsMatch(students[i]))
                        Console.WriteLine("Incorrect Regex of entered student");
                }
                while (!regStud.IsMatch(students[i]));
            }

            for (int i = 0; i < students.Length; i++)
            {
                for (int j = 0; j < students[i].Length; j++)
                {
                    if (Char.IsDigit(students[i][j]))
                        grades[i] += Convert.ToDouble(Char.GetNumericValue(students[i][j]));
                }
                grades[i] /= 3;
            }

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] < firstWorst)
                {
                    thirdWorst = secondWorst;
                    secondWorst = firstWorst;
                    firstWorst = grades[i];
                }
                else if (grades[i] < secondWorst)
                {
                    thirdWorst = secondWorst;
                    secondWorst = grades[i];
                }
                else if (grades[i] < thirdWorst)
                    thirdWorst = grades[i];
            }

            Console.WriteLine($"{firstWorst}, {secondWorst}, {thirdWorst}");

            for (int i = 0; i < students.Length; i++)
            {
                if (grades[i] == firstWorst)
                {
                    for (int j = 0; j < students[i].Length; j++)
                    {
                        if (Char.IsDigit(students[i][j]))
                        {
                            studFirstWorst += $"{students[i].Substring(0, j)}, ";
                            break;
                        }
                    }
                }
                else if (grades[i] == secondWorst)
                {
                    for (int j = 0; j < students[i].Length; j++)
                    {
                        if (Char.IsDigit(students[i][j]))
                        {
                            studSecndWorst += $"{students[i].Substring(0, j)}, ";
                            break;
                        }
                    }
                }
                else if (grades[i] == thirdWorst)
                {
                    for (int j = 0; j < students[i].Length; j++)
                    {
                        if (Char.IsDigit(students[i][j]))
                        {
                            studThirdWorst += $"{students[i].Substring(0, j)}, ";
                            break;
                        }
                    }
                }
            }

            Console.WriteLine($"Worst students: {studFirstWorst}\nSecond worst: {studSecndWorst}\nThird worst: {studThirdWorst}");

            Console.ReadKey();
        }
    }
}
