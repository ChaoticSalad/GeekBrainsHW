using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3ex3
{
    class Fraction
    {
        private int integerNum;
        private int numenatorNum;
        private int denomNum;

        public Fraction(int integerNum, int numenatorNum, int denomNum)
        {
            this.integerNum = integerNum;
            this.numenatorNum = numenatorNum;
            this.denomNum = denomNum;
        }

        public int NumenatorNum
        {
            get
            {
                return numenatorNum;
            }
            set
            {
                numenatorNum = value;
            }
        }

        public int DenomNum
        {
            get
            {
                return denomNum;
            }
            set
            {
                 denomNum = value;
            }
        }

        public double FracToDecimal
        {
            get
            {
                return Convert.ToDouble(numenatorNum) / Convert.ToDouble(denomNum);
            }
        }

        public static Fraction UserEnter(Fraction userFrac)
        {
            Console.Write("Enter integer of fraction: ");
            bool success = Int32.TryParse(Console.ReadLine(), out userFrac.integerNum);
            if (!success)
                userFrac.integerNum = 0;

            Console.Write("Enter numenator of fraction: ");
            userFrac.numenatorNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator of fraction: ");
            userFrac.denomNum = Convert.ToInt32(Console.ReadLine()); 
            if (userFrac.denomNum == 0)
                throw new ArgumentException("Oh no, what are you doing stepbro?\nDenominator can't be 0 ;_;");

            return userFrac;
        }

        public static string Print(Fraction userFrac)
        {
            string result;
            if (userFrac.integerNum == 0)
                result = ($"{userFrac.numenatorNum}/{userFrac.denomNum}");
            else
                result = ($"{userFrac.integerNum}({userFrac.numenatorNum}/{userFrac.denomNum})");
            return result;
        }

        public static void UserChoiceSwitch(Fraction userFrac1, Fraction userFrac2, string userChoice)
        {
            Fraction resultFrac;
            switch (userChoice)
            {
                case "+":
                    resultFrac = Fraction.PlusFrac(userFrac1, userFrac2);
                    Console.WriteLine($"{Fraction.Print(resultFrac)}"); break;
                case "-":
                    Console.Write("1 for First fracture from second, 2 to vice versa : ");
                    if(Console.ReadLine() == "1")
                    {
                        resultFrac = Fraction.MinusFrac(userFrac1, userFrac2);
                        Console.WriteLine($"{Fraction.Print(resultFrac)}");
                    }
                    else
                    {
                        resultFrac = Fraction.MinusFrac(userFrac2, userFrac1);
                        Console.WriteLine($"{Fraction.Print(resultFrac)}");
                    }
                    break;
                case "*":
                    resultFrac = Fraction.MultiFrac(userFrac1, userFrac2);
                    Console.WriteLine($"{Fraction.Print(resultFrac)}"); break;
                default:
                    Console.Write("1 for First fracture to second, 2 to vice versa : ");
                    if (Console.ReadLine() == "1")
                    {
                        resultFrac = Fraction.SplitFrac(userFrac1, userFrac2);
                        Console.WriteLine($"{Fraction.Print(resultFrac)}");
                    }
                    else
                    {
                        resultFrac = Fraction.SplitFrac(userFrac2, userFrac1);
                        Console.WriteLine($"{Fraction.Print(resultFrac)}");
                    }
                    break;
            }
        }

        public static Fraction PlusFrac(Fraction userFrac1, Fraction userFrac2)
        {
            userFrac1 = MakeItWrong(userFrac1);
            userFrac2 = MakeItWrong(userFrac2);

            Console.WriteLine($"{Print(userFrac1)} + {Print(userFrac2)}");

            Fraction resFrac = new Fraction(0, (userFrac1.numenatorNum * userFrac2.denomNum) + (userFrac2.numenatorNum * userFrac1.denomNum), userFrac1.denomNum * userFrac2.denomNum);

            resFrac = MakeItRight(resFrac);

            return resFrac;
        }

        public static Fraction MinusFrac(Fraction userFrac1, Fraction userFrac2)
        {
            userFrac1 = MakeItWrong(userFrac1);
            userFrac2 = MakeItWrong(userFrac2);

            Console.WriteLine($"{Print(userFrac1)} - {Print(userFrac2)}");

            Fraction resFrac = new Fraction(0, (userFrac1.numenatorNum * userFrac2.denomNum) - (userFrac2.numenatorNum * userFrac1.denomNum), userFrac1.denomNum * userFrac2.denomNum);

            resFrac = MakeItRight(resFrac);

            return resFrac;
        }

        public static Fraction MultiFrac(Fraction userFrac1, Fraction userFrac2)
        {

            userFrac1 = MakeItWrong(userFrac1);
            userFrac2 = MakeItWrong(userFrac2);

            Console.WriteLine($"{Print(userFrac1)} * {Print(userFrac2)}");

            Fraction resFrac = new Fraction(0, userFrac1.numenatorNum * userFrac2.numenatorNum, userFrac1.denomNum * userFrac2.denomNum);

            resFrac = MakeItRight(resFrac);

            return resFrac;
        }

        public static Fraction SplitFrac(Fraction userFrac1, Fraction userFrac2)
        {
            userFrac1 = MakeItWrong(userFrac1);
            userFrac2 = MakeItWrong(userFrac2);

            Console.WriteLine($"{Print(userFrac1)} / {Print(userFrac2)}");

            Fraction resFrac = new Fraction(0, userFrac1.numenatorNum * userFrac2.denomNum, userFrac1.denomNum * userFrac2.numenatorNum);

            resFrac = MakeItRight(resFrac);

            return resFrac;
        }
        private static Fraction MakeItWrong(Fraction userFrac)
        {
            userFrac.numenatorNum += userFrac.integerNum * userFrac.denomNum;
            userFrac.integerNum = 0;

            return userFrac;
        }

        private static Fraction MakeItRight(Fraction userFrac)
        {
            if (userFrac.denomNum == 0)
                throw new ArgumentException("Oh no, nononononono\nDenominator can't be 0 ;_;");
            int gdcFrac = GCD(userFrac);
            userFrac.numenatorNum /= gdcFrac;
            userFrac.denomNum /= gdcFrac;
            while (userFrac.numenatorNum >= userFrac.denomNum)
            {
                userFrac.numenatorNum -= userFrac.denomNum;
                userFrac.integerNum++;
            }
            return userFrac;
        }
        private static int GCD(Fraction userFrac) //euclidean algorithm, stole it from stack overflow, but can explain it
        {
            int a = Math.Abs(userFrac.numenatorNum);
            int b = Math.Abs(userFrac.denomNum);
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }
    }
}
