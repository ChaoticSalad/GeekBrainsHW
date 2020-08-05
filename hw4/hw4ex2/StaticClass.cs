using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4ex2
{
    static class StaticClass
    {
        private static int[] arr;

        public static int[] FillArray(string fileName)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName);
                int n = Convert.ToInt32(sr.ReadLine());
                arr = new int[n];
                for (int i = 0; i < n; i++)
                    try
                    {
                        arr[i] = Convert.ToInt32(sr.ReadLine());
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.Message);
                    }
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return arr;
        }

        public static string PrintArr(int[] userArray)
        {
            string res = "";
            foreach (var el in userArray)
                res += $"{el} ";

            return res;
        }

        public static int FindPairsWithThree(int[] userArr)
        {
            int sum = 0;
            for (int i = 0; i < userArr.Length - 1; i++)
            {
                if (userArr[i] % 3 == 0 && userArr[i + 1] % 3 != 0)
                    sum++;
                else if (userArr[i] % 3 != 0 && userArr[i + 1] % 3 == 0)
                    sum++;
            }
            return sum;
        }
    }
}
