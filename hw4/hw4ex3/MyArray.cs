using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера 
//    и заполняющий массив числами от начального значения с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, 
//    метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),  
//    метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
//б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
//е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
//    Черников Олег
namespace hw4ex3
{
    class MyArray
    {
        int[] a; 

        public MyArray(int length)
        {
            a = new int[length];
            for (int i = 0; i < a.Length; i++)
                a[i] = i;
        }

        public MyArray(int n, int step)
        {
            int smth = step;
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = smth;
                smth += step;
            }
        }

        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }

        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }

        public int Summ
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
        }
        public static string ToString(MyArray userArr)
        {
            string s = "";
            foreach (int v in userArr.a)
                s = s + v + " ";
            return s;
        }

        public static MyArray Inverse(MyArray userArr)
        {
            MyArray inverseArr = new MyArray(userArr.a.Length);
            for (int i = 0; i < userArr.a.Length; i++)
            {
                inverseArr.a[i] = -userArr.a[i];
            }
            return inverseArr;
        }

        public static MyArray Multi(MyArray userArr, int multi)
        {
            for (int i = 0; i < userArr.a.Length; i++)
            {
                userArr.a[i] = userArr.a[i] * multi;
            }
            return userArr;
        }

        public static int MaxCount(MyArray userArr)
        {
            int count = 0;
            for (int i = 0; i < userArr.a.Length; i++)
            {
                if (userArr.a[i] == userArr.Max)
                    count++;
            }
            return count;
        }
    }
}
