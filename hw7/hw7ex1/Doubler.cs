using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
//а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, 
//    какое число должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
//в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.
// Вся логика игры должна быть реализована в классе с удвоителем.
//    Черников Олег
namespace hw7ex1
{
    class Doubler
    {
        List<int> userNums = new List<int>();

        Random random = new Random();

        int userNum;
        int targetNum;
        int step;

        public Doubler()
        {
            this.userNum = 0;
            this.targetNum = 0;
            this.step = 0;
        }

        public int UserNum
        {
            get
            {
                return this.userNum;
            }
        }

        public int Step
        {
            get
            {
                return this.step;
            }
        }

        public int TargetNum
        {
            get
            {
                return this.targetNum;
            }
        }
        /// <summary>
        /// Getting random number for a target
        /// </summary>
        public void Start()
        {
            targetNum = random.Next(100);
        }

        public void Increment ()
        {
            userNum += 1;
            step += 1;
            SaveNum(userNum);
        }

        public void DoubleIt ()
        {
            userNum *= 2;
            step += 1;
            SaveNum(userNum);
        }
        /// <summary>
        /// Adding user number to a list for ctrlZ method
        /// </summary>
        /// <param name="userNum"></param>
        public void SaveNum (int userNum)
        {
            userNums.Add(userNum);
        }
        /// <summary>
        /// Showing last element of a list and deleting it from it
        /// </summary>
        public void CtrlZ()
        {
            try
            {
                userNum = userNums[step - 2];
                userNums.RemoveRange(step - 1, 1);
                step -= 1;
            }
            catch
            {
                userNums.Clear();
                userNum = 0;
                step = 0;
            }
        }

        public void Reset()
        {
            userNums.Clear();
            userNum = 0;
            step = 0;
            targetNum = 0;
        }

        public bool CheckIfWin()
        {
            if (userNum == targetNum)
            {
                return true;
            }
            return false;
        }
    }
}
