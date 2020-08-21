using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
//    Черников Олег
namespace hw3ex1A
{
    struct Complex
    {
        public double im;
        public double re;
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public string Print()
        {
            return $"({re}) + ({im})i";
        }
        public string PrintCompute(int sign, Complex x, Complex y)
        {
            string result;
            switch(sign)
            {
                case 1: result = $"( {x.re} + {y.re} ) + ( {x.im} + {y.im} )i"; break;
                case 2: result = $"( {x.re} - {y.re} ) + ( {x.im} - {y.im} )i"; break;
                default: result = $"( {x.re} * {y.re} - {x.im} * {y.im} ) + ( {x.re} * {y.im} + {y.re} * {x.im} )i"; break;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.PrintCompute(1, complex1, complex2));
            Console.WriteLine(result.Print());

            result = complex1.Minus(complex2);
            Console.WriteLine(result.PrintCompute(2, complex1, complex2));
            Console.WriteLine(result.Print());

            result = complex1.Multi(complex2);
            Console.WriteLine(result.PrintCompute(0, complex1, complex2));
            Console.WriteLine(result.Print());

            Console.ReadKey();
        }
    }

}
