using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm3ex1B
{
    class Complex
    {
        private double imaginaryNum;
        private double realNum;

        public Complex()
        {
            imaginaryNum = 0;
            realNum = 0;
        }

        public Complex(double imaginaryNum, double realNum)
        {
            this.imaginaryNum = imaginaryNum;
            this.realNum = realNum;
        }
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.imaginaryNum = x2.imaginaryNum + imaginaryNum;
            x3.realNum = x2.realNum + realNum;
            return x3;
        }
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.imaginaryNum = imaginaryNum - x2.imaginaryNum;
            x3.realNum = realNum - x2.realNum;
            return x3;
        }
        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.imaginaryNum = realNum * x2.imaginaryNum + imaginaryNum * x2.realNum;
            x3.realNum = realNum * x2.realNum - imaginaryNum * x2.imaginaryNum;
            return x3;
        }
        public static void PrintSwitch(Complex userComplex1, Complex userComplex2, string choice) //Диалоговое окно switch???
        {
            switch (choice)
            {
                case "+":
                    Complex result = userComplex1.Plus(userComplex2);
                    Console.WriteLine(result.PrintCompute(choice, userComplex1, userComplex2));
                    Console.WriteLine(result.Print()); break;
                case "-":
                    result = userComplex1.Minus(userComplex2);
                    Console.WriteLine(result.PrintCompute(choice, userComplex1, userComplex2));
                    Console.WriteLine(result.Print()); break;
                default:
                    result = userComplex1.Multi(userComplex2);
                    Console.WriteLine(result.PrintCompute(choice, userComplex1, userComplex2));
                    Console.WriteLine(result.Print()); break;
            }
        }
        public string Print()
        {
            return $"({realNum}) + ({imaginaryNum})i";
        }
        public string PrintCompute(string sign, Complex x2, Complex x3) //Демонстрация работы класса ???
        {
            string result;
            switch (sign)
            {
                case "+": result = $"( {x2.realNum} + {x3.realNum} ) + ( {x2.imaginaryNum} + {x3.imaginaryNum} )i"; break;
                case "-": result = $"( {x2.realNum} - {x3.realNum} ) + ( {x2.imaginaryNum} - {x3.imaginaryNum} )i"; break;
                default: result = $"( {x2.realNum} * {x3.realNum} - {x2.imaginaryNum} * {x3.imaginaryNum} ) + ( {x2.realNum} * {x3.imaginaryNum} + {x2.realNum} * {x3.imaginaryNum} )i"; break;
            }
            return result;
        }
    }

}
