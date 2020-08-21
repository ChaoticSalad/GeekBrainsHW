using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown
//    Черников Олег
namespace hw8ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Text<->Value";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                numericUpDown1.Value = Convert.ToDecimal(textBox1.Text);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Incorrect input: {ex.Message}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Incorrect input: {ex.Message}");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }
    }
}
