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
    public partial class Form2 : Form
    {
        string resultTb;

        public string ResultTb
        {
            get { return resultTb; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            resultTb = tbUserAnswer.Text;
            tbUserAnswer.Text = String.Empty;
            this.Close();
        }
    }
}
