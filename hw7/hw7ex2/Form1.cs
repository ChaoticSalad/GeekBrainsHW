using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, 
//    а человек пытается его угадать за минимальное число попыток.Компьютер говорит, больше или меньше загаданное число введенного.
//a) Для ввода данных от человека используется элемент TextBox;
//б) ** Реализовать отдельную форму c TextBox для ввода числа.
//    Черников Олег
namespace hw7ex2
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        Guess guess;
        public Form1()
        {
            guess = new Guess();
            InitializeComponent();
        }
        /// <summary>
        /// Initializing form2, getting user answer out form2's tb and checking it in guess class for a match
        /// </summary>
        private void btnTry_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
            guess.Answer = form2.ResultTb;
            guess.Submit();
            IsMatch();
        }
        /// <summary>
        /// getting result out of class and checking it for a match
        /// </summary>
        private void IsMatch()
        {
            lblTries.Text = guess.Tries;
            if (guess.Result == "big")
                lblResult.Text = "Entered number too big";
            else if (guess.Result == "small")
                lblResult.Text = "Entered number too small";
            else if (guess.Result == "win")
            {
                MessageBox.Show($"You guessed it, number is {guess.CompNum}, tries: {guess.Tries}", "Congrats");
                lblResult.Text = "Try to guess a number from 0 to 100";
                lblTries.Text = "0";
                guess.Refresh();
            }
        }
    }
}
