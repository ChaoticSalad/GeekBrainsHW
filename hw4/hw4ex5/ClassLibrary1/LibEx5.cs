using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibHw4Ex5
{
    public class LibEx5
    {
        int[,] arr;
        public LibEx5(int x, int y, int max, int min)
        {
            arr = new int[x,y];
            Random rnd = new Random();
            for (int i = 0; i < y; i++)
                for (int j = 0; j < x; j++)
                    arr[i,j] = rnd.Next(min,max);      
        }

        //two-dimensional array from txt file
        public LibEx5(int x, int y, string fileName)
        {
            arr = new int[x, y];
            string[] stringArr = new string[x];
            try
            {
                StreamReader sr = new StreamReader(fileName);
                for (int i = 0; i < y; i++)
                {
                    try
                    {
                        string line = sr.ReadLine();
                        stringArr = line.Split(' ');
                        for (int j = 0; j < arr.GetLength(0); j++)
                        {
                            arr[i, j] = Convert.ToInt32(stringArr[j]);
                        }
                    }
                    catch(Exception exc)
                    {
                        Console.WriteLine(exc.Message);
                    }
                }
                sr.Close();
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int Min
        {
            get 
            {
                int min = arr[0, 0];
                for (int i = 0; i < arr.GetLength(0); i++)
                    for (int j = 0; j < arr.GetLength(1); j++)
                        if (arr[i, j] < min) min = arr[i, j];
                return min;
            }
        }


        public int Max
        {
            get
            {
                int max = arr[0, 0];
                for (int i = 0; i < arr.GetLength(0); i++)
                    for (int j = 0; j < arr.GetLength(1); j++)
                        if (arr[i, j] > max) 
                            max = arr[i, j];
                return max;
            }
        }

        public void MaxElIndex(LibEx5 userArr, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] == Max)
                    {
                        x = j;
                        y = i;
                    }
        }

        public int SumOfArr(LibEx5 userArr)
        {
            int sum = 0;
            for (int i = 0; i < userArr.arr.GetLength(0); i++)
                for (int j = 0; j < userArr.arr.GetLength(0); j++)
                    sum += arr[i, j];
            return sum;
        }

        public int SumOfArrMod(LibEx5 userArr, int min)
        {
            int sum = 0;
            for (int i = 0; i < userArr.arr.GetLength(0); i++)
                for (int j = 0; j < userArr.arr.GetLength(0); j++)
                    if (arr[i, j] > min)
                        sum += arr[i, j];
            return sum;
        }

        public string Print()
        {
            string res = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    res += arr[i, j] + " ";
                res += "\n"; // Переход на новую строчку
            }
            return res;
        }

    }
}
