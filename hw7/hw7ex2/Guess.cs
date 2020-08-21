using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, 
//    а человек пытается его угадать за минимальное число попыток.Компьютер говорит, больше или меньше загаданное число введенного.
//a) Для ввода данных от человека используется элемент TextBox;
//б) ** Реализовать отдельную форму c TextBox для ввода числа.
//    Черников Олег
namespace hw7ex2
{
    class Guess
    {
        Random random = new Random();

        int userNum;
        int compNum;
        int tries = 0;
        string result = String.Empty;

        public Guess()
        {
            this.compNum = random.Next(100);
        }
        /// <summary>
        /// Converting user answer to int and to userNum
        /// </summary>
        public string Answer
        {
            set { this.userNum = Convert.ToInt32(value); }
        }
        public int UserNum
        {
            get { return this.userNum; }
        }
        public int CompNum
        {
            get { return this.compNum; }
        }
        /// <summary>
        /// Converting tries to show them on the first form
        /// </summary>
        public string Tries
        {
            get { return Convert.ToString(this.tries); }
        }
        public string Result
        {
            get
            { return this.result; }
        }
        /// <summary>
        /// Submiting user answer and checking it for a match
        /// </summary>
        public void Submit()
        {
            tries++;
            if (userNum > compNum)
                result = "big";
            else if (userNum < compNum)
                result = "small";
            else
                result = "win";
        }
        /// <summary>
        /// Refreshing class after win
        /// </summary>
        public void Refresh()
        {

            userNum = 0;
            compNum = random.Next(100);
            tries = 0;
            result = String.Empty;
        }
    }
}
