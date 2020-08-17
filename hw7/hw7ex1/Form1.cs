using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, 
//    какое число должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
//в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.
// Вся логика игры должна быть реализована в классе с удвоителем.
//    Черников Олег
namespace hw7ex1
{
    public partial class Form1 : Form
    {

        Doubler doubler;

        public Form1()
        {
            doubler = new Doubler();
            InitializeComponent();
            UpdateForm();
            btnPlus.Enabled = false;
            btnDouble.Enabled = false;
            btnCtrlZ.Enabled = false;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            doubler.Increment();
            UpdateForm();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            doubler.DoubleIt();
            UpdateForm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetClick();
        }

        private void btnCtrlZ_Click(object sender, EventArgs e)
        {
            doubler.CtrlZ();
            UpdateForm();
        }
        /// <summary>
        /// Updating form with Doubler's class properties and checking for a win
        /// </summary>
        private void UpdateForm()
        {
            lblUserNum.Text = Convert.ToString(doubler.UserNum);
            lblSteps.Text = Convert.ToString(doubler.Step);
            lblNum.Text = Convert.ToString(doubler.TargetNum);
            if (doubler.CheckIfWin() && btnReset.Text != "Start")
            {
                MessageBox.Show($"You win! Steps: {doubler.Step}", "Congratulations");
                ResetClick();
            }
        }
        /// <summary>
        /// Reset form, duh
        /// </summary>
        private void ResetClick()
        {
            if (btnReset.Text == "Start")
            {
                btnReset.Text = "Reset";
                btnPlus.Enabled = true;
                btnDouble.Enabled = true;
                btnCtrlZ.Enabled = true;
                doubler.Start();
                UpdateForm();
            }
            else
            {
                btnReset.Text = "Start";
                btnPlus.Enabled = false;
                btnDouble.Enabled = false;
                btnCtrlZ.Enabled = false;
                doubler.Reset();
                UpdateForm();
            }
        }
    }
}
