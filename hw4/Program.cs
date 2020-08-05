using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace hw4ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[20];
            int min = -10_000;
            int max = 10_000;
            int sum = 0;
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(min, max);
                Console.Write(myArray[i] + " ");

            }

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (myArray[i] % 3 == 0 && myArray[i + 1] % 3 != 0)
                    sum++;
                else if (myArray[i] % 3 != 0 && myArray[i + 1] % 3 == 0)
                    sum++;
            }

            Console.WriteLine("\n" + sum);
            Console.ReadKey();
        }
    }
}
